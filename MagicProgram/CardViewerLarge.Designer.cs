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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPT = new System.Windows.Forms.TextBox();
            this.pictureBoxCMC = new System.Windows.Forms.PictureBox();
            this.counters1 = new MagicProgram.Counters();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCMC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.counters1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 159);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(2, 1);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(3, 192);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(226, 20);
            this.textBoxType.TabIndex = 7;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(2, 211);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(227, 108);
            this.richTextBoxText.TabIndex = 8;
            this.richTextBoxText.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBoxPT);
            this.panel2.Controls.Add(this.pictureBoxCMC);
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.richTextBoxText);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Location = new System.Drawing.Point(17, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 339);
            this.panel2.TabIndex = 11;
            // 
            // textBoxPT
            // 
            this.textBoxPT.Location = new System.Drawing.Point(158, 319);
            this.textBoxPT.Name = "textBoxPT";
            this.textBoxPT.Size = new System.Drawing.Size(72, 20);
            this.textBoxPT.TabIndex = 12;
            this.textBoxPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxCMC
            // 
            this.pictureBoxCMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxCMC.Location = new System.Drawing.Point(156, 1);
            this.pictureBoxCMC.Name = "pictureBoxCMC";
            this.pictureBoxCMC.Size = new System.Drawing.Size(73, 20);
            this.pictureBoxCMC.TabIndex = 2;
            this.pictureBoxCMC.TabStop = false;
            // 
            // counters1
            // 
            this.counters1.BackColor = System.Drawing.Color.Transparent;
            this.counters1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("counters1.BackgroundImage")));
            this.counters1.counters = 6;
            this.counters1.Location = new System.Drawing.Point(191, -2);
            this.counters1.MaximumSize = new System.Drawing.Size(32, 160);
            this.counters1.Name = "counters1";
            this.counters1.Size = new System.Drawing.Size(32, 160);
            this.counters1.TabIndex = 1;
            this.counters1.Visible = false;
            // 
            // CardViewerLarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "CardViewerLarge";
            this.Size = new System.Drawing.Size(265, 370);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}
