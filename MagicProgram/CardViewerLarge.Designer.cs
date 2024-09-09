namespace MagicProgram
{
    partial class CardViewerLarge
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardViewerLarge));
            this.panel1 = new System.Windows.Forms.Panel();
            this.counters1 = new MagicProgram.Counters();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPT = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxCMC = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.counters1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCMC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.counters1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 165);
            this.panel1.TabIndex = 10;
            // 
            // counters1
            // 
            this.counters1.BackColor = System.Drawing.Color.Transparent;
            this.counters1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("counters1.BackgroundImage")));
            this.counters1.counters = 6;
            this.counters1.Dock = System.Windows.Forms.DockStyle.Right;
            this.counters1.Image = ((System.Drawing.Image)(resources.GetObject("counters1.Image")));
            this.counters1.Location = new System.Drawing.Point(191, 0);
            this.counters1.MaximumSize = new System.Drawing.Size(32, 160);
            this.counters1.Name = "counters1";
            this.counters1.Size = new System.Drawing.Size(32, 160);
            this.counters1.TabIndex = 1;
            this.counters1.TabStop = false;
            this.counters1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName.Location = new System.Drawing.Point(0, -1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxType
            // 
            this.textBoxType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxType.Location = new System.Drawing.Point(5, 190);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(225, 20);
            this.textBoxType.TabIndex = 7;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxText.Location = new System.Drawing.Point(5, 210);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(225, 108);
            this.richTextBoxText.TabIndex = 8;
            this.richTextBoxText.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Controls.Add(this.richTextBoxText);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(235, 340);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxPT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 17);
            this.panel3.TabIndex = 13;
            // 
            // textBoxPT
            // 
            this.textBoxPT.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxPT.Location = new System.Drawing.Point(153, 0);
            this.textBoxPT.MaximumSize = new System.Drawing.Size(72, 4);
            this.textBoxPT.Name = "textBoxPT";
            this.textBoxPT.Size = new System.Drawing.Size(72, 20);
            this.textBoxPT.TabIndex = 12;
            this.textBoxPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxName);
            this.panel4.Controls.Add(this.pictureBoxCMC);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 20);
            this.panel4.TabIndex = 14;
            // 
            // pictureBoxCMC
            // 
            this.pictureBoxCMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCMC.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCMC.Name = "pictureBoxCMC";
            this.pictureBoxCMC.Size = new System.Drawing.Size(225, 20);
            this.pictureBoxCMC.TabIndex = 2;
            this.pictureBoxCMC.TabStop = false;
            // 
            // CardViewerLarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(331, 462);
            this.MinimumSize = new System.Drawing.Size(265, 370);
            this.Name = "CardViewerLarge";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(265, 370);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.counters1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCMC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPT;
        private System.Windows.Forms.PictureBox pictureBoxCMC;
        private Counters counters1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}
