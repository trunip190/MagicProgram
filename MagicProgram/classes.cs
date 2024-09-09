// Ignore Spelling: Initialise Cloudfin Raptor Crocanura

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace MagicProgram
{
    public class ImageLibrary
    {
        public Dictionary<string, string> image = new Dictionary<string, string>();
    }

    [System.Xml.Serialization.XmlRoot("Collection")]
    public class CardCollection
    {
        [System.Xml.Serialization.XmlElement("Card")]
        public List<MagicCard> cards = new List<MagicCard>();
        private Dictionary<string, int> link = new Dictionary<string, int>();

        [XmlIgnore]
        public string Filename = "";

        # region cards changed
        public event CardUse CardAdded;
        protected void callCardAdded(MagicCard mc)
        {
            CardUse handler = CardAdded;
            if (handler != null)
            {
                handler(mc);
            }
        }

        public event CardUse CardRemoved;
        protected void callCardRemoved(MagicCard mc)
        {
            CardUse handler = CardRemoved;
            if (handler != null)
            {
                handler(mc);
            }
        }
        # endregion

        public int getIndex(string s)
        {
            int result = -1;

            if (link.ContainsKey(s.ToUpper()))
            {
                result = link[s.ToUpper()];
            }

            return result;
        }

        public MagicCard getCard(string s, string edition = "")
        {
            //MagicCard result = s == "Gyre Sage" ? new GyreSage() : new MagicCard { Name = "Blank" };
            MagicCard result = CardMethods.CreateCard(s);

            if (link.ContainsKey(s.ToUpper()))
            {
                int j = link[s.ToUpper()];
                result = cards[j];
                if (cards[j].Edition == edition)
                {
                    return cards[j];
                }
            }
            return result;
        }

        public void index()
        {
            link.Clear();
            string st;

            for (int i = 0; i < cards.Count; i++)
            {
                st = cards[i].Name.ToUpper().Trim();

                if (!link.ContainsKey(st))
                {
                    link.Add(st, i);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">0 Name, 1 Quantity, 2 Edition, 3 Rarity, 4 Colour, 5 CMC, 6 PT, 7 Type, 8 Text, 9 Flavour</param>
        /// <param name="order"></param>
        public void Sort(int type, SortOrder order)
        {
            # region switch (type)
            switch (type)
            {
                case 0:
                    cards = cards.OrderBy(o => o.Name).ToList();
                    break;

                case 1:
                    cards = cards.OrderBy(o => o.quantity).ToList();
                    break;

                case 2:
                    cards = cards.OrderBy(o => o.Edition).ToList();
                    break;

                case 3:
                    cards = cards.OrderBy(o => o.Rarity).ToList();
                    break;

                case 4:
                    cards = cards.OrderBy(o => o.Color).ToList();
                    break;

                case 5:
                    cards = cards.OrderBy(o => o.CMC).ToList();
                    break;

                case 6:
                    cards = cards.OrderBy(o => o.PT).ToList();
                    break;

                case 7:
                    cards = cards.OrderBy(o => o.Type).ToList();
                    break;

                case 8:
                    cards = cards.OrderBy(o => o.Text).ToList();
                    break;

                case 9:
                    cards = cards.OrderBy(o => o.Flavor).ToList();
                    break;
            }
            # endregion

            if (order == SortOrder.Descending)
            {
                cards.Reverse();
            }
        }

        public bool Add(MagicCard card)
        {
            bool result = false; //False means not in cards

            string st = card.Name.ToUpper().Trim();
            index();

            if (link.ContainsKey(st))
            {
                int i = link[st];
                int x = cards[i].quantity;
                int y = card.quantity;

                if (cards[i].attachedCards.Count > 0)
                {
                    cards.Add(card);
                }
                else
                {
                    //cards[i].attachedCards.Add(card);
                    cards[i].quantity += card.quantity;

                    result = true;
                }
            }
            else
            {
                link.Add(st, cards.Count);
                cards.Add(card);
            }

            callCardAdded(card);

            return result;
        }

        public void Clear()
        {
            cards.Clear();
            link.Clear();
        }
    }

    #region Magic Cards
    public class MagicCard : ICloneable
    {
        # region declarations
        # region Fields
        //"Name";"Edition";"Rarity";"Color";"Cost";"P/T";"Type";"Text";"Flavor"
        # region Card parts
        public string Name = "Temp Card";
        public string Edition = "TPC";
        public string Rarity = "C";
        public string Color = "W";
        public string Cost = "1";
        public string PT = "1/1";
        public string Type = "Creature";
        public string Text = "Temp Card";
        public string Flavor = "Nothing to see here";

        [XmlIgnore]
        public string NameLower => Name.ToLower();
        [XmlIgnore]
        public string TextLower => Text.ToLower();
        [XmlIgnore]
        public int DeckID = 0;

        # endregion

        # region card states
        public bool Token = false;

        [XmlIgnore]
        public bool _Tapped = false;
        public bool Tapped
        {
            get { return _Tapped; }
            set
            {
                _Tapped = value;
                CallTapChanged();
            }
        }

        [XmlIgnore]
        public bool Sick = false;
        # endregion

        [XmlIgnore]
        public int _XValue = 0;

        [XmlIgnore]
        public bool Attacking = false;

        [XmlIgnore]
        public CardLocation Location = CardLocation.Deck;

        [XmlIgnore]
        public int CMC
        {
            get
            {
                int result = 0;

                foreach (char c in Cost)
                {
                    if (Char.IsNumber(c))
                    {
                        result += (int)char.GetNumericValue(c);
                    }
                    else
                    {
                        result++;
                    }
                }

                return result;
            }
        }

        # region temp parts
        [XmlIgnore]
        public ColourCost manaCost = new ColourCost();

        [XmlIgnore]
        private int _power = 0;

        [XmlIgnore]
        private int _toughness = 0;

        [XmlIgnore]
        public int PowerCalc => _power + PBonus;
        [XmlIgnore]
        public int ToughnessCalc => _toughness + TBonus;

        [XmlIgnore]
        public int PBonus = 0;  //temp bonus
        [XmlIgnore]
        public int TBonus = 0;  //temp bonus

        [XmlIgnore]
        public string imgLoc = "";

        private int countersTurn = 0;
        [XmlIgnore]
        private int _counters = 0;
        public int counters
        {
            get { return _counters; }
            set
            {
                if (value == 0) return;
                int change = value - _counters;
                if (value < _counters && Name == "Protean Hydra")
                {
                    countersTurn -= change;
                }
                _counters = value;
                checkPT();
                CallCountersChanged(change);
            }
        }
        # endregion

        public int quantity = 1;
        [XmlIgnore]
        public bool AbilitySearch = false;
        [XmlIgnore]
        public bool AbilityEvolve = false;
        [XmlIgnore]
        public bool AbilityActivate = false;

        [XmlIgnore]
        public List<MagicCard> attachedCards = new List<MagicCard>();
        [XmlIgnore]
        public List<CardAbility> Abilities = new List<CardAbility>();
        # endregion

        # region handlers
        # region delegates/events
        public delegate void Ability(MagicCard mc, int ID);
        public delegate void ValueChanged(int count);
        public delegate void ManaChanged(ColourCost cc);
        public delegate void LocationChange(int CardID, CardLocation NewArea, CardLocation OldArea);

        public event Ability Evolving;
        public event Ability Activate;
        public event Ability Activating;
        public event Ability OnAttack;
        public event ValueChanged CountersChanged;
        public event Phase Upkeep;
        public event Phase EndPhase;
        public event CardUse TapChanged;
        public event CardUse Discard;
        public event CardUse Destroyed;
        public event CardUse PrePlay;
        public event CardUse OnPlay;
        public event SearchLocation SearchCard;
        public event Action StatsChanged;
        public event ManaChanged ChangeMana;
        public event LocationChange OnLocationChanged;
        # endregion

        # region Call event trigger methods
        public void CallActivate(int ID)
        {
            Ability handler = Activate;
            if (handler != null)
            {
                handler(this, ID);
            }
        }

        private void CallActivating(int ID)
        {
            Ability handler = Activating;
            if (handler != null)
            {
                handler(this, ID);
            }
        }

        public void CallEvolve(int ID)
        {
            Ability handler = Evolving;

            if (handler != null)
            {
                handler(this, ID);
            }
        }

        public void CallAbility(int ID)
        {
            Ability handler = Activate;
            if (handler != null)
            {
                handler(this, ID);
            }
        }

        public void CallOnAttack(int ID)
        {
            Ability handler = OnAttack;
            if (handler != null)
            {
                handler(this, ID);
            }
        }

        public void CallTapChanged()
        {
            CardUse handler = TapChanged;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void CallDiscard()
        {
            this.LocationChanged(CardLocation.Graveyard);
            CardUse handler = Discard;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void CallDestroyed()
        {
            this.LocationChanged(CardLocation.Graveyard);
            CardUse handler = Destroyed;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void CallCountersChanged(int count)
        {
            ValueChanged handler = CountersChanged;
            if (handler != null)
            {
                handler(count);
            }
        }

        public void CallPrePlay()
        {
            CardUse handler = PrePlay;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void CallOnPlay()
        {
            CardUse handler = OnPlay;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void CallStatsChanged()
        {
            Action handler = StatsChanged;
            if (handler != null)
            {
                handler();
            }
        }

        public void CallManaChanged(ColourCost cc)
        {
            ManaChanged handler = ChangeMana;
            if (handler != null) handler(cc);
        }

        public void CallSearchArea(string Location, string CardType, int depth, int count)
        {
            SearchLocation handler = SearchCard;
            if (handler != null) handler(Location, CardType, depth, count);
        }

        public void CallLocationChanged(CardLocation NewArea)
        {
            LocationChange handler = OnLocationChanged;
            Debug.WriteLine($"{Name} changed location to {NewArea}");
            if (handler != null) handler(DeckID, NewArea, Location);
        }
        # endregion
        # endregion
        # endregion

        # region methods
        public MagicCard() { }

        public MagicCard(MagicCard mc)
        {
            Name = mc.Name;
            Edition = mc.Edition;
            Rarity = mc.Rarity;
            Color = mc.Color;
            Cost = mc.Cost;
            PT = mc.PT;
            Type = mc.Type;
            Text = mc.Text;
            Flavor = mc.Flavor;

            _power = mc._power;
            _toughness = mc._toughness;

            imgLoc = mc.imgLoc;
            Location = mc.Location;
            quantity = mc.quantity;
            counters = mc.counters;

            _XValue = mc._XValue;

            DeckID = mc.DeckID;
        }

        public void Initialise()
        {
            setMana();
            checkPT();
            ParseText();
        }

        public void checkPT()
        {
            if (PT == "") return;
            string[] parts = PT.Split('/');
            int pOri = PBonus;
            int tOri = TBonus;

            if (parts.Length > 1)
            {
                int.TryParse(parts[0], out _power);
                int.TryParse(parts[1], out _toughness);
            }

            # region cycle through attached cards
            foreach (MagicCard mc in attachedCards)
            {
                List<string> temp = mc.getStats();

                foreach (string s in temp)
                {
                    string[] sPart = s.Split(new string[] { "#" }, StringSplitOptions.None);

                    switch (sPart[0])
                    {
                        case "Power":
                            _power += int.Parse(sPart[1]);
                            break;

                        case "Toughness":
                            _toughness += int.Parse(sPart[1]);
                            break;

                        case "Ability":

                            break;
                    }
                }
            }
            # endregion

            PBonus = counters;
            TBonus = counters;

            //_Power += PBonus;
            //_Toughness += TBonus;

            if (pOri != PBonus || tOri != TBonus)
            {
                CallCountersChanged(0);
            }
        }

        public void setMana()
        {
            manaCost.Clear();
            foreach (char c in Cost)
            {
                if (char.IsNumber(c))
                {
                    manaCost.grey += (int)char.GetNumericValue(c);
                }
                else
                {
                    switch (c)
                    {
                        case 'U':
                            manaCost.blue++;
                            break;

                        case 'R':
                            manaCost.red++;
                            break;

                        case 'G':
                            manaCost.green++;
                            break;

                        case 'W':
                            manaCost.white++;
                            break;

                        case 'B':
                            manaCost.black++;
                            break;

                        case 'X':
                            manaCost.grey += _XValue;
                            break;
                    }
                }
            }
        }

        public void ParseText()
        {
            Abilities.Clear();

            List<string> groups = Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string s in groups)
            {
                CardAbility abi = new CardAbility();

                int i = s.IndexOf(':');

                if (s.Contains(':'))
                {
                    List<string> cost = s.Split(':').ToList();
                    abi.RawCost = cost[0];
                    abi.Text = cost[1];
                }
                else
                {
                    abi.Text = s;
                }
                Abilities.Add(abi);
            }
        }

        # region Image get/set
        public void set(string im)
        {
            if (!File.Exists(im))
            {

            }
            else
            {
                imgLoc = SplitString.convertTo(im);
            }
        }

        public Image get()
        {
            Image img = null;

            string net = SplitString.convertFrom(imgLoc);

            if (net != "" && File.Exists(net)) { img = Image.FromFile(net); }
            else
            {
                img = Properties.Resources.mr224_back;
            }

            return img;
        }
        # endregion

        # region card actions
        public virtual bool Play()
        {
            return false;
        }

        public void UpkeepCard()
        {
            Sick = false;
            Tapped = false;
        }

        public void EndStepCard()
        {
            if (Name == "Protean Hydra")
            {
                counters += countersTurn * 2;
                countersTurn = 0;
            }

            PBonus = 0;
            TBonus = 0;
        }

        public void ChangeTap()
        {
            Tapped = !Tapped;
        }

        public void LocationChanged(CardLocation NewLocation)
        {
            if (NewLocation != CardLocation.Play) this.counters = 0;

            this.Location = NewLocation;

            CallLocationChanged(NewLocation);
        }

        public void Tap(bool value, bool silent)
        {
            if (Tapped != value)
            {
                if (silent)
                {
                    _Tapped = value;
                }
                else
                {
                    Tapped = value;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">The index of the ability to try (0 base)</param>
        /// <returns>Whether the ability can activate</returns>
        public virtual bool TryActivate(int i)
        {
            ParseText();

            bool result = false;

            if (Abilities.Count > i)
            {
                result = true;
            }

            CallActivating(i);

            return result;
        }

        public virtual bool ActivateAbility(int i)
        {
            return false;
        }

        public virtual bool ProcEndTurn() { return false; }

        public virtual bool CreatureEntered(MagicCard mc) { return false; }

        public virtual bool Evolve(int p, int t)
        {
            checkPT();

            if (Text.Contains("Evolve"))
            {
                if (p > PowerCalc || t > ToughnessCalc)
                {
                    counters++;
                    CallEvolve(0);
                    return true;
                }
            }

            return false;
        }

        public virtual void Attack()
        {
            CallOnAttack(0);
        }

        /// <summary>
        /// Returns a List<string> of all the enchancements that the card provides when attached
        /// </summary>
        /// <returns>The enhancements it provides when attached to another card</returns>
        public List<string> getStats()
        {
            List<string> result = new List<string>();

            if (Name == "Rancor")
            {
                result.Add("Power#2");
                result.Add("Toughness#0");
                result.Add("Ability#Trample");
            }

            return result;
        }
        # endregion

        public override string ToString()
        {
            return $"{Name} {quantity} {Location}";
        }

        # region toListViewItem
        public ListViewItem ToListViewItem()
        {
            ListViewItem result = new ListViewItem(Name);
            if (Token)
            {
                result.Name += " (" + quantity + ")";
            }
            result.ImageKey = Name.ToUpper();

            result.SubItems.Add(quantity.ToString());
            result.SubItems.Add(Edition);
            result.SubItems.Add(Rarity);
            result.SubItems.Add(Color);
            result.SubItems.Add(Cost);
            result.SubItems.Add(PT);
            result.SubItems.Add(Type);
            result.SubItems.Add(Text);
            result.SubItems.Add(Flavor);
            result.Tag = DeckID;

            return result;
        }

        public ListViewItem ToListViewItem(bool alt)
        {
            if (Token)
            {
                alt = Token;
            }
            ListViewItem result;
            if (alt)
            {
                checkPT();
                result = new ListViewItem(Name + " (" + PowerCalc.ToString() + "/" + ToughnessCalc.ToString() + ")" + " (" + counters.ToString() + ")");
            }
            else
            {
                result = new ListViewItem(Name + " (" + quantity.ToString() + ")");
            }

            result.ImageKey = Name.ToUpper();

            result.SubItems.Add(quantity.ToString());
            result.SubItems.Add(Edition);
            result.SubItems.Add(Rarity);
            result.SubItems.Add(Color);
            result.SubItems.Add(Cost);
            result.SubItems.Add(PT);
            result.SubItems.Add(Type);
            result.SubItems.Add(Text);
            result.SubItems.Add(Flavor);
            result.Tag = DeckID;

            return result;
        }
        # endregion

        # region cloning/copying/comparing
        public object Clone() { return this.MemberwiseClone(); }

        public MagicCard Copy()
        {
            return Clone() as MagicCard;
        }

        public bool CompareCard(MagicCard card)
        {
            bool result = true;
            checkPT();

            if (Name != card.Name) { result = false; }

            if (PowerCalc != card.PowerCalc) { result = false; }
            if (ToughnessCalc != card.ToughnessCalc) { result = false; }
            if (Tapped != card.Tapped) { result = false; }
            if (attachedCards.Count > 0 || card.attachedCards.Count > 0) { result = false; }
            if (counters != card.counters) { result = false; }

            return result;
        }
        # endregion
        # endregion
    }

    #region Creatures
    public class Crocanura : MagicCard
    {
        public Crocanura()
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Evolve#(Whenever a creature enters the battlefield under your control, if that creature has greater power or toughness than this creature, put a +1/+1 counter on this creature.);"
            };

            AbilityEvolve = true;
            Abilities.Add(abi1);
        }

        public Crocanura(MagicCard mc) : base(mc)
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Evolve#(Whenever a creature enters the battlefield under your control, if that creature has greater power or toughness than this creature, put a +1/+1 counter on this creature.);"
            };

            AbilityEvolve = true;
            Abilities.Add(abi1);
        }

        public override bool CreatureEntered(MagicCard mc)
        {
            Evolve(mc.PowerCalc, mc.ToughnessCalc);
            return true;
        }

    }

    public class GyreSage : MagicCard
    {
        public GyreSage()
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Evolve#(Whenever a creature enters the battlefield under your control, if that creature has greater power or toughness than this creature, put a +1/+1 counter on this creature.);"
            };
            var abi2 = new CardAbility
            {
                RawCost = "%T",
                Text = "Add %G to your mana pool for each +1/+1 counter on Gyre Sage."
            };

            AbilityActivate = true;
            AbilityEvolve = true;
            Abilities.Add(abi1);
            Abilities.Add(abi2);
        }

        public GyreSage(MagicCard mc) : base(mc)
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Evolve#(Whenever a creature enters the battlefield under your control, if that creature has greater power or toughness than this creature, put a +1/+1 counter on this creature.);"
            };
            var abi2 = new CardAbility
            {
                RawCost = "%T",
                Text = "Add %G to your mana pool for each +1/+1 counter on Gyre Sage."
            };

            AbilityActivate = true;
            AbilityEvolve = true;
            Abilities.Add(abi1);
            Abilities.Add(abi2);
        }

        public override bool TryActivate(int i)
        {
            return base.TryActivate(i);
        }

        public override bool CreatureEntered(MagicCard mc)
        {
            Evolve(mc.PowerCalc, mc.ToughnessCalc);
            return true;
        }

        public override bool ActivateAbility(int i)
        {
            if (Abilities.Count < i) return false;

            switch (i)
            {
                case 0: counters++; return true;
                case 1:
                    ColourCost addMana = new ColourCost { green = counters };
                    CallManaChanged(addMana);
                    return true;
            }

            return true;
        }
    }

    public class CloudfinRaptor : MagicCard
    {
        public CloudfinRaptor()
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Evolve#(Whenever a creature enters the battlefield under your control, if that creature has greater power or toughness than this creature, put a +1/+1 counter on this creature.);"
            };

            AbilityEvolve = true;
            Abilities.Add(abi1);
        }

        public CloudfinRaptor(MagicCard mc)
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Evolve#(Whenever a creature enters the battlefield under your control, if that creature has greater power or toughness than this creature, put a +1/+1 counter on this creature.);"
            };

            AbilityEvolve = true;
            Abilities.Add(abi1);
        }

        public override bool CreatureEntered(MagicCard mc)
        {
            Evolve(mc.PowerCalc, mc.ToughnessCalc);
            return true;
        }

        public override bool ActivateAbility(int i)
        {
            if (Abilities.Count < i) return false;

            switch (i)
            {
                case 0: counters++; return true;
            }

            return true;
        }
    }

    public class Fertilid : MagicCard
    {
        public Fertilid()
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Fertilid enters the battlefield with two +1/+1 counters on it."
            };
            counters = 2;

            var abi2 = new CardAbility
            {
                RawCost = "%1%G, Remove a +1/+1 counter from Fertilid",
                Text = "Target player searches his or her library for a basic land card and puts it onto the battlefield tapped. Then that player shuffles his or her library."
            };

            AbilityActivate = true;
            AbilitySearch = true;
            Abilities.Add(abi1);
            Abilities.Add(abi2);
        }

        public Fertilid(MagicCard mc) : base(mc)
        {
            var abi1 = new CardAbility
            {
                RawCost = "",
                Text = "Fertilid enters the battlefield with two +1/+1 counters on it."
            };
            counters = 2;

            var abi2 = new CardAbility
            {
                RawCost = "%1%G, Remove a +1/+1 counter from Fertilid",
                Text = "Target player searches his or her library for a basic land card and puts it onto the battlefield tapped. Then that player shuffles his or her library."
            };

            AbilityActivate = true;
            AbilitySearch = true;
            Abilities.Add(abi1);
            Abilities.Add(abi2);
        }

        public override bool TryActivate(int i)
        {
            // Probably not needed any more
            ParseText();

            bool result = false;

            if (Abilities.Count > i
                && counters > 0)
            {
                result = true;
            }

            return base.TryActivate(i);


        }

        public override bool ActivateAbility(int i)
        {
            if (i == 0) return false;
            counters--;
            CallSearchArea("Library", "Basic Land", -1, 1);
            return true;
        }
    }

    public class KalonianHydra : MagicCard
    {
        public KalonianHydra()
        {
            counters = 4;
        }

        public KalonianHydra(MagicCard mc) : base(mc)
        {
            counters = 4;
        }
    }

    public class ZameckGuildmage : MagicCard
    {
        public bool AddCounters = false;

        public ZameckGuildmage()
        {
            var abi1 = new CardAbility
            {
                RawCost = "%G%U",
                Text = "This turn, each creature you control enters the battlefield with an additional +1/+1 counter on it."
            };
            var abi2 = new CardAbility
            {
                RawCost = "%G%U, Remove a +1/+1 counter from a creature you control",
                Text = "Draw a card."
            };

            AbilityActivate = true;
            Abilities.Add(abi1);
            Abilities.Add(abi2);
        }

        public ZameckGuildmage(MagicCard mc) : base(mc)
        {
            var abi1 = new CardAbility
            {
                RawCost = "%G%U",
                Text = "This turn, each creature you control enters the battlefield with an additional +1/+1 counter on it."
            };
            var abi2 = new CardAbility
            {
                RawCost = "%G%U, Remove a +1/+1 counter from a creature you control",
                Text = "Draw a card."
            };

            AbilityActivate = true;
            Abilities.Add(abi1);
            Abilities.Add(abi2);
        }

        public override bool ActivateAbility(int i)
        {
            if (i == 0) return AddCounters = true;

            return false;
        }

        public override bool ProcEndTurn()
        {
            AddCounters = false;
            return true;
        }

        public override bool CreatureEntered(MagicCard mc)
        {
            mc.counters += AddCounters ? 1 : 0;

            return base.CreatureEntered(mc);
        }


    }

    public class Ooze : MagicCard
    {
        public Ooze() { }

        public Ooze(MagicCard mc) : base(mc)
        {
            Token = true;
            Name = "Ooze";
            Type = "Creature - Ooze";
            PT = $"0/0";
        }
    }
    #endregion

    #region Instants
    public class Ponder : MagicCard
    {
        public Ponder() { OnPlay += Ponder_OnPlay; AbilitySearch = true; }

        public Ponder(MagicCard mc) : base(mc) { OnPlay += Ponder_OnPlay; AbilitySearch = true; }

        private void Ponder_OnPlay(MagicCard mc)
        {
            CallSearchArea("Library", "", 3, 1);
        }
    }
    #endregion
    #endregion

    public class MRUList
    {
        [XmlElement("mru")]
        public List<string> _docs = new List<string>();

        public void add(string s)
        {
            List<string> temp = new List<string>();
            string netPath = SplitString.convertTo(s);

            if (_docs.Contains(netPath))
            {
                int i = _docs.IndexOf(netPath);
                _docs.RemoveAt(i);          //remove string from old list.
            }

            temp.Add(netPath);                    //add string to first position.

            foreach (string old in _docs)
                temp.Add(old);

            _docs = temp;                   //confirm changes.            
        }

        public List<string> get()
        {
            return _docs;
        }

        public string get(int i)
        {
            string result = "";

            if (-1 < i && i < _docs.Count)  //i is between 0 & last entry
                result = _docs[i];

            result = SplitString.convertTo(result);

            return result;
        }
    }

    public class SplitString
    {
        public static string[] splitSafe(string s, char Seperator, char Qualifier)
        {
            string[] result;
            bool Text = false;
            List<string> arrTemp = new List<string>();

            //add initial placeholder
            arrTemp.Add("");

            for (int i = 0; i < s.Length; i++)
            {
                char temp = s[i];

                if (temp == Seperator && !Text) { arrTemp.Add(""); }    //start new string

                else
                {
                    if (temp == Qualifier) { Text = !Text; }

                    else { arrTemp[arrTemp.Count - 1] += temp; }
                }
            }

            result = new string[arrTemp.Count];

            arrTemp.CopyTo(result);

            return result;
        }

        public static List<string[]> split_number(string[] s, int count)
        {
            List<string[]> result = new List<string[]>();

            string[] temp = new string[count];
            int j = 0;


            for (int i = 0; i < s.Length; i++)
            {
                if (j == count)
                {
                    result.Add(temp);
                    temp = new string[count];
                    j = 0;
                }

                temp[j] = s[i];
                j++;
            }

            return result;
        }

        //public static string convertManaToRtf(string s)
        //{
        //    using (RichTextBox rtb = new RichTextBox())
        //    {
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            rtb.Font = new Font("WingDings 2", 11, FontStyle.Regular);

        //            rtb.Select(rtb.Text.Length, 0);
        //            string ch = s[i].ToString();

        //            switch (s[i])
        //            {
        //                # region colours
        //                case 'G':
        //                    rtb.SelectionColor = Color.Green;
        //                    ch = "u";
        //                    break;

        //                case 'U':
        //                    rtb.SelectionColor = Color.Blue;
        //                    ch = "u";
        //                    break;

        //                case 'R':
        //                    rtb.SelectionColor = Color.Red;
        //                    ch = "u";
        //                    break;

        //                case 'W':
        //                    rtb.SelectionColor = Color.White;
        //                    ch = "u";
        //                    break;

        //                case 'B':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "j";
        //                    break;

        //                case '/':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = " ";
        //                    break;
        //                # endregion

        //                # region numbers
        //                case '1':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "u";
        //                    break;

        //                case '2':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "v";
        //                    break;

        //                case '3':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "w";
        //                    break;

        //                case '4':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "x";
        //                    break;

        //                case '5':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "y";
        //                    break;

        //                case '6':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "z";
        //                    break;

        //                case '7':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "{";
        //                    break;

        //                case '8':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "|";
        //                    break;

        //                case '9':
        //                    rtb.SelectionColor = Color.Black;
        //                    ch = "}";
        //                    break;
        //                # endregion

        //                default:
        //                    rtb.SelectionColor = Color.Black;
        //                    Output.Write("{0}", s[i]);
        //                    break;
        //            }

        //            rtb.AppendText(ch);
        //        }

        //        return rtb.Rtf;
        //    }
        //}

        #region convert paths to/from relative
        public static string convertTo(string s)
        {
            string result = s;
            string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            s = s.Replace(userDir, "~");

            return s;
        }

        public static string convertFrom(string s)
        {
            string result = s;
            string userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            s = s.Replace("~", userDir);

            return s;
        }
        #endregion
    }

    public static class Output
    {
        public static Stopwatch sw = new Stopwatch();

        public static void Write(string s, params object[] args)
        {
            string result = s;

            int c = args.Length;

            for (int i = 0; i < c; i++)
            {
                result = result.Replace("{" + i + "}", args[i].ToString());
            }
        }
    }

    public class MagicImage
    {
        #region set up colours
        private static Image white = Properties.Resources.W;
        private static Image red = Properties.Resources.R;
        private static Image blue = Properties.Resources.U;
        private static Image green = Properties.Resources.G;
        private static Image black = Properties.Resources.B;

        private static Image zero = Properties.Resources._0;
        private static Image one = Properties.Resources._1;
        private static Image two = Properties.Resources._2;
        private static Image three = Properties.Resources._3;
        private static Image four = Properties.Resources._4;
        private static Image five = Properties.Resources._5;
        private static Image six = Properties.Resources._6;
        private static Image seven = Properties.Resources._7;
        private static Image _X = Properties.Resources.X;
        #endregion

        public static Image FromString(string s)
        {
            if (s.Length <= 0)
            {
                return null;
            }

            string adjusted = s.Replace("%", "").ToUpper();

            int x = adjusted.Length * 16;
            Image result = new Bitmap(x, 16);   //16x16 for each character


            using (Graphics g = Graphics.FromImage(result))
            {
                for (int i = 0; i < adjusted.Length; i++)
                {
                    Rectangle rect = new Rectangle(i * 16, 0, 16, 16);

                    Char c = adjusted[i];

                    #region switch (c)
                    switch (c)
                    {
                        #region base mana
                        case 'U':
                            g.DrawImage(blue, rect);
                            break;

                        case 'B':
                            g.DrawImage(black, rect);
                            break;

                        case 'R':
                            g.DrawImage(red, rect);
                            break;

                        case 'W':
                            g.DrawImage(white, rect);
                            break;

                        case 'G':
                            g.DrawImage(green, rect);
                            break;
                        #endregion

                        #region hybrid
                        case 'P':
                            g.DrawImage(Properties.Resources.P, rect);
                            break;

                        case 'A':
                            g.DrawImage(Properties.Resources.A, rect);
                            break;

                        case 'L':
                            g.DrawImage(Properties.Resources.L, rect);
                            break;

                        case 'D':
                            g.DrawImage(Properties.Resources.D, rect);
                            break;

                        case 'O':
                            g.DrawImage(Properties.Resources.O, rect);
                            break;

                        case 'Q':
                            g.DrawImage(Properties.Resources.Q, rect);
                            break;

                        case 'V':
                            g.DrawImage(Properties.Resources.V, rect);
                            break;

                        case 'S':
                            g.DrawImage(Properties.Resources.S, rect);
                            break;

                        case 'K':
                            g.DrawImage(Properties.Resources.K, rect);
                            break;

                        case 'I':
                            g.DrawImage(Properties.Resources.I, rect);
                            break;
                        #endregion

                        #region numbers
                        case '0':
                            g.DrawImage(zero, rect);
                            break;

                        case '1':
                            g.DrawImage(one, rect);
                            break;

                        case '2':
                            g.DrawImage(two, rect);
                            break;

                        case '3':
                            g.DrawImage(three, rect);
                            break;

                        case '4':
                            g.DrawImage(four, rect);
                            break;

                        case '5':
                            g.DrawImage(five, rect);
                            break;

                        case '6':
                            g.DrawImage(six, rect);
                            break;

                        case '7':
                            g.DrawImage(seven, rect);
                            break;

                        case '8':
                            g.DrawString(c.ToString(), new Font("WingDings 2", 11, FontStyle.Regular), new SolidBrush(Color.Gray), rect);
                            break;

                        case '9':
                            g.DrawString(c.ToString(), new Font("WingDings 2", 11, FontStyle.Regular), new SolidBrush(Color.Gray), rect);
                            break;

                        case 'X':
                            g.DrawImage(_X, rect);
                            break;
                        #endregion

                        default:
                            Output.Write("Invalid Character {0}", c);
                            break;
                    }
                    #endregion
                }
            }

            Output.Write("{0}, {1}", result.Width, result.Height);

            return result;
        }
    }

    public class ColourCost
    {
        public delegate void Action();
        public event Action ManaChanged;

        protected void onManaChanged()
        {
            Action handler = ManaChanged;
            if (handler != null)
            {
                handler();
            }
        }

        #region mana
        #region internal values
        private int _blue = 0;
        private int _green = 0;
        private int _black = 0;
        private int _white = 0;
        private int _red = 0;
        private int _grey = 0;
        #endregion

        #region public values
        public int blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                onManaChanged();
            }
        }

        public int black
        {
            get
            {
                return _black;
            }
            set
            {
                _black = value;
                onManaChanged();
            }
        }

        public int green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                onManaChanged();
            }
        }

        public int red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                onManaChanged();
            }
        }

        public int white
        {
            get
            {
                return _white;
            }
            set
            {
                _white = value;
                onManaChanged();
            }
        }

        public int grey
        {
            get
            {
                return _grey;
            }
            set
            {
                _grey = value;
                onManaChanged();
            }
        }

        #endregion

        public int Colourless
        {
            get
            {
                int i = blue + black + green + red + white + grey;

                return i;
            }
        }

        public int Colours
        {
            get
            {
                return blue + green + black + red + white;
            }
        }

        public bool MatchMana(string s)
        {
            if (blue > 0 && !s.Contains("U")) return false;
            if (black > 0 && !s.Contains("B")) return false;
            if (green > 0 && !s.Contains("G")) return false;
            if (red > 0 && !s.Contains("R")) return false;
            if (white > 0 && !s.Contains("W")) return false;

            return true;
        }
        #endregion

        public void Clear()
        {
            blue = 0;
            green = 0;
            black = 0;
            white = 0;
            red = 0;
            grey = 0;
        }

        public void ParseString(string s)
        {

        }

        public override string ToString()
        {
            string s = "";

            s += new string('u', blue);
            s += new string('g', green);
            s += new string('r', red);
            s += new string('b', black);
            s += new string('w', white);
            s += new string('g', grey);

            return s;
        }

        #region Math
        public void Add(ColourCost cc)
        {
            blue += cc.blue;
            black += cc.black;
            green += cc.green;
            red += cc.red;
            white += cc.white;
            grey += cc.grey;

            blue = blue < 0 ? 0 : blue;
            black = black < 0 ? 0 : black;
            green = green < 0 ? 0 : green;
            red = red < 0 ? 0 : red;
            white = white < 0 ? 0 : white;
            grey = grey < 0 ? 0 : grey;
        }

        public void Subtract(ColourCost cc)
        {
            _blue -= cc.blue;
            _black -= cc.black;
            _green -= cc.green;
            _red -= cc.red;
            _white -= cc.white;

            int cless = cc.grey;

            for (int i = 0; cless > 0 && _green > 0; i++)
            {
                cless--;
                _green--;
            }
            for (int i = 0; cless > 0 && _blue > 0; i++)
            {
                cless--;
                _blue--;
            }
            for (int i = 0; cless > 0 && _red > 0; i++)
            {
                cless--;
                _red--;
            }
            for (int i = 0; cless > 0 && _white > 0; i++)
            {
                cless--;
                _white--;
            }
            for (int i = 0; cless > 0 && _black > 0; i++)
            {
                cless--;
                _black--;
            }
        }

        public bool Compare(ColourCost cc)
        {
            bool result = true;

            if (cc.blue > blue) { result = false; }
            if (cc.black > black) { result = false; }
            if (cc.red > red) { result = false; }
            if (cc.green > green) { result = false; }
            if (cc.white > white) { result = false; }

            int g = Colourless - cc.Colours;

            if (cc.grey > g) { result = false; }

            return result;
        }
        #endregion
    }

    public class CardMethods
    {
        private static int _cardID = 100;
        public static int CardID
        {
            get
            {
                _cardID++;
                return _cardID;
            }
        }

        public static List<MagicCard> SplitCardList(List<MagicCard> List)
        {
            List<MagicCard> results = new List<MagicCard>();

            foreach (MagicCard mc in List)
            {
                for (int i = 0; i < mc.quantity; i++)
                {
                    MagicCard nmc = mc.Copy();
                    nmc.quantity = 1;
                    results.Add(nmc);
                }
            }

            return results;
        }

        public static MagicCard CreateCard(MagicCard mc)
        {
            switch (mc.Name)
            {
                case "Gyre Sage": return new GyreSage(mc) {DeckID =CardID };
                case "Fertilid": return new Fertilid(mc) { DeckID = CardID };
                case "Kalonian Hydra": return new KalonianHydra(mc) { DeckID = CardID };
                case "Crocanura": return new Crocanura(mc) { DeckID = CardID };
                case "Zameck Guildmage": return new ZameckGuildmage(mc) { DeckID = CardID };
                case "Ponder": return new Ponder(mc) { DeckID = CardID };
                case "Ooze": return new Ooze(mc) { DeckID = CardID };
            }

            return new MagicCard(mc) { DeckID = CardID };
        }
        public static MagicCard CreateCard(string name)
        {
            switch (name)
            {
                case "Gyre Sage": return new GyreSage() { DeckID = CardID };
                case "Fertilid": return new Fertilid() { DeckID = CardID };
                case "Kalonian Hydra": return new KalonianHydra() { DeckID = CardID };
                case "Crocanura": return new Crocanura() { DeckID = CardID };
                case "Zameck Guildmage": return new ZameckGuildmage() { DeckID = CardID };
                case "Ponder": return new Ponder() { DeckID = CardID };
                case "Ooze": return new Ooze() { DeckID = CardID };
            }

            return new MagicCard
            {
                Name = "Arbor Elf",
                Edition = "M13",
                Rarity = "C",
                Color = "G",
                Cost = "G",
                PT = "1/1",
                Type = "Creature",
                Text = "%t: Untap target Forest.",
                Flavor = "",
                imgLoc = "~\\Downloads\\Magic Cards\\M13\\Arbor Elf.jpg",
                Location = CardLocation.Exiled,
                Tapped = false,
                DeckID = CardID
            };
        }
    }

    public class CardAbility
    {
        public ColourCost Cost
        {
            get
            {
                ColourCost c = new ColourCost();

                string adj = RawCost.Replace(",", "").Replace(" ", "");
                List<string> colours = adj.Split(new string[] { "%" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                foreach (string s in colours)
                {
                    switch (s)
                    {
                        case "U":
                            c.blue++;
                            break;

                        case "R":
                            c.red++;
                            break;

                        case "G":
                            c.green++;
                            break;

                        case "W":
                            c.white++;
                            break;

                        case "B":
                            c.black++;
                            break;
                    }
                }

                return c;
            }
        }
        public string RawCost = "";
        public string Text = "";

    }

    public enum CSize
    {
        vSmall,
        Small,
        Normal,
        Large,
        vLarge
    };


    public enum CardLocation
    {
        Deck,
        Library,
        Graveyard,
        Hand,
        Exiled,
        Play,
        Lands,
        Enchantments,
        Artifacts
    }
}
