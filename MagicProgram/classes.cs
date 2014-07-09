using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

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

        public MagicCard getCard(string s)
        {
            if (link.ContainsKey(s.ToUpper()))
            {
                int j = link[s.ToUpper()];
                return cards[j];
            }
            else
            {
                return new MagicCard { Name = "Blank" };
            }
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
            index();

            return result;
        }

        /// <summary>
        /// Remove a card from the collection
        /// </summary>
        /// <param name="card">The card to remove if it's in the collection</param>
        /// <returns>Whether card was in collection</returns>
        public int Remove(MagicCard card)
        {
            int result = cards.FindIndex(o => o == card);

            if (result > -1)
            {
                cards.Remove(card);
                callCardRemoved(card);
            }

            return result;
        }

        public void Clear()
        {
            cards.Clear();
            link.Clear();
        }
    }

    public class MagicCard : ICloneable
    {
        # region declarations
        # region Fields
        //"Name";"Edition";"Rarity";"Color";"Cost";"P/T";"Type";"Text";"Flavor"
        # region Card parts
        public string Name = "";
        public string Edition = "";
        public string Rarity = "";
        public string Color = "";
        public string Cost = "";
        public string PT = "";
        public string Type = "Creature";
        public string Text = "";
        public string Flavor = "";
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
                callTapChanged();
            }
        }

        [XmlIgnore]
        public bool Sick = false;
        # endregion

        [XmlIgnore]
        public int Xvalue = 0;

        [XmlIgnore]
        public bool Attacking = false;

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
        public int Power = 0;
        [XmlIgnore]
        public int Toughness = 0;
        [XmlIgnore]
        public string imgLoc = "";

        # region Spell variables
        [XmlIgnore]
        public int Targets = 0;
        [XmlIgnore]
        public int AbilityIndex = 0;
        [XmlIgnore]
        public int AdditionalCost = 1;
        # endregion

        [XmlIgnore]
        public int PBonus = 0;  //temp bonus
        [XmlIgnore]
        public int TBonus = 0;  //temp bonus

        private int countersTurn = 0;
        [XmlIgnore]
        private int _counters = 0;
        public int counters
        {
            get { return _counters; }
            set
            {
                int change = value - _counters;
                _counters = value;
                if (value < _counters && Name == "Protean Hydra")
                {
                    countersTurn -= change;
                }
                checkPT();
                callCountersChanged(change);
            }
        }
        # endregion

        public int quantity = 1;

        [XmlIgnore]
        public List<MagicCard> attachedCards = new List<MagicCard>();
        [XmlIgnore]
        public MagicCard Parent = null;

        [XmlIgnore]
        public PlayArea PArea
        {
            get { return _pArea; }
            set
            {
                _pArea = value;
            }
        }
        private PlayArea _pArea = null;

        [XmlIgnore]
        public string Location = "Library";

        //[XmlIgnore]
        public List<CardAbility> Abilities = new List<CardAbility>();
        # endregion

        # region handlers
        # region delegates/events
        public delegate void ActiveAbility(MagicCard mc, int index);  //index of ability being used. 0 based.
        public delegate void PassiveEvent(MagicCard mc);

        public event ActiveAbility Activate;
        public event ActiveAbility Activating;
        public event PassiveEvent Evolving;
        public event PassiveEvent OnUpkeep;
        public event PassiveEvent OnAttack;
        public event PassiveEvent OnEquip;
        public event PassiveEvent OnUnequip;
        public event PassiveEvent onEquipmentAdd;
        public event PassiveEvent onEquipmentRemoved;
        public event PassiveEvent onSpellCast;
        public event PassiveEvent onDie;
        public event ValueChanged CountersChanged;
        public event CardUse TapChanged;
        public event CardUse Discard;
        public event CardUse Destroyed;
        public event CardUse PrePlay;
        public event CardUse OnPlay;
        public event CardUse Resolving;
        public event Action StatsChanged;
        # endregion

        # region event trigger methods
        public void callResolving()
        {
            CardUse handler = Resolving;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnUpkeep()
        {
            PassiveEvent handler = OnUpkeep;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callDie()
        {
            PassiveEvent handler = onDie;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callActivate(int index)
        {
            ActiveAbility handler = Activate;
            if (handler != null)
            {
                handler(this, index);
            }
        }

        private void callActivating(int index)
        {
            ActiveAbility handler = Activating;
            if (handler != null)
            {
                handler(this, index);
            }
        }

        public void callEvolve()
        {
            PassiveEvent handler = Evolving;

            if (handler != null)
            {
                handler(this);
            }
        }

        public void callAbility(int index)
        {
            ActiveAbility handler = Activate;
            if (handler != null)
            {
                handler(this, index);
            }
        }

        public void callSpellCast()
        {
            PassiveEvent handler = onSpellCast;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnEquipmentAdd()
        {
            PassiveEvent handler = onEquipmentAdd;
            if (handler != null)
            {
                handler(this);
            }
        }

        private void callOnEquipmentRemoved(MagicCard mc)
        {
            PassiveEvent handler = onEquipmentRemoved;
            if (handler != null)
            {
                handler(mc);
            }
        }

        public void callOnEquip()
        {
            PassiveEvent handler = OnEquip;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnUnequip()
        {
            PassiveEvent handler = OnUnequip;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnAttack()
        {
            PassiveEvent handler = OnAttack;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callTapChanged()
        {
            CardUse handler = TapChanged;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callDiscard()
        {
            CardUse handler = Discard;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callDestroyed()
        {
            CardUse handler = Destroyed;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callCountersChanged(int count)
        {
            ValueChanged handler = CountersChanged;
            if (handler != null)
            {
                handler(count);
            }
        }

        public void callPrePlay()
        {
            CardUse handler = PrePlay;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callOnPlay()
        {
            CardUse handler = OnPlay;
            if (handler != null)
            {
                handler(this);
            }
        }

        public void callStatsChanged()
        {
            Action handler = StatsChanged;
            if (handler != null)
            {
                handler();
            }
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

            Power = mc.Power;
            Toughness = mc.Toughness;

            imgLoc = mc.imgLoc;

            quantity = mc.quantity;
            //counters = mc.counters;

            Xvalue = mc.Xvalue;
        }

        public void Initialise()
        {
            attachedCards.Clear();
            setMana();
            checkPT();
            ParseText();
        }
        
        public void checkPT()
        {
            string[] parts = PT.Split('/');
            int pOri = Power;
            int tOri = Toughness;

            if (parts.Length > 1)
            {
                int.TryParse(parts[0], out Power);
                int.TryParse(parts[1], out Toughness);
            }

            switch (Name)
            {
                case "Crusader of Odric":
                    if (PArea != null)
                    {
                        Power = PArea._play.cards.Count;
                        Toughness = PArea._play.cards.Count;
                    }
                    break;

                case "Eidolon of Countless Battles":
                    if (PArea != null)
                    {
                        Power = PArea._play.cards.Count;
                        Toughness = PArea._play.cards.Count;
                    }
                    break;
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
                            Power += int.Parse(sPart[1]);
                            break;

                        case "Toughness":
                            Toughness += int.Parse(sPart[1]);
                            break;

                        case "Ability":

                            break;
                    }
                }
            }
            # endregion

            Power += counters;
            Toughness += counters;

            Power += PBonus;
            Toughness += TBonus;

            if (pOri != Power || tOri != Toughness)
            {
                callCountersChanged(0);
            }
        }

        public void setMana()
        {
            manaCost.Clear();
            foreach (char c in Cost)
            {
                # region colourless
                if (char.IsNumber(c))
                {
                    manaCost.grey += (int)char.GetNumericValue(c);
                }
                # endregion
                # region basic mana types
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
                            manaCost.grey += Xvalue;
                            break;
                    }
                }
                # endregion
            }
        }

        public void ParseText()
        {
            Abilities.Clear();

            List<string> groups = Text.Split(new string[] { "\r", "\n" }, StringSplitOptions.None).ToList();

            foreach (string s in groups)
            {
                int i = s.IndexOf(':');

                if (s.Contains(':'))
                {
                    List<string> cost = s.Split(':').ToList();
                    CardAbility abi = new CardAbility();
                    abi.RawCost = cost[0];
                    abi.Text = cost[1];
                    Abilities.Add(abi);
                }

                if (s.Contains("Bestow"))
                {
                    string[] tCost = Text.Split('(');
                    CardAbility abi = new CardAbility();
                    abi.RawCost = tCost[0].Replace("Bestow ", "");
                    abi.Text = tCost[1].Trim();
                    abi.Name = "Bestow";
                    Abilities.Add(abi);
                }
            }
        }

        public void AttachCard(MagicCard mc)
        {
            attachedCards.Add(mc);
            mc.Parent = this;
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
        public void UpkeepCard()
        {
            callOnUpkeep();
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

        # region equipment
        public void AddEquipment(MagicCard mc)
        {
            attachedCards.Add(mc);
            mc.Parent = this;
            callOnEquipmentAdd();
            mc.OnEquip += new PassiveEvent(RemoveEquipment);
        }

        public void RemoveEquipment(MagicCard mc)
        {
            attachedCards.Remove(mc);
            mc.callOnUnequip();

            if (mc.Parent == this)
            {
                mc.Parent = null;
            }

            callOnEquipmentRemoved(mc);
            mc.onEquipmentRemoved -= RemoveEquipment;
        }
        # endregion

        internal void Resolve()
        {
            callResolving();
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
        public bool TryActivate(int i)
        {
            ParseText();

            bool result = false;

            if (Abilities.Count > i)
            {
                result = true;
            }

            callActivating(i);

            return result;
        }

        public virtual void Evolve(int p, int t)
        {
            checkPT();

            if (Text.Contains("Evolve"))
            {
                if (p > Power || t > Toughness)
                {
                    counters++;
                    callEvolve();
                }
            }
        }

        public virtual void Attack()
        {
            callOnAttack();
        }

        /// <summary>
        /// Returns a string list of all the enchancements that the card provides when attached
        /// </summary>
        /// <returns>The enhancements it provides when attached to another card</returns>
        public List<string> getStats()
        {
            List<string> result = new List<string>();

            switch (Name)
            {
                case "Rancor":
                    result.Add("Power#2");
                    result.Add("Toughness#0");
                    result.Add("Ability#Trample");
                    break;

                case "Mogis's Warhound":
                    result.Add("Power#2");
                    result.Add("Toughness#2");
                    result.Add("Ability#Must Attack");
                    break;

                case "Favor of the Overbeing":
                    if (Parent.Cost.Contains("U"))
                    {
                        result.Add("Power#1");
                        result.Add("Toughness#1");
                        result.Add("Ability#Flying");
                    }
                    if (Parent.Cost.Contains("G"))
                    {
                        result.Add("Power#1");
                        result.Add("Toughness#1");
                        result.Add("Ability#Vigilance");
                    }
                    break;
            }

            return result;
        }
        # endregion

        # region triggers
        public void LifeChanged(int i)
        {
            if (i > 0)
            {
                //hp increase
                if (Name == "Ajani's Pridemate")
                {
                    counters++;
                }
            }
            else if (i < 0)
            {
                //hp decrease

            }
            else
            {
                //no change

            }
        }
        # endregion

        public override string ToString()
        {
            return Name + " " + quantity;
        }

        # region toListViewItem
        public ListViewItem toListViewItem()
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

            return result;
        }

        public ListViewItem toListViewItem(bool alt)
        {
            if (Token)
            {
                alt = Token;
            }
            ListViewItem result;
            if (alt)
            {
                checkPT();
                result = new ListViewItem(Name + " (" + Power.ToString() + "/" + Toughness.ToString() + ")" + " (" + counters.ToString() + ")");
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
            //if (Edition != card.Edition) { result = false; }
            //if (Rarity != card.Rarity) { result = false; }
            //if (Color != card.Color) { result = false; }
            //if (Cost != card.Cost) { result = false; }
            //if (PT != card.PT) { result = false; }
            //if (Type != card.Type) { result = false; }
            //if (Text != card.Text) { result = false; }
            //if (Flavor != card.Flavor) { result = false; }

            if (Power != card.Power) { result = false; }
            if (Toughness != card.Toughness) { result = false; }
            if (Tapped != card.Tapped) { result = false; }
            if (attachedCards.Count > 0 || card.attachedCards.Count > 0) { result = false; }
            if (counters != card.counters) { result = false; }

            return result;
        }
        # endregion
        # endregion
    }

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

        public static ColourCost textToMana(string cost)
        {
            ColourCost result = new ColourCost();

            int t = cost.IndexOf('{');

            string trimmed = cost.Substring(t, cost.Length - t);
            trimmed = trimmed.Replace("{", "").Replace("}", "");

            foreach (char c in trimmed)
            {
                # region numbers
                if (char.IsNumber(c))
                {
                    int n = 0;
                    int.TryParse(c.ToString(), out n);
                    result.grey += n;
                }
                # endregion
                # region colours
                else
                {
                    switch (c)
                    {
                        case 'B':
                            result.black++;
                            break;

                        case 'G':
                            result.green++;
                            break;

                        case 'R':
                            result.red++;
                            break;

                        case 'U':
                            result.blue++;
                            break;

                        case 'W':
                            result.white++;
                            break;

                        default:
                            break;
                    }
                }
                # endregion
            }

            return result;
        }

        # region convert paths to/from relative
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
        # endregion
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
        # region set up colours
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
        # endregion

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

                    # region switch (c)
                    switch (c)
                    {
                        # region base mana
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
                        # endregion

                        # region hybrid
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
                        # endregion

                        # region numbers
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
                        # endregion

                        default:
                            Output.Write("Invalid Character {0}", c);
                            break;
                    }
                    # endregion
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

        # region mana
        # region internal values
        public int _blue = 0;
        public int _green = 0;
        public int _black = 0;
        public int _white = 0;
        public int _red = 0;
        public int _grey = 0;
        # endregion

        # region public values
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
        # endregion

        public int colourless
        {
            get
            {
                int i = blue + black + green + red + white + grey;

                return i;
            }
        }
        public int colours
        {
            get
            {
                return blue + green + black + red + white;
            }
        }
        # endregion

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

        # region Math
        public void Add(ColourCost cc)
        {
            blue += cc.blue;
            black += cc.black;
            green += cc.green;
            red += cc.red;
            white += cc.white;
            grey += cc.grey;
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

            int g = colourless - cc.colours;

            if (cc.grey > g) { result = false; }

            return result;
        }

        public int CompareInt(ColourCost cc)
        {
            ColourCost result = MemberwiseClone() as ColourCost;

            cc.Subtract(cc);

            return result.colourless;
        }
        # endregion
    }

    public class CardMethods
    {
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
    }

    public class CardAbility
    {
        public ColourCost _cost;
        public ColourCost Cost
        {
            get
            {
                if (_cost != null)
                {
                    return _cost;
                }
                else
                {
                    ColourCost c = new ColourCost();

                    string adj = RawCost.Replace(",", "").Replace(" ", "");
                    List<string> colours = adj.Split('%').ToList();

                    # region colours
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
                    # endregion

                    _cost = c;
                    return c;
                }
            }
        }
        public string RawCost = "";
        public string Text = "";
        public string Name = "";
        public bool Active = false;
    }

    public enum CSize
    {
        vSmall,
        Small,
        Normal,
        Large,
        vLarge
    };
        
}
