using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Policy;

namespace MagicProgram
{
    public partial class CardArea : UserControl
    {
        # region designer attributes
        # region CardViewMode
        [Browsable(true), DefaultValue(false), Description("Show Power/Toughness at the bottom of the card?"), Category("Custom")]
        private bool _viewerMode = false;
        public bool TextSpoiler
        {
            get { return _viewerMode; }
            set { _viewerMode = value; }
        }
        # endregion

        # region separate each card
        [Category("Custom")]
        private bool _individual = false;
        public bool IndividualCard
        {
            get { return _individual; }
            set { _individual = value; }
        }
        # endregion

        # region Card Size
        [DefaultValue(CSize.Small), Category("Custom")]
        private CSize _cardSize = CSize.Small;
        public CSize CardSize
        {
            get { return _cardSize; }
            set
            {
                _cardSize = value;
                SetHeight();
            }

        }

        /// <summary>
        /// Gets the size of the current CardSize.
        /// </summary>
        public Size ViewerSize
        {
            get
            {
                Size result;
                switch (CardSize)
                {
                    case CSize.vSmall:
                        result = new Size(53, 74);
                        break;

                    case CSize.Small:
                        result = new Size(106, 148);
                        break;

                    case CSize.Large:
                        result = new Size(212, 296);
                        break;

                    case CSize.vLarge:
                        result = new Size(265, 370);
                        break;

                    default:    //Normal
                        result = new Size(159, 222);
                        break;
                }

                if (TextSpoiler)
                {
                    result.Height += 20;
                }

                return result;
            }
        }
        # endregion

        # region limit card options to Choose
        private bool _singleChoice = false;
        [Browsable(true), DefaultValue("false"), Category("Custom")]
        public bool SingleChoice
        {
            get { return _singleChoice; }
            set { _singleChoice = value; }
        }

        private bool _tappable = false;
        [Browsable(true), DefaultValue("true"), Category("Custom")]
        public bool Tappable
        {
            get { return _tappable; }
            set { _tappable = value; }
        }

        private bool _discard = false;
        [Browsable(true), DefaultValue("false"), Category("Custom")]
        public bool Discard
        {
            get { return _discard; }
            set { _discard = value; }
        }

        private bool _activate = false;
        [Browsable(true), DefaultValue("false"), Category("Custom")]
        public bool Activate
        {
            get { return _activate; }
            set { _activate = value; }
        }

        private bool _chooseCard = false;
        [Browsable(true), DefaultValue("false"), Category("Custom")]
        public bool ChooseCard
        {
            get { return _chooseCard; }
            set
            {
                _chooseCard = value;
                setActions();
            }
        }
        # endregion

        # region "Choose Card" text
        private string _chooseCardString = "Choose";
        [Browsable(true), DefaultValue("Choose"), Category("Custom")]
        public string ChooseCardString
        {
            get { return _chooseCardString; }
            set { _chooseCardString = value; }
        }
        # endregion

        public bool Paused = false;
        public MagicCard CurrentCard;

        public CardCollection Cards = new CardCollection();
        # endregion

        # region private attributes
        private List<MagicCardViewer> mControls = new List<MagicCardViewer>();
        //private Dictionary<MagicCard, int> CardDict = new Dictionary<MagicCard, int>();
        # endregion

        # region delegates/events/handlers
        public delegate void CardChosen(MagicCard mc, MouseEventArgs e);
        public delegate void CountersChosen(int value, Dictionary<MagicCard, int> sources);

        public event CardChosen CardClicked;
        public event CardChosen CardDoubleClicked;
        public event CardUse ChoseCard;

        public event CountersChosen CountersPicked;

        protected void callCardClicked(MagicCard mc, MouseEventArgs e)
        {
            CardChosen handler = CardClicked;
            CurrentCard = mc;
            if (handler != null)
            {
                handler(mc, e);
            }
        }

        protected void callCardDoubleClicked(MagicCard mc, MouseEventArgs e)
        {
            CardChosen handler = CardDoubleClicked;
            CurrentCard = mc;
            if (handler != null)
            {
                handler(mc, e);
            }
        }

