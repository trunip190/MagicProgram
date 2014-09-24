using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicProgram
{
    public partial class MagicCardViewer : UserControl
    {
        # region Declaration
        # region Designer Attributes
        # region ConstrainProportions
        [Browsable(true), DefaultValue(false), Description("Does this control snap to sizes?")]
        private bool _ConstrainProportions = false;
        public bool ConstrainProportions
        {
            get { return _ConstrainProportions; }
            set { _ConstrainProportions = value; }
        }
        # endregion

        # region Choose size
        private CSize _viewerSize = CSize.Normal;
        public CSize ViewerSize
        {
            get { return _viewerSize; }
            set
            {
                _viewerSize = value;
                SetTapSize(false);
            }
        }

        public Size cardSize
        {
            get
            {
                Size result;
                switch (ViewerSize)
                {
                    case CSize.vSmall:
                        result = new Size(80, 112);
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

                if (TextVisible)
                {
                    result.Height += 20;
                }

                return result;
            }
        }
        # endregion

        # region Magic Card
        private MagicCard _mc = new MagicCard();
        [Browsable(false)]
        public MagicCard mc
        {
            get { return cards[0]; }// return _mc; }
            set
            {
                cards[0] = value;
                //_mc = value;
                UpdateCard();
            }
        }
        # endregion

        # region button visibility
        # region Choosing
        public bool Choosing
        {
            get { return buttonChoose.Visible; }
            set { buttonChoose.Visible = value; }
        }
        # endregion

        # region Attack
        public bool Attack
        {
            get { return buttonAttack.Visible; }
            set { buttonAttack.Visible = value; }
        }
        # endregion

        # region Tap
        public bool Tap
        {
            get { return buttonTap.Visible; }
            set { buttonTap.Visible = value; }
        }
        # endregion

        # region Activate
        public bool Activate
        {
            get { return buttonActivate.Visible; }
            set { buttonActivate.Visible = value; }
        }
        # endregion

        # region Discard
        public bool Discard
        {
            get { return buttonDiscard.Visible; }
            set { buttonDiscard.Visible = value; }
        }
        # endregion
        # endregion

        private bool _border = false;
        public bool Border
        {
            get { return _border; }
            set
            {
                _border = value;
                DrawBorder();
            }
        }
        # endregion

        public bool TextVisible = false;
        public bool Chosen = false;

        private List<MagicCard> _cards = new List<MagicCard>();
        public List<MagicCard> cards
        {
            get
            {
                return _cards;
            }
            set
            {
                _cards = value;
            }

        }

        # region delegates/events/handlers
        public delegate void MagicCardViewerEvent(MagicCardViewer mcv);
        public event MagicCardViewerEvent CardChanged;
        public event MagicCardViewerEvent CardDeleted;
        public event PassiveEvent CardChosen;

        protected void onCardChanged()
        {
            MagicCardViewerEvent handler = CardChanged;
            if (handler != null)
            {
                handler(this);
            }
        }

        protected void callCardChosen()
        {
            PassiveEvent handler = CardChosen;
            if (handler != null)
            {
                handler(cards[0]);
            }
        }

        protected void callCardDeleted()
        {
            MagicCardViewerEvent handler = CardDeleted;
            if (handler != null)
            {
                handler(this);
            }
        }
        # endregion
        # endregion

        public MagicCardViewer()
        {
            InitializeComponent();
        }

        public MagicCardViewer(bool tap, bool activate, bool discard, bool choose)
        {
            InitializeComponent();

            buttonTap.Visible = tap;
            buttonActivate.Visible = activate;
            buttonDiscard.Visible = discard;
            buttonChoose.Visible = choose;
        }

        void mc_TapChanged(MagicCard mc)
        {
            int i = cards.IndexOf(mc);
            if (i < 0)
            {
                mc.TapChanged -= mc_TapChanged;
                return;
            }
            DrawCardTap();
        }

        public void LoadCard(MagicCard card)
        {
            cards.Clear();

            card.checkPT();

            if (buttonActivate.Visible && !card.Text.Contains("%T"))
            {
                buttonActivate.Visible = false;
            }

            card.CountersChanged -= mc_CountersChanged;
            card.CountersChanged += new ValueChanged(mc_CountersChanged);

            card.TapChanged -= mc_TapChanged;
            card.TapChanged += new PassiveEvent(mc_TapChanged);

            card.Destroyed -= card_Destroyed;
            card.Destroyed += new PassiveEvent(card_Destroyed);

            cards.Add(card);
            mc = card;
        }

        void card_Destroyed(MagicCard mc)
        {
            if (cards.Count < 1)
            {
                callCardDeleted();
            }
        }

        public void RemoveCard(MagicCard mc)
        {
            if (cards.Contains(mc))
            {
                //Remove all handlers from mc
                mc.CountersChanged -= mc_CountersChanged;
                mc.TapChanged -= mc_TapChanged;
                cards.Remove(mc);
            }
            else
            {
                Debug.WriteLine("Card not contained in collection.");
            }
        }

        private void mc_CountersChanged(int count)
        {
            if (cards.Count < 1)
            {
                return;
            }

            textBox1.Text = "(" + cards[0].Power + "/" + cards[0].Toughness + ")(" + cards[0].counters + ")";
            textBox1.Visible = TextVisible;
        }

        # region update/draw
        public void UpdateCard()
        {
            DrawCardTap();

            mc_CountersChanged(0);

            drawCounters();
            DrawQuantity();
        }

        private void DrawCardTap()
        {
            if (cards[0].Tapped)
            {
                buttonTap.Text = "Untap";
                pictureBox1.BackgroundImage = RotateImage(cards[0].get());
            }
            else
            {
                buttonTap.Text = "Tap";
                pictureBox1.BackgroundImage = cards[0].get();
            }

            //onCardChanged();
            CardViewer_Resize();
        }

        private void DrawBorder()
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                if (mc.Sick)
                {
                    g.DrawRectangle(new Pen(Color.Orange, 5), pictureBox1.ClientRectangle);
                }
                if (mc.attachedCards.Count > 0)
                {
                    g.DrawRectangle(new Pen(Color.Green, 4), pictureBox1.ClientRectangle);
                }
                if (Border)
                {
                    g.DrawRectangle(new Pen(Color.Red, 3), pictureBox1.ClientRectangle);
                }
            }


        }

        private void drawCounters()
        {
            # region set image
            Image counterImage;
            int j = cards[0].counters;

            if (j > 0)
            {
                counterImage = Properties.Resources.CounterPlus;
            }
            else
            {
                j *= -1;
                counterImage = Properties.Resources.CounterMinus;
            }
            # endregion
            Rectangle area = new Rectangle(0, 0, 32, 32);

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            # region draw counters on image
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int p = 0; p < j; p++)
                {
                    if (p < 5)
                    {
                        area.Y = (p * 32) + 64;
                        g.DrawImage(counterImage, area);
                    }
                    else
                    {
                        g.DrawString(cards[0].counters.ToString(), Font, new SolidBrush(Color.Black), new Point(9, 9));
                        break;
                    }
                }
            }
            # endregion

            BackgroundImage = bmp;
        }

        public void DrawQuantity()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            if (cards.Count > 1)
            {
                # region set point location
                Point pnt = new Point();

                switch (ViewerSize)
                {
                    case CSize.vSmall:
                        pnt = new Point(40, 10);
                        break;

                    case CSize.Small:
                        pnt = new Point(43, 55);
                        break;

                    case CSize.Normal:
                        pnt = new Point(50, 16);
                        break;

                    case CSize.Large:
                        pnt = new Point(77, 53);
                        break;

                    case CSize.vLarge:
                        pnt = new Point(103, 90);
                        break;
                }
                # endregion

                Font font = new Font(FontFamily.GenericSansSerif, 16);

                # region draw string on bmp
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawString(cards.Count.ToString(), font, new SolidBrush(Color.White), pnt);
                }
                # endregion
            }

            pictureBox1.Image = bmp;
            DrawBorder();
        }

        public Image RotateImage(Image img)
        {
            var bmp = new Bitmap(img);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.Clear(Color.White);
                gfx.DrawImage(img, 0, 0, img.Width, img.Height);
            }

            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return bmp;
        }
        # endregion

        private void CardViewer_Resize()
        {
            if (cards.Count < 1)
            {
                //Dispose();
                return;
            }

            SetTapSize(cards[0].Tapped);
        }

        private void SetTapSize(bool tapped)
        {
            if (tapped)
            {
                this.Height = cardSize.Width;
                this.Width = cardSize.Height;
            }
            else
            {
                this.Height = cardSize.Height;
                this.Width = cardSize.Width;
            }
        }

        public void SetChooseString(string s)
        {
            buttonChoose.Text = s;
        }

        # region Events
        # region Control events
        private void MagicCardViewer_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void MagicCardViewer_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 500;
            timer1.Tick -= timer1_TickOn;
            timer1.Tick += new EventHandler(timer1_TickOff);
        }

        private void MagicCardViewer_MouseEnter(object sender, EventArgs e)
        {
            showPanel1();
        }

        public void showPanel1()
        {
            panel1.Visible = true;
        }

        public void hidePanel1()
        {
            panel1.Visible = false;
        }
        # endregion

        # region button events
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            Chosen = !Chosen;

            if (Chosen)
            {
                buttonChoose.BackColor = Color.LightSeaGreen;
                callCardChosen();
            }
            else
            {
                buttonChoose.BackColor = Control.DefaultBackColor;
            }
        }

        private void buttonTap_Click(object sender, EventArgs e)
        {
            cards[0].ChangeTap();

            DrawCardTap();
            onCardChanged();
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            cards[0].TryActivate(0);
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            cards[0].callDiscard();
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            cards[0].Attacking = !cards[0].Attacking;
            if (!mc.Text.Contains("Vigilance"))
            {
                cards[0].ChangeTap();
            }
            if (cards[0].Attacking)
            {
                buttonAttack.BackColor = Color.Green;
            }
            else
            {
                buttonAttack.BackColor = Color.Transparent;
            }
        }
        # endregion

        void timer1_TickOn(object sender, EventArgs e)
        {
            //TODO sometimes button doesn't work
            showPanel1();

            timer1.Tick -= timer1_TickOn;
            timer1.Stop();
        }

        void timer1_TickOff(object sender, EventArgs e)
        {
            bool contained = false;

            if (!panel1.IsDisposed)
            {
                if (panel1.RectangleToScreen(panel1.Bounds).Contains(MousePosition))
                {
                    contained = true;
                }
            }

            if (!contained)
            {
                hidePanel1();
            }

            timer1.Tick -= timer1_TickOff;
            timer1.Stop();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.OnMouseDoubleClick(e);
        }
        # endregion

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > mc.counters)
            {
                numericUpDown1.Value = mc.counters;
            }

            if (numericUpDown1.Value < 0)
            {
                numericUpDown1.Value = 0;
            }
        }
    }
}
