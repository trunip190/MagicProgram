using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
        public Form1 ParentForm1;

        int EffectStrength = 0;
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
                mc.CallAbility(0);
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
            PlArea.InitialiseDeck();
            PlArea.Setup();

            createOppDeck();

            cardAreaHand.Paused = true;
            DrawCard(7);
            cardAreaHand.Paused = false;

            PhaseChanged += new Phase(DeckTest_PlMainOneEnd);

            PhaseChanged += new Phase(DeckTest_PlPhaseChanged);

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

            PlArea.SearchDeck += new SearchLocation(PlArea_SearchDeck);
            PlArea.SearchDeck += new SearchLocation(OppArea_SearchDeck);
            PlArea.SearchGraveyard += new SearchLocation(PlArea_SearchGraveyard);
            PlArea.SearchGraveyard += new SearchLocation(OppArea_SearchGraveyard);

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
            update_listViewArtEnch();
            update_listViewHand();
            update_listViewLand();
            update_listViewPlay();
        }

        private void PlArea_SearchDeck(string location, string type, int depth, int count)
        {
            List<MagicCard> cards = PlArea._library.Where(o => o.Type.ToLower().Contains(type.ToLower())).ToList();
            comboCardPicker_Fill(cards.GetRange(0, 3));
            targets = count;

            CardChosen += new CardUse(PlArea_PlayCardFromStack);
        }

        private void OppArea_SearchDeck(string location, string type, int depth, int count) { }

        private void PlArea_SearchGraveyard(string location, string type, int depth, int count)
        {
            List<MagicCard> cards = PlArea._graveyard.Where(o => o.Type.ToLower().Contains(type.ToLower())).ToList();
            comboCardPicker_Fill(cards);

            CardChosen += new CardUse(PlArea_PlayCardFromGraveyard);
        }

        private void OppArea_SearchGraveyard(string location, string type, int depth, int count) { }
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
            OppArea.InitialiseDeck();
            OppArea.drawCards(7);

            updateOppSide();
        }
        # endregion

        # region methods
        # region game
        private void DrawCard(int i)
        {
            PlArea.drawCards(i);
        }

        private bool useCard(MagicCard mct)
        {
            MagicCard mc = PlArea.SortedDeck.cards.Find(o => o.DeckID == mct.DeckID);

            mc = mc == null ? CardMethods.CreateCard(mct) : mc;

            # region work out if there is enough mana
            bool mana = true;

            mc.setMana();
            if (mc.manaCost.blue > PlArea.mana.blue) { mana = false; }
            if (mc.manaCost.black > PlArea.mana.black) { mana = false; }
            if (mc.manaCost.red > PlArea.mana.red) { mana = false; }
            if (mc.manaCost.green > PlArea.mana.green) { mana = false; }
            if (mc.manaCost.white > PlArea.mana.white) { mana = false; }

            int g = PlArea.mana.Colourless - mc.manaCost.Colours;

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


            // Copy card
            //mc = CardMethods.CreateCard(mc);
            mc.CallOnPlay();

            // Set side to work with
            PlayArea area = playerTurn ? PlArea : OppArea;

            if (mc.Type.Contains("Land"))
            {
                area.PlayCard(mc);
                mc.CallLocationChanged(CardLocation.Lands);

                cardAreaLand.AddCard(mc);

                //cardAreaLand.AddCard(mc);
                //cardAreaHand.RemoveCard(mc);
                update_listViewLand();
            }
            else if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            {
                switch (mc.Name)
                {
                    case "Nature's Lore":
                        List<MagicCard> cards = PlArea._library.Where(o => o.Type.ToUpper().Contains("FOREST")).ToList();
                        comboCardPicker_Fill(cards);
                        CardChosen += new CardUse(CardChosen_NaturesLore);
                        break;

                    case "Triton Tactics":
                        targets = 2;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardChosen_TritonTactics);
                        break;

                    case "Predator's Rapport":
                        targets = 1;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardChosen_PredatorsRapport);
                        break;

                    case "Call to Heel":
                        targets = 1;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardChosen_CalltoHeel);
                        break;

                    case "Strength of the Tajuru":
                        targets = mc._XValue;
                        EffectStrength = mc._XValue;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_StrengthOfTheTajuru);
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
                            area._graveyard.Add(mc);
                            mc.LocationChanged(CardLocation.Graveyard);
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

                switch (mc.Name)
                {
                    case "Verdant Haven":
                        area.HP += 2;
                        break;

                    case "Ooze Flux":
                        mc.Activating += new MagicCard.Ability(Activating_OozeFlux);
                        break;
                }

                tempCard = mc;
                update_listViewArtEnch();
            }
            // creatures
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

                    case "Fathom Mage":
                        mc.CountersChanged += new MagicCard.ValueChanged(mc_CountersChangedFathomMage);
                        break;

                        //case "Gyre Sage":
                        //    mc.Activating += new MagicCard.Ability(Activating_GyreSage);
                        //    break;
                }

                mc.Activate += new MagicCard.Ability(mc_ActivateCard);

                mc.checkPT();

                //resolve spell
                onSpellRes();
                CardsProc = new List<MagicCard>();

                //final resolution - add card to play.
                area.PlayCard(mc);
                mc.LocationChanged(CardLocation.Play);
                update_listViewPlay();
            }

            if (mc.Location == CardLocation.Hand)
                Debug.WriteLine("");

            updateAll();
            updateManaLabel();
            //updateAll();
            return true;
        }

        private void Mc_ChangeMana(ColourCost cc)
        {
            PlArea.mana.Add(cc);
        }

        void mc_CountersChangedFathomMage(int count)
        {
            if (count > 0)
            {
                DrawCard(count);
            }
        }

        void cardAreaPlay_CountersPicked(int value, Dictionary<MagicCard, int> sources)
        {
            MagicCard mc = CardMethods.CreateCard("Ooze");

            mc.checkPT();

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
            mc._XValue = 0;
            //Debug.WriteLine("X value was {0}", mc._XValue);
            mc.Initialise();
            mc.setMana();

            if (!PlArea.mana.Compare(mc.manaCost))
            {
                Debug.WriteLine("Not enough mana to play card");
                return;
            }

            mc.CallPrePlay();

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

            CardStack[0]._XValue = value;
            //string edited = CardStack[0].Cost.Replace("X", value.ToString());
            //CardStack[0].Cost = edited;

            //cc.grey += value * count;

            if (PlArea.mana.Compare(cc))
            {
                MagicCard mc = new MagicCard(CardStack[0]);
                useCard(mc);
                Debug.WriteLine($"picker_ValuePicked {CardStack[0].Name}");
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

            int cost = mc.CMC;
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

            mc.LocationChanged(CardLocation.Exiled);
            //cardAreaHand.RemoveCard(mc);
            cardAreaHand.CardClicked -= cardAreaHand_CardClickedCipher;

            mc.Activate += new MagicCard.Ability(mc_ActivateEliteArcanist);

        }

        void mc_ActivateEliteArcanist(MagicCard mc, int ID)
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
            //PlArea._play.index();

            if (lv.SelectedIndices.Count > 0)
            {
                # region clicked item
                int i = lv.SelectedIndices[0];
                MagicCard mc = PlArea._play[i];

                if (i > -1)
                {
                    mc.counters = 0;
                    mc.LocationChanged(CardLocation.Hand);
                    //PlArea._hand.Add(mc);
                    //PlArea._play.Remove(mc.DeckID);
                }
                # endregion
            }

            updateAll();
        }

        private void ProcStack()
        {
            for (int i = CardStack.Count - 1; i >= 0; i--)
            {
                //need to replace callActivate() with a proc method
                //or work out how to add abilities to the stack,
                //maybe with onResolve event.
                CardStack[i].CallActivate(-1);

                CardStack.RemoveAt(i);
            }
        }

        private void Mc_LocationChange(int CardID, CardLocation NewArea, CardLocation OldArea)
        {
            switch (NewArea)
            {
                //case CardLocation.Library: break;
                //case CardLocation.Graveyard: break;
                case CardLocation.Hand: cardAreaHand.UpdateCard(CardID); break;
                //case CardLocation.Exiled          ;
                case CardLocation.Play: cardAreaPlay.UpdateCard(CardID); break;
                case CardLocation.Lands: cardAreaLand.UpdateCard(CardID); break;
                    //case CardLocation.Enchantments: cardAreaPlay.UpdateCard(CardID); break;
                    //case CardLocation.Artifacts: cardAreaPlay.UpdateCard(CardID); break;
            }

            switch (OldArea)
            {
                //case CardLocation.Library: break;
                //case CardLocation.Graveyard: break;
                case CardLocation.Hand: cardAreaHand.UpdateCard(CardID); break;
                //case CardLocation.Exiled          ;
                case CardLocation.Play: cardAreaPlay.UpdateCard(CardID); break;
                case CardLocation.Lands: cardAreaLand.UpdateCard(CardID); break;
                    //case CardLocation.Enchantments: cardAreaPlay.UpdateCard(CardID); break;
                    //case CardLocation.Artifacts: cardAreaPlay.UpdateCard(CardID); break;
            }
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
            int i = OppArea._hand.FindIndex(o => o.Type.Contains("Land"));

            if (i > -1)
            {
                MagicCard mc = new MagicCard(OppArea._hand[i]);
                OppArea.PlayCard(mc);
                //OppArea._hand.Remove(mc.DeckID);
                //OppArea._hand.cards.RemoveAt(i);
            }
            # endregion

            # region work out how much mana there is to play with
            //foreach (MagicCard mc in OppArea._lands.cards)
            foreach (MagicCard mc in OppArea._lands)
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
            for (int j = 0; j < OppArea._hand.Count; j++)
            {
                MagicCard mc = OppArea._hand[j];
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
                    int g = OppArea.mana.Colourless - mc.manaCost.Colours;

                    if (mc.manaCost.grey > g) { mana = false; }
                    # endregion

                    //play card
                    if (mana)
                    {
                        OppArea.PlayCard(mc);
                        mc.LocationChanged(CardLocation.Play);
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
            PlArea.InitialiseDeck();
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

            PlArea.InitialiseDeck();

            cardAreaHand.Paused = true;
            DrawCard(7);
            cardAreaHand.Paused = false;

            OppArea.InitialiseDeck();
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
            foreach (MagicCard mc in PlArea._hand)
            {
                imageListHand.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._hand)
            {
                imageListHand.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion

            # region Play
            imageListPlay.Images.Clear();
            foreach (MagicCard mc in PlArea._play)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._play)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion

            # region Land
            foreach (MagicCard mc in PlArea._lands)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._lands)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion

            # region artifacts/enchantments
            foreach (MagicCard mc in PlArea._artEnch)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            foreach (MagicCard mc in OppArea._artEnch)
            {
                imageListPlay.Images.Add(mc.Name.ToUpper(), mc.get());
            }
            # endregion
        }

        # region player side

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
            //foreach (MagicCard mc in PlArea._artEnch.cards)
            foreach (MagicCard mc in PlArea._artEnch)
            {
                listViewArtEnch.Items.Add(mc.ToListViewItem(false));
            }
        }

        private void update_listViewPlay()
        {
            cardAreaPlay.Cards.cards = PlArea._play;
            cardAreaPlay.DrawAllCards();
        }

        private void update_listViewLand()
        {
            cardAreaLand.Cards.cards = PlArea._lands;
            cardAreaLand.DrawAllCards();
        }

        private void update_listViewHand()
        {
            cardAreaHand.Cards.cards = PlArea._hand;
            cardAreaHand.DrawAllCards();
        }
        # endregion
        # endregion

        # region opponent side
        private void updateOppSide()
        {
            listViewOppLand.Items.Clear();
            listViewOppLand.OwnerDraw = true;

            //foreach (MagicCard mc in OppArea._lands.cards)
            foreach (MagicCard mc in OppArea._lands)
            {
                ListViewItem lvi = mc.ToListViewItem(false);
                listViewOppLand.Items.Add(lvi);
            }

            listViewOppLand.OwnerDraw = false;

            listViewOppCrea.OwnerDraw = true;
            listViewOppCrea.Items.Clear();
            //foreach (MagicCard mc in OppArea._play.cards)
            foreach (MagicCard mc in OppArea._play)
            {
                listViewOppCrea.Items.Add(mc.ToListViewItem(true));
            }
            listViewOppCrea.OwnerDraw = false;

            updateManaLabel();
        }

        private void updateManaLabel()
        {
            label2.Text = PlArea.mana.Colourless.ToString() + "_ / ";
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
            cPanelControls.Hide();
            //cardAreaHand.RemoveCard(mc);

            mc.OnPlay -= temp_OnPlay;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            ListView lv = listViewPlay;
            //PlArea._play.index();

            if (lv.SelectedIndices.Count > 0)
            {
                int i = lv.SelectedIndices[0];

                PlArea._play.RemoveAt(i);

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
            //PlArea._hand.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                # region clicked item
                int ind = temp.SelectedIndices[0];

                if (ind > -1)
                {
                    MagicCard mc = PlArea._hand[ind];

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
            //PlArea._lands.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                # region clicked item
                int ind = temp.SelectedIndices[0];

                if (ind > -1)
                {
                    MagicCard mc = PlArea._lands[ind];
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
            //PlArea._play.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                # region clicked item
                int ind = temp.SelectedIndices[0];

                if (ind > -1)
                {
                    MagicCard mc = PlArea._play[ind];
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

                onCardChosen(PlArea._play[ind]);
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
            //PlArea._deck.index();
            ListView temp = sender as ListView;

            if (temp.SelectedIndices.Count > 0)
            {
                int.TryParse(temp.SelectedItems[0].Tag.ToString(), out int DeckID);

                if (DeckID > -1)
                {
                    MagicCard mc = PlArea._artEnch.Find(o => o.DeckID == DeckID);

                    if (mc != null) ViewCard(mc);
                }
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
            if (lvTemp != null && lvTemp.SelectedItems.Count > 0)
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

            PlArea.InitialiseDeck();
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
        private void AddCardHandlers(ref MagicCard mc)
        {
            //mc.OnLocationChanged += new MagicCard.LocationChange(Mc_LocationChange);
        }

        void Activating_OozeFlux(MagicCard mc, int ID)
        {
            int c = 0;  //number of counters on creatures
            //foreach (MagicCard mcs in PlArea._play.cards)
            foreach (MagicCard mcs in PlArea._play)
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

        void mc_ActivateCard(MagicCard mc, int ID)
        {
            switch (mc.Name)
            {
                case "Voyaging Satyr":
                    cardAreaLand.CardClicked += new CardArea.CardChosen(VoyagingSatyrLand);
                    break;

                case "Vorel of the Hull Clade":
                    cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_VorelHullClade);
                    break;

                case "Elite Arcanist":

                    break;

                default:
                    mc.ActivateAbility(ID);
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

        //void CardEvent_Populate(MagicCard mc, MouseEventArgs e)
        //{
        //    if (!mc.Token)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        //MagicCard mct = mc.Name == "Gyre Sage" ? new GyreSage(mc) : new MagicCard(mc);
        //        MagicCard mct = CardMethods.CreateCard(mc);
        //        PlArea.PlayCard(mct);
        //    }
        //}

        void CardChosen_TritonTactics(MagicCard mc, EventArgs e)
        {
            //if (PlArea._play.cards.Contains(mc))
            if (PlArea._hand.Contains(mc))
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

        void CardChosen_CalltoHeel(MagicCard mc, EventArgs e)
        {
            //PlArea._deck.Remove(mc.DeckID);
            mc.LocationChanged(CardLocation.Hand); //Probably the new way of changing location.
            update_listViewPlay();

            PlArea._hand.Add(mc.Copy());
            update_listViewHand();

            DrawCard(1);

            targets--;
            if (targets < 1)
            {
                cardAreaPlay.CardClicked -= CardChosen_CalltoHeel;
            }
        }

        void CardChosen_PredatorsRapport(MagicCard mc, EventArgs e)
        {
            PlArea.HP += mc.PowerCalc + mc.ToughnessCalc;

            cardAreaPlay.CardClicked -= CardChosen_PredatorsRapport;
        }

        void CardClicked_StrengthOfTheTajuru(MagicCard mc, MouseEventArgs e)
        {
            //using targets as temporary xvalue
            mc.counters += EffectStrength;

            targets--;
            if (targets < 1)
                cardAreaPlay.CardClicked -= CardClicked_StrengthOfTheTajuru;
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
        void DeckTest_PlPhaseChanged() { ReportAllCards(); }
        void DeckTest_OppPhaseChanged() { }

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
        #endregion

        #region CardAreas
        public void UpdateArea(CardArea area, CardLocation location)
        {
            switch (location)
            {
                case CardLocation.Library: area.Cards.cards = PlArea._library; break;
                case CardLocation.Graveyard: area.Cards.cards = PlArea._graveyard; break;
                case CardLocation.Hand: area.Cards.cards = PlArea._hand; break;
                //case CardLocation.Exiled: area.Cards.cards = PlArea.; break;
                case CardLocation.Play: area.Cards.cards = PlArea._play; break;
                case CardLocation.Lands: area.Cards.cards = PlArea._lands; break;
                case CardLocation.Enchantments: area.Cards.cards = PlArea._artEnch; break;
                case CardLocation.Artifacts: area.Cards.cards = PlArea._artEnch; break;
            }
        }
        #endregion

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
                        //int ind = listViewOppCrea.SelectedIndices[0];
                        int.TryParse(listViewOppCrea.SelectedItems[0].Tag.ToString(), out int ind);
                        if (ind > -1)
                        {
                            var mc = OppArea.SortedDeck.cards.Find(o => o.DeckID == ind);
                            mc.CallDestroyed();

                            updateOppSide();
                        }
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
            else
            {
                if (comboCardPicker.SelectedItem != null)
                {
                    var v = ParentForm1.Database.cards.Where(o => o.Name == comboCardPicker.SelectedItem.ToString());
                    if (v.Count() > 0 && v.First() != null)
                    {
                        MagicCard mc = v.First();
                        useCard(mc);
                    }
                }
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
        #endregion


        #region Pop-up card viewer
        private void button1_Click(object sender, EventArgs e)
        {
            viewCard = null;
            cPanelControls.Hide();

            CardChosen -= DeckTest_CardChosen_PlayCard;
        }


        #endregion
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
            cardViewer1.LoadCard(mc);

            panel1.Controls.Add(cardViewer1);
            cPanelControls.Show();
            panel1.Show();
            panel1.BringToFront();

            int count = mc.attachedCards.Count;
            panel1.Width = 200 * (1 + count);
            for (int i = 0; i < count; i++)
            {
                CardViewer cv = new CardViewer();
                panel1.Controls.Add(cv);
                cv.Show();
                cv.Left = (panel1.Controls.Count - 1) * 200;
                cv.LoadCard(mc.attachedCards[i]);
            }
        }

        private void ReportAllCards()
        {
            return;

            CardReportView.BeginUpdate();
            CardReportView.Items.Clear();
            foreach (var v in PlArea.SortedDeck.cards.OrderBy(o => o.Location).ThenBy(o => o.Name))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = v.Name;
                lvi.SubItems.Add(v.Location.ToString());
                CardReportView.Items.Add(lvi);
            }
            CardReportView.EndUpdate();
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

        private void addCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboCardPicker.BeginUpdate();
            foreach (var v in ParentForm1.Database.cards)
            {
                //ListViewItem item = new ListViewItem(Name = v.Name);
                //item.SubItems.Add(v.Edition);
                comboCardPicker.Items.Add(v.Name);
            }
            comboCardPicker.EndUpdate();
            comboCardPicker.Show();

            CardChosen += DeckTest_CardChosen_PlayCard;

            buttonCardChoose.Show();

            cPanelControls.Show();
        }

        #region Play cards from location
        private void PlArea_PlayCardFromStack(MagicCard mc)
        {
            //PlArea._stack.Remove(mc.DeckID);
            useCard(mc);

            targets--;

            if (targets < 1)
                CardChosen -= PlArea_PlayCardFromStack;
        }

        private void PlArea_PlayCardFromGraveyard(MagicCard mc)
        {
            useCard(mc);
        }
        #endregion

        private void DeckTest_CardChosen_PlayCard(MagicCard mc)
        {
            temp_OnPlay(mc);
            CardChosen -= DeckTest_CardChosen_PlayCard;
            //throw new NotImplementedException();
        }

        private void refreshCardLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAllCards();
        }
    }

    public class PlayArea
    {
        # region declarations
        # region card areas
        public CardCollection _deck;
        public CardCollection SortedDeck;
        public List<MagicCard> _library => SortedDeck.cards.Where(o => o.Location == CardLocation.Library).ToList();
        public List<MagicCard> _graveyard => SortedDeck.cards.Where(o => o.Location == CardLocation.Graveyard).ToList();
        public List<MagicCard> _hand => SortedDeck.cards.Where(o => o.Location == CardLocation.Hand).ToList();
        public List<MagicCard> _artEnch => SortedDeck.cards.Where(o => o.Location == CardLocation.Enchantments
                                                               || o.Location == CardLocation.Artifacts).ToList();
        public List<MagicCard> _play => SortedDeck.cards.Where(o => o.Location == CardLocation.Play).ToList();
        public List<MagicCard> _lands => SortedDeck.cards.Where(o => o.Location == CardLocation.Lands).ToList();
        # endregion

        # region hp
        public event Action HPChanged;
        public event SearchLocation SearchDeck;
        public event SearchLocation SearchGraveyard;

        private void onHPChanged()
        {
            Action handler = HPChanged;
            if (handler != null)
            {
                handler();
            }
        }

        private void onSearchDeck(string Type, int depth, int count)
        {
            SearchLocation handler = SearchDeck;
            if (handler != null)
            {
                handler("Library", Type, depth, count);
            }
        }

        private void onSearchGraveyard(String Type, int depth, int count)
        {
            SearchLocation handler = SearchGraveyard;
            if (handler != null)
            {
                handler("Graveyard", Type, depth, count);
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
        public ColourCost mana = new ColourCost();
        private List<MagicCard> CardsProc = new List<MagicCard>();

        public event Phase SpellRes;
        public event CardUse CardUsed;
        public event CardUse CardDrawn;

        protected void onSpellRes()
        {
            Phase handler = SpellRes;

            foreach (MagicCard mc in CardsProc)
            {
                mc.CallAbility(-1);
            }

            if (handler != null)
            {
                handler();
            }
        }
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

        # endregion

        public void Setup()
        {
            mw.Closing += new ManaWheel.Chosen(mw_Closing);

        }

        public void InitialiseDeck()
        {

            SortedDeck = new CardCollection();

            // Assign DeckID, set quantity to 0
            for (int j = 0; j < _deck.cards.Count; j++)
            {
                MagicCard mc = _deck.cards[j];

                for (int i = 0; i < mc.quantity; i++)
                {
                    //MagicCard newCard = mc.Clone() as MagicCard;
                    MagicCard NewCard = CardMethods.CreateCard(mc);

                    // Set ID for searching later.
                    NewCard.DeckID = CardMethods.CardID;

                    NewCard.quantity = 1;
                    SortedDeck.cards.Add(NewCard);
                    NewCard.Location = CardLocation.Library;
                }
            }

            Output.Write("\r\nshuffling cards\r\n");
            //_stack.cards.OrderBy(o => o.Type);
            _library.OrderBy(o => o.Type);
            SortedDeck = Shuffle(SortedDeck, false);
            SortedDeck = Shuffle(SortedDeck, false);
            SortedDeck = Shuffle(SortedDeck, true);
        }

        public void AddCardTriggers(MagicCard mc)
        {
            mc.ChangeMana += Mc_ChangeMana;
            mc.Activating += new MagicCard.Ability(mc_Activating);
            mc.Discard += new CardUse(Play_Discard);
            mc.Destroyed += new CardUse(Play_Destroyed);
            mc.SearchCard += new SearchLocation(Mc_SearchCard);
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

                mc.LocationChanged(CardLocation.Lands);

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

                mc.LocationChanged(CardLocation.Graveyard);
            }
            # endregion
            # region artifacts and enchantments
            else if (mc.Type.Contains("Artifact") || mc.Type.Contains("Enchantment"))
            {
                if (mc.Type.Contains("Artifact")) mc.LocationChanged(CardLocation.Artifacts);
                else mc.LocationChanged(CardLocation.Enchantments);
            }
            # endregion
            # region creatures
            else
            {
                foreach (MagicCard mstc in _play)
                {
                    if (mstc.Name == "Master Biomancer")
                    {
                        mc.counters += mstc.PowerCalc;
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

                    //case "Gyre Sage":
                    //    mc.Activate += new MagicCard.Ability(Activate_GyreSage);
                    //    break;

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
                        mc.counters += mc._XValue;
                        break;

                    case "Vastwood Hydra":
                        mc.counters += mc._XValue;
                        break;

                    case "Primordial Hydra":
                        mc.counters += mc._XValue;
                        break;

                    case "Elite Arcanist":
                        mc.Activating += new MagicCard.Ability(Activating_EliteArcanist);
                        break;
                }
                # endregion

                CallCreatureEntered(mc);

                mc.checkPT();
                foreach (MagicCard mcs in _play)
                {
                    mcs.Evolve(mc.PowerCalc, mc.ToughnessCalc);
                }

                onSpellRes();

                //TODO need to expand this to actually check.
                if (!mc.Text.Contains("Haste"))
                {
                    mc.Sick = true;
                }

                mc.LocationChanged(CardLocation.Play);
            }
            #endregion

            //AddCardTriggers(mc);
            //mc.ChangeMana += Mc_ChangeMana;
            //mc.Activating += new MagicCard.Ability(mc_Activating);
            //mc.Discard += new CardUse(Play_Discard);
            //mc.Destroyed += new CardUse(Play_Destroyed);
            //mc.SearchCard += Mc_SearchCard;


        }

        private void Mc_SearchCard(string location, string type, int depth, int count)
        {
            switch (location)
            {
                case "Library":
                    onSearchDeck(type, depth, count); break;
                case "Graveyard":
                    onSearchGraveyard(type, depth, count); break;

                default:
                    Debug.WriteLine($"Searching card area {location} not programmed");
                    break;
            }
        }


        private void Mc_ChangeMana(ColourCost cc)
        {
            mana.Add(cc);
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
                    //_hand.Add(mc);
                    mc.LocationChanged(CardLocation.Hand);

                    toHand = true;
                }
            }

            if (!toHand)
            {
                //_graveyard.cards.Add(mc);
                mc.LocationChanged(CardLocation.Graveyard);
            }

        }

        void Play_Discard(MagicCard mc)
        {
            bool toHand = false;
            foreach (MagicCard mca in mc.attachedCards)
            {
                if (mc.Name == "Rancor")
                {
                    //_hand.Add(mc);
                    mc.LocationChanged(CardLocation.Hand);

                    toHand = true;
                }
            }

            if (!toHand)
            {
                //_graveyard.Add(mc);
                mc.LocationChanged(CardLocation.Graveyard);
            }
        }

        void Hand_Discard(MagicCard mc)
        {
            //_graveyard.Add(mc);
            mc.LocationChanged(CardLocation.Graveyard);
        }

        void mc_Activating(MagicCard mc, int ability)
        {
            if (mc.Abilities.Count == 0)
            {
                return;
            }

            ColourCost c = mc.Abilities[ability].Cost;
            bool tap = mc.Abilities[ability].RawCost.Contains("%T");


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

            mc.CallActivate(ability);
        }

        private bool CheckLandType(string type, int count)
        {
            bool result = false;
            int c = 0;
            //foreach (MagicCard mcs in _lands.cards)
            foreach (MagicCard mcs in _lands)
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

        private void CallCreatureEntered(MagicCard Creature)
        {
            foreach (MagicCard mc in _play) if (mc.DeckID != Creature.DeckID) mc.CreatureEntered(Creature);
            foreach (MagicCard mc in _artEnch) if (mc.DeckID != Creature.DeckID) mc.CreatureEntered(Creature);
            foreach (MagicCard mc in _lands) if (mc.DeckID != Creature.DeckID) mc.CreatureEntered(Creature);
        }

        # region individual card events
        void RenegadeKrasis_Evolve(MagicCard mc, int ID)
        {
            CardsProc.Add(mc);
            mc.Activate += new MagicCard.Ability(DeckTest_SpellRes);
        }

        void DeckTest_SpellRes(MagicCard mc, int ID)
        {
            //foreach (MagicCard msc in _play.cards)
            foreach (MagicCard msc in _play)
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

        void Activate_VoyagingSatyr(MagicCard mc, int ID)
        {
            //hook for decktest
            mc.Tap(true, true);
        }


        void Activating_EliteArcanist(MagicCard mc, int ID)
        {
            if (mc.attachedCards.Count > 0)
            {
                if (mana.Colourless >= mc.attachedCards[0].manaCost.Colourless)
                {
                    mc.attachedCards[0].TryActivate(0);
                    mc.Tap(true, false);
                }
                else
                {
                    string s = "Elite Arcanist: Not enough mana to activate ability (" + mana.Colourless + "/" + mc.attachedCards[0].manaCost.Colourless + ")";
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
            //_stack.Clear();
            //_graveyard.Clear();
            //_hand.Clear();
            //_artEnch.Clear();
            //_play.Clear();
            //_lands.Clear();

            mana.Clear();

            HP = 20;
        }

        public List<MagicCard> drawCards(int i)
        {
            List<MagicCard> result = new List<MagicCard>();

            for (int j = 0; j < i; j++)
            {
                //if (_stack.cards.Count < 1) break;
                if (_library.Count < 1) break;

                MagicCard mc = _library[0];
                //_hand.Add(mc);
                mc.Location = CardLocation.Hand;

                //_stack.cards.RemoveAt(0);

                result.Add(mc);
                if (mc.Name == "Ponder")
                    Debug.WriteLine("Ponder found");
                AddCardTriggers(mc);
                onCardDrawn(mc);
            }

            return result;
        }

        public int countAttackers()
        {
            int result = 0;

            //foreach (MagicCard mc in _play.cards)
            foreach (MagicCard mc in _play)
            {
                if (!mc.Tapped && !mc.Sick && mc.PowerCalc > 0) //And not defender
                {
                    result++;
                }
            }

            return result;
        }

        public void ProcAttack()
        {
            //foreach (MagicCard mc in _play.cards)
            foreach (MagicCard mc in _play)
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
            //foreach (MagicCard mc in _play.cards)
            foreach (MagicCard mc in _play)
            {
                mc.UpkeepCard();
            }
            //foreach (MagicCard mc in _artEnch.cards)
            foreach (MagicCard mc in _artEnch)
            {
                mc.UpkeepCard();
            }
            //foreach (MagicCard mc in _lands.cards)
            foreach (MagicCard mc in _lands)
            {
                mc.UpkeepCard();
            }
            //foreach (MagicCard mc in _hand.cards)
            foreach (MagicCard mc in _hand)
            {
                mc.UpkeepCard();
            }
        }

        public void EndStep()
        {
            //foreach (MagicCard mc in _play.cards)
            foreach (MagicCard mc in _play)
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
    public delegate void SearchLocation(string location, string type, int depth, int count);
    public delegate void CardDraw();
}
