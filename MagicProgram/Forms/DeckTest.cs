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
using MagicProgram.Controls;

namespace MagicProgram
{
    public partial class DeckTest : Form
    {
        # region variables
        # region card lists
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
        public event Action onCancel;

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

        public event PassiveEvent CreaCast;
        public event PassiveEvent CardChosen;

        private void callOnCancel()
        {
            Action handler = onCancel;
            if (handler != null)
            {
                handler();
            }
        }

        private void onSpellRes()
        {
            Phase handler = SpellRes;

            foreach (MagicCard mc in CardsProc)
            {
                //TODO rewrite to only activate specified abilities
                //Ability needs an "activated" or index
                mc.callAbility(0);
            }

            if (handler != null)
            {
                handler();
            }
        }

        private void onCreaCast(MagicCard mc)
        {
            PassiveEvent handler = CreaCast;
            if (handler != null)
            {
                handler(mc);
            }
        }

        private void onCardChosen(MagicCard mc)
        {
            PassiveEvent handler = CardChosen;
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
            //PlArea.HPChanged += new Action(PlaHP_ValueChanged);
            //OppArea.HPChanged += new Action(FoeHP_ValueChanged);

            //PlArea.CardUsed += new PassiveEvent(PlArea_CardUsed);
            //OppArea.CardUsed += new PassiveEvent(OppArea_CardUsed);

            PlArea.mana.ManaChanged += new ColourCost.Action(updateManaLabel);
            OppArea.mana.ManaChanged += new ColourCost.Action(updateManaLabel);

            //PlArea.CardDrawn += new PassiveEvent(PlArea_CardDrawn);
            //OppArea.CardDrawn += new PassiveEvent(OppArea_CardDrawn);

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
            # region set side to work with
            PlayArea area = PlArea;
            if (!playerTurn)
            {
                area = OppArea;
                mc.PArea = OppArea;
                mc.OppArea = PlArea;
            }
            else
            {
                mc.PArea = PlArea;
                mc.OppArea = OppArea;
            }
            # endregion

            //work out if there is enough mana
            CheckMana(mc);

            # region land
            if (mc.Type.Contains("Land"))
            {
                area.PlayCard(mc);
                cardAreaLand.AddCard(mc);
                area.landPlayed++;
                //update_listViewLand();

                switch (mc.Name)
                {
                    case "Terramorphic Expanse":
                        mc.Activating += new MagicCard.ValueAbility(Activating_SacSearchBasic);
                        break;

                    case "Evolving Wilds":
                        mc.Activating += new MagicCard.ValueAbility(Activating_SacSearchBasic);
                        break;
                }
            }
            # endregion
            # region spells
            else if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            {
                switch (mc.Name)
                {
                    # region Nature's Lore
                    case "Nature's Lore":
                        List<MagicCard> cards = PlArea._stack.cards.Where(o => o.Type.ToUpper().Contains("FOREST")).ToList();
                        comboCardPicker_Fill(cards);
                        CardChosen += new PassiveEvent(CardChosen_NaturesLore);
                        break;
                    # endregion

                    # region Triton Tactics
                    case "Triton Tactics":
                        targets = 2;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardChosen_TritonTactics);
                        break;
                    # endregion

                    # region Gaea's Blessing
                    case "Gaea's Blessing":
                        targets = 3;
                        comboCardPicker_Fill(PlArea._graveyard.cards);
                        CardChosen += new PassiveEvent(CardChosen_GaeasBlessing);
                        onCancel += new Action(CardCancel_GaeasBlessing);
                        break;
                    # endregion

                    # region Predator's Rapport
                    case "Predator's Rapport":
                        targets = 1;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardChosen_PredatorsRapport);
                        break;
                    # endregion

                    # region Call to Heel
                    case "Call to Heel":
                        targets = 1;
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardChosen_CalltoHeel);
                        break;
                    # endregion

                    # region Strength of the Tajuru
                    case "Strength of the Tajuru":
                        //targets = mc.Xvalue;
                        mc.Resolving += new PassiveEvent(mc_ResolvingStrengthTajuru);
                        //cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_StrengthOfTheTajuru);
                        break;
                    # endregion

                    # region Rouse the Mob
                    case "Rouse the Mob":
                        mc.Resolving += new PassiveEvent(mc_ResolvingRouseTheMob);
                        break;
                    # endregion

                    # region Nature's Panoply
                    case "Nature's Panoply":
                        mc.Resolving += new PassiveEvent(mc_ResolvingNaturesPanoply);
                        break;
                    # endregion

                    # region Ajani's Presence
                    case "Ajani's Presence":
                        mc.Resolving += new PassiveEvent(mc_ResolvingAjanisPresence);
                        break;
                    # endregion

                    # region Wake the Reflections
                    case "Wake the Reflections":
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_WakeReflections);
                        break;
                    # endregion

