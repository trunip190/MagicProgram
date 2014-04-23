namespace MagicProgram
{
    partial class CardBrowser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardBrowser));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEdition = new System.Windows.Forms.TextBox();
            this.textBoxRarity = new System.Windows.Forms.TextBox();
            this.textBoxColour = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.textBoxToughness = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardViewer1 = new MagicProgram.CardViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(550, 380);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Edition";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rarity";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Colour";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cost";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "P/T";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Text";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Flavour";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 10);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxEdition
            // 
            this.textBoxEdition.Location = new System.Drawing.Point(118, 10);
            this.textBoxEdition.Name = "textBoxEdition";
            this.textBoxEdition.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdition.TabIndex = 2;
            // 
            // textBoxRarity
            // 
            this.textBoxRarity.Location = new System.Drawing.Point(224, 10);
            this.textBoxRarity.Name = "textBoxRarity";
            this.textBoxRarity.Size = new System.Drawing.Size(100, 20);
            this.textBoxRarity.TabIndex = 3;
            // 
            // textBoxColour
            // 
            this.textBoxColour.Location = new System.Drawing.Point(330, 10);
            this.textBoxColour.Name = "textBoxColour";
            this.textBoxColour.Size = new System.Drawing.Size(100, 20);
            this.textBoxColour.TabIndex = 4;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(436, 10);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 5;
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(12, 36);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(100, 20);
            this.textBoxPower.TabIndex = 6;
            // 
            // textBoxToughness
            // 
            this.textBoxToughness.Location = new System.Drawing.Point(118, 36);
            this.textBoxToughness.Name = "textBoxToughness";
            this.textBoxToughness.Size = new System.Drawing.Size(100, 20);
            this.textBoxToughness.TabIndex = 7;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(224, 36);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 8;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(330, 36);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(100, 20);
            this.textBoxText.TabIndex = 9;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(436, 34);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Find";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.textBoxText);
            this.panel1.Controls.Add(this.textBoxEdition);
            this.panel1.Controls.Add(this.textBoxType);
            this.panel1.Controls.Add(this.textBoxRarity);
            this.panel1.Controls.Add(this.textBoxToughness);
            this.panel1.Controls.Add(this.textBoxColour);
            this.panel1.Controls.Add(this.textBoxPower);
            this.panel1.Controls.Add(this.textBoxCost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 74);
            this.panel1.TabIndex = 11;
            // 
            // cardViewer1
            // 
            this.cardViewer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardViewer1.BackgroundImage")));
            this.cardViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardViewer1.Location = new System.Drawing.Point(164, 12);
            this.cardViewer1.MinimumSize = new System.Drawing.Size(200, 279);
            this.cardViewer1.Name = "cardViewer1";
            this.cardViewer1.Size = new System.Drawing.Size(265, 370);
            this.cardViewer1.TabIndex = 11;
            // 
            // CardBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 454);
            this.Controls.Add(this.cardViewer1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(566, 382);
            this.Name = "CardBrowser";
            this.Text = "CardBrowser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEdition;
        private System.Windows.Forms.TextBox textBoxRarity;
        private System.Windows.Forms.TextBox textBoxColour;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.TextBox textBoxToughness;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
        private CardViewer cardViewer1;
    }
}