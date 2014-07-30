﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicProgram
{
    public partial class XManaPicker : UserControl
    {
        # region declarations
        [Browsable(false)]
        private ColourCost _mana = new ColourCost();
        public ColourCost Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        [Browsable(false)]
        private ColourCost _cost = new ColourCost();
        public ColourCost Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        private int _value = 0;
        public int Value
        {
            get
            {
                _value = (int)numericUpDown1.Value;
                return _value;
            }
            set
            {
                if (value <= Max && value >= 0)
                {
                    _value = value;
                    numericUpDown1.Value = _value;
                }
            }
        }

        private int _max = 0;
        public int Max
        {
            get { return _max; }
            set { _max = value; updateMax(); }
        }

        public int xCount = 0;
        # endregion

        # region Delegates
        public delegate void IntReturn(int value, int count);
        public event IntReturn ValuePicked;
        protected void callValuePicked()
        {
            IntReturn handler = ValuePicked;
            if (handler != null)
            {
                handler(Value, xCount);
            }
        }

        public event Action Cancel;
        protected void callCancel()
        {
            Action handler = Cancel;
            if (handler != null)
            {
                handler();
            }
        }
        # endregion

        public XManaPicker()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            callValuePicked();
        }

        private void updateMax()
        {
            textBox2.Text = "Max - " + Max.ToString();
            numericUpDown1.Maximum = Max;
        }

        public void Show(int count)
        {
            Value = 0;
            xCount = count;
            int j = Mana.colourless - Cost.colours;
            Max = j / count;
            Show();
        }

        public void Show(MagicCard mc)
        {
            
        }

        public void ShowMax(int Maximum)
        {
            Value = 1;
            Max = Maximum;
            Show();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            Value++;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            Value--;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
            callCancel();
        }
    }
}
