namespace MagicProgram
{
    partial class CardViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardViewer));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPT = new System.Windows.Forms.TextBox();
            this.pictureBoxCMC = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.counters1 = new MagicProgram.Counters();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCMC)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName.Location = new System.Drawing.Point(11, 11);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(99, 15);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(13, 153);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(170, 15);
            this.textBoxType.TabIndex = 1;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxText.Location = new System.Drawing.Point(13, 170);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(170, 81);
            this.richTextBoxText.TabIndex = 2;
            this.richTextBoxText.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 124);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(11, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 124);
            this.panel1.TabIndex = 5;
            // 
            // textBoxPT
            // 
            this.textBoxPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPT.Location = new System.Drawing.Point(131, 251);
            this.textBoxPT.Multiline = true;
            this.textBoxPT.Name = "textBoxPT";
            this.textBoxPT.Size = new System.Drawing.Size(53, 16);
            this.textBoxPT.TabIndex = 6;
            this.textBoxPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBoxCMC
            // 
            this.pictureBoxCMC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxCMC.Location = new System.Drawing.Point(110, 11);
            this.pictureBoxCMC.Name = "pictureBoxCMC";
            this.pictureBoxCMC.Size = new System.Drawing.Size(73, 16);
            this.pictureBoxCMC.TabIndex = 8;
            this.pictureBoxCMC.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBoxCMC);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Controls.Add(this.richTextBoxText);
            this.panel2.Controls.Add(this.textBoxPT);
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 272);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Activate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // counters1
            // 
            this.counters1.BackColor = System.Drawing.Color.Transparent;
            this.counters1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("counters1.BackgroundImage")));
            this.counters1.Location = new System.Drawing.Point(19, 34);
            this.counters1.MaximumSize = new System.Drawing.Size(32, 160);
            this.counters1.Name = "counters1";
            this.counters1.Size = new System.Drawing.Size(32, 160);
            this.counters1.TabIndex = 5;
            this.counters1.Visible = false;
            // 
            // CardViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.counters1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(200, 279);
            this.Name = "CardViewer";
            this.Size = new System.Drawing.Size(200, 279);
            this.Click += new System.EventHandler(this.CardViewer_Resize);
            this.Resize += new System.EventHandler(this.CardViewer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCMC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPT;
        private System.Windows.Forms.PictureBox pictureBoxCMC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Counters counters1;
    }
}
