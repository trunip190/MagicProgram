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

namespace MagicProgram
{
    public partial class CardViewerLarge : UserControl
    {
        Font FontText;
        Font FontFlavour;

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
        # endregion

        # region event handlers
        private void CardViewer_Resize(object sender, EventArgs e)
        {
            textBoxName.Top = (int)(0.0513513513513514 * this.Height);
            richTextBoxText.Top = (int)(0.0513513513513514 * this.Height);
            pictureBox1.Top = (int)(0.116216216216216 * this.Height);
            textBoxType.Top = (int)(0.559459459459459 * this.Height);
            richTextBoxText.Top = (int)(0.618918918918919 * this.Height);
        }
        # endregion
    }
}
