namespace MagicProgram
{
    partial class ManaWheel
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
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonGrey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRed
            // 
            this.buttonRed.BackgroundImage = global::MagicProgram.Properties.Resources.R;
            this.buttonRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRed.Location = new System.Drawing.Point(61, 3);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(23, 23);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = true;
            this.buttonRed.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackgroundImage = global::MagicProgram.Properties.Resources.G;
            this.buttonGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGreen.Location = new System.Drawing.Point(32, 3);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(23, 23);
            this.buttonGreen.TabIndex = 1;
            this.buttonGreen.UseVisualStyleBackColor = true;
            this.buttonGreen.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackgroundImage = global::MagicProgram.Properties.Resources.W;
            this.buttonWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonWhite.Location = new System.Drawing.Point(3, 32);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(23, 23);
            this.buttonWhite.TabIndex = 2;
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackgroundImage = global::MagicProgram.Properties.Resources.B;
            this.buttonBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBlack.Location = new System.Drawing.Point(61, 32);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(23, 23);
            this.buttonBlack.TabIndex = 3;
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackgroundImage = global::MagicProgram.Properties.Resources.U;
            this.buttonBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBlue.Location = new System.Drawing.Point(3, 3);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(23, 23);
            this.buttonBlue.TabIndex = 4;
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonGrey
            // 
            this.buttonGrey.BackgroundImage = global::MagicProgram.Properties.Resources._1;
            this.buttonGrey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGrey.Location = new System.Drawing.Point(32, 32);
            this.buttonGrey.Name = "buttonGrey";
            this.buttonGrey.Size = new System.Drawing.Size(23, 23);
            this.buttonGrey.TabIndex = 5;
            this.buttonGrey.UseVisualStyleBackColor = true;
            this.buttonGrey.Click += new System.EventHandler(this.button_Click);
            // 
            // ManaWheel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGrey);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonRed);
            this.Name = "ManaWheel";
            this.Size = new System.Drawing.Size(89, 59);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonGrey;
    }
}
