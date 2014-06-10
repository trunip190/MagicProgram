using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicProgram
{
    public partial class CardViewerSmall : UserControl
    {
        public MagicCard _mc = new MagicCard();

        public CardViewerSmall()
        {
            InitializeComponent();
        }

        # region LoadCard
        public void LoadCard(MagicCard mc)
        {
            _mc = mc;

            _mc.TapChanged += new CardUse(_mc_TapChanged);

            LoadCard();
        }

        public void LoadCard()
        {
            BackgroundImage = _mc.get();

            if (_mc.Tapped)
            {
                BackgroundImage = RotateImage(_mc.get());
                Height = 90;
                Width = 126;
                button1.Text = "Untap";
            }
            else
            {
                BackgroundImage = _mc.get();
                Height = 126;
                Width = 90;
                button1.Text = "Tap";
            }
        }
        # endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _mc.ChangeTap();
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

        void _mc_TapChanged(MagicCard mc)
        {
            LoadCard();
        }
    }
}
