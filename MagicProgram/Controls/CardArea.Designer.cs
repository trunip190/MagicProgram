namespace MagicProgram
{
    partial class CardArea
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDone.Location = new System.Drawing.Point(0, 0);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(346, 23);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Visible = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // CardArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.buttonDone);
            this.Name = "CardArea";
            this.Size = new System.Drawing.Size(346, 167);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CardArea_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LandArea_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button buttonDone;





    }
}
