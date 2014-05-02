namespace MagicProgram
{
    partial class MagicCardViewer
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.buttonTap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.buttonDiscard);
            this.panel1.Controls.Add(this.buttonActivate);
            this.panel1.Controls.Add(this.buttonChoose);
            this.panel1.Controls.Add(this.buttonAttack);
            this.panel1.Controls.Add(this.buttonTap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(70, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 135);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 115);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscard.Location = new System.Drawing.Point(0, 92);
            this.buttonDiscard.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(212, 23);
            this.buttonDiscard.TabIndex = 3;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonActivate
            // 
            this.buttonActivate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivate.Location = new System.Drawing.Point(0, 69);
            this.buttonActivate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(212, 23);
            this.buttonActivate.TabIndex = 1;
            this.buttonActivate.Text = "Activate";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoose.Location = new System.Drawing.Point(0, 46);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(212, 23);
            this.buttonChoose.TabIndex = 2;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttack.Location = new System.Drawing.Point(0, 23);
            this.buttonAttack.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(212, 23);
            this.buttonAttack.TabIndex = 10;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Visible = false;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // buttonTap
            // 
            this.buttonTap.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTap.Location = new System.Drawing.Point(0, 0);
            this.buttonTap.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTap.Name = "buttonTap";
            this.buttonTap.Size = new System.Drawing.Size(212, 23);
            this.buttonTap.TabIndex = 0;
            this.buttonTap.Text = "Tap";
            this.buttonTap.UseVisualStyleBackColor = true;
            this.buttonTap.Click += new System.EventHandler(this.buttonTap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 296);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MagicProgram.Properties.Resources.Arbor_Elf;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.MagicCardViewer_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.MagicCardViewer_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.MagicCardViewer_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_TickOn);
            // 
            // MagicCardViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(265, 390);
            this.MinimumSize = new System.Drawing.Size(53, 74);
            this.Name = "MagicCardViewer";
            this.Size = new System.Drawing.Size(212, 316);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonActivate;
        private System.Windows.Forms.Button buttonTap;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonAttack;
    }
}
