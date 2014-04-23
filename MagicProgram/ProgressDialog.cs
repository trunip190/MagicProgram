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
    public partial class ProgressDialog : UserControl
    {
        public ProgressDialog()
        {            
            InitializeComponent();
        }

        public void show_text(string s)
        {
            textBox1.Text = s;
            if (!Visible)
                Show();
        }

        public void Progress_Set(int max, int step)
        {
            progressBar1.Maximum = max;
            progressBar1.Step = step;
        }

        public void Progress_step()
        {
            progressBar1.PerformStep();

            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Hide();
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
