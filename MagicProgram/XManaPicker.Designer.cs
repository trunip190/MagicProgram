namespace MagicProgram
{
    partial class XManaPicker
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
            this.buttonUp = new System.Windows.Forms.Button();
            this.textBoxVal = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(65, 35);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(53, 23);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // textBoxVal
            // 
            this.textBoxVal.Location = new System.Drawing.Point(65, 64);
            this.textBoxVal.Name = "textBoxVal";
            this.textBoxVal.ReadOnly = true;
            this.textBoxVal.Size = new System.Drawing.Size(53, 20);
            this.textBoxVal.TabIndex = 3;
            this.textBoxVal.Text = "0";
            this.textBoxVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(18, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(88, 13);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Pick a value for X";
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(65, 90);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(53, 23);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(14, 64);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.ReadOnly = true;
            this.textBoxMax.Size = new System.Drawing.Size(45, 20);
            this.textBoxMax.TabIndex = 4;
            this.textBoxMax.Text = "0";
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(14, 119);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(45, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(65, 119);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(53, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // XManaPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxVal);
            this.Controls.Add(this.buttonUp);
            this.MinimumSize = new System.Drawing.Size(133, 154);
            this.Name = "XManaPicker";
            this.Size = new System.Drawing.Size(133, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.TextBox textBoxVal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;

    }
}
