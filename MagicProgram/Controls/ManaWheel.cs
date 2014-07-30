using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicProgram
{
    public partial class ManaWheel : UserControl
    {
        # region return value
        public delegate void Chosen(ColourCost c);
        public event Chosen Closing;

        private ColourCost Options = new ColourCost();

        private List<ColourCost> queuedCards = new List<ColourCost>();

        public event Action Showing;
        # endregion

        protected void onClosing(ColourCost c)
        {
            Chosen handler = Closing;
            Options = new ColourCost();

            if (handler != null)
            {
                handler(c);
            }

            Hide();
            if (queuedCards.Count > 0)
            {
                ShowWheel(queuedCards[0]);
                queuedCards.RemoveAt(0);
            }
        }

        protected void onShowing()
        {
            Action handler = Showing;
            if (handler != null)
            {
                handler();
            }
        }

        public ManaWheel()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                Button b = sender as Button;
                ColourCost choice = new ColourCost();

                switch (b.Name)
                {
                    case "buttonBlue":
                        choice.blue += Options.blue;
                        break;

                    case "buttonGreen":
                        choice.green += Options.green;
                        break;

                    case "buttonRed":
                        choice.red += Options.red;
                        break;

                    case "buttonWhite":
                        choice.white += Options.white;
                        break;

                    case "buttonBlack":
                        choice.black += Options.black;
                        break;

                    case "buttonGrey":
                        choice.grey += Options.grey;
                        break;

                    default:
                        return;
                }
                onClosing(choice);
            }
        }

        public void ShowWheel(ColourCost cc)
        {
            if (Visible)
            {
                queuedCards.Add(cc);
                return;
            }

            if (cc.blue < 1) { buttonRed.Visible = false; } else { buttonRed.Visible = true; }
            if (cc.green < 1) { buttonGreen.Visible = false; } else { buttonGreen.Visible = true; }
            if (cc.red < 1) { buttonRed.Visible = false; } else { buttonRed.Visible = true; }
            if (cc.white < 1) { buttonWhite.Visible = false; } else { buttonWhite.Visible = true; }
            if (cc.black < 1) { buttonBlack.Visible = false; } else { buttonBlack.Visible = true; }
            if (cc.colourless < 1) { buttonGrey.Visible = false; } else { buttonGrey.Visible = true; }

            bool vis = Visible;

            Options.Add(cc);

            Location = new Point((Parent.Width - Width) / 2, (Parent.Height - Height) / 2);

            onShowing();
            Show();
            BringToFront();
        }

        public void ShowWheel(string s)
        {
            ColourCost cc = new ColourCost();

            //parse string
            foreach (char c in s)
            {
                if (!char.IsNumber(c))
                {
                    # region Colour Costs
                    switch (c)
                    {
                        case 'B':
                            cc.black++;
                            break;

                        case 'U':
                            cc.blue++;
                            break;

                        case 'G':
                            cc.green++;
                            break;

                        case 'R':
                            cc.red++;
                            break;

                        case 'W':
                            cc.white++;
                            break;
                    }
                    # endregion
                }
            }

            ShowWheel(cc);
        }
    }
}
