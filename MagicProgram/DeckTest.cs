using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MagicProgram
{
    public partial class DeckTest : Form
    {
        # region variables
        # region card lists
        private PlayArea PlArea = new PlayArea();
        private PlayArea OppArea = new PlayArea();

        private List<MagicCard> CardsProc = new List<MagicCard>();
        # endregion

        int turns = 0;
        int mulligans = 0;
        Random rand = new Random();
        int games = 0;

        int targets = 0;

        bool playerTurn = true;

        # region cards/controls held in temp
        ListView lvTemp;
        MagicCard tempCard;
        MagicCard viewCard;
        List<MagicCard> CardStack = new List<MagicCard>();
        List<MagicCard> PickList = new List<MagicCard>();
        # endregion

        # region events
        public event Phase SpellRes;
        public event Phase PhaseChanged;


        private string _phaseName = "Upkeep";
        public string PhaseName
        {
            get
            {
                return _phaseName;
            }
            set
            {
                _phaseName = value;
                Text = "Deck Text (" + _phaseName + ")";
            }
        }

        public event CardUse CreaCast;
        public event CardUse CardChosen;

        private void onSpellRes()
        {
            Phase handler = SpellRes;

            foreach (MagicCard mc in CardsProc)
            {
                mc.callAbility();
            }

            if (handler != null)
            {
                handler();
            }
        }

        private void onCreaCast(MagicCard mc)
        {
            CardUse handler = CreaCast;
            if (handler != null)
            {
                handler(mc);
            }
        }

        private void onCardChosen(MagicCard mc)
        {
            CardUse handler = CardChosen;
            if (handler != null)
            {
                handler(mc);
            }
        }

        private void callPhaseChanged()
        {
            Phase handler = PhaseChanged;
            //Debug.WriteLine(Text);

            if (handler != null)
            {
                handler();
            }
        }
        # endregion
        #endregion

        # region form setup
        public DeckTest()
        {
            InitializeComponent();

            addHandlers();

            CardCollection tempDeck = new CardCollection();
            Initialise(tempDeck);
        }

        public DeckTest(CardCollection deck)
        {
            InitializeComponent();

            addHandlers();

            Initialise(deck);
        }

        private void Initialise(CardCollection deck)
        {
            Random rand = new Random();

            PlArea._deck = deck;
            PlArea.seed = rand.Next();
            PlArea.initialise();
            PlArea.Setup();

            createOppDeck();

            cardAreaHand.Paused = true;
            DrawCard(7);
            cardAreaHand.Paused = false;

            PhaseChanged += new Phase(DeckTest_PlMainOneEnd);

            updateAll();
        }

        # region custom handlers
        private void addHandlers()
        {
            PlArea.HPChanged += new Action(PlaHP_ValueChanged);
            OppArea.HPChanged += new Action(FoeHP_ValueChanged);

            PlArea.CardUsed += new CardUse(PlArea_CardUsed);
            OppArea.CardUsed += new CardUse(OppArea_CardUsed);

            PlArea.mana.ManaChanged += new ColourCost.Action(updateManaLabel);
            OppArea.mana.ManaChanged += new ColourCost.Action(updateManaLabel);

            PlArea.CardDrawn += new CardUse(PlArea_CardDrawn);
            OppArea.CardDrawn += new CardUse(OppArea_CardDrawn);

            Controls.Add(PlArea.mw);
            PlArea.mw.Parent = this;
        }

        void OppArea_CardDrawn(MagicCard mc)
        {
            //updateImageLists();
        }

        void PlArea_CardDrawn(MagicCard mc)
        {
            updateImageLists();
            cardAreaHand.AddCard(mc);
        }

        void OppArea_CardUsed(MagicCard mc)
        {
            updateImageLists();
            updateOppSide();
        }

        void PlArea_CardUsed(MagicCard mc)
        {
            updateImageLists();
            updatePlaSide();
        }


        # endregion

        private void createOppDeck()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path += @"\Opponent.mcxd";

            if (File.Exists(path))
            {
                XmlSerializer serial = new XmlSerializer(typeof(CardCollection));

                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    OppArea._deck = serial.Deserialize(stream) as CardCollection;
                }
            }
            else
            {
                OppArea._deck = PlArea._deck;
            }

            OppArea.seed = rand.Next();
            OppArea.initialise();
            OppArea.drawCards(7);

            updateOppSide();
        }
        # endregion

        # region methods
        # region game
        /// <summary>
        /// Draws cards from Player's library
        /// </summary>
        /// <param name="i">Number of cards to draw</param>
        private void DrawCard(int i)
        {
            PlArea.drawCards(i);
        }

        private bool useCard(MagicCard mc)
        {

            # region work out if there is enough mana
            bool mana = true;

            mc.setMana();
            if (mc.manaCost.blue > PlArea.mana.blue) { mana = false; }
            if (mc.manaCost.black > PlArea.mana.black) { mana = false; }
            if (mc.manaCost.red > PlArea.mana.red) { mana = false; }
            if (mc.manaCost.green > PlArea.mana.green) { mana = false; }
            if (mc.manaCost.white > PlArea.mana.white) { mana = false; }

            int g = PlArea.mana.colourless - mc.manaCost.colours;

            if (mc.manaCost.grey > g) { mana = false; }

            if (!mana)
            {
                if (MessageBox.Show("Not enough mana. Play anyway?", "Force card?", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return false;
                }
            }
            else
            {
                PlArea.mana.Subtract(mc.manaCost);
            }
            # endregion

            mc.callOnPlay();

            # region copy card
            mc = new MagicCard(mc);
            # endregion

            # region set side to work with
            PlayArea area = PlArea;
            if (!playerTurn)
            {
                area = OppArea;
            }
            # endregion

            # region land
            if (mc.Type.Contains("Land"))
            {
                area.PlayCard(mc);
                cardAreaLand.AddCard(mc);
                //update_listViewLand();
            }
            # endregion
            # region spells
            else if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            {
                switch (mc.Name)
                {
                    case "Nature's Lore":
                        List<MagicCard> cards = PlArea._stack.cards.Where(o => o.Type.ToUpper().Contains("FOREST")).ToList();
                        comboCardPicker_Fill(cards);
                        CardChosen += new CardUse(CardChosen_NaturesLore);
                        break;

                    case "Triton Tactics":
                        targets += 2;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardChosen_TritonTactics);
                        break;
                }

                if (mc.Text.Contains("Cipher"))
                {
                    if (playerTurn)
                    {
                        DialogResult dr = MessageBox.Show("Cipher this ability on to a creature?", "Choose Creature", MessageBoxButtons.YesNoCancel);
                        if (dr == DialogResult.Yes)
                        {
                            //listViewPlay.MouseUp += new MouseEventHandler(listViewPlay_MouseClick);
                            cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_CardClicked);
                            tempCard = mc;
                        }
                        if (dr == DialogResult.No)
                        {
                            area._graveyard.cards.Add(mc);
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    area.PlayCard(mc);
                }
            }
            # endregion
            # region artifacts and enchantments
            else if (mc.Type.Contains("Artifact") || mc.Type.Contains("Enchantment"))
            {
                onSpellRes();
                CardsProc = new List<MagicCard>();

                if (mc.Text.Contains("Enchant land"))
                {
                    if (playerTurn)
                    {
                        cardAreaLand.CardClicked += new CardArea.CardChosen(cardArea1_CardClicked1);
                        //listViewLand.MouseUp += new MouseEventHandler(listViewLand_MouseClick);
                    }
                }
                else if (mc.Text.Contains("Enchant creature"))
                {
                    if (playerTurn)
                    {
                        //listViewPlay.MouseUp += new MouseEventHandler(listViewPlay_MouseClick);
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_CardClicked);
                    }
                }
                else
                {
                    area.PlayCard(mc);
                    //listViewArtEnch.MouseUp += new MouseEventHandler(listViewArtEnch_MouseClick);
                }

                if (mc.Name == "Ooze Flux")
                {
                    mc.Activate += new MagicCard.Ability(Activate_OozeFlux);
                }

                tempCard = mc;
                update_listViewArtEnch();
            }
            # endregion
            # region creatures
            else
            {
                onCreaCast(mc);

                switch (mc.Name)
                {
                    case "Elite Arcanist":
                        if (playerTurn)
                        {
                            DialogResult dr = MessageBox.Show("Copy card onto Elite Arcanist?", "Copy card?", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                tempCard = mc;
                                cardAreaHand.CardClicked += new CardArea.CardChosen(cardAreaHand_CardClickedEliteArcanist);
                            }
                        }
                        break;

                    case "Bond Beetle":
                        if (playerTurn)
                        {
                            cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClick_BondBeetle);
                        }
                        break;
                }

                mc.Activate += new MagicCard.Ability(mc_ActivateCard);

                mc.checkPT();

                //resolve spell
                onSpellRes();
                CardsProc = new List<MagicCard>();

                //final resolution - add card to play.
                area.PlayCard(mc);
                update_listViewPlay();
            }
            # endregion

            //updateAll();
            return true;
        }

        void cardAreaPlay_CountersPicked(int value, Dictionary<MagicCard, int> sources)
        {
            MagicCard mc = new MagicCard
            {
                Token = true,
                Name = "Ooze",
                Type = "Creature - Ooze",
                PT = value + "/" + value,
                Power = value,
                Toughness = value
            };

            foreach (KeyValuePair<MagicCard, int> k in sources)
            {
                k.Key.counters -= k.Value;
            }

            PlArea.PlayToken(mc);
            cardAreaPlay.DrawAllCards();

            cardAreaPlay.CountersPicked -= cardAreaPlay_CountersPicked;
        }

        public void PrePlay(MagicCard mc)
        {
            int x = 0;
            string cost = mc.Cost.ToUpper();
            int count = cost.Count(c => c == 'X');
            ColourCost Cost = new ColourCost();
            mc.Xvalue = 0;
            //Debug.WriteLine("X value was {0}", mc.Xvalue);
            mc.setMana();

            if (!PlArea.mana.Compare(mc.manaCost))
            {
                Debug.WriteLine("Not enough mana to play card");
                return;
            }

            mc.callPrePlay();

            if (cost.Contains("X"))
            {
                for (int c = 0; c < cost.Length; c++)
                {
                    char j = mc.Cost[c];
                    if (j == 'X')
                    {
                        j = x.ToString()[0];
                    }
                }

                CardStack.Add(mc);

                mc.Initialise();
                xPicker.Cost = mc.manaCost;
                xPicker.Mana = PlArea.mana;
                xPicker.Value = 0;
                xPicker.Show(count);
                xPicker.BringToFront();
                ViewCard(mc);
                //cPanelControls.BringToFront();
            }
            else
            {
                useCard(mc);
            }
        }

        void picker_ValuePicked(int value, int count)
        {
            xPicker.Hide();

            if (CardStack.Count < 1)
            {
                //Debug.WriteLine("No cards on the stack to replace X with.");
                return;
            }

            ColourCost cc = CardStack[0].manaCost;

            CardStack[0].Xvalue = value;
            //string edited = CardStack[0].Cost.Replace("X", value.ToString());
            //CardStack[0].Cost = edited;

            //cc.grey += value * count;

            if (PlArea.mana.Compare(cc))
            {
                useCard(CardStack[0]);
                CardStack.RemoveAt(0);
            }
        }

        # region choose where to add card
        void listViewArtEnch_MouseClick(object sender, MouseEventArgs e)
        {
            PlArea._artEnch.Add(tempCard);
            tempCard = null;

            listViewArtEnch.MouseUp -= listViewArtEnch_MouseClick;
            updateAll();
        }

        void cardAreaPlay_CardClicked(MagicCard mc, MouseEventArgs e)
        {
            mc.attachedCards.Add(tempCard);
            mc.checkPT();
            tempCard = null;
            cardAreaPlay.CardClicked -= cardAreaPlay_CardClicked;
        }

        void cardAreaHand_CardClickedEliteArcanist(MagicCard mc, MouseEventArgs e)
        {
            //mc.Activate += new MagicCard.Ability(mc_ActivateEliteArcanist);
            mc.Activating += new MagicCard.Ability(mc_ActivateEliteArcanist);

            MagicCard mcvt = tempCard;

            tempCard.attachedCards.Add(mc);
            cardAreaHand.RemoveCard(mc);

            int cost = mc.manaCost.colourless;
            mc.manaCost.Clear();
            mc.Cost = cost.ToString();

            tempCard.checkPT();
            tempCard = null;
            cardAreaHand.CardClicked -= cardAreaHand_CardClickedEliteArcanist;
        }

        void cardAreaHand_CardClickedCipher(MagicCard mc, MouseEventArgs e)
        {
            tempCard.attachedCards.Add(mc);
            tempCard.checkPT();
            tempCard = null;

            PlArea._hand.Remove(mc);
            cardAreaHand.RemoveCard(mc);
            cardAreaHand.CardClicked -= cardAreaHand_CardClickedCipher;

            mc.Activate += new MagicCard.Ability(mc_ActivateEliteArcanist);

        }

        void mc_ActivateEliteArcanist(MagicCard mc)
        {
            PrePlay(mc);
        }

        void cardArea1_CardClicked1(MagicCard mc, MouseEventArgs e)
        {
            mc.quantity = 1;
            mc.attachedCards.Add(tempCard);
            mc.checkPT();
            mc.Name += "*";
            mc.TapChanged += new CardUse(mc_TapVerdantHaven);

            tempCard = null;

            cardAreaLand.CardClicked -= cardArea1_CardClicked1;
            updateAll();
        }

        # region cardAreaHand
        private void cardAreaHand_CardClicked(MagicCard mc, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ViewCard(mc);
            }
        }

        private void cardAreaHand_CardDoubleClicked(MagicCard mc, MouseEventArgs e)
        {
            cardAreaHand_ChoseCard(mc);
        }

        private void cardAreaHand_ChoseCard(MagicCard mc)
        {
            mc.OnPlay += new CardUse(temp_OnPlay);
            PrePlay(mc);
        }
        # endregion
        # endregion

        private void ToHand(ListView lv)
        {
            PlArea._play.index();

            if (lv.SelectedIndices.Count > 0)
            {
                # region clicked item
                int i = lv.SelectedIndices[0];

                if (i > -1)
                {
                    PlArea._play.cards[i].counters = 0;
                    PlArea._hand.cards.Add(PlArea._play.cards[i]);
                    PlArea._play.cards.RemoveAt(i);
                }
                # endregion
            }

            updateAll();
        }

        # region
        private void endTurn()
        {


            //panelPlayerSide.Enabled = false;

            PhaseName = "Player - Combat Start";
            //PhaseChanged += new Phase(DeckTest_PlCombatStart);
            TimersStart();
        }

        private void TimersStart()
        {
            timer2.Start();
            timer1.Start();
        }

        private void OppPlayHand()
        {
            # region play a land
            int i = OppArea._hand.cards.FindIndex(o => o.Type.Contains("Land"));

            if (i > -1)
            {
                MagicCard mc = new MagicCard(OppArea._hand.cards[i]);
                OppArea.PlayCard(mc);
                OppArea._hand.cards.RemoveAt(i);
            }
            # endregion

            # region work out how much mana there is to play with
            foreach (MagicCard mc in OppArea._lands.cards)
            {
                switch (mc.Name)
                {
                    case "Island":
                        OppArea.mana.blue += mc.quantity;
                        break;

                    case "Forest":
                        OppArea.mana.green += mc.quantity;
                        break;

                    case "Swamp":
                        OppArea.mana.black += mc.quantity;
                        break;

                    case "Plains":
                        OppArea.mana.white += mc.quantity;
                        break;

                    case "Mountain":
                        OppArea.mana.red += mc.quantity;
                        break;
                }
            }

            updateManaLabel();
            # endregion

            # region play a creature
            foreach (MagicCard mc in OppArea._hand.cards)
            {
                if (!mc.Type.ToLower().Contains("land"))
                {
                    bool mana = true;

                    mc.setMana();

                    if (mc.manaCost.blue > OppArea.mana.blue) { mana = false; }
                    if (mc.manaCost.black > OppArea.mana.black) { mana = false; }
                    if (mc.manaCost.red > OppArea.mana.red) { mana = false; }
                    if (mc.manaCost.green > OppArea.mana.green) { mana = false; }
                    if (mc.manaCost.white > OppArea.mana.white) { mana = false; }

                    # region grey
                    int g = OppArea.mana.colourless - mc.manaCost.colours;

                    if (mc.manaCost.grey > g) { mana = false; }
                    # endregion

                    //play card
                    if (mana)
                    {
                        MagicCard mcs = new MagicCard(mc);
                        OppArea.PlayCard(mcs);
                        OppArea._hand.cards.Remove(mc);
                        break;
                    }
                }
            }
            # endregion

            updateOppSide();
        }

        private void Mulligan()
        {
            mulligans++;
            PlArea.initialise();
            int cards = 7 - mulligans;

            cardAreaHand.Paused = true;
            DrawCard(cards);
            cardAreaHand.Paused = false;

            update_listViewHand();
        }

        private void ResetGame()
        {
            clearAll();
            games++;

            PlArea.initialise();

            cardAreaHand.Paused = true;
            DrawCard(7);
            cardAreaHand.Paused = false;

            OppArea.initialise();
            OppArea.drawCards(7);

            updateAll();
        }
        # endregion
        # endregion

        # region internal
        # region update
        private void updateAll()
        {
            updateImageLists();

            updateManaLabel();
            updateText();

            update_listViewArtEnch();
            update_listViewHand();
            update_listViewLand();
            update_listViewPlay();

            updateOppSide();
        }

        private void updateText()
        {
            numOppHP.Value = OppArea.HP;
            numPlaHP.Value = PlArea.HP;
            textTurn.Text = "Turn " + (turns + 1).ToString();
        }

        private void updateImageLists()
        {
            # region Hand
            imageListHand.Images.Clear();
            foreach (MagicCard mc in PlArea._hand.cards)
            {
                imageListHand.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._hand.cards)
            {
                imageListHand.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion

            # region Play
            imageListPlay.Images.Clear();
            foreach (MagicCard mc in PlArea._play.cards)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._play.cards)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion

            # region Land
            foreach (MagicCard mc in PlArea._lands.cards)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._lands.cards)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion

            # region artifacts/enchantments
            foreach (MagicCard mc in PlArea._artEnch.cards)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._artEnch.cards)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion
        }

        # region player side
        private void updatePlaSide()
        {
            update_listViewArtEnch();
            update_listViewHand();
            update_listViewLand();
            update_listViewPlay();
        }

        # region listviews
        //private void updateListViews()
        //{
        //    update_listViewHand();
        //    update_listViewLand();
        //    update_listViewPlay();
        //    update_listViewArtEnch();
        //}

        private void update_listViewArtEnch()
        {
            listViewArtEnch.Items.Clear();
            foreach (MagicCard mc in PlArea._artEnch.cards)
            {
                listViewArtEnch.Items.Add(mc.toListViewItem(false));
            }
        }

        private void update_listViewPlay()
        {
            cardAreaPlay.Cards = PlArea._play;
            cardAreaPlay.DrawAllCards();
        }

        private void update_listViewLand()
        {
            cardAreaLand.Cards = PlArea._lands;
            cardAreaLand.DrawAllCards();   //cardviewer version
        }

        private void update_listViewHand()
        {
            cardAreaHand.Cards = PlArea._hand;
            cardAreaHand.DrawAllCards();
        }
        # endregion
        # endregion

        # region opponent side
        private void updateOppSide()
        {
            listViewOppLand.Items.Clear();
            listViewOppLand.OwnerDraw = true;

            foreach (MagicCard mc in OppArea._lands.cards)
            {
                ListViewItem lvi = mc.toListViewItem(false);
                listViewOppLand.Items.Add(lvi);
            }

            listViewOppLand.OwnerDraw = false;

            listViewOppCrea.OwnerDraw = true;
            listViewOppCrea.Items.Clear();
            foreach (MagicCard mc in OppArea._play.cards)
            {
                listViewOppCrea.Items.Add(mc.toListViewItem(true));
            }
            listViewOppCrea.OwnerDraw = false;

            updateManaLabel();
        }

        private void updateManaLabel()
        {
            label2.Text = PlArea.mana.colourless.ToString() + "_ / ";
            label2.Text += PlArea.mana.green.ToString() + "G / ";
            label2.Text += PlArea.mana.red.ToString() + "R / ";
            label2.Text += PlArea.mana.blue.ToString() + "U / ";
            label2.Text += PlArea.mana.white.ToString() + "W / ";
            label2.Text += PlArea.mana.black.ToString() + "K";
        }
        # endregion
        # endregion

        # region clear
        private void clearAll()
        {
            PlArea.Clear();
            OppArea.Clear();

            mulligans = 0;
            turns = 0;
        }
        # endregion
        # endregion
        # endregion

        # region events
        # region buttons
        # region card actions
        void temp_OnPlay(MagicCard mc)
        {
            PlArea._hand.cards.Remove(mc);

            cPanelControls.Hide();
            cardAreaHand.RemoveCard(mc);
            mc.OnPlay -= temp_OnPlay;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            ListView lv = listViewPlay;
            PlArea._play.index();

            if (lv.SelectedIndices.Count > 0)
            {
                int i = lv.SelectedIndices[0];

                PlArea._play.cards.RemoveAt(i);

                cPanelControls.Hide();
                updateAll();
            }
        }

        private void buttonCountUp_Click(object sender, EventArgs e)
        {
            if (viewCard != null)
            {
                viewCard.counters++;
            }
        }

        private void buttonCountDown_Click(object sender, EventArgs e)
        {
            if (viewCard != null)
            {
                viewCard.counters--;
            }
        }

        private void buttonCount_Leave(object sender, EventArgs e)
        {
            t1_Tick(t1, e);
        }

        private void buttonToHand_Click(object sender, EventArgs e)
        {
            ToHand(listViewPlay);
        }
        # endregion

        # region admin buttons
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            DrawCard(1);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void buttonTurn_Click(object sender, EventArgs e)
        {
            endTurn();
        }
        # endregion
        # endregion

        # region listviews
        private void changeView(ListView lv, View v)
        {
            if (lv != null)
            {
                lv.View = v;
            }
        }

        # region listviewhand
        private void listViewHand_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlArea._hand.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                # region clicked item
                int ind = temp.SelectedIndices[0];

                if (ind > -1)
                {
                    MagicCard mc = PlArea._hand.cards[ind];

                    ViewCard(mc);
                }
                # endregion
            }
            else
            {
                cPanelControls.Hide();
            }
        }

        # endregion

        private void listViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlArea._lands.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                # region clicked item
                int ind = temp.SelectedIndices[0];

                if (ind > -1)
                {
                    MagicCard mc = PlArea._lands.cards[ind];
                    ViewCard(mc);
                }
                # endregion
            }
            else
            {
                cPanelControls.Hide();
            }
        }

        private void landArea1_CardClicked(MagicCard mc, MouseEventArgs e)
        {
            if (tempCard == null)
            {
                tempCard = mc;
            }

            if (e.Button == MouseButtons.Right)
            {
                ViewCard(mc);
            }
        }

        # region listviewplay
        private void listViewPlay_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlArea._play.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                # region clicked item
                int ind = temp.SelectedIndices[0];

                if (ind > -1)
                {
                    MagicCard mc = PlArea._play.cards[ind];
                    ViewCard(mc);
                }
                # endregion
            }
            else
            {
                cPanelControls.Hide();
            }
        }
        # endregion

        private void listViewPlay_MouseUp(object sender, MouseEventArgs e)
        {
            ListView temp = sender as ListView;
            lvTemp = temp;

            cPanelControls.Hide();

            if (temp.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    listViewPlay_SelectedIndexChanged(listViewPlay, e);
                }
                int ind = listViewPlay.SelectedItems[0].Index;

                onCardChosen(PlArea._play.cards[ind]);
            }
        }

        private void listViewArtEnch_MouseUp(object sender, MouseEventArgs e)
        {
            ListView temp = sender as ListView;
            lvTemp = temp;

            cPanelControls.Hide();

            if (e.Button == MouseButtons.Right)
            {
                if (temp.SelectedItems.Count > 0)
                {
                    listViewArtEnch_SelectedIndexChanged(listViewArtEnch, e);
                }
            }
        }

        private void listViewArtEnch_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlArea._artEnch.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                # region clicked item
                int ind = temp.SelectedIndices[0];

                if (ind > -1)
                {
                    MagicCard mc = PlArea._artEnch.cards[ind];

                    ViewCard(mc);
                }
                # endregion
            }
            else
            {
                cPanelControls.Hide();
            }
        }

        private void listViewArtEnch_DoubleClick(object sender, EventArgs e)
        {
            ToHand(listViewArtEnch);
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {

        }
        # endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (lvTemp.SelectedItems.Count > 0)
            {
                e.Cancel = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Magic Decks (*.mcxd)|*.mcxd";

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK && File.Exists(ofd.FileName))
            {
                using (Stream stream = File.Open(ofd.FileName, FileMode.Open))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(CardCollection));

                    PlArea._deck = serial.Deserialize(stream) as CardCollection;
                }

            }

            PlArea.initialise();
            DrawCard(7);
        }

        private void DeckTest_KeyPress(object sender, KeyPressEventArgs e)  //keyboard shortcuts
        {
            switch (e.KeyChar)
            {
                case 'd':
                    buttonDraw_Click(sender, e);
                    e.Handled = true;
                    break;

                case 't':
                    buttonTurn_Click(sender, e);
                    e.Handled = true;
                    break;

                case 'm':
                    Mulligan();
                    e.Handled = true;
                    break;

                case ' ':
                    if (timer2.Enabled)
                    {
                        TimerStop();
                        Text = "Deck Text (" + PhaseName + ") Paused";
                        panelPlayerSide.Enabled = true;
                    }
                    else
                    {
                        TimersStart();
                        Text = "Deck Text (" + PhaseName + ") Running";
                        panelPlayerSide.Enabled = false;
                    }
                    break;
            }

        }

        private void TimerStop()
        {
            timer2.Stop();
            timer1.Stop();
        }

        # region timer ticking
        void t1_Tick(object sender, EventArgs e)
        {
            t1.Stop();

            //updateListViews();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //now redundant
            //replaced by phasechanged
        }
        # endregion

        # region hp
        private void numFoeHP_ValueChanged(object sender, EventArgs e)
        {
            OppArea.HP = (int)numOppHP.Value;
        }

        private void FoeHP_ValueChanged()
        {
            numOppHP.Value = OppArea.HP;
        }

        private void numPlaHP_ValueChanged(object sender, EventArgs e)
        {
            PlArea.HP = (int)numPlaHP.Value;
        }

        private void PlaHP_ValueChanged()
        {
            numPlaHP.Value = PlArea.HP;
        }
        # endregion
        # endregion

        # region card events
        void mc_TapVerdantHaven(MagicCard mc)
        {
            if (!mc.Tapped) { return; }

            ColourCost c = new ColourCost
            {
                blue = 1,
                black = 1,
                red = 1,
                green = 1,
                white = 1,
                grey = 1
            };

            PlArea.mw.ShowWheel(c);
        }

        void mc_ActivateCard(MagicCard mc)
        {
            switch (mc.Name)
            {
                case "Voyaging Satyr":
                    cardAreaLand.CardClicked += new CardArea.CardChosen(VoyagingSatyrLand);
                    break;

                case "Vorel of the Hull Clade":
                    cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_VorelHullClade);
                    break;
            }
        }

        void CardClicked_VorelHullClade(MagicCard mc, EventArgs e)
        {
            cardAreaPlay.CardClicked -= CardClicked_VorelHullClade;
            mc.counters *= 2;
            //update_listViewPlay();
        }

        void VoyagingSatyrLand(MagicCard mc, MouseEventArgs e)
        {
            if (!mc.Tapped)
            {
                return;
            }
            else
            {
                cardAreaLand.CardClicked -= VoyagingSatyrLand;

                mc.Tap(false, false);
            }
        }

        void CardEvent_Populate(MagicCard mc, MouseEventArgs e)
        {
            if (!mc.Token)
            {
                return;
            }
            else
            {
                MagicCard mct = new MagicCard(mc);
                PlArea.PlayCard(mct);
            }
        }

        void CardChosen_TritonTactics(MagicCard mc, EventArgs e)
        {
            if (PlArea._play.cards.Contains(mc))
            {
                mc.Tap(false, false);
                mc.TBonus += 3;
                mc.checkPT();
            }

            targets--;
            if (targets < 1)
            {
                cardAreaPlay.CardClicked -= CardChosen_TritonTactics;
            }
        }

        void Activate_OozeFlux(MagicCard mc)
        {
            int c = 0;  //number of counters on creatures
            foreach (MagicCard mcs in PlArea._play.cards)
            {
                if (mcs.counters > 0)
                {
                    c += mcs.counters;
                }
            }

            cPanelControls.Hide();

            cardAreaPlay.PickCounters();
            cardAreaPlay.CountersPicked += new CardArea.CountersChosen(cardAreaPlay_CountersPicked);
        }

        void CardClick_BondBeetle(MagicCard mc, MouseEventArgs e)
        {
            mc.counters++;
            cardAreaPlay.CardClicked -= CardClick_BondBeetle;
        }

        void CardChosen_NaturesLore(MagicCard mc)
        {
            useCard(mc);
            CardChosen -= CardChosen_NaturesLore;
        }
        # endregion

        # region phase order
        void DeckTest_PlTurnStart()
        {
            PhaseChanged -= DeckTest_PlTurnStart;
            PhaseChanged += new Phase(DeckTest_PlMainOneStart);
            PhaseName = "Player - Turn Start";

            timer2.Interval = 2000; //TODO is this necessary?
            progressBar1.Maximum = 2000;

            turns++;

            //Pause refreshing areas until all updated
            cardAreaPlay.Paused = true;
            cardAreaLand.Paused = true;
            PlArea.Upkeep();
            cardAreaPlay.Paused = false;
            cardAreaLand.Paused = false;

            update_listViewPlay();

            buttonDraw_Click(timer2, EventArgs.Empty);

            updateText();

            panelPlayerSide.Enabled = true;
        }

        void DeckTest_PlMainOneStart()
        {
            PhaseChanged -= (DeckTest_PlMainOneStart);
            PhaseChanged += new Phase(DeckTest_PlMainOneEnd);
            PhaseName = "Player - Main Step 1 Start";

            progressBar1.Maximum = 5000;

            if (CheckValidCards())
            {
                TimerStop();
            }
        }

        void DeckTest_PlMainOneEnd()
        {
            PhaseChanged -= DeckTest_PlMainOneEnd;
            PhaseChanged += new Phase(DeckTest_PlCombatStart);
            PhaseName = "Player - Main Step 1 End";

            TimersStart();
            callPhaseChanged();
        }

        void DeckTest_PlCombatStart()
        {
            PhaseChanged -= DeckTest_PlCombatStart;
            PhaseChanged += new Phase(DeckTest_PlCombatEnd);
            PhaseName = "Player - Combat Start";

            cardAreaPlay.SetCombat(true);

            if (cardAreaPlay.countAttackers() > 0)
            {
                TimerStop();
            }
        }

        void DeckTest_PlCombatEnd()
        {
            PhaseChanged -= DeckTest_PlCombatEnd;
            PhaseChanged += new Phase(DeckTest_PlMainTwoStart);
            PhaseName = "Player - Combat End";

            PlArea.ProcAttack();

            cardAreaPlay.SetCombat(false);
        }

        void DeckTest_PlMainTwoStart()
        {
            PhaseChanged -= DeckTest_PlMainTwoStart;
            PhaseChanged += new Phase(DeckTest_PlMainTwoEnd);
            PhaseName = "Player - Main Step 2 Start";
        }

        void DeckTest_PlMainTwoEnd()
        {
            PhaseChanged -= DeckTest_PlMainTwoEnd;
            PhaseChanged += new Phase(DeckTest_PlEndStep);
            PhaseName = "Player - Main Step 2 End";

            TimersStart();
            callPhaseChanged();
        }

        void DeckTest_PlEndStep()
        {
            PhaseChanged -= DeckTest_PlEndStep;
            PhaseChanged += new Phase(DeckTest_OppStart);
            PhaseName = "Player - End Step";

            PlArea.EndStep();

            PlArea.mana.Clear();
            OppArea.mana.Clear();

            timer2.Interval = 1000;
            progressBar1.Maximum = 1000;
        }

        void DeckTest_OppStart()
        {
            PhaseChanged -= DeckTest_OppStart;
            PhaseChanged += new Phase(DeckTest_OppUpkeepEnd);
            PhaseName = "Foe - Turn Start";

            OppArea.Upkeep();
            OppArea.drawCards(1);
        }

        void DeckTest_OppUpkeepEnd()
        {
            PhaseChanged -= DeckTest_OppUpkeepEnd;
            PhaseChanged += new Phase(DeckTest_OppMainPreEnd);
            PhaseName = "Foe - Upkeep Start";

            OppPlayHand();
        }

        void DeckTest_OppMainPreEnd()
        {
            PhaseChanged -= DeckTest_OppMainPreEnd;
            PhaseChanged += new Phase(DeckTest_OppCombEnd);
            PhaseName = "Foe - Main Step 1 Start";
        }

        void DeckTest_OppCombEnd()
        {
            PhaseChanged -= DeckTest_OppCombEnd;
            PhaseChanged += new Phase(DeckTest_OppMainPostEnd);
            PhaseName = "Foe - Combat Start";

            //Pause for combat
            if (OppArea.countAttackers() > 0)
            {
                TimerStop();

                cardAreaPlay.Discard = true;
                cardAreaPlay.ChooseCard = true;
                cardAreaPlay.ChooseCardString = "Block";
            }
        }

        void DeckTest_OppMainPostEnd()
        {
            cardAreaPlay.Discard = false;
            cardAreaPlay.ChooseCard = false;

            PhaseChanged -= DeckTest_OppMainPostEnd;
            PhaseChanged += new Phase(DeckTest_OppTurnEnd);
            PhaseName = "Foe - Main Step 2 Start";
        }

        void DeckTest_OppTurnEnd()
        {
            PhaseChanged -= DeckTest_OppTurnEnd;
            PhaseChanged += new Phase(DeckTest_PlTurnStart);
            PhaseName = "Foe - End Step";

            PlArea.mana.Clear();
            OppArea.mana.Clear();

            PlArea.EndStep();
            OppArea.EndStep();
        }
        # endregion

        # region context menu items.
        private void largeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTemp != null)
            {
                changeView(lvTemp, View.LargeIcon);
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTemp != null)
            {
                changeView(lvTemp, View.Details);
            }
        }

        private void smallImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTemp != null)
            {
                changeView(lvTemp, View.SmallIcon);
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTemp != null)
            {
                changeView(lvTemp, View.List);
            }
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTemp != null)
            {
                changeView(lvTemp, View.Tile);
            }
        }
        # endregion

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Controls.Clear();
            }
        }

        private void listViewOppCrea_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (listViewOppCrea.SelectedItems.Count > 0)
                    {
                        int ind = listViewOppCrea.SelectedIndices[0];
                        OppArea._play.cards[ind].callDestroyed();
                        updateOppSide();
                        e.Handled = true;
                    }
                    break;
            }
        }

        # region collapsiblePanels
        private void collapsiblePanel2_CollapsedChanged()
        {
            if (cPanelOppPlay.Collapsed)
            {
                Height -= (cPanelOppPlay.sizeDiff.Height);
            }
            else
            {
                Height += (cPanelOppPlay.sizeDiff.Height);
            }
        }

        private void collapsiblePanel3_CollapsedChanged()
        {
            if (cPanelOppLand.Collapsed)
            {
                Height -= (cPanelOppLand.sizeDiff.Height);
            }
            else
            {
                Height += (cPanelOppLand.sizeDiff.Height);
            }
        }
        # endregion

        private void panelOppEnch_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(panelOppEnch.Height);
        }

        private void xPicker_Cancel()
        {
            xPicker.Hide();
            CardStack.RemoveAt(0);
        }

        private void buttonCardChoose_Click(object sender, EventArgs e)
        {
            int i = comboCardPicker.SelectedIndex;
            if (i >= 0 && i < PickList.Count)
            {
                MagicCard mc = PickList[i];
                onCardChosen(mc);
            }

            buttonCardChoose.Visible = false;
            comboCardPicker.Visible = false;
            cPanelControls.Visible = false;
        }

        private static bool CheckValidCards()
        {
            return true;
        }

        # region comboCardPicker
        private void comboCardPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            int i = comboCardPicker.SelectedIndex;
            if (i >= 0 && i < PickList.Count)
            {
                MagicCard mc = PickList[i];
                ViewCard(mc);
            }
        }

        private void comboCardPicker_Fill(List<MagicCard> cards)
        {
            PickList = cards;
            foreach (MagicCard mc in PickList)
            {
                comboCardPicker.Items.Add(mc);
            }

            cPanelControls.Show();
            buttonCardChoose.Visible = true;
            comboCardPicker.Visible = true;
        }
        # endregion

        private void button1_Click(object sender, EventArgs e)
        {
            viewCard = null;
            cPanelControls.Hide();
        }

        private void viewDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Visible = true;
            cPanelControls.Show();
        }

        private void landAreaPlay_KeyUp(object sender, KeyEventArgs e)
        {
            update_listViewPlay();
        }

        private void ViewCard(MagicCard mc)
        {
            panel1.Controls.Clear();
            viewCard = mc;

            CardViewer cardViewer1 = new CardViewer();
            panel1.Controls.Add(cardViewer1);
            cardViewer1.LoadCard(mc);
            cPanelControls.Show();
            panel1.Show();
            panel1.BringToFront();

            int count = mc.attachedCards.Count;

            panel1.Width = 200 * (1 + count);

            Debug.WriteLine("Count: {0}, size: {1}", count, panel1.Width);

            for (int i = 0; i < count; i++)
            {
                CardViewer cv = new CardViewer();
                panel1.Controls.Add(cv);
                cv.Show();
                cv.Left = (panel1.Controls.Count - 1) * 200;
                cv.LoadCard(mc.attachedCards[i]);
            }
        }

        void cv_VisibleChanged(object sender, EventArgs e)
        {
            Control ct = sender as Control;
            if (ct.Visible == false)
            {
                ct.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Step = (timer1.Interval * 100) / timer2.Interval;
            progressBar1.PerformStep();

            if (progressBar1.Value == progressBar1.Maximum)
            {
                callPhaseChanged();
                progressBar1.Value = 0;
            }
        }
    }

    public class PlayArea
    {
        # region declarations
        # region card areas
        public CardCollection _deck;
        public CardCollection _stack;
        public CardCollection _graveyard;
        public CardCollection _hand;
        public CardCollection _artEnch;
        public CardCollection _play;
        public CardCollection _lands;
        # endregion

        # region hp
        public event Action HPChanged;

        private void onHPChanged()
        {
            Action handler = HPChanged;
            if (handler != null)
            {
                handler();
            }
        }

        private int _hp = 20;
        public int HP
        {
            get { return _hp; }
            set
            {
                _hp = value;
                onHPChanged();
            }
        }
        # endregion

        public int MaxHand = 7;
        int shuffles = 0;

        public int seed = 0;

        public ManaWheel mw = new ManaWheel { Visible = false };

        private List<MagicCard> CardsProc = new List<MagicCard>();

        public event Phase SpellRes;
        protected void onSpellRes()
        {
            Phase handler = SpellRes;

            foreach (MagicCard mc in CardsProc)
            {
                mc.callAbility();
            }

            if (handler != null)
            {
                handler();
            }
        }

        public event CardUse CardUsed;
        public event CardUse CardDrawn;

        protected void onCardUse(MagicCard mc)
        {
            CardUse handler = CardUsed;
            if (handler != null)
            {
                handler(mc);
            }
        }
        protected void onCardDrawn(MagicCard mc)
        {
            CardUse handler = CardDrawn;
            if (handler != null)
            {
                handler(mc);
            }
        }

        public ColourCost mana = new ColourCost();
        # endregion

        public void Setup()
        {
            mw.Closing += new ManaWheel.Chosen(mw_Closing);

        }

        public void initialise()
        {
            _stack = new CardCollection();
            _hand = new CardCollection();
            _play = new CardCollection();
            _graveyard = new CardCollection();
            _lands = new CardCollection();
            _artEnch = new CardCollection();


            initialiseDeck();
        }

        private void initialiseDeck()
        {
            foreach (MagicCard mc in _deck.cards)
            {
                for (int i = 0; i < mc.quantity; i++)
                {
                    MagicCard newCard = mc.Clone() as MagicCard;
                    newCard.quantity = 1;
                    _stack.cards.Add(newCard);
                }
            }

            Output.Write("\r\nshuffling cards\r\n");
            _stack.cards.OrderBy(o => o.Type);
            _stack = Shuffle(_stack, false);
            _stack = Shuffle(_stack, false);
            _stack = Shuffle(_stack, true);
        }

        public void PlayCard(MagicCard mc)
        {
            # region land
            if (mc.Type.Contains("Land"))
            {
                if (mc.Type.Contains("Basic Land"))
                {
                    mc.TapChanged += new CardUse(Activate_BasicLand);
                }
                if (mc.Type.Contains("Gate"))
                {
                    mc.TapChanged += new CardUse(Tap_Gate);
                    mc.Activating += new MagicCard.Ability(mc_Activating);
                }

                # region named cards
                switch (mc.Name)
                {
                    case "Breeding Pool":
                        DialogResult dr = MessageBox.Show("Pay 2 life to untap?", "Pay life?", MessageBoxButtons.YesNo);
                        mc.TapChanged += new CardUse(Tap_Gate);

                        if (dr == DialogResult.Yes)
                        {
                            mc.Tap(false, true);
                            HP -= 2;
                        }
                        else
                        {
                            mc.Tap(true, true);
                        }
                        break;

                    case "Oran-Rief, the Vastwood":
                        mc.Tap(true, true);
                        break;

                    case "Simic Guildgate":
                        mc.Tap(true, true);
                        break;
                }
                # endregion
                _lands.cards.Add(mc);
                _lands.index();
            }
            # endregion
            # region spells
            else if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            {
                switch (mc.Name)
                {
                    default:
                        break;
                }

                _graveyard.cards.Add(mc);
                _graveyard.index();
            }
            # endregion
            # region artifacts and enchantments
            else if (mc.Type.Contains("Artifact") || mc.Type.Contains("Enchantment"))
            {
                if (mc.Name == "Verdant Haven")
                {
                    HP += 2;
                }

                _artEnch.Add(mc);
                _artEnch.index();
            }
            # endregion
            # region creatures
            else
            {
                foreach (MagicCard mstc in _play.cards)
                {
                    if (mstc.Name == "Master Biomancer")
                    {
                        mc.counters += mstc.Power;
                    }
                }

                if (mc.Name == "Leech Bonder")
                {
                    mc.counters -= 2;
                }

                # region individual card switch
                switch (mc.Name)
                {
                    case "Renegade Krasis":
                        mc.Evolving += new MagicCard.Ability(RenegadeKrasis_Evolve);
                        break;

                    case "Vorel of the Hull Clade":
                        mc.Activating += new MagicCard.Ability(Activate_VorelHullClade);
                        break;

                    case "Gyre Sage":
                        mc.Activate += new MagicCard.Ability(Activate_GyreSage);
                        break;

                    case "Voyaging Satyr":
                        mc.Activate += new MagicCard.Ability(Activate_VoyagingSatyr);
                        break;

                    case "Opal Lake Gatekeepers":
                        if (CheckLandType("gate", 2))
                        {
                            drawCards(1);
                        }
                        break;

                    case "Saruli Gatekeepers":
                        if (CheckLandType("gate", 2))
                        {
                            HP += 7;
                        }
                        break;

                    case "Protean Hydra":
                        mc.counters += mc.Xvalue;
                        break;

                    case "Vastwood Hydra":
                        mc.counters += mc.Xvalue;
                        break;

                    case "Primordial Hydra":
                        mc.counters += mc.Xvalue;
                        break;

                    case "Elite Arcanist":
                        mc.Activating += new MagicCard.Ability(Activating_EliteArcanist);
                        break;
                }
                # endregion

                mc.checkPT();
                foreach (MagicCard mcs in _play.cards)
                {
                    mcs.Evolve(mc.Power, mc.Toughness);
                }

                onSpellRes();

                //TODO need to expand this to actually check.
                if (!mc.Text.Contains("Haste"))
                {
                    mc.Sick = true;
                }

                _play.cards.Add(mc);
                _play.index();
            }
            # endregion

            mc.Activating += new MagicCard.Ability(mc_Activating);
            mc.Discard += new CardUse(Play_Discard);
            mc.Destroyed += new CardUse(Play_Destroyed);
        }

        public void PlayToken(MagicCard mc)
        {
            PlayCard(mc);
        }

        void Play_Destroyed(MagicCard mc)
        {
            bool toHand = false;
            foreach (MagicCard mca in mc.attachedCards)
            {
                if (mc.Name == "Rancor")
                {
                    _hand.cards.Add(mc);
                    toHand = true;
                }
            }

            if (!toHand)
            {
                _graveyard.cards.Add(mc);
            }
            _play.cards.Remove(mc);
        }

        void Play_Discard(MagicCard mc)
        {
            _graveyard.cards.Add(mc);
            _play.cards.Remove(mc);
        }

        void Hand_Discard(MagicCard mc)
        {
            _graveyard.cards.Add(mc);
            _hand.cards.Remove(mc);
        }

        void mc_Activating(MagicCard mc)
        {
            if (mc.Abilities.Count == 0)
            {
                return;
            }
            ColourCost c = mc.Abilities[0].Cost;
            bool tap = mc.Abilities[0].RawCost.Contains("%T");


            if (!mana.Compare(c))
            {
                return;
            }

            if (tap)
            {
                if (mc.Tapped || mc.Sick)
                {
                    return;
                }
                else
                {
                    mc.Tap(true, false);
                }
            }

            mana.Subtract(c);

            mc.callActivate();

        }

        private bool CheckLandType(string type, int count)
        {
            bool result = false;
            int c = 0;
            foreach (MagicCard mcs in _lands.cards)
            {
                if (mcs.Type.ToLower().Contains(type.ToLower()))
                {
                    c++;
                }
            }
            if (c >= count)
            {
                result = true;
            }

            return result;
        }

        # region individual card events
        void RenegadeKrasis_Evolve(MagicCard mc)
        {
            CardsProc.Add(mc);
            mc.Activate += new MagicCard.Ability(DeckTest_SpellRes);
        }

        void DeckTest_SpellRes(MagicCard mc)
        {
            foreach (MagicCard msc in _play.cards)
            {
                if (msc.counters > 0 && msc != mc)
                {
                    msc.counters++;
                }
            }
            mc.Activate -= DeckTest_SpellRes;
        }

        # region Activate
        void Activate_BasicLand(MagicCard mc)
        {
            if (!mc.Tapped)
            {
                return;
            }

            if (mc.Name.Contains("Forest"))
            {
                mana.green++;
            }

            if (mc.Name.Contains("Island"))
            {
                mana.blue++;
            }

            if (mc.Name.Contains("Swamp"))
            {
                mana.black++;
            }

            if (mc.Name.Contains("Mountain"))
            {
                mana.red++;
            }

            if (mc.Name.Contains("Plains"))
            {
                mana.white++;
            }

        }

        void Activate_GyreSage(MagicCard mc)
        {
            if (mc.counters > 0)
            {
                mana.green += mc.counters;
                mc.Tap(true, true);
            }
        }

        void Activate_VorelHullClade(MagicCard mc)
        {

        }

        void Activate_VoyagingSatyr(MagicCard mc)
        {
            //hook for decktest
            mc.Tap(true, true);
        }

        void Activate_Gate(MagicCard mc)
        {
            if (mc.Tapped)
            {
                return;
            }

            mc.Tap(true, false);
        }

        void Activating_EliteArcanist(MagicCard mc)
        {
            if (mc.attachedCards.Count > 0)
            {
                if (mana.colourless >= mc.attachedCards[0].manaCost.colourless)
                {
                    mc.attachedCards[0].TryActivate(0);
                    mc.Tap(true, false);
                }
                else
                {
                    string s = "Elite Arcanist: Not enough mana to activate ability (" + mana.colourless + "/" + mc.attachedCards[0].manaCost.colourless + ")";
                    MessageBox.Show(s);
                }
            }
        }

        void Tap_Gate(MagicCard mc)
        {
            if (!mc.Tapped)
            {
                return;
            }

            ColourCost ManaAdd = new ColourCost();

            if (mc.Name.Contains("Simic")) { ManaAdd.blue = ManaAdd.green = 1; }
            if (mc.Name.Contains("Gruul")) { ManaAdd.blue = ManaAdd.black = 1; }
            if (mc.Name.Contains("Selesnya")) { ManaAdd.white = ManaAdd.green = 1; }
            if (mc.Name.Contains("Rakdos")) { ManaAdd.black = ManaAdd.red = 1; }
            if (mc.Name.Contains("Azorius")) { ManaAdd.blue = ManaAdd.white = 1; }

            if (mc.Name.Contains("Orzhov")) { ManaAdd.white = ManaAdd.black = 1; }
            if (mc.Name.Contains("Izzet")) { ManaAdd.blue = ManaAdd.red = 1; }
            if (mc.Name.Contains("Golgari")) { ManaAdd.black = ManaAdd.green = 1; }
            if (mc.Name.Contains("Boros")) { ManaAdd.white = ManaAdd.red = 1; }
            if (mc.Name.Contains("Dimir")) { ManaAdd.blue = ManaAdd.black = 1; }

            if (mc.Name.Contains("Breeding Pool")) { ManaAdd.green = ManaAdd.blue = 1; }

            mw.ShowWheel(ManaAdd);
        }
        # endregion

        void mw_Closing(ColourCost c)
        {
            mana.Add(c);
        }
        # endregion

        public void Clear()
        {
            //_deck.Clear();
            _stack.Clear();
            _graveyard.Clear();
            _hand.Clear();
            _artEnch.Clear();
            _play.Clear();
            _lands.Clear();

            mana.Clear();

            HP = 20;
        }

        public List<MagicCard> drawCards(int i)
        {
            List<MagicCard> result = new List<MagicCard>();

            for (int j = 0; j < i; j++)
            {
                if (_stack.cards.Count < 1)
                {
                    break;
                }

                MagicCard mc = _stack.cards[0];

                _hand.cards.Add(mc);
                _stack.cards.Remove(mc);    //remove?
                //_stack.cards.RemoveAt(0);

                result.Add(mc);
                onCardDrawn(mc);
            }

            return result;
        }

        public int countAttackers()
        {
            int result = 0;

            foreach (MagicCard mc in _play.cards)
            {
                if (!mc.Tapped && !mc.Sick) //And not defender
                {
                    result++;
                }
            }

            return result;
        }

        public void ProcAttack()
        {
            foreach (MagicCard mc in _play.cards)
            {

                if (mc.Attacking)
                {
                    if (mc.Name == "Predator Ooze")
                    {
                        mc.counters++;
                    }
                    mc.Attack();
                }
            }
        }

        public void Upkeep()
        {
            foreach (MagicCard mc in _play.cards)
            {
                mc.UpkeepCard();
            }
            foreach (MagicCard mc in _artEnch.cards)
            {
                mc.UpkeepCard();
            }
            foreach (MagicCard mc in _lands.cards)
            {
                mc.UpkeepCard();
            }
            foreach (MagicCard mc in _hand.cards)
            {
                mc.UpkeepCard();
            }
        }

        public void EndStep()
        {
            foreach (MagicCard mc in _play.cards)
            {
                mc.EndStepCard();
            }
        }

        public CardCollection Shuffle(CardCollection cc, bool standard)
        {
            CardCollection result = new CardCollection();
            List<MagicCard> source = cc.cards;

            if (standard)
            {
                # region randomise
                int s = seed + DateTime.Now.Second + shuffles;
                Random rng = new Random(s);

                while (source.Count > 0)
                {
                    int k = rng.Next(source.Count);

                    result.cards.Add(source[k]);
                    source.RemoveAt(k);
                }
                # endregion
            }
            else
            {
                # region method shuffle
                List<MagicCard> one = new List<MagicCard>();
                List<MagicCard> two = new List<MagicCard>();
                List<MagicCard> three = new List<MagicCard>();

                List<MagicCard> list = one;
                int l = 0;
                for (int i = 0; i < source.Count; i++)
                {
                    list.Add(source[i]);

                    # region set list
                    if (l == 0) { l = 1; list = two; }
                    else if (l == 1) { l = 2; list = three; }
                    else if (l == 2) { l = 0; list = one; }
                    # endregion
                }

                result.cards = new List<MagicCard>();
                foreach (MagicCard mc in one)
                {
                    result.cards.Add(mc);
                }
                foreach (MagicCard mc in two)
                {
                    result.cards.Add(mc);
                }
                foreach (MagicCard mc in three)
                {
                    result.cards.Add(mc);
                }
                # endregion
            }

            shuffles++;
            return result;
        }
    }

    public delegate void Phase();
    public delegate void CardUse(MagicCard mc);
    public delegate void CardDraw();
}
