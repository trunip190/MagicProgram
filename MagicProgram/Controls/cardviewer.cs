using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicProgram
{
    public partial class CardViewer : UserControl
    {
        Font FontText;
        Font FontFlavour;

        MagicCard nMC = new MagicCard();

        # region constructors
        public CardViewer()
        {
            InitializeComponent();

            FontText = new Font("Cambria", 7, FontStyle.Regular);
            FontFlavour = new Font("Cambria", 7, FontStyle.Italic);

            richTextBoxText.Font = FontText;

            textBoxName.Font = FontText;
            textBoxType.Font = FontText;
            textBoxPT.Font = FontText;
        }
        # endregion

        # region methods
        public void LoadCard(MagicCard mc)
        {
            if (mc != null)
            {
                nMC = mc;

                //is getting assigned multiple times.
                nMC.TapChanged -= LoadCard;
                nMC.TapChanged += new PassiveEvent(LoadCard);

                LoadCard();
            }
        }

        public void LoadCard()
        {
            bool exists = File.Exists(nMC.imgLoc);

            if (!exists)
            {
            }

            foreach (Control c in this.Controls)
            {
                if (c.Name != "label1")
                {
                    c.Visible = !exists;
                }
            }

            this.BackgroundImage = nMC.get();

            # region set tap button text
            if (nMC.Tapped)
            {
                button1.Text = "Untap";
            }
            else
            {
                button1.Text = "Tap";
            }
            # endregion

            # region show details or image
            if (File.Exists(SplitString.convertFrom(nMC.imgLoc)))
            {
                panel2.Hide();
            }
            else
            {
                panel2.Show();
            }
            # endregion

            textBoxName.Text = nMC.Name;
            textBoxType.Text = nMC.Type;

            # region abilities
            nMC.ParseText();
            comboBox1.Items.Clear();
            foreach (CardAbility cb in nMC.Abilities)
            {
                comboBox1.Items.Add(cb.Text);
            }

            bool abilities = false;
            if (nMC.Abilities.Count > 0)
            {
                abilities = true;
            }
            else
            {
                abilities = false;
            }
            button1.Visible = button2.Visible = comboBox1.Visible = abilities;
            # endregion

            # region CMC
            pictureBoxCMC.BackgroundImage = MagicImage.FromString(nMC.Cost);
            if (pictureBoxCMC.BackgroundImage != null)
            {
                pictureBoxCMC.Left = pictureBoxCMC.Right - pictureBoxCMC.BackgroundImage.Width;
                pictureBoxCMC.Width = pictureBoxCMC.BackgroundImage.Width;
            }
            # endregion

            textBoxPT.Text = nMC.PT;

            counters1.counters = nMC.counters;

            //Set text
            richTextBoxText.Clear();
            richTextBoxText.Rtf = convertToRtf(nMC.Text + "\r\n");

            //Add in italic flavour text
            richTextBoxText.Select(richTextBoxText.Text.Length, 0);
            richTextBoxText.SelectionFont = FontFlavour;
            richTextBoxText.AppendText(nMC.Flavor);

            getImageCrop(nMC);
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
                rtb.Font = FontText;
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


                //Output.Write("{0}", rtb.Rtf);

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

        private void button1_Click(object sender, EventArgs e)
        {
            nMC.ChangeTap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = comboBox1.SelectedIndex;

            if (ind > -1)
            {
                nMC.TryActivate(ind);
            }
            else
            {
                nMC.TryActivate(0);
            }
        }
    }
}