                    #region Fated Infatuation
                    case "Fated Infatuation":
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CreateCopyScry);
                        break;
                    # endregion

                    # region Cerulean Wisps
                    case "Cerulean Wisps":
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(BlueUntapDraw);
                        break;
                    # endregion

                    # region Magma Jet
                    case "Magma Jet":
                        mc.Resolving += new PassiveEvent(mc_Scry2);
                        break;
                    # endregion

                    # region Chord of Calling
                    case "Chord of Calling":
                        List<MagicCard> cardList = area._stack.cards.Where(o => o.Type.Contains("Creature") && o.CMC <= mc.Xvalue).ToList();
                        comboCardPicker_Fill(cardList);
                        CardChosen += new PassiveEvent(CardChosen_ChordofCalling);
                        break;
                    # endregion

                    # region Fungal Sprouting
                    case "Fungal Sprouting":
                        int x = 0;
                        foreach (MagicCard mcp in area._play.cards)
                        {
                            if (mcp.Power > x)
                            {
                                x = mcp.Power;
                            }
                        }

                        for (int i = 0; i < x; i++)
                        {
                            CreateSaproling(mc);
                        }
                        break;
                    # endregion

                    # region Titan's Strength
                    case "Titan's Strength":
                        mc.Resolving += new PassiveEvent(Resolving_TitansStrength);
                        break;
                    # endregion

                    # region Launch the Fleet
                    case "Launch the Fleet":
                        tempCard = mc;
						cardAreaPlay.CardsPicked += new CardArea.CardsChosen(CardsChosen_LaunchTheFleet);
						cardAreaPlay.ChooseCards();
						targets = mc.Targets;
                        break;
                    # endregion

                    # region Battle Hymn
                    case "Battle Hymn":
                        mc.PArea.mana.red += mc.PArea._play.cards.Count(o => o.Type.ToLower().Contains("creature"));
                        break;
                    # endregion

                    # region Triplicate Spirits
                    case "Triplicate Spirits":
                        mc.Resolving += new PassiveEvent(Resolving_TriplicateSpirits);
                        break;
                    # endregion

                    # region TwinFlame
                    case "Twinflame":
                        cardAreaPlay.CardsPicked += new CardArea.CardsChosen(CardsChosen_Twinflame);
                        cardAreaPlay.ChooseCards();
                        targets = mc.Targets;
                        break;
                    # endregion

                    default:
                        if (MessageBox.Show("Does this spell target one of your creatures?", "Targets?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_Null);
                        }
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
                            cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_AuraCard);
                            tempCard = mc;
                        }
                        if (dr == DialogResult.No)
                        {
                            area._graveyard.cards.Add(mc);
                            mc.Location = "Graveyard";
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
            # region creatures
            else if (mc.Type.ToUpper().Contains("CREATURE"))
            {
                if (mc.Abilities.Count > 0 && mc.Abilities[0].Name == "Bestow" && mc.Abilities[0].Active)
                {
                    if (playerTurn)
                    {
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_AuraCard);
                    }
                    tempCard = mc;
                    update_listViewArtEnch();
                }
                else
                {
                    PlayCreature(mc, area);
                }
            }
            # endregion
            # region artifacts and enchantments
            else if (mc.Type.Contains("Artifact") || mc.Type.Contains("Enchantment"))
            {
                onSpellRes();
                CardsProc = new List<MagicCard>();

                # region Enchant Land
                if (mc.Text.Contains("Enchant land"))
                {
                    if (playerTurn)
                    {
                        cardAreaLand.CardClicked += new CardArea.CardChosen(cardArea1_CardClicked1);
                        //listViewLand.MouseUp += new MouseEventHandler(listViewLand_MouseClick);
                    }
                }
                # endregion
                # region Enchant Creature
                else if (mc.Text.ToLower().Contains("enchant creature"))
                {
                    if (playerTurn)
                    {
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_AuraCard);
                    }
                }
                # endregion
                # region Enchant Artifact
                else if (mc.Text.ToLower().Contains("enchant artifact"))
                {
                    if (playerTurn)
                    {
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_AuraCard);
                    }
                }
                # endregion
                # region Equipment
                else if (mc.Type.Contains("Equipment"))
                {
                    switch (mc.Name)
                    {
                        case "Explorer's Scope":
                            mc.OnEquip += new PassiveEvent(OnEquip_ExplorersScope);
                            mc.OnUnequip += new PassiveEvent(OnUnequip_ExplorersScope);
                            mc.Activating += new MagicCard.ValueAbility(Activating_Equipment);
                            break;

                        case "Godsend":

                            break;

                        default:
                            mc.Activating += new MagicCard.ValueAbility(Activating_Equipment);
                            mc.OnEquip += new PassiveEvent(mc_OnEquip);
                            break;
                    }
                    area.PlayCard(mc);
                    update_listViewPlay();
                }
                # endregion
                # region non-Equipment
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
                        mc.Activating += new MagicCard.ValueAbility(Activating_OozeFlux);
                        break;

                    case "Spirit Bonds":
                        mc.PArea.CreatureEntered += new PassiveEvent(CreatureEntered_Spiritbonds);
                        break;

                    case "Growing Ranks":
                        mc.OnUpkeep += new PassiveEvent(PassiveEvent_Populate);
                        break;
                }

                tempCard = mc;
                update_listViewArtEnch();
            }
                # endregion
            # endregion
            # region New card type
            else
            {
                throw new NotImplementedException();
            }
            # endregion

            mc.Resolve();
            mc.callOnPlay();

            string s = mc.GetType().ToString();

            return true;
        }

        void CardClicked_Null(MagicCard mc, MouseEventArgs e)
        {
            mc.callSpellCast();
            cardAreaPlay.CardClicked -= CardClicked_Null;
        }

        # region Ajani's Presence
        void mc_ResolvingAjanisPresence(MagicCard mc)
        {
            mc.Resolving -= mc_ResolvingAjanisPresence;
            cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_AjanisPresence);
        }

        void CardClicked_AjanisPresence(MagicCard mc, MouseEventArgs e)
        {
            targets--;

            # region card effect
            mc.PBonus++;
            mc.TBonus++;
            mc.Abilities.Add(new CardAbility
            {
                Name = "Indestructable",
            });
            mc.callSpellCast();
            # endregion

            if (targets < 1)
            {
                cardAreaPlay.CardClicked -= CardClicked_AjanisPresence;
            }
        }
        # endregion

        # region Nature's Panoply
        void mc_ResolvingNaturesPanoply(MagicCard mc)
        {
            mc.Resolving -= mc_ResolvingNaturesPanoply;
            cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_NaturesPanoply);
        }

        void CardClicked_NaturesPanoply(MagicCard mc, MouseEventArgs e)
        {
            mc.counters++;
            targets--;

            if (targets < 1)
            {
                cardAreaPlay.CardClicked -= CardClicked_NaturesPanoply;
            }
        }
        # endregion

        # region Reouse the Mob
        void mc_ResolvingRouseTheMob(MagicCard mc)
        {
            cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_RouseTheMob);
            mc.Resolving -= mc_ResolvingRouseTheMob;
        }

        void CardClicked_RouseTheMob(MagicCard mc, MouseEventArgs e)
        {
            mc.PBonus += 2;
            mc.callSpellCast();
            cardAreaPlay.CardClicked -= CardClicked_RouseTheMob;
        }
        # endregion

        # region Gaea's Blessing
        void CardCancel_GaeasBlessing()
        {
            DrawCard(1);
            onCancel -= CardCancel_GaeasBlessing;
            CardChosen -= CardChosen_GaeasBlessing;
        }

        void CardChosen_GaeasBlessing(MagicCard mc)
        {
            if (PlArea._graveyard.cards.Contains(mc))
            {
                PlArea._graveyard.Remove(mc);
                PlArea._stack.cards.Add(mc);
                mc.Location = "Library";
                PlArea._stack = PlArea.Shuffle(PlArea._stack);
            }

            targets--;

            if (targets < 1 || PlArea._graveyard.cards.Count < 1)
            {
                onCancel -= CardCancel_GaeasBlessing;
                CardChosen -= CardChosen_GaeasBlessing;
            }
            else
            {
                List<MagicCard> cards = PlArea._graveyard.cards;
                comboCardPicker_Fill(cards);
            }
        }
        # endregion

        void Resolving_TriplicateSpirits(MagicCard mc)
        {
            for (int i = 0; i < 3; i++)
            {
                MagicCard mct = new MagicCard
                {
                    Token = true,
                    Name = "Spirit",
                    Type = "Creature - Spirit",
                    Color = "White",
                    PT = "1/1",
                    Text = "Flying",
                    PArea = mc.PArea,
                    OppArea = mc.OppArea
                };
                mc.PArea.PlayToken(mct);
            }
            update_listViewPlay();
        }

        void Resolving_TitansStrength(MagicCard mc)
        {
            cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_TitansStrength);
            mc.Resolving -= Resolving_TitansStrength;
        }

        void CardClicked_TitansStrength(MagicCard mc, MouseEventArgs e)
        {
            mc.PBonus += 3;
            mc.TBonus += 1;
            mc.callSpellCast();
            Scry(1);
            cardAreaPlay.CardClicked -= CardClicked_TitansStrength;
        }

        void AuraAdded_BroodKeeper(MagicCard mc)
        {
            MagicCard mct = new MagicCard
            {
                Name = "Dragon",
                Type = "Creature - Dragon",
                Color = "R",
                Text = "Flying\r\n{R}: This creature gets +1/+0 until end of turn",
                PT = "2/2",
                Token = true,
                PArea = mc.PArea,
                OppArea = mc.OppArea
            };
            PlayCard(mct);
        }

        private void CheckMana(MagicCard mc)
        {
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
                Debug.WriteLine("!mana");
                bool fal = false;
                if (fal)
                {
                    timerStack.Stop();
                }
            }
            else
            {
                PlArea.mana.Subtract(mc.manaCost);
            }
        }

        void Discard_DoomedTraveler(MagicCard mc)
        {
            MagicCard mct = new MagicCard
            {
                Name = "Spirit",
                Token = true,
                PT = "1/1",
                Power = 1,
                Toughness = 1,
                Text = "Flying",
                PArea = mc.PArea,
                OppArea = mc.OppArea
            };

            mct.Abilities.Add(new CardAbility
            {
                Name = "Flying",
            });

            PlayCreature(mct, PlArea);
        }

        void mc_ActivatingScry1(MagicCard mc, int index)
        {
            mc.Tap(true, false);
            Scry(1);
        }

        void mc_Scry1(MagicCard mc)
        {
            Scry(1);
        }

        void mc_Scry2(MagicCard mc)
        {
            Scry(2);
        }

        void CardToHand(MagicCard mc)
        {
            switch (mc.Location)
            {
                case "Play":
                    break;

                case "Hand":
                    break;

                case "Graveyard":
                    break;

                case "Library":
                    break;

                default:
                    break;
            }
        }

        void mc_OnEquip(MagicCard mc)
        {
            if (PlArea._play.cards.Contains(mc))
            {
                PlArea._play.cards.Remove(mc);
            }
        }

        void cardAreaPlay_CardEquip(MagicCard mc, MouseEventArgs e)
        {
            tempCard.Parent = mc;
            tempCard.callOnEquip();
            mc.AddEquipment(tempCard);
            tempCard = null;
            update_listViewPlay();
            cardAreaPlay.CardClicked -= cardAreaPlay_CardEquip;
        }

        //void mc_CountersChangedFathomMage(int count)
        //{
        //    if (count > 0)
        //    {
        //        xPicker.ShowMax(count);
        //        xPicker.BringToFront();
        //        ViewCard(new MagicCard());

        //        xPicker.ValuePicked += new XManaPicker.IntReturn(xPicker_ValuePickedDrawCards);
        //    }
        //}

        void xPicker_ValuePickedDrawCards(int value, int count)
        {
            DrawCard(count);
            xPicker.ValuePicked -= xPicker_ValuePickedDrawCards;
        }

        void mc_ResolvingStrengthTajuru(MagicCard mc)
        {
            Debug.WriteLine("mc_ResolvingStrengthTajuru");
            tempCard = mc;
            cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClicked_StrengthOfTheTajuru);
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
                Toughness = value,
                PArea = PlArea,
                OppArea = OppArea
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
            //MagicCard mcn = CardMethods.GetClass(mc);
            MagicCard mcn = mc;

            mcn.setMana();
            ColourCost cc = mcn.manaCost;

            if (mcn.PArea == null)
            {
                mcn.PArea = PlArea;
            }

            # region check if land allowance used
            if (mcn.Type.Contains("Land"))
            {
                if (mcn.PArea.landPlayed >= mcn.PArea.landMax)
                {
                    MessageBox.Show("Played lands this turn (" + mcn.PArea.landPlayed.ToString() + "/" + mcn.PArea.landMax.ToString() + ")");
                    return;
                }
            }
            # endregion

            # region cycle through cost reduction
            foreach (MagicCard mcna in PlArea._play.cards)
            {
                if (mcna.Name == "Battlefield Thaumaturge" && (mcn.Type.Contains("Instant") && mcn.Type.Contains("Sorcery")))
                {
                    cc.grey -= mcn.Targets;
                }
            }
            # endregion

            # region check bestow
            foreach (CardAbility cAbi in mcn.Abilities)
            {
                if (cAbi.Name == "Bestow")
                {
                    if (MessageBox.Show("Do you want to bestow this card?", "Bestow?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        mcn.Type = "Enchantment - Aura";
                        mcn.Text += "\r\nEnchant Creature";
                        cAbi.Active = true;
                        cc = cAbi.Cost;
                    }
                }
            }
            # endregion

            //mana check
            if (!PlArea.mana.Compare(cc))
            {
                return;
            }

            mcn.callPrePlay();
            string cost = mcn.Cost.ToUpper();

            # region x in cost
            if (cost.Contains("X"))
            {
                int x = 0;
                int count = cost.Count(c => c == 'X');
                ColourCost Cost = new ColourCost();
                mcn.Xvalue = 0;

                for (int c = 0; c < cost.Length; c++)
                {
                    char j = mcn.Cost[c];
                    if (j == 'X')
                    {
                        j = x.ToString()[0];
                    }
                }

                mcn.Initialise();
                tempCard = viewCard = mcn;
                xPicker.ValuePicked += new XManaPicker.IntReturn(picker_ValuePicked);
                PickerShow(count, cc);
                ViewCard(mcn);
            }
            # endregion
            # region Strive
            else if (mcn.Text.Contains("Strive"))
            {
                int count = 1;
                ColourCost Cost = mcn.AdditionalCost;
                mcn.Xvalue = 0;  //Make sure it is reset

                mcn.Initialise();
                tempCard = viewCard = mcn;
                xPicker.ValuePicked += new XManaPicker.IntReturn(picker_ValuePicked);
                PickerShow(1, count, cc);
                ViewCard(mcn);
            }
            # endregion
            # region no x in cost
            else
            {
                CheckEntersBattlefield(mcn);
                return;
            }
            # endregion
        }

        private void CheckEntersBattlefield(MagicCard mc)
        {
            # region Devour
            if (mc.Text.Contains("Devour 1"))
            {
                tempCard = mc;
                cardAreaPlay.ChooseCards();
                cardAreaPlay.CardsPicked += new CardArea.CardsChosen(CardsPicked_Devour1);
            }
            else if (mc.Text.Contains("Devour 2"))
            {
                tempCard = mc;
                cardAreaPlay.ChooseCards();
                cardAreaPlay.CardsPicked += new CardArea.CardsChosen(CardsPicked_Devour2);
            }
            else
            {
                PlayCard(mc);
            }
            # endregion
        }

        private void PlayCard(MagicCard mc)
        {
            if (mc.Type.ToUpper().Contains("LAND"))
            {
                Debug.WriteLine("PrePlay - UseCard");
                useCard(mc);
            }
            else
            {
                Debug.WriteLine("PrePlay - AddToStack");
                AddToStack(mc);
            }
        }

        void xPicker_ValuePicked_StrengthTajuru(int value, int count)
        {
            //TODO potentially redundant
            CardStack[0].Targets = count;
            CardStack[0].manaCost.grey += value * count;

            ColourCost cc = CardStack[0].manaCost;

            if (PlArea.mana.Compare(cc))
            {
                Debug.WriteLine("xPicker_ValuePicked_StrengthTajuru - UseCard");
                useCard(CardStack[0]);
            }
            CardStack.RemoveAt(0);

            xPicker.ValuePicked -= xPicker_ValuePicked_StrengthTajuru;
            xPicker.ValuePicked += new XManaPicker.IntReturn(picker_ValuePicked);
        }

        # region choose where to add card
        void listViewArtEnch_MouseClick(object sender, MouseEventArgs e)
        {
            PlArea._artEnch.Add(tempCard);
            tempCard = null;

            listViewArtEnch.MouseUp -= listViewArtEnch_MouseClick;
            updateAll();
        }

        void cardAreaPlay_AuraCard(MagicCard mc, MouseEventArgs e)
        {
            mc.AttachCard(tempCard);
            mc.checkPT();
            mc.callSpellCast();
            tempCard = null;
            cardAreaPlay.CardClicked -= cardAreaPlay_AuraCard;
        }

        void cardAreaHand_CardClickedEliteArcanist(MagicCard mc, MouseEventArgs e)
        {
            //mc.Activate += new MagicCard.Ability(mc_ActivateEliteArcanist);
            mc.Activating += new MagicCard.ValueAbility(mc_ActivateEliteArcanist);

            MagicCard mcvt = tempCard;

            tempCard.AttachCard(mc);
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
            tempCard.AttachCard(mc);
            tempCard.checkPT();
            tempCard = null;

            PlArea._hand.Remove(mc);
            cardAreaHand.RemoveCard(mc);
            cardAreaHand.CardClicked -= cardAreaHand_CardClickedCipher;

            mc.Activate += new MagicCard.ValueAbility(mc_ActivateEliteArcanist);

        }

        void mc_ActivateEliteArcanist(MagicCard mc, int index)
        {
            PrePlay(mc);
        }

        void cardArea1_CardClicked1(MagicCard mc, MouseEventArgs e)
        {
            mc.quantity = 1;
            mc.AttachCard(tempCard);
            mc.checkPT();
            mc.Name += "*";
            mc.TapChanged += new PassiveEvent(mc_TapVerdantHaven);

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
            mc.OnPlay += new PassiveEvent(temp_OnPlay);

            PrePlay(mc);
        }
        # endregion
        # endregion

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

        private void TimerStop()
        {
            timer2.Stop();
            timer1.Stop();
            timerStack.Stop();
        }

        private void OppPlayHand()
        {
            # region play a land
            int i = OppArea._hand.cards.FindIndex(o => o.Type.Contains("Land"));

            if (i > -1)
            {
                MagicCard mc = CardMethods.GetClass(OppArea._hand.cards[i]);
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
                        MagicCard mcs = CardMethods.GetClass(mc);
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

        # region casting cycle
        //choose card

        //remove from hand

        private void CalcCost(MagicCard mc)
        { }

        private void ChooseTargetCount(MagicCard mc)
        { }

        private void ChooseX(MagicCard mc)
        { }

        private void PayCosts(MagicCard mc)
        { }

        private void AddToStack(MagicCard mc)
        {
            Debug.WriteLine("AddToStack({0}", mc.Name);
            if (mc.Name == "Progenitor Mimic")
            {
                tempCard = mc;
                PlArea._hand.cards.Remove(mc);
                cardAreaHand.RemoveCard(mc);

                cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_CardClickedProgenitorMimic);
            }
            else
            {
                CardStack.Add(mc);
                timerStack.Start();
            }
        }

        void cardAreaPlay_CardClickedProgenitorMimic(MagicCard mc, MouseEventArgs e)
        {
            MagicCard mcn = new MagicCard(mc);
            mcn.Text += "\r\nAt the beginning of your upkeep, if this creature isn't a token, put a token onto the battlefield that's a copy of this creature.";
            CardStack.Add(mcn);
            timerStack.Start();
            cardAreaPlay.CardClicked -= cardAreaPlay_CardClickedProgenitorMimic;
        }

        private void timerStack_Tick(object sender, EventArgs e)
        {
            ProcStack();
            timerStack.Stop();
        }

        private void ProcStack()
        {
            for (int i = CardStack.Count - 1; i >= 0 && CardStack.Count > 0; i--)
            {
                //CardStack[i].Resolve();   //Final method?
                MagicCard mc = CardStack[i];
                if (mc.Name == "Protean Hydra")
                {
                    Debug.WriteLine("Card");
                }

                Debug.WriteLine("ProcStack - UseCard");
                CardStack.Remove(mc);
                useCard(mc);  //Temporary?
            }
            timerStack.Stop();
        }
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        private void listViewOppCrea_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (listViewOppCrea.SelectedItems.Count > 0)
                    {
                        int ind = listViewOppCrea.SelectedIndices[0];
                        MagicCard mc = OppArea._play.cards[ind];
                        mc.callDestroyed();
                        OppArea._play.cards.Remove(mc);
                        updateOppSide();
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {

        }
        # endregion

        # region cPanel
        private void xPicker_Cancel()
        {
            xPicker.Hide();
            if (CardStack.Count > 0)
            {
                CardStack.RemoveAt(0);
            }
        }

        private void buttonCPanelHide_Click(object sender, EventArgs e)
        {
            viewCard = null;
            cPanelControls.Hide();
        }

        private void buttonCardChoose_Click(object sender, EventArgs e)
        {
            buttonCardChoose.Visible = false;
            comboCardPicker.Visible = false;
            cPanelControls.Visible = false;

            int i = comboCardPicker.SelectedIndex;

            if (i >= 0 && i < PickList.Count)
            {
                MagicCard mc = PickList[i];
                onCardChosen(mc);
            }
            else
            {
                callOnCancel();
            }
        }

        private void PickerShow(int MaxCount, ColourCost cost)
        {
            xPicker.Cost = cost;
            xPicker.Mana = PlArea.mana;
            xPicker.Value = 0;
            xPicker.Show(MaxCount);
            xPicker.BringToFront();
        }

        private void PickerShow(int MinCount, int MaxCount, ColourCost cost)
        {
            xPicker.Cost = cost;
            xPicker.Mana = PlArea.mana;
            xPicker.Show(MaxCount);
            xPicker.Value = MinCount;
            xPicker.BringToFront();
        }

        private void PickerShow(MagicCard mc, ColourCost cc)
        {
            xPicker.Mana = PlArea.mana;
            xPicker.Value = 0;
            xPicker.Show(mc);
            xPicker.BringToFront();
        }

        void picker_ValuePicked(int value, int count)
        {
            //TODO this was just copied off of git, and may be wrong
            xPicker.Hide();
            MagicCard mc = viewCard;

            if (mc == null)
            {
                return;
            }

            ColourCost cc = mc.manaCost;
            mc.Xvalue = value;

            mc.Targets = (int)numTargets.Value;

            # region set targeting and cost
            //consider Strive, kicker && multikicker etc.
            if (mc.Text.ToUpper().Contains("KICKER"))
            {
                for (int i = 0; i < numTargets.Value - 1; i++)
                {
                    //cc.grey += ((int)numTargets.Value - 1) * mc.AdditionalCost;
                    cc.Add(mc.AdditionalCost);
                }
            }
            else if (mc.Text.ToUpper().Contains("STRIVE"))
            {
                mc.Targets += value;
                for (int i = 0; i < value; i++)
                {
                    cc.Add(mc.AdditionalCost);
                }
            }
            # endregion

            if (PlArea.mana.Compare(cc))
            {
                CheckEntersBattlefield(mc);
                xPicker.ValuePicked -= picker_ValuePicked;
            }
            else
            {
                tempCard = mc;
                //xPicker.ValuePicked += new XManaPicker.IntReturn(picker_ValuePicked);
                PickerShow(count, mc.manaCost);
                ViewCard(mc);
            }


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

            # region set size
            panel1.Width = 200 * (1 + count);
            if (panel1.Width > 800)
            { panel1.Width = 800; }
            # endregion

            for (int i = 0; i < count; i++)
            {
                CardViewer cv = new CardViewer();
                panel1.Controls.Add(cv);
                cv.Show();
                cv.Left = (panel1.Controls.Count - 1) * 200;
                cv.LoadCard(mc.attachedCards[i]);
            }

            cPanelControls.Width = panel8.Width + panel1.Width;
            cPanelControls.Left = (this.Width - cPanelControls.Width) / 2;
            if (cPanelControls.Left < 0)
            { cPanelControls.Left = 0; }
        }
        # endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //if (lvTemp.SelectedItems.Count > 0)
            //{
            //    e.Cancel = true;
            //}
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

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Controls.Clear();
            }
        }

        private void panelOppEnch_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(panelOppEnch.Height);
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

        void cv_VisibleChanged(object sender, EventArgs e)
        {
            Control ct = sender as Control;
            if (ct.Visible == false)
            {
                ct.Dispose();
            }
        }

        # region timer ticking
        void t1_Tick(object sender, EventArgs e)
        {
            t1.Stop();

            //updateListViews();
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
        # region Explorer's Scope
        void OnUnequip_ExplorersScope(MagicCard mc)
        {
            //TODO not getting called
            mc.Parent.OnAttack -= OnAttack_ExplorersScope;
        }

        void OnEquip_ExplorersScope(MagicCard mc)
        {
            if (PlArea._play.cards.Contains(mc))
            {
                PlArea._play.cards.Remove(mc);
            }

            //TODO not getting called
            mc.Parent.OnAttack += new PassiveEvent(OnAttack_ExplorersScope);
        }

        void OnAttack_ExplorersScope(MagicCard mc)
        {
            //TODO not getting hooked up
            MagicCard tempCard = PlArea._stack.cards[0];
            ViewCard(tempCard);

            if (tempCard.Type.Contains("Land"))
            {
                cPanelControls.VisibleChanged += new EventHandler(cPanelControls_VisibleChanged);
            }
        }

        void cPanelControls_VisibleChanged(object sender, EventArgs e)
        {
            MagicCard mc = PlArea._stack.cards[0];
            PlArea._lands.Add(mc);
            PlArea._stack.cards.Remove(mc);
            mc._Tapped = true;

            cPanelControls.VisibleChanged -= cPanelControls_VisibleChanged;
        }
        # endregion

		# region Launch The Fleet
		void CardsChosen_LaunchTheFleet(List<MagicCard> sources)
		{
            if (sources.Count > targets)
			{
				return;
			}

            foreach (MagicCard mc in sources)
			{
				mc.OnAttack += new PassiveEvent(OnAttack_CreateSoldier);
				mc.callSpellCast();
			}
			cardAreaPlay.CardsPicked -= CardsChosen_LaunchTheFleet;			
            update_listViewPlay();
		}
		# endregion
		
        void OnAttack_CreateSoldier(MagicCard mc)
        {
            MagicCard mct = new MagicCard
            {
                Name = "Soldier",
                Type = "Creature - Soldier",
                Token = true,
                Tapped = true,
                Attacking = true,
                PT = "1/1",
                PArea = mc.PArea,
                OppArea = mc.OppArea
            };
            mc.PArea.PlayToken(mct);

            mc.OnAttack -= OnAttack_CreateSoldier;
            update_listViewPlay();
        }

        void Activating_SacSearchBasic(MagicCard mc, int index)
        {
            mc.callDie();
            List<MagicCard> list = mc.PArea._stack.cards.Where(o => o.Type.Contains("Basic Land")).ToList();
            comboCardPicker_Fill(list);
            CardChosen += new PassiveEvent(CardChosen_Play);
        }

        void CardChosen_Play(MagicCard mc)
        {
            useCard(mc);
        }

        private void PlayCreature(MagicCard mc, PlayArea area)
        {
            onCreaCast(mc);

            # region add card specific event handlers
            switch (mc.Name)
            {
                # region Elite Arcanist
                case "Elite Arcanist":
                    if (playerTurn)
                    {
                        DialogResult dr = MessageBox.Show("Copy card onto Elite Arcanist?", "Copy card?", MessageBoxButtons.YesNo);

                        Debug.WriteLine("count: {0}", CardStack.Count);
                        if (dr == DialogResult.Yes)
                        {
                            tempCard = mc;
                            cardAreaHand.CardClicked += new CardArea.CardChosen(cardAreaHand_CardClickedEliteArcanist);
                        }
                    }
                    mc.Activating += new MagicCard.ValueAbility(Activating_EliteArcanist);
                    break;
                # endregion

                # region Mnemonic Wall
                case "Mnemonic Wall":
                    if (playerTurn)
                    {
                        List<MagicCard> cards = PlArea._graveyard.cards.Where(o => o.Type.ToUpper().Contains("INSTANT") || o.Type.ToUpper().Contains("SORCERY")).ToList();
                        comboCardPicker_Fill(cards);
                        CardChosen += new PassiveEvent(CardChosen_MnemonicWall);
                    }
                    break;
                # endregion

                # region BondBeetle
                case "Bond Beetle":
                    if (playerTurn)
                    {
                        cardAreaPlay.CardClicked += new CardArea.CardChosen(CardClick_BondBeetle);
                    }
                    break;
                # endregion

                # region Fathom Mage
                //case "Fathom Mage":
                //    if (playerTurn)
                //    {
                //        mc.CountersChanged += new ValueChanged(mc_CountersChangedFathomMage);
                //    }
                //    break;
                # endregion

                # region Zameck Guildmage
                case "Zameck Guildmage":
                    mc.Activating += new MagicCard.ValueAbility(Activating_ZameckGuildmage);
                    break;
                # endregion

                # region Sigiled Skink
                case "Sigiled Skink":
                    mc.OnAttack += new PassiveEvent(mc_Scry1);
                    break;

                case "Sigiled Starfish":
                    mc.Activating += new MagicCard.ValueAbility(mc_ActivatingScry1);
                    break;
                #endregion

                # region Vanguard of Brimaz
                case "Vanguard of Brimaz":
                    mc.onSpellCast += new PassiveEvent(Heroic_VanguardBrimaz);
                    break;
                # endregion

                # region Doomed Traveler
                case "Doomed Traveler":
                    mc.onDie += new PassiveEvent(Discard_DoomedTraveler);
                    break;
                # endregion

                # region God-Favored General
                case "God-Favored General":
                    mc.TapChanged += new PassiveEvent(Untap_GodFavoredGeneral);
                    break;
                # endregion

                # region Geist-Honored Monk
                case "Geist-Honored Monk":
                    break;
                # endregion

                # region Triton Fortune Hunter
                case "Triton Fortune Hunter":
                    mc.onSpellCast += new PassiveEvent(HeroicDrawCard);
                    break;
                # endregion

                # region Sage of Hours
                case "Sage of Hours":
                    mc.onSpellCast += new PassiveEvent(Heroic_One);
                    break;
                # endregion

                # region Phalanx Leader
                case "Phalanx Leader":
                    mc.onSpellCast += new PassiveEvent(Heroic_PhalanxLeader);
                    break;
                # endregion

                # region Tethmos High Priest
                case "Tethmos High Priest":
                    mc.onSpellCast += new PassiveEvent(Heroic_TethmosHighPriest);
                    break;
                # endregion

                # region Hero of Iroas
                case "Hero of Iroas":
                    mc.onSpellCast += new PassiveEvent(Heroic_One);
                    break;
                # endregion

                # region Brood Keeper
                case "Brood Keeper":
                    mc.onAuraAdded += new PassiveEvent(AuraAdded_BroodKeeper);
                    break;
                # endregion

                # region Akroan Crusader
                case "Akroan Crusader":
                    mc.onSpellCast += new PassiveEvent(Heroic_Soldier);
                    break;
                # endregion

                # region Guttersnipe
                case "Guttersnipe":
                    area.SpellRes += new PassiveEvent(SpellCast_Guttersnipe);
                    mc.onDie += new PassiveEvent(Died_Guttersnipe);
                    break;
                # endregion

                # region Young Pyromancer
                case "Young Pyromancer":
                    area.SpellRes += new PassiveEvent(SpellCast_YoungPyromancer);
                    mc.onDie += new PassiveEvent(Died_YoungPyromancer);
                    break;
                # endregion

                # region Thallid
                case "Thallid":
                    mc.OnUpkeep += new PassiveEvent(Upkeep_Fungus);
                    mc.Activating += new MagicCard.ValueAbility(Activating_Fungus);
                    break;
                # endregion

                # region Elvish Farmer
                case "Elvish Farmer":
                    mc.OnUpkeep += new PassiveEvent(Upkeep_Fungus);
                    mc.Activating += new MagicCard.ValueAbility(Activating_ElvishFarmer);
                    break;
                # endregion

                # region Mycoloth
                case "Mycoloth":
                    mc.OnUpkeep += new PassiveEvent(Upkeep_Mycoloth);
                    break;
                # endregion

                # region Jade Mage
                case "Jade Mage":
                    mc.Activating += new MagicCard.ValueAbility(Activating_JadeMage);
                    break;
                # endregion

                # region Satyr Hoplite
                case "Satyr Hoplite":
                    mc.onSpellCast += new PassiveEvent(Heroic_One);
                    break;
                # endregion
            }
            # endregion

            mc.Activate += new MagicCard.ValueAbility(mc_ActivateCard);

            if (!mc.Token && mc.Text.Contains("At the beginning of your upkeep, if this creature isn't a token, put a token onto the battlefield that's a copy of this creature."))
            {
                mc.OnUpkeep += new PassiveEvent(Upkeep_ProgenitorMimic);
            }

            mc.checkPT();

            CardsProc = new List<MagicCard>();

            area.PlayCard(mc);

            update_listViewPlay();
        }

        void Heroic_Soldier(MagicCard mc)
        {
            MagicCard mct = new MagicCard
            {
                Name = "Soldier",
                Type = "Creature - Soldier",
                Text = "Haste",
                PT = "1/1",
                Token = true,
                PArea = mc.PArea,
                OppArea = mc.OppArea
            };
            PlayCard(mct);
        }

        void CardClicked_WakeReflections(MagicCard mc, MouseEventArgs e)
        {
            if (mc.Token)
            {
                MagicCard mct = new MagicCard(mc);
                PlayCreature(mct, PlArea);
                cardAreaPlay.CardClicked -= CardClicked_WakeReflections;
            }
        }

        void Scry(int count)
        {
            List<MagicCard> cards = new List<MagicCard>();

            for (int i = 0; i < count; i++)
            {
                cards.Add(PlArea._stack.cards[i]);
            }

            comboCardPicker_Fill(cards);
            CardChosen += new PassiveEvent(CardChosen_ToBottom);
            onCancel += new Action(OnCancel_ToBottom);
        }

        void OnCancel_ToBottom()
        {
            onCancel -= OnCancel_ToBottom;
            CardChosen -= CardChosen_ToBottom;
        }

        void CardChosen_ToBottom(MagicCard mc)
        {
            if (PlArea._stack.cards.Contains(mc))
            {
                PlArea._stack.cards.Remove(mc);
                PlArea._stack.cards.Add(mc);
                mc.Location = "Library";

                onCancel -= OnCancel_ToBottom;
                CardChosen -= CardChosen_ToBottom;
            }
        }

        void Upkeep_ProgenitorMimic(MagicCard mc)
        {
            MagicCard mcn = CardMethods.GetClass(mc);
            mcn.Token = true;
            mc.PArea.PlayToken(mcn);
        }

        void Untap_GodFavoredGeneral(MagicCard mc)
        {
            if (mc.Tapped)
            {
                return;
            }

            if (MessageBox.Show("Do you want to pay {2}{W} to create two soldier tokens?", "Inspired", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //need a way to produce the mana...
                cardAreaPlay.CountersPicked += new CardArea.CountersChosen(cardAreaPlay_GodFavoredGeneral);
                cardAreaPlay.buttonDone.Show();
            }
        }

        # region Heroic
        void HeroicDrawCard(MagicCard mc)
        {
            DrawCard(1);
        }

        void Heroic_One(MagicCard mc)
        {
            mc.counters++;
        }

        void Heroic_PhalanxLeader(MagicCard mc)
        {
            foreach (MagicCard mcc in mc.PArea._play.cards)
            {
                mcc.counters++;
            }
        }

        void Heroic_VanguardBrimaz(MagicCard mc)
        {
            MagicCard mct = new MagicCard
            {
                Name = "Cat",
                Token = true,
                PT = "1/1",
                Power = 1,
                Toughness = 1,
                Text = "Vigilance",
                PArea = mc.PArea,
                OppArea = mc.OppArea
            };
            mct.Abilities.Add(new CardAbility
            {
                Name = "Vigilance"
            });

            PlayCreature(mct, PlArea);
        }

        # region Tethmos High Priest
        void Heroic_TethmosHighPriest(MagicCard mc)
        {
            List<MagicCard> cards = mc.PArea._graveyard.cards.Where(o => o.CMC <= 2).ToList();
            comboCardPicker_Fill(cards);
            CardChosen += new PassiveEvent(CardChosen_TethmosHighPriest);
        }

        void CardChosen_TethmosHighPriest(MagicCard mc)
        {
            PlArea._graveyard.Remove(mc);
            mc.Location = "Play";

            CardChosen -= CardChosen_TethmosHighPriest;
        }
        # endregion
        # endregion

        void CardChosen_ChordofCalling(MagicCard mc)
        {
            CheckEntersBattlefield(mc);
            CardChosen -= CardChosen_ChordofCalling;
        }

        void BlueUntapDraw(MagicCard mc, MouseEventArgs e)
        {
            if (mc.Type.Contains("Creature"))
            {
                mc.callSpellCast();
                mc.Color = "U";
                mc.Tap(false, false);
                DrawCard(1);
                cardAreaPlay.CardClicked -= BlueUntapDraw;
            }
        }

        void CreateCopyScry(MagicCard mc, MouseEventArgs e)
        {
            if (mc.Type.Contains("Creature"))
            {
                mc.callSpellCast();
                MagicCard nmc = new MagicCard(mc);
                nmc.Token = true;
                PlayCreature(nmc, mc.PArea);

                if (playerTurn) { Scry(2); }

                cardAreaPlay.CardClicked -= CreateCopyScry;
            }
        }

        void CreatureEntered_Spiritbonds(MagicCard mc)
        {
            if (mc.Token)
            {
                return;
            }

            if (MessageBox.Show("Pay {W} to create a Spirit token?", "Spirit Bonds", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cardAreaPlay.CountersPicked += new CardArea.CountersChosen(CountersPicked_SpiritBonds);
                cardAreaPlay.buttonDone.Show();
            }
        }

        void CountersPicked_SpiritBonds(int value, Dictionary<MagicCard, int> sources)
        {
            ColourCost cc = new ColourCost { white = 1, };

            if (PlArea.mana.Compare(cc))
            {
                PlArea.mana.Subtract(cc);

                PlArea.PlayToken(new MagicCard
                {
                    Name = "Spirit",
                    Text = "Flying",
                    Type = "Creature - Spirit",
                    Token = true,
                    PT = "1/1",
                    PArea = PlArea,
                    OppArea = OppArea
                });

                update_listViewPlay();
            }

            cardAreaPlay.CountersPicked -= CountersPicked_SpiritBonds;
        }

        void Activating_JadeMage(MagicCard mc, int index)
        {
            CreateSaproling(mc);
            update_listViewPlay();
        }

        void Entering_Devour2(MagicCard mc)
        {
            mc.OnPlay -= Entering_Devour2;

            cardAreaPlay.CardsPicked += new CardArea.CardsChosen(CardsPicked_Devour2);
            cardAreaPlay.ChooseCards();
            tempCard = mc;
        }

        void Entering_Devour1(MagicCard mc)
        {
            mc.OnPlay -= Entering_Devour1;

            cardAreaPlay.CardsPicked += new CardArea.CardsChosen(CardsPicked_Devour1);
            cardAreaPlay.ChooseCards();
            tempCard = mc;
        }

        void Upkeep_Mycoloth(MagicCard mc)
        {
            for (int i = 0; i < mc.counters; i++)
            {
                CreateSaproling(mc);
            }
            update_listViewPlay();
        }

        void Activating_ElvishFarmer(MagicCard mc, int index)
        {
            switch (index)
            {
                case 0:
                    Activating_Fungus(mc, 0);
                    break;

                case 1:
                    cardAreaPlay.CardClicked += new CardArea.CardChosen(Cardclicked_Sapsac);
                    break;
            }

        }

        void Cardclicked_Sapsac(MagicCard mc, MouseEventArgs e)
        {
            if (!mc.Type.Contains("Saproling"))
            {
                return;
            }

            //mc.callSacrificed();
            mc.callDiscard();
            PlArea.HP += 2;
            cardAreaPlay.CardClicked -= Cardclicked_Sapsac;
            update_listViewPlay();
        }

        void CardsPicked_Devour2(List<MagicCard> sources)
        {
            int count = 0;

            foreach (MagicCard mc in sources)
            {
                mc.callDiscard();
                count++;
            }

            if (tempCard != null)
            {
                tempCard.counters += count * 2;
            }

            cardAreaPlay.CardsPicked -= CardsPicked_Devour2;
            PlayCard(tempCard);
        }

        void CardsPicked_Devour1(List<MagicCard> sources)
        {
            int count = 0;

            foreach (MagicCard mc in sources)
            {
                mc.callDiscard();
                count++;
            }

            if (tempCard != null)
            {
                tempCard.counters += count;
            }

            cardAreaPlay.CardsPicked -= CardsPicked_Devour1;
            PlayCard(tempCard);
        }

        void Activating_Fungus(MagicCard mc, int index)
        {
            if (index == 0 && mc.counters >= 3)
            {
                mc.counters -= 3;
                CreateSaproling(mc);
                update_listViewPlay();
            }
        }

        private void CreateSaproling(MagicCard mc)
        {
            MagicCard mct = new MagicCard
            {
                Name = "Saproling",
                Type = "Creature - Saproling",
                Token = true,
                PT = "1/1",
                PArea = mc.PArea,
                OppArea = mc.OppArea
            };
            PlayCreature(mct, mc.PArea);
        }

        void Upkeep_Fungus(MagicCard mc)
        {
            mc.counters++;
        }

        # region Young Pyromancer
        void SpellCast_YoungPyromancer(MagicCard mc)
        {
            //if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            //{
            //    MagicCard mct = new MagicCard
            //    {
            //        Token = true,
            //        Name = "Elemental",
            //        Type = "Creature - Elemental",
            //        Color = "Red",
            //        PT = "1/1",
            //    };
            //    mc.PArea.PlayToken(mct);
            update_listViewPlay();
            //}
        }

        void Died_YoungPyromancer(MagicCard mc)
        {
            mc.PArea.SpellRes -= SpellCast_YoungPyromancer;
        }
        # endregion

        # region Guttersnipe
        void SpellCast_Guttersnipe(MagicCard mc)
        {
            //if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            //{
            //    OppArea.HP -= 2;
            //}
        }

        void Died_Guttersnipe(MagicCard mc)
        {
            mc.PArea.SpellRes -= SpellCast_Guttersnipe;
        }
        # endregion

        void cardAreaPlay_GodFavoredGeneral(int value, Dictionary<MagicCard, int> sources)
        {
            ColourCost cc = new ColourCost
            {
                white = 1,
                grey = 2,
            };

            if (!PlArea.mana.Compare(cc))
            {
                return;
            }

            PlArea.mana.Subtract(cc);

            # region Play Tokens
            for (int i = 0; i < 2; i++)
            {
                PlArea.PlayToken(new MagicCard
                {
                    Type = "Enchantment Creature",
                    Name = "Soldier",
                    PT = "1/1",
                    Token = true,
                    PArea = PlArea,
                    OppArea = OppArea,
                });
            }
            # endregion

            cardAreaPlay.CountersPicked -= cardAreaPlay_GodFavoredGeneral;

            update_listViewPlay();
        }

        void Activating_OozeFlux(MagicCard mc, int index)
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

        void Activating_Equipment(MagicCard mc, int index)
        {
            //maybe redundant check that it is the equip event being called
            if (mc.Abilities[index].Text.Contains("Equip"))
            {
                tempCard = mc;
                cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_CardEquip);
            }
        }

        void EntersBattlefield_MnemonicWall(MagicCard mc)
        {
            //TODO potentially redundant - done in PlayCreature
            List<MagicCard> cards = PlArea._graveyard.cards.Where(o => o.Type == "Instant" || o.Type == "Sorcery").ToList();
            comboCardPicker_Fill(cards);

            CardChosen += new PassiveEvent(CardChosen_MnemonicWall);
        }

        void EntersBattlefield_GeistHonoredMonk(MagicCard mc)
        {
            # region Play Token
            PlArea.PlayToken(new MagicCard
            {
                Name = "Spirit",
                Type = "Creature",
                PT = "1/1",
                Text = "Flying",
                Token = true,
                PArea = mc.PArea,
                OppArea = mc.OppArea
            });
            # endregion

            # region Play Token
            PlArea.PlayToken(new MagicCard
            {
                Name = "Spirit",
                Type = "Creature",
                PT = "1/1",
                Text = "Flying",
                Token = true,
                PArea = mc.PArea,
                OppArea = mc.OppArea
            });
            # endregion

            update_listViewPlay();
        }

        void CardChosen_MnemonicWall(MagicCard mc)
        {
            if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            {
                PlArea._graveyard.Remove(mc);
                cardAreaHand.AddCard(mc);
                mc.Location = "Hand";
                CardChosen -= CardChosen_MnemonicWall;
            }
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

        void mc_ActivateCard(MagicCard mc, int index)
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
            }

            if (mc.Type.Contains("Equipment"))
            {
                Debug.WriteLine("Equipping");
            }
        }

        void Activating_ZameckGuildmage(MagicCard mc, int index)
        {
            if (index == 0)
            {

            }
            else if (index == 1)
            {
                cardAreaPlay.CardClicked += new CardArea.CardChosen(cardAreaPlay_CardClickedZameckGuildmage);
            }
        }

        void cardAreaPlay_CardClickedZameckGuildmage(MagicCard mc, MouseEventArgs e)
        {
            if (mc.counters > 0)
            {
                mc.counters--;
                DrawCard(1);
                cardAreaPlay.CardClicked -= cardAreaPlay_CardClickedZameckGuildmage;
            }
        }

        void Activating_EliteArcanist(MagicCard mc, int index)
        {
            if (mc.attachedCards.Count > 0)
            {
                MagicCard mcn = mc.attachedCards[0];
                if (PlArea.mana.colourless >= mcn.manaCost.colourless)
                {
                    mc.Tap(true, false);
                    Debug.WriteLine("Activating_EliteArcanist - AddToStack");
                    AddToStack(mcn);
                }
                else
                {
                    string s = "Elite Arcanist: Not enough mana to activate ability (" + PlArea.mana.colourless + "/" + mcn.manaCost.colourless + ")";
                    MessageBox.Show(s);
                }
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
            if (!mc.Token || !mc.Type.ToLower().Contains("creature"))
            {
                return;
            }
            else
            {
                CardEvent_MakeToken(mc);
                cardAreaPlay.CardClicked -= CardEvent_Populate;
            }
        }

        MagicCard CardEvent_MakeToken(MagicCard mc)
        {
            MagicCard mct = new MagicCard(mc);
            if (mc.PArea == null)
            {
                mc.PArea = PlArea;
            }

            return mct;
        }
        
        void CardsChosen_Twinflame(List<MagicCard> sources)
        {
            if (sources.Count > targets)
            {
                MessageBox.Show("Too many targets");
                return;
            }

            foreach (MagicCard mc in sources)
            {
                MagicCard mct = CardEvent_MakeToken(mc);
                mct.Text += "\r\nHaste";
                mct.onEndStep += new PassiveEvent(PassiveEvent_ExileSelf);

                PlayCard(mct);
            }

            cardAreaPlay.CardsPicked -= CardsChosen_Twinflame;
            update_listViewPlay();
        }

        void PassiveEvent_ExileSelf(MagicCard mc)
        {
            mc.callExile();
        }

        void PassiveEvent_Populate(MagicCard mc)
        {
            if (mc.PArea._play.cards.Count(o => o.Token == true) > 0)
            {
                cardAreaPlay.CardClicked += new CardArea.CardChosen(CardEvent_Populate);
            }
        }

        void CardChosen_TritonTactics(MagicCard mc, EventArgs e)
        {
            if (PlArea._play.cards.Contains(mc))
            {
                mc.callSpellCast();
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
            PlArea._play.cards.Remove(mc);
            update_listViewPlay();

            PlArea._hand.Add(new MagicCard(mc));
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
            PlArea.HP += mc.Power + mc.Toughness;

            cardAreaPlay.CardClicked -= CardChosen_PredatorsRapport;
        }

        void CardClicked_StrengthOfTheTajuru(MagicCard mc, MouseEventArgs e)
        {
            Debug.WriteLine("CardClicked_StrengthOfTheTajuru");
            //using targets as temporary xvalue
            mc.counters += tempCard.Xvalue;

            tempCard.Targets--;
            if (tempCard.Targets < 1)
            {
                cardAreaPlay.CardClicked -= CardClicked_StrengthOfTheTajuru;
            }
        }

        void CardClick_BondBeetle(MagicCard mc, MouseEventArgs e)
        {
            mc.counters++;
            cardAreaPlay.CardClicked -= CardClick_BondBeetle;
        }

        void CardChosen_NaturesLore(MagicCard mc)
        {
            PlArea.landMax++;
            //technically doesn't use the stack.
            AddToStack(mc);
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
            PlArea.UntapStep();
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

            OppArea.UntapStep();
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
            comboCardPicker.Items.Clear();
            foreach (MagicCard mc in PickList)
            {
                comboCardPicker.Items.Add(mc);
            }

            cPanelControls.Show();
            buttonCardChoose.Visible = true;
            comboCardPicker.Visible = true;
        }
        # endregion

        private void listViewOppCrea_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int i = listViewOppCrea.SelectedIndices[0];
                if (i > -1 && OppArea._play.cards.Count > i)
                {
                    MagicCard mc = OppArea._play.cards[i];
                    ViewCard(mc);
                }
            }
        }

        private void manaWheelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlArea.mw.ShowWheel("BUGRW");
        }

        private void PlArea_onScry(MagicCard mc, int value)
        {
            Scry(value);
        }

        private void PlArea_onPickCards(List<MagicCard> cards)
        {
            comboCardPicker_Fill(cards);
            CardChosen += new PassiveEvent(CardChosen_ToHand);
        }

        void CardChosen_ToHand(MagicCard mc)
        {
            if (mc.PArea != null && mc.PArea._graveyard.cards.Contains(mc))
            {
                mc.PArea._graveyard.cards.Remove(mc);
                mc.PArea._hand.Add(mc);
                update_listViewHand();
            }
            CardChosen -= CardChosen_ToHand;
        }
    }

    public delegate void Phase();
    public delegate void PassiveEvent(MagicCard mc);
    public delegate void CardDraw();
    public delegate void ValueChanged(int value);
}