        protected void callChoseCard(MagicCard mc)
        {
            CardUse handler = ChoseCard;
            if (handler != null)
            {
                handler(mc);
            }
        }

        protected void callCountersPicked()
        {
            int x = 0;
            Dictionary<MagicCard, int> sources = new Dictionary<MagicCard, int>();

            # region set values
            foreach (MagicCardViewer mcv in mControls)
            {
                if (mcv == null)
                {
                    continue;
                }

                x += (int)mcv.numericUpDown1.Value;
                sources.Add(mcv.cards[0], (int)mcv.numericUpDown1.Value);
            }
            # endregion

            CountersChosen handler = CountersPicked;
            if (handler != null)
            {
                handler(x, sources);
            }
        }
        # endregion

        public CardArea()
        {
            InitializeComponent();
            //Sample Card
            MagicCard mc = CardMethods.CreateCard("Arbor Elf");
            Cards.Add(mc);

            DrawAllCards();
        }

        # region add/remove/update cards
        public void DrawAllCards()
        {
            if (Paused)
            {
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();
            Debug.WriteLine($"DrawAllCards...");
            this.SuspendLayout();

            # region preparation
            Cards.cards = CardMethods.SplitCardList(Cards.cards);

            //CardDict.Clear();
            ClearViewers();

            Cards.index();

            Cards.cards = Cards.cards.OrderBy(o => o.Type).ToList();
            Cards.cards = Cards.cards.OrderBy(o => o.Name).ToList();
            Cards.cards = Cards.cards.OrderBy(o => o.Tapped).ToList();

            int position = -1;
            string PName = "";
            bool tapped = false;
            # endregion

            MagicCardViewer mcvtemp = new MagicCardViewer();

            int count = 1;
            # region cycle through cards
            for (int i = 0; i < Cards.cards.Count; i++)
            {
                MagicCard mc = Cards.cards[i];

                # region set position
                //set depth down one
                if (IndividualCard)
                {
                    position++;
                    count = 1;
                }
                else if ((i > 0 && mc.Name == PName && mc.Tapped == tapped))
                {
                    count++;
                }
                else
                {
                    position++;
                    count = 1;
                }

                # endregion

                PName = mc.Name;
                tapped = mc.Tapped;

                if (count == 1)
                {
                    # region create new MagicCardViewer
                    MagicCardViewer mcv;

                    mcv = CreateViewer(mc);

                    mcvtemp = mcv;
                    # endregion
                }
                else
                {
                    # region add mc to mcv.cards
                    mcvtemp.cards.Add(mc);
                    # endregion
                }

                //CardDict.Add(mc, position);
            }
            # endregion

            Controls_SetPos();

            foreach (MagicCardViewer mcv in mControls)
            {
                mcv.DrawQuantity();
                mcv.CardDeleted -= mcv_CardDeleted;
                mcv.CardDeleted += new MagicCardViewer.MagicCardViewerEvent(mcv_CardDeleted);
                mcv.UpdateCard();

                SetIndAction(mcv);
            }

            this.ResumeLayout();
            sw.Stop();
            Debug.WriteLine($"DrawAllCards...{sw.ElapsedMilliseconds}");
        }

        void mcv_CardDeleted(MagicCardViewer mcv)
        {

        }

        public void AddCard(MagicCard mc)
        {
            if (Paused) return;

            bool duplicate = false;

            if (mc.attachedCards.Count != 0 || SingleChoice)
            {
                duplicate = false;
            }
            else
            {
                int index = ContainsCard(mc);

                if (index > -1)
                {
                    MagicCardViewer mcv = mControls[index];

                        mcv.cards.Add(mc);
                        duplicate = true;
                    mcv.DrawQuantity();

                    //int p = mControls.IndexOf(mcv);
                    //CardDict.Add(card, p);
                }

            }

            if (!duplicate)
            {
                int c = mControls.Count;
                MagicCardViewer mcv = CreateViewer(mc);
                //CardDict.Add(card, c);
            }

            Controls_SetPos();
        }

        public void RemoveCard(MagicCard mc)
        {
            if (Paused)
            {
                return;
            }

            for (int i = 0; i < mControls.Count; i++)
            {
                if (mControls[i].mc == mc)
                {
                    mControls[i].RemoveCard(mc);
                    mControls[i].Dispose();
                    mControls.RemoveAt(i);
                    break;
                }
            }

            Controls_SetPos();
        }

        public void UpdateCard(int CardID)
        {
            if (Paused) return;

            foreach ( MagicCardViewer mcv in mControls)
            {
                var v = mcv.cards.Find(o=>o.DeckID == CardID);
                if (v == null) { continue; }

                mcv.UpdateCard();
                return;
            }
        }

        public void RepopulateCards( List<MagicCard> cards)
        {
            Cards.cards = cards;

            string Name = "";
            bool tapped = false;
            List<MagicCard> attached = new List<MagicCard>();

            foreach (MagicCardViewer mcv in mControls)
            {
                mcv.cards.Clear();
            }

            int mIndex = -1;

            foreach (MagicCard mc in Cards.cards)
            {
                if (Name == mc.Name && tapped == mc.Tapped && attached == mc.attachedCards)
                {
                    mControls[mIndex].cards.Add(mc);
                }
                else
                {
                    mIndex++;
                    if (mControls.Count <= mIndex)
                    {
                        CreateViewer(mc);
                    }
                }
            }

            Controls_SetPos();
            DrawAllCards();
        }

        private void Controls_SetPos()
        {
            for (int i = 0; i < mControls.Count; i++)
            {
                mControls[i].Left = i * (ViewerSize.Width + 6);
            }
        }

        private void ClearViewers()
        {
            this.SuspendLayout();
            foreach (Control c in mControls)
            {
                c.Dispose();
            }
            //Controls.Clear();
            mControls.Clear();
            this.ResumeLayout();
        }

        public void CardsChanged(MagicCard[] cards)
        {

        }

        private int ContainsCard(MagicCard mc)
        {
            int result = -1;

            for (int i = 0; i < mControls.Count; i++)
            {
                if (mControls[i].cards.Count > 0)
                {
                    MagicCard card = mControls[i].cards[0];

                    if (card.attachedCards.Count == 0 && card.Name == mc.Name && card.Tapped == mc.Tapped)
                    {
                        result = i;
                        break;
                    }
                }
            }

            return result;
        }

        private MagicCardViewer CreateViewer(MagicCard mc)
        {
            MagicCardViewer mcv;
            //bool CardTappable = mc.Text.ToLower().Contains("tap");
            mc.Initialise();
            bool CardTappable = mc.Abilities.Count > 0;

            if (SingleChoice)
            {
                mcv = new MagicCardViewer(false, false, false, true);
            }
            else
            {
                //mcv = new MagicCardViewer(Tappable, Activate, Discard, ChooseCard);
                mcv = new MagicCardViewer(CardTappable, Activate, Discard, ChooseCard);
            }

            SetIndAction(mcv);

            mcv.SetChooseString(ChooseCardString);

            mcv.ViewerSize = CardSize;
            mcv.TextVisible = TextSpoiler;
            //mcv.Choosing = ChooseCard;

            mcv.cards.Add(mc);
            mcv.LoadCard(mc);

            mcv.MouseClick += new MouseEventHandler(mcv_MouseClick);
            mcv.MouseDoubleClick += new MouseEventHandler(mcv_MouseDoubleClick);
            mcv.CardChanged += new MagicCardViewer.MagicCardViewerEvent(mcv_CardChanged);
            mcv.CardChosen += new CardUse(callChoseCard);
            Controls.Add(mcv);
            mControls.Add(mcv);
            mcv.BringToFront();
            return mcv;
        }
        # endregion

        void SetHeight()
        {
            Size result = new Size();

            switch (CardSize)
            {
                case CSize.vSmall:
                    result = new Size(53, 74);
                    break;

                case CSize.Small:
                    result = new Size(106, 148);
                    break;

                case CSize.Large:
                    result = new Size(212, 296);
                    break;

                case CSize.vLarge:
                    result = new Size(265, 370);
                    break;

                default:    //Normal
                    result = new Size(159, 222);
                    break;
            }

            if (TextSpoiler)
            {
                result.Height += 20;
            }

            foreach (MagicCardViewer mcv in mControls)
            {
                if (!mcv.IsDisposed)
                {
                    mcv.ViewerSize = CardSize;
                }
            }

            this.Height = result.Height;
        }

        private void setActions()
        {
            foreach (MagicCardViewer mcv in mControls)
            {
                SetIndAction(mcv);
            }
        }

        private void SetIndAction(MagicCardViewer mcv)
        {
            mcv.Tap = Tappable;
            mcv.Discard = Discard;
            mcv.Choosing = _chooseCard;

            if (mcv.cards.Count < 0 && mcv.cards[0].Abilities.Count > 0)
            {
                mcv.Activate = Activate;
            }
            else
            {
                mcv.Activate = false;
            }
        }

        # region events
        # region MagicCardViewer
        void mcv_CardChanged(MagicCardViewer mcv)
        {
            MagicCard mc = mcv.cards[0];

            //mcv.cards.Remove(mc);
            //CardDict.Remove(mc);

            if (mcv.cards.Count > 0)
            {
                mcv.UpdateCard();
                //mcv.DrawCount();                
            }
            else
            {
                mControls.Remove(mcv);
                mcv.Dispose();
            }

            //AddCard(mc);

            DrawAllCards();
        }

        void mcv_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(MagicCardViewer))
            {
                MagicCardViewer mcv = sender as MagicCardViewer;

                //if ( mcv)

                if (e.Button == MouseButtons.Right)
                {
                    callCardClicked(mcv.mc, e);
                }
                else
                {
                    callCardClicked(mcv.mc, e);
                    BringToFront();
                }
            }

        }

