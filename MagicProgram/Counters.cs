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
    public partial class Counters : PictureBox
    {
        # region counters
        private int _counters = 0;
        [Browsable(true), DefaultValue(0), Description("The number of counters to be represented.")]
        public int counters
        {
            get { return _counters; }
            set
            {
                _counters = value;
                callCountersChanged();
            }
        }
        # endregion

        /// <summary>
        /// Raised when the number of counters on this object changes.
        /// </summary>
        public event Action CountersChanged;

        protected void callCountersChanged()
        {
            Action handler = CountersChanged;
            if (handler != null)
            {
                handler();
            }
            UpdateCounters();
        }

        public Counters()
        {
            InitializeComponent();
            UpdateCounters();
        }

        public void AddCounters(int i)
        {
            counters += i;
        }

        public void UpdateCounters()
        {
            # region set visibility
            if (counters == 0)
            {
                Visible = false;
                return;
            }
            Visible = true;
            # endregion

            # region set image
            Image counterImage;
            int j = counters;

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

            Height = j * 32;
            Bitmap bmp = new Bitmap(Width, Height);

            # region draw counters on image
            using (Graphics g = Graphics.FromImage(bmp))
            {
                for (int p = 0; p < j; p++)
                {
                    if (p < 5)
                    {
                        area.Y = p * 32;
                        g.DrawImage(counterImage, area);
                    }
                    else
                    {
                        g.DrawString(counters.ToString(), Font, new SolidBrush(Color.Black), new Point(9, 9));
                        break;
                    }
                }
            }
            # endregion
                        
            Image = bmp;
        }
    }
}
