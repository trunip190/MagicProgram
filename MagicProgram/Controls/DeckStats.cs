using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicProgram
{
    public partial class DeckStats : UserControl
    {
        List<MagicCard> deck = new List<MagicCard>();

        private int land = 0;
        private int crea = 0;
        private int spell = 0;
        private int other = 0;

        private int one = 0;
        private int two = 0;
        private int three = 0;
        private int four = 0;
        private int five = 0;

        private int Black = 0;
        private int Blue = 0;
        private int Green = 0;
        private int Red = 0;
        private int White = 0;

        public DeckStats()
        {
            InitializeComponent();
        }

        public void clear()
        {
            deck.Clear();

            land = 0;
            crea = 0;
            spell = 0;
            other = 0;

            one = 0;
            two = 0;
            three = 0;
            four = 0;
            five = 0;

            Black = 0;
            Blue = 0;
            Green = 0;
            Red = 0;
            White = 0;
        }

        public void LoadCard(List<MagicCard> cards)
        {
            clear();

            foreach (MagicCard mc in cards)
            {
                for (int i = 0; i < mc.quantity; i++)
                {
                    MagicCard nMC = CardMethods.GetClass(mc);

                    nMC.quantity = 1;

                    deck.Add(nMC);
                }
            }

            updateStats();
        }

        private void updateStats()
        {
            foreach (MagicCard mc in deck)
            {
                # region set CMC
                switch (mc.CMC)
                {
                    case 0:
                        break;

                    case 1:
                        one++;
                        break;

                    case 2:
                        two++;
                        break;

                    case 3:
                        three++;
                        break;

                    case 4:
                        four++;
                        break;

                    default:
                        five++;
                        break;
                }
                # endregion

                # region set colours
                foreach (char c in mc.Cost)
                {
                    switch (c)
                    {
                        case 'B':
                            Black++;
                            break;

                        case 'U':
                            Blue++;
                            break;

                        case 'G':
                            Green++;
                            break;

                        case 'R':
                            Red++;
                            break;

                        case 'W':
                            White++;
                            break;
                    }
                }
                # endregion

                # region set type
                if (mc.Type.ToLower().Contains("creature"))
                {
                    crea++;
                }
                if (mc.Type.ToLower().Contains("enchantment"))
                {
                    other++;
                }
                if (mc.Type.ToLower().Contains("land"))
                {
                    land++;
                }
                if (mc.Type.ToLower().Contains("sorcery") || mc.Type.ToLower().Contains("instant"))
                {
                    spell++;
                }
                if (mc.Type.ToLower().Contains("artifact"))
                {
                    other++;
                }
                # endregion
            }

            # region Type
            textBox1.Text = land.ToString();
            textBox2.Text = crea.ToString();
            textBox3.Text = spell.ToString();
            textBox4.Text = other.ToString();
            # endregion

            # region CMC
            textCost1.Text = one.ToString();
            textCost2.Text = two.ToString();
            textCost3.Text = three.ToString();
            textCost4.Text = four.ToString();
            textCost5.Text = five.ToString();
            # endregion

            # region Colours
            labelB.Text = Black.ToString();
            labelU.Text = Blue.ToString();
            labelG.Text = Green.ToString();
            labelR.Text = Red.ToString();
            labelW.Text = White.ToString();
            # endregion
        }

        private void DeckStats_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