        void mcv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(MagicCardViewer))
            {
                MagicCardViewer mcv = sender as MagicCardViewer;

                if (e.Button == MouseButtons.Right)
                {
                    callCardDoubleClicked(mcv.mc, e);
                }
                else
                {
                    callCardDoubleClicked(mcv.mc, e);
                    BringToFront();
                }
            }
        }
        # endregion

        private void CardArea_KeyUp(object sender, KeyEventArgs e)
        {
            if (CurrentCard == null)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Add:
                    CurrentCard.counters++;
                    e.Handled = true;
                    break;

                case Keys.Subtract:
                    CurrentCard.counters--;
                    e.Handled = true;
                    break;

                case Keys.Delete:
                    if (CurrentCard != null)
                    {
                        CurrentCard.CallDestroyed();
                        CurrentCard = null;
                        e.Handled = true;
                    }
                    break;
            }

            Debug.WriteLine("CardArea_KeyUp: Should cards be updated?");
        }
        # endregion

        # region game stages
        public void SetCombat(bool combat)
        {
            //foreach (MagicCardViewer mcv in mControls)
            //{
            //    mcv.Attack = combat;
            //}
        }

        public int countAttackers()
        {
            int result = 0;
            foreach (MagicCardViewer mcv in mControls)
            {
                if (!mcv.cards[0].Sick && !mcv.cards[0].Tapped && mcv.cards[0].PowerCalc > 0)
                {
                    mcv.Attack = true;
                    result++;
                }
            }
            return result;
        }

        public void resetAttackers()
        {
            foreach (MagicCardViewer mcv in mControls)
            {
                mcv.Attack = false;
            }
        }
        # endregion

        public void HighlightCards()
        {
            List<MagicCardViewer> mcv = mControls.Where(o => o.mc.Token).ToList();

            foreach (MagicCardViewer mc in mcv)
            {
                mc.Border = true;
            }
        }

        public void PickCounters()
        {
            foreach (MagicCardViewer mcv in mControls)
            {
                if (mcv.cards[0].counters > 0)
                {
                    mcv.numericUpDown1.Show();
                    mcv.showPanel1();
                }
            }

            int x = Controls.Count;

            buttonDone.Click += new EventHandler(buttonDone_Click);
            buttonDone.Show();
        }

        void buttonDone_Click(object sender, EventArgs e)
        {
            callCountersPicked();
            buttonDone.Click -= buttonDone_Click;
        }
    }
}
