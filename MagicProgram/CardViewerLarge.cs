using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MagicProgram
{
    public partial class CardViewerLarge : UserControl
    {
        Font FontText;
        Font FontFlavour;
        bool SizeLarge = false;

        # region constructors
        public CardViewerLarge()
        {
            InitializeComponent();

            FontText = richTextBoxText.Font;
            FontFlavour = new Font(richTextBoxText.SelectionFont, FontStyle.Italic);
        }
        # endregion

        # region methods
        public void LoadCard(MagicCard mc)
        {
            bool exists = File.Exists(mc.imgLoc);

            if (!exists)
            {
                Debug.WriteLine(mc.imgLoc);
            }

            foreach (Control c in this.Controls)
            {
                c.Visible = !exists;
            }

            this.BackgroundImage = mc.get();

            if (File.Exists(SplitString.convertFrom(mc.imgLoc)))
            {
                panel2.Hide();
            }
            else
            {
                panel2.Show();
            }

            textBoxName.Text = mc.Name;
            textBoxType.Text = mc.Type;

            # region CMC
            pictureBoxCMC.BackgroundImage = MagicImage.FromString(mc.Cost);
            if (pictureBoxCMC.BackgroundImage != null)
            {
                pictureBoxCMC.Left = pictureBoxCMC.Right - pictureBoxCMC.BackgroundImage.Width;
                pictureBoxCMC.Width = pictureBoxCMC.BackgroundImage.Width;
            }
            # endregion

            textBoxPT.Text = mc.PT;

            # region counters
            //label1.Text = mc.counters.ToString() + "/" + mc.counters.ToString();
            //if (mc.counters != 0)
            //{
            //    Output.Write("{0} counters", mc.counters);
            //    //label1.Show();
            //}
            //else
            //{
            //    //label1.Hide();
            //}
            counters1.counters = mc.counters;
            # endregion

            //Set text
            richTextBoxText.Clear();
            //richTextBox1.Select(0, 0);
            //richTextBox1.SelectionFont = FontText;
            richTextBoxText.Rtf = convertToRtf(mc.Text + "\r\n");

            //Add in italic flavour text
            richTextBoxText.Select(richTextBoxText.Text.Length, 0);
            richTextBoxText.SelectionFont = FontFlavour;
            richTextBoxText.AppendText(mc.Flavor);

            getImageCrop(mc);
        }

        private void getImageCrop(MagicCard mc)
        {
            string dir = @"C:\Program Files (x86)\Magic Workstation\Pics\";
            dir += mc.Edition + @"\";

            pictureBox1.BackgroundImage = null;

            if (!Directory.Exists(dir))
            {
                return;
            }

            string[] files = Directory.GetFiles(dir);
            string filename = "";
            Image img = new Bitmap(1, 1);

            foreach (string s in files)
            {
                filename = Path.GetFileNameWithoutExtension(s).ToUpper();

                if (filename == mc.Name.ToUpper())
                {
                    img = Image.FromFile(s);
                    break;
                }
            }

            pictureBox1.BackgroundImage = img;
        }

        private string convertToRtf(string s)
        {
            using (RichTextBox rtb = new RichTextBox())
            {
                foreach (char c in s)
                {
                    if (c == '#')
                    {
                        rtb.Select(rtb.Text.Length, 0);

                        if (rtb.SelectionFont.Italic)
                        {
                            rtb.SelectionFont = FontText;
                        }
                        else
                        {
                            rtb.SelectionFont = FontFlavour;
                        }
                    }
                    else
                    {
                        rtb.AppendText(c.ToString());
                    }
                }

                return rtb.Rtf;
            }
        }

        public void ResizeControl(bool Large)
        {
            SizeLarge = Large;
            CardViewer_Resize(null, EventArgs.Empty);
        }
        # endregion

        # region event handlers
        private void CardViewer_Resize(object sender, EventArgs e)
        {

            this.Size = SizeLarge ? new Size(331, 462) : new Size(265, 370);

            Debug.WriteLine($"{this.Name}\t{this.Width}\t{this.Height}");

            foreach (Control c in panel2.Controls)
            {
                Debug.WriteLine($"{c.Name}\t{c.Width}\t{c.Height}");
            }

            panel1.Size = SizeLarge ? new Size(290, 210) : new Size(232, 168);
            panel2.Size = SizeLarge ? new Size(300, 430) : new Size(232, 339);
            panel4.Size = SizeLarge ? new Size(225, 26) : new Size(225, 20);

            textBoxName.Size = SizeLarge ? new Size(166, 32) : new Size(152, 20);
            textBoxName.Location = new Point(5,5);

            richTextBoxText.Size = SizeLarge ? new Size(301, 148) : new Size(232, 108);
            richTextBoxText.Top = 214;

            pictureBox1.Size = SizeLarge ? new Size(281, 157) : new Size(230, 166);
            pictureBox1.Top = 0;

            textBoxType.Size = SizeLarge ? new Size(227, 20) : new Size(232, 20);
            textBoxType.Top = SizeLarge ? 194 : 194;


            foreach (Control c in panel2.Controls)
            {
                Debug.WriteLine($"{c.Name}\t{c.Width}\t{c.Height}");
            }
        }
        # endregion
    }
}
