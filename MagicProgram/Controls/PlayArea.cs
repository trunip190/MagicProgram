using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace MagicProgram.Controls
{
    public class PlayArea : Component
    {
        # region declarations
        # region values
        # region card areas
        public CardCollection _deck = new CardCollection();
        public CardCollection _stack = new CardCollection();
        public CardCollection _graveyard = new CardCollection();
        public CardCollection _hand = new CardCollection();
        public CardCollection _artEnch = new CardCollection();
        public CardCollection _play = new CardCollection();
        public CardCollection _lands = new CardCollection();
        # endregion

        # region hp
        public event Action HPChanged;
        public event ValueChanged HPDown;
        public event ValueChanged HPUp;

        private void onHPChanged()
        {
            Action handler = HPChanged;
            if (handler != null)
            {
                handler();
            }
        }
        private void callHPDown(int value)
        {
            ValueChanged handler = HPDown;
            if (handler != null)
            {
                handler(value);
            }
            onHPChanged();
        }
        private void callHPUp(int value)
        {
            ValueChanged handler = HPUp;
            if (handler != null)
            {
                handler(value);
            }
            onHPChanged();
            List<MagicCard> cards = _play.cards;
        }

        private int _hp = 20;
        public int HP
        {
            get { return _hp; }
            set
            {
                int val = value - _hp;
                _hp = value;
                if (val > 0)
                {
                    callHPUp(val);
                }
                else if (val < 0)
                {
                    callHPDown(val);
                }
                foreach (MagicCard mc in _play.cards)
                {
                    mc.LifeChanged(val);
                }
            }
        }
        # endregion

        # region lands
        public int landPlayed = 0;
        public int landMax = 1;
        # endregion

        public int MaxHand = 7;
        int shuffles = 0;
        public MagicCard Commander = new NarsetEnlightenedMasterKTK();
        public int CommanderCast = 0;

        public int ExtraTurns = 0;

        public int seed = 0;
        private Random r = new Random();

        private List<MagicCard> CardsProc = new List<MagicCard>();
        # endregion

        # region components
        public ManaWheel mw = new ManaWheel { Visible = false };
        public ColourCost mana = new ColourCost();
        # endregion

        # region events
        public delegate void ValueEvent(MagicCard mc, int value);
        public delegate void CardsPicked(List<MagicCard> cards);

        public event Phase UpkeepDone;
        public event PassiveEvent SpellRes;
        public event PassiveEvent CardUsed;
        public event PassiveEvent CardDrawn;
        public event PassiveEvent CreatureEntered;
        public event ValueChanged onDamageOpponent;
        public event ValueEvent onScry;
        public event CardsPicked onPickCardsHand;
        public event CardsPicked onPickCardsUse;
        # endregion

        # region handlers
        protected void callCardUse(MagicCard mc)
        {
            PassiveEvent handler = CardUsed;
            if (handler != null)
            {
                handler(mc);
            }
        }
        protected void callCardDrawn(MagicCard mc)
        {
            PassiveEvent handler = CardDrawn;
            if (handler != null)
            {
                handler(mc);
            }
        }
        protected void callSpellRes(MagicCard mc)
        {
            PassiveEvent handler = SpellRes;
            List<MagicCard> list = new List<MagicCard>();

            foreach (MagicCard mcp in CardsProc)
            {
                //TODO need to rewrite Ability to take an index or bool for being used on the stack.
                mcp.callAbility(0);
            }

            foreach (MagicCard mcp in _play.cards)
            {
                list.Add(mcp);
            }
            foreach (MagicCard mcp in _artEnch.cards)
            {
                list.Add(mcp);
            }
            foreach (MagicCard mcp in list)
            {
                mcp.SpellResolved(mc);
                if (mc.Type.Contains("Creature"))
                {
                    mcp.CreatureEnteredPlay(mc);
                }
            }

            if (handler != null)
            {
                handler(mc);
            }
        }
        protected void callUpkeepDone()
        {
            Phase handler = UpkeepDone;
            if (handler != null)
            {
                handler();
            }
        }
        protected void callDamageOpponent(int i)
        {
            ValueChanged handler = onDamageOpponent;
            if (handler != null)
            {
                handler(i);
            }
        }
        public void callScry(MagicCard mc, int value)
        {
            ValueEvent handler = onScry;
            if (handler != null)
            {
                handler(mc, value);
            }
        }
        public void callPickCardsHands(List<MagicCard> cards)
		{
			CardsPicked handler = onPickCardsHand;
			if ( handler != null )
			{
				handler(cards);
			}
		}
        public void callPickCardsUse(List<MagicCard> cards)
        {
            CardsPicked handler = onPickCardsUse;
            if (handler != null)
            {
                handler(cards);
            }
        }
		# endregion
        # endregion

        # region method
        public PlayArea()
        {
        }

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
                    MagicCard newCard = CardMethods.GetClass(mc); ;
                    newCard.quantity = 1;
                    newCard.Initialise();
                    _stack.cards.Add(newCard);
                    newCard.Location = "Library";
                }
            }

            Output.Write("\r\nshuffling cards\r\n");
            _stack.cards.OrderBy(o => o.Type);
            _stack = Shuffle(_stack);
            _stack = Shuffle(_stack);
            _stack = Shuffle(_stack);
        }

        public void PlayCard(MagicCard mc)
        {
            # region land
            if (mc.Type.Contains("Land"))
            {
                switch (mc.Name)
                {
                    # region named cards
                    # region Breeding Pool
                    case "Breeding Pool":
                        DialogResult dr = MessageBox.Show("Pay 2 life to untap?", "Pay life?", MessageBoxButtons.YesNo);
                        mc.TapChanged += new PassiveEvent(Tap_Gate);

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
                    # endregion

                    # region Oran-Rief, the Vastwood
                    case "Oran-Rief, the Vastwood":
                        mc.Tap(true, true);
                        break;
                    # endregion
                    # endregion

                    default:
                        if (mc.Type.Contains("Basic Land"))
                        {
                            mc.TapChanged += new PassiveEvent(Activate_BasicLand);
                        }
                        else if (mc.Type.Contains("Gate"))
                        {
                            mc.TapChanged += new PassiveEvent(Tap_Gate);
                            mc.Activating += new MagicCard.ValueAbility(mc_Activating);
                            mc.Tap(true, true);
                        }
                        else
                        {
                            mc.TapChanged += new PassiveEvent(mc_TapLand);
                            mc.Activating += new MagicCard.ValueAbility(mc_Land);
                        }
                        break;
                }
                //_lands.cards.Add(mc);
                _lands.Add(mc);
                mc.Location = "Play";
                _lands.index();
            }
            # endregion
            # region spells
            else if (mc.Type.Contains("Instant") || mc.Type.Contains("Sorcery"))
            {
                switch (mc.Name)
                {
                    case "Explore":
                        landMax++;
                        drawCards(1);
                        break;

                    case "Divination":
                        drawCards(2);
                        break;

                    case "Nourish":
                        HP += 6;
                        break;

                    default:
                        break;
                }

                if (!mc.Token)
                {
                    _graveyard.cards.Add(mc);
                    mc.Location = "Graveyard";
                    _graveyard.index();
                }
            }
            # endregion
            # region creatures
            else if (mc.Type.ToUpper().Contains("CREATURE"))
            {
                # region card enters effects
                foreach (MagicCard mstc in _play.cards)
                {
                    switch (mstc.Name)
                    {
                        case "Master Biomancer":
                            mc.counters += mstc.Power;
                            break;

                        case "Champion of Lambholt":
                            mstc.counters++;
                            break;

                        case "Foundry Street Denizen":
                            mstc.PBonus += 1;
                            break;
                    }
                }
                # endregion

                # region individual card switch
                switch (mc.Name)
                {
                    case "Vorel of the Hull Clade":
                        mc.Activating += new MagicCard.ValueAbility(Activate_VorelHullClade);
                        break;

                    case "Overgrown Battlement":
                        mc.Activate += new MagicCard.ValueAbility(Activate_OvergrownBattlement);
                        break;

                    case "Voyaging Satyr":
                        mc.Activate += new MagicCard.ValueAbility(Activate_VoyagingSatyr);
                        break;

                    case "Opal Lake Gatekeepers":
                        if (_lands.cards.Count(o => o.Type.Contains("Gate")) >= 2)
                        {
                            drawCards(1);
                        }
                        break;

                    case "Leech Bonder":
                        mc.counters -= 2;
                        break;

                    case "Saruli Gatekeepers":
                        if (CheckLandType("gate", 2))
                        {
                            HP += 7;
                        }
                        break;

                    # region Axebane Guardian
                    case "Axebane Guardian":
                        mc.Activating += new MagicCard.ValueAbility(Activating_AxebaneGuardian);
                        break;
                    # endregion

                    case "Protean Hydra":
                        mc.counters += mc.Xvalue;
                        break;

                    case "Vastwood Hydra":
                        mc.counters += mc.Xvalue;
                        break;

                    case "Primordial Hydra":
                        mc.counters += mc.Xvalue;
                        break;

                    case "Generator Servant":
                        mc.Activating += new MagicCard.ValueAbility(Activating_GeneratorServant);
                        break;
                }
                # endregion

                mc.checkPT();
                //foreach (MagicCard mcs in _play.cards)
                //{
                //    mcs.Evolve(mc.Power, mc.Toughness);
                //}

                //TODO need to expand this to actually check.
                if (!mc.Text.Contains("Haste"))
                {
                    mc.Sick = true;
                }

                //_play.cards.Add(mc);
                _play.Add(mc);

                mc.Location = "Play";
                _play.index();
            }
            # endregion
            # region artifacts and enchantments
            else if (mc.Type.Contains("Artifact") || mc.Type.Contains("Enchantment"))
            {
                if (mc.Type.Contains("Equipment"))
                {
                    mc.OnEquip += new PassiveEvent(mc_OnEquip);
                    _play.Add(mc);
                    _play.index();
                }
                else
                {
                    switch (mc.Name)
                    {
                        case "Spirit Bonds":
                            //moved oncreaentered to decktest main
                            mc.Activating += new MagicCard.ValueAbility(Activating_SpiritBonds);
                            break;
                    }

                    _artEnch.Add(mc);
                    //_artEnch.index();  //called as part of _artEnch.Add();
                }
            }
            # endregion
            else
            {
                throw new NotImplementedException();
            }

            callSpellRes(mc);

            mc.Activating += new MagicCard.ValueAbility(mc_Activating);
            if (_play.cards.Contains(mc))
            {
                mc.Discard += new PassiveEvent(Play_Discard);
                mc.Destroyed += new PassiveEvent(Play_Destroyed);
            }
            if (_lands.cards.Contains(mc))
            {
                mc.Destroyed += new PassiveEvent(Land_Destroyed);
            }

            # region PostPlay individual card events
            switch (mc.Name)
            {
                case "Renegade Krasis":
                    mc.Evolving += new PassiveEvent(RenegadeKrasis_Evolve);
                    break;

                case "Soul Warden":
                    CreatureEntered += new PassiveEvent(CreatureEntered_SoulWarden);
                    mc.onDie += new PassiveEvent(CreatureLeft_SoulWarden);
                    break;

                case "Essence Warden":
                    CreatureEntered += new PassiveEvent(CreatureEntered_SoulWarden);
                    mc.onDie += new PassiveEvent(CreatureLeft_SoulWarden);
                    break;
            }
            # endregion
        }

        void Activating_DualLand(MagicCard mc, int index)
        {
            throw new NotImplementedException();
        }

        void Activating_SpiritBonds(MagicCard mc, int index)
        {

        }

        # region soul warden
        void CreatureEntered_SoulWarden(MagicCard mc)
        {
            HP++;
        }

        void CreatureLeft_SoulWarden(MagicCard mc)
        {
            CreatureEntered -= CreatureEntered_SoulWarden;
        }
        # endregion

        void Passive_AddOne(MagicCard mc)
        {
            mc.counters++;
        }

        void Activate_OvergrownBattlement(MagicCard mc, int index)
        {
            int c = 0;
            foreach (MagicCard mcp in _play.cards)
            {
                if (mc.Text.Contains("Defender"))
                {
                    c++;
                }
            }
            mana.green += c;
            mc.Tap(true, false);

        }
        
        void mc_OnEquip(MagicCard mc)
        {
            _play.Remove(mc);
            mc.OnEquip -= mc_OnEquip;
        }

        public void PlayToken(MagicCard mc)
        {
            PlayCard(mc);
        }

        # region Card events
        void Play_Destroyed(MagicCard mc)
        {
            foreach (MagicCard mca in mc.attachedCards)
            {
                CheckGrave(mca);    //place card in appropriate place                
            }
            CheckGrave(mc);

            _play.Remove(mc);
        }

        void Land_Destroyed(MagicCard mc)
        {
            foreach (MagicCard mca in mc.attachedCards)
            {
                CheckGrave(mca);    //place card in appropriate place                
            }
            CheckGrave(mc);

            _lands.Remove(mc);
        }

        void Play_Discard(MagicCard mc)
        {
            foreach (MagicCard mca in mc.attachedCards)
            {
                CheckGrave(mca);    //place card in appropriate place                
            }
            CheckGrave(mc);

            _play.Remove(mc);

            mc.callDie();
        }

        public void Play_Exile(MagicCard mc)
        {
            foreach (MagicCard mca in mc.attachedCards)
            {
                CheckGrave(mca);    //place card in appropriate place                
            }

            //_play.cards.Remove(mc);
            _play.Remove(mc);
        }

        void Hand_Discard(MagicCard mc)
        {
            _graveyard.cards.Add(mc);
            mc.Location = "Graveyard";
            _hand.cards.Remove(mc);
        }

        void mc_Activating(MagicCard mc, int index)
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

            //TODO testing which call is appropriate.
            //mc.callActivate(index);
            mc.DoActivate(index);
        }
        # endregion

        private bool CheckGrave(MagicCard mc)
        {
            bool toGrave = true;
            if (mc.Name == "Rancor")
            {
                MagicCard mcv = new MagicCard(mc);
                _hand.cards.Add(mcv);
                mcv.Location = "Hand";
                toGrave = false;
            }
            if (mc.Type.Contains("Equipment"))
            {
                _play.Add(mc);
                mc.OnEquip += new PassiveEvent(mc_OnEquip);
                toGrave = false;
            }
            if (mc.Text.Contains("Bestow") && mc.Type.Contains("Aura"))
            {
                _play.Add(mc);
                mc.Type = "Enchantment Creature";
                mc.Text = mc.Text.Replace("\r\nEnchant creature", "");
                toGrave = false;
            }

            if (toGrave)
            {
                _graveyard.Add(mc.Copy());
                toGrave = true;
            }

            return toGrave;
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
            mc.Activate += new MagicCard.ValueAbility(DeckTest_SpellRes);
        }

        void DeckTest_SpellRes(MagicCard mc, int index)
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

        void Activating_ZhurTaarDruid(MagicCard mc, int index)
        {
            callDamageOpponent(1);
            mana.Add("G");
            mc.Tap(true, false);
        }

        void Activating_GeneratorServant(MagicCard mc, int index)
        {
            mc.callSacrifice();
            mana.Add("2");
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

        void Activating_AxebaneGuardian(MagicCard mc, int index)
        {
            int count = _play.cards.Count(o => o.Text.Contains("Defender"));
            foreach (MagicCard mcp in _play.cards)
            {
                if (mcp.Text.Contains("Defender"))
                {
                    mw.ShowWheel("UBGRW");
                }
            }

        }

        void Activate_VorelHullClade(MagicCard mc, int index)
        {

        }

        void Activate_VoyagingSatyr(MagicCard mc, int index)
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

        void Tap_Gate(MagicCard mc)
        {
            if (!mc.Tapped)
            {
                return;
            }

            ColourCost ManaAdd = new ColourCost();

            switch (mc.Name)
            {
                case "Simic Guildgate": ManaAdd.blue = ManaAdd.green = 1; break;
                case "Gruul Guildgate": ManaAdd.red = ManaAdd.green = 1; break;
                case "Selesnya Guildgate": ManaAdd.white = ManaAdd.green = 1; break;
                case "Rakdos Guildgate": ManaAdd.black = ManaAdd.red = 1; break;
                case "Azorius Guildgate": ManaAdd.blue = ManaAdd.white = 1; break;

                case "Orzhov Guildgate": ManaAdd.white = ManaAdd.black = 1; break;
                case "Izzet Guildgate": ManaAdd.blue = ManaAdd.red = 1; break;
                case "Golgari Guildgate": ManaAdd.black = ManaAdd.green = 1; break;
                case "Boros Guildgate": ManaAdd.white = ManaAdd.red = 1; break;
                case "Dimir Guildgate": ManaAdd.blue = ManaAdd.black = 1; break;

                case "Breeding Pool": ManaAdd.green = ManaAdd.blue = 1; break;
            }

            mw.ShowWheel(ManaAdd);
        }

        void mc_Land(MagicCard mc, int index)
        {
            string text = mc.Abilities[index].Text;
            ColourCost cc = new ColourCost
            {
                black = text.Length - text.Replace("{B}", "{}").Length,
                blue = text.Length - text.Replace("{U}", "{}").Length,
                green = text.Length - text.Replace("{G}", "{}").Length,
                red = text.Length - text.Replace("{R}", "{}").Length,
                white = text.Length - text.Replace("{W}", "{}").Length,
            };

            int black = (text.Length - text.Replace("%B", "?").Length);
            int blue = (text.Length - text.Replace("%U", "?").Length);
            int green = (text.Length - text.Replace("%G", "?").Length);
            int red = (text.Length - text.Replace("%R", "?").Length);
            int white = (text.Length - text.Replace("%W", "?").Length);

            cc.black += black;
            cc.blue += blue;
            cc.green += green;
            cc.red += red;
            cc.white += white;

            if (text.Contains("or"))
            {
                mw.ShowWheel(cc);
            }
            else
            {
                mana.Add(cc);
            }
        }

        void mc_TapLand(MagicCard mc)
        {
            //if (!mc.Tapped)
            //{
            //    mc.TryActivate(0);
            //}
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
                mc.Location = "Hand";
                _stack.cards.Remove(mc);    //remove?
                //_stack.cards.RemoveAt(0);

                result.Add(mc);
                callCardDrawn(mc);
            }

            return result;
        }

        public List<MagicCard> DiscardCard(int i)
        {
            List<MagicCard> result = new List<MagicCard>();
            int c = i;
            while (c > 0)
            {
                if (_hand.cards.Count > 0)
                {
                    MagicCard mc = _hand.cards[0];
                    result.Add(mc);

                    _hand.cards.Remove(mc);
                    _graveyard.Add(mc);
                }

                c--;
            }

            return result;
        }

        public int countAttackers()
        {
            int result = 0;

            foreach (MagicCard mc in _play.cards)
            {
                if (!mc.Tapped && !mc.Sick && mc.Power > 0) //And not defender
                {
                    result++;
                }
            }

            return result;
        }

        public void ProcAttack()
        {
            for (int i = 0; i < _play.cards.Count; i++)
            {
                MagicCard mc = _play.cards[i];
                if (mc.Attacking)
                {
                    if (mc.Name == "Predator Ooze")
                    {
                        mc.counters++;
                    }
                    mc.Attack();
                    mc.Attacking = false;
                }
            }
        }

        public void UntapStep()
        {
            landPlayed = 0;

            for (int i = 0; i < _lands.cards.Count; i++)
            {
                _lands.cards[i].UntapStep();
            }
            for (int i = 0; i < _play.cards.Count; i++)
            {
                _play.cards[i].UntapStep();
            }
            for (int i = 0; i < _artEnch.cards.Count; i++)
            {
                _artEnch.cards[i].UntapStep();
            }
        }

        public void Upkeep()
        {
            for (int i = 0; i < _lands.cards.Count; i++)
            {
                _lands.cards[i].UpkeepCard();
            }
            for (int i = 0; i < _play.cards.Count; i++)
            {
                _play.cards[i].UpkeepCard();
            }
            for (int i = 0; i < _artEnch.cards.Count; i++)
            {
                _artEnch.cards[i].UpkeepCard();
            }
            //foreach (MagicCard mc in _hand.cards)
            //{
            //    mc.UpkeepCard();
            //}

            callUpkeepDone();
        }

        public void EndStep()
        {
            List<MagicCard> list = _play.cards.Where(o => o != null).ToList();

            foreach (MagicCard mc in list)
            {
                mc.EndStepCard();
            }
            landMax = 1;
        }

        public CardCollection Shuffle(CardCollection cc)
        {
            int s = seed + DateTime.Now.Second + shuffles;
            r = new Random(s);

            // randomise cards
            CardCollection result = new CardCollection
            {
                cards = Randomise(cc.cards)
            };

            # region Land Shuffle
            //Create Lists
            List<MagicCard> Lands = new List<MagicCard>();
            List<MagicCard> nonLands = new List<MagicCard>();

            # region split into lands/nonlands
            foreach (MagicCard mc in result.cards)
            {
                if (mc.Type.Contains("Land"))
                {
                    Lands.Add(mc);
                }
                else
                {
                    nonLands.Add(mc);
                }
            }
            # endregion

            int ratio = (Lands.Count + nonLands.Count) / Lands.Count;
            int count = 0;

            result = new CardCollection();

            Lands = Randomise(Lands);
            nonLands = Randomise(nonLands);

            # region add cards to list
            while (Lands.Count + nonLands.Count > 0)
            {
                if (Lands.Count > 0)
                {
                    ratio = (Lands.Count + nonLands.Count) / Lands.Count;
                }
                else
                {
                    ratio = 1;
                }
                if (count < ratio && nonLands.Count > 0)
                {
                    MagicCard mc = nonLands[0];

                    result.cards.Add(mc);
                    mc.Location = "Library";
                    nonLands.Remove(mc);
                    count++;
                }
                else if (Lands.Count > 0)
                {
                    MagicCard mc = Lands[0];

                    result.cards.Add(mc);
                    mc.Location = "Library";
                    Lands.Remove(mc);
                    count = 0;
                }
                else
                {
                    int p = Lands.Count;
                    int q = nonLands.Count;
                }
            }
            # endregion
            # endregion

            shuffles++;
            return result;
        }

        private List<MagicCard> Randomise(List<MagicCard> cards)
        {
            List<MagicCard> result = new List<MagicCard>();
            List<MagicCard> source = cards;

            while (source.Count > 0)
            {
                int k = r.Next(source.Count);

                result.Add(source[k]);
                source.RemoveAt(k);
            }
            return result;
        }
        # endregion
    }
}
