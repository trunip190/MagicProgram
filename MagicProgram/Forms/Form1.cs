using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MagicProgram
{
    public partial class Form1 : Form
    {
        # region declarations
        Dictionary<int, MagicCard> lvLink = new Dictionary<int, MagicCard>();
        Dictionary<int, int> lv2Link = new Dictionary<int, int>();
        SortOrder ordering = SortOrder.Ascending;

        string filepath = "";
        int ColSort = -1;

        ImageLibrary Lib = new ImageLibrary();
        CardCollection LibCards = new CardCollection();
        CardCollection Database = new CardCollection();
        CardCollection Deck = new CardCollection();
        MRUList mrus = new MRUList();
        # endregion

        public Form1()
        {
            InitializeComponent();

            LoadImages();

            MRU_Load();
            MRU_Update();

            //Database_Load(Properties.Settings.Default.DatabaseLoc);
            LoadDatabaseCollection(Properties.Settings.Default.DatabaseDir);

            Database_loadImages();

            listView2.Columns.Clear();
            foreach (ColumnHeader ch in listView1.Columns)
            {
                listView2.Columns.Add(ch.Text);
            }

            # region try and load "Load" deck
            string sFile = Directory.GetCurrentDirectory() + "\\Resources\\Decks\\Load.txt";
            if (File.Exists(sFile))
            {
                Deck_Load(sFile);
            }
            else
            {
                Debug.WriteLine("{0}: Not found.", sFile);
            }
            # endregion
        }

        # region event
        # region toolstrip items
        # region File
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        # region Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Magic Card Xml Library (*.mcxl)|*.mcxl";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filepath = sfd.FileName;
                progressDialog1.show_text("Saving...");

                progressDialog1.Progress_Set(10, 1);

                backgroundWorker1.RunWorkerAsync(sender);

                mrus.add(filepath);
                MRU_Update();
            }
        }

        private void saveDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = Deck.Filename;

            if (!File.Exists(filename))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text file (*.txt)|*.txt|Magic Card Xml Deck (*.mcxd)|*.mcxd";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                Deck.Filename = sfd.FileName;
            }

            Deck_Save(filename);
        }

        private void saveAsDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (*.txt)|*.txt|Magic Card Xml Deck (*.mcxd)|*.mcxd";

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Deck.Filename = sfd.FileName;

            Deck_Save(Deck.Filename);
        }

        private void Deck_Save(string filename)
        {
            Deck.Filename = filename;
            string s = Path.GetExtension(Deck.Filename);

            if (s == ".mcxd")
            {
                using (Stream stream = File.Create(filename))
                {
                    XmlSerializer serial = new XmlSerializer(typeof(CardCollection));

                    serial.Serialize(stream, Deck);
                }
            }
            else if (s == ".txt")
            {
                Deck_SaveBasic(Deck.Filename);
            }
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database_Save();
        }
        # endregion

        # region Load
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files *.txt, *.csv|*.txt;*.csv";
            fileToolStripMenuItem.HideDropDown();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //clearAll();
                filepath = ofd.FileName;
                ImportFile(filepath);
            }
        }

        private void loadDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|Magic Card Xml Deck (*.mcxd)|*.mcxd";

            if (ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
            {
                Deck_Load(ofd.FileName);
            }
        }

        private void loadSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Magic Card Xml Library (*.mcxl)|*.mcxl";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                Serial_Load(filepath);
            }
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Magic Xml Database (*.mxd)|*.mxd|Text (*.txt;*.csv)|*.csv;*.txt";

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    Database_Load(ofd.FileName);
            //}

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Properties.Settings.Default.DatabaseDir;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                LoadDatabaseCollection(fbd.SelectedPath);
            }
        }
        # endregion

        private void exportDeckListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportDeckList();
        }

        void mru_Click(object sender, EventArgs e)
        {
            Output.Write("mru_Click({0}, {1})", sender, e);
            //clearAll();

            ToolStripItem tsi = sender as ToolStripItem;

            int i = recentToolStripMenuItem.DropDownItems.IndexOf(tsi);
            filepath = mrus.get(i);

            filepath = SplitString.convertFrom(filepath);

            if (File.Exists(filepath))
            {
                string ext = Path.GetExtension(filepath);

                Output.Write("Opening {0}.", filepath);
                if (ext == ".mcxl")
                {
                    clearAll();
                    Output.Write("Loading serial.");
                    Serial_Load(filepath);
                }
                else if (ext == ".csv" || ext == ".txt")
                {
                    Output.Write("Loading raw.");
                    ImportFile(filepath);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        # endregion

        # region view changing
        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = listView2.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = listView2.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = listView2.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = listView2.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = listView2.View = View.Details;
        }
        # endregion

        # region Settings
        private void updateImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateCardImages();
            updateDeckDetails();
            listView2_refresh();
        }

        private void setImageLocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ImageLoc = fbd.SelectedPath;
                Properties.Settings.Default.Save();

                Lib.image.Clear();
                LoadImages();
            }

            listView1_refresh();
        }
        # endregion

        # region Deck
        private void testDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeckTest tester = new DeckTest(Deck);
            tester.FormClosed += new FormClosedEventHandler(DeckTest_Closed);

            if (this.WindowState == FormWindowState.Maximized)
            {
                tester.WindowState = FormWindowState.Maximized;
            }
            else
            {
                tester.StartPosition = FormStartPosition.Manual;
                tester.DesktopLocation = this.DesktopLocation;
            }

            tester.Show();
            this.Hide();
        }

        private void viewStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deckStats1.LoadCard(Deck.cards);
            deckStats1.Show();
        }
        # endregion

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        # endregion

        # region buttons
        private void buttonAddOne_Click(object sender, EventArgs e)
        {
            DeckAdd(listView1.SelectedItems, false);
            deckStats1.LoadCard(Deck.cards);
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            DeckAdd(listView1.SelectedItems, true);
            deckStats1.LoadCard(Deck.cards);
        }

        private void buttonTakeOne_Click(object sender, EventArgs e)
        {
            DeckRemove(listView2.SelectedItems, false);
            deckStats1.LoadCard(Deck.cards);
        }

        private void buttonTakeAll_Click(object sender, EventArgs e)
        {
            DeckRemove(listView2.SelectedItems, true);
            deckStats1.LoadCard(Deck.cards);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = SearchResults.SelectedItem.ToString();

            if (Database.getIndex(s) == -1 || s == "")
            {
                return;
            }

            MagicCard temp = Database.getCard(s).Clone() as MagicCard;
            Deck.Add(temp);

            listView2_refresh();
        }
        # endregion

        # region listview events
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int i = listView1.SelectedIndices[0];

                loadCardviewer(i);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                int j = 0;

                string name = listView2.SelectedItems[0].Text;

                Deck.index();
                j = Deck.getIndex(name);

                //Causes everything to update due to lost focus.
                numericCount.Value = Deck.cards[j].quantity;

                LoadCard(Deck.cards[j]);
            }
        }

        private void listView_HeaderClick(object sender, ColumnClickEventArgs e)
        {
            # region check if reording column
            if (ColSort == e.Column)
            {
                # region change sort order
                if (ordering != SortOrder.Descending)
                {
                    ordering = SortOrder.Descending;
                }
                else
                {
                    ordering = SortOrder.Ascending;
                }
                # endregion
            }
            else
            {
                ordering = SortOrder.Ascending;
            }
            # endregion

            LibCards.Sort(e.Column, ordering);

            # region add back in to listview/lvlink
            listView1.Items.Clear();
            lvLink.Clear();

            listView1.OwnerDraw = true;
            listView1_refresh();
            # endregion

            //store which column was clicked
            ColSort = e.Column;
        }

        private void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column > -1)
            {
                Deck.Sort(e.Column, SortOrder.Ascending);

                listView2_refresh();
            }
        }

        private void listView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            # region check user has selected items
            if (listView2.SelectedIndices.Count < 1)
            {
                return;
            }
            # endregion

            int inc = 0;

            # region switch (e.KeyChar)
            switch (e.KeyChar)
            {
                case '+':
                    inc = 1;
                    e.Handled = true;
                    break;

                case '-':
                    inc = -1;
                    e.Handled = true;
                    break;
            }
            # endregion

            foreach (ListViewItem item in listView2.SelectedItems)
            {
                MagicCard mc = Deck.getCard(item.Text);

                if (mc.quantity + inc <= 4 || mc.Type.Contains("Basic Land"))
                {
                    mc.quantity += inc;
                }

            }

            int index = listView2.SelectedIndices[0];

            listView2_refresh();

            listView2.Focus();

            listView2.Items[index].Selected = true;
            listView2.Items[index].Focused = true;
        }
        # endregion

        # region background worker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Serial_Save(filepath);
            Output.Write("Saving.");

            for (int i = 1; i <= 10; i++) //repeat ten times
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressDialog1.Progress_step();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressDialog1.show_text("Saving complete.");
            progressDialog1.Progress_step();
        }
        # endregion

        # region textBox1 events
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    SearchResults.Items.Clear();
                }
                else
                {
                    # region search database
                    List<string> results = SearchDatabase(textBox1.Text);
                    foreach (string s in results)
                    {
                        SearchResults.Items.Add(s);
                    }
                    # endregion

                    # region search Library
                    //foreach (int i in SearchLibrary(textBox1.Text))
                    //{
                    //    SearchResults.Items.Add(listView1.Items[i].Text);
                    //}
                    # endregion

                    SearchResults.Show();
                    SearchResults.Focus();
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (SearchResults.Items.Count > 0)
            {
                SearchResults.Visible = !SearchResults.Visible;
            }
        }
        # endregion

        # region misc
        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            # region search Library version
            //string s = (SearchResults.SelectedItem.ToString());
            //int index = SearchLibrary(s)[0];

            //loadCardviewer(index);
            # endregion

            # region search database version
            string s = (SearchResults.SelectedItem.ToString());
            int i = Database.getIndex(s);

            if (i > -1)
            {
                LoadCard(Database.cards[i]);
            }
            # endregion
        }

        private void form1_Resize(object sender, EventArgs e)
        {
            # region set widths
            //int width = (panel1.Width - 33 - panel2.Width);
            int width = (panel1.Width - panel2.Width);

            # region neither collapsed
            if (!collapsablePanel1.Collapsed && !collapsablePanel2.Collapsed)
            {
                collapsablePanel1.Width = width / 2;
                collapsablePanel2.Width = width - collapsablePanel1.Width;
            }
            # endregion

            # region collapsiblePanel1 Collapsed
            if (collapsablePanel1.Collapsed && !collapsablePanel2.Collapsed)
            {
                collapsablePanel2.Width = width - collapsablePanel1.Width;
                if (collapsablePanel2.Width < 147)
                {
                    collapsablePanel2.Width = 147;
                }
            }
            # endregion

            # region collapsiblePanel2 Collapsed
            if (!collapsablePanel1.Collapsed && collapsablePanel2.Collapsed)
            {
                collapsablePanel1.Width = width - collapsablePanel2.Width;
                if (collapsablePanel1.Width < 147)
                {
                    collapsablePanel1.Width = 147;
                }
            }
            # endregion

            # region both Collapsed
            if (collapsablePanel1.Collapsed && collapsablePanel2.Collapsed)
            {
                //this.Width = collapsablePanel1.Width + 33 + collapsablePanel2.Width;

            }
            # endregion

            # endregion

            # region set lefts
            if (collapsablePanel1.Collapsed && collapsablePanel2.Collapsed)
            {
                panel2.Left = width - (panel2.Width / 2);
            }
            else
            {
                panel2.Left = collapsablePanel1.Right;

            }

            if (collapsablePanel2.Collapsed)
            {
                collapsablePanel2.Left = panel1.Width - collapsablePanel2.Width;
            }
            else
            {
                collapsablePanel2.Left = panel2.Right;
            }

            # endregion
        }

        private void DeckTest_Closed(object sender, EventArgs e)
        {
            Form tester = sender as Form;

            if (tester.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.StartPosition = FormStartPosition.Manual;
                this.DesktopLocation = tester.DesktopLocation;
            }

            this.Show();
        }

        private void hide_control(object sender, EventArgs e)
        {
            ((Control)sender).Hide();
        }

        private void numericCount_ValueChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int i = listView2.SelectedItems[0].Index;

                MagicCard mc = Deck.cards[i];
                int count = mc.quantity;

                mc.quantity = (int)numericCount.Value;

                if (mc.quantity > 4 && !mc.Type.ToLower().Contains("basic land"))
                {
                    mc.quantity = 4;
                }
                if (mc.quantity < 1)
                {
                    mc.quantity = 1;
                }

                if (mc.quantity != count)
                {
                    listView2_refresh();
                }
            }
        }
        # endregion
        # endregion

        # region methods
        # region ListView
        private void listView_resize(ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            for (int i = 0; i < lv.Columns.Count; i++)
            {
                if (lv.Columns[i].Width > 200)
                {
                    lv.Columns[i].Width = 200;
                }
            }
        }

        private void listView1_refresh()
        {
            listView1.Items.Clear();
            lvLink.Clear();

            listView1.OwnerDraw = true;
            foreach (MagicCard mc in LibCards.cards)
            {
                lvLink.Add(listView1.Items.Count, mc);
                listView1.Items.Add(mc.toListViewItem());
            }
            listView1.OwnerDraw = false;

            //resize columns
            listView_resize(listView1);
        }

        private void listView2_refresh()
        {
            listView2.Items.Clear();

            listView2.OwnerDraw = true;
            foreach (MagicCard mc in Deck.cards)
            {
                listView2.Items.Add(mc.toListViewItem());
            }
            listView2.OwnerDraw = false;

            listView_resize(listView2);

            DeckUpdate();
        }
        # endregion

        # region MRU's
        private void MRU_Update()
        {
            # region add in MRU's to toolstrip
            # region assign names
            mru1ToolStripMenuItem.Text = mrus.get(0);
            mru2ToolStripMenuItem.Text = mrus.get(1);
            mru3ToolStripMenuItem.Text = mrus.get(2);
            mru4ToolStripMenuItem.Text = mrus.get(3);
            mru5ToolStripMenuItem.Text = mrus.get(4);
            mru6ToolStripMenuItem.Text = mrus.get(5);
            # endregion

            # region make mru invisible if blank
            foreach (ToolStripMenuItem tsmi in loadToolStripMenuItem.DropDownItems)
            {
                if (tsmi.Text == "") tsmi.Visible = false;
                else tsmi.Visible = true;
            }
            # endregion
            # endregion

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            path += "\\mrus.xml";

            XmlSerializer serial = new XmlSerializer(typeof(MRUList));

            using (Stream stream = File.Open(path, FileMode.Create))
            {
                serial.Serialize(stream, mrus);
            }
        }

        private void MRU_Load()
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            path += "\\mrus.xml";

            XmlSerializer serial = new XmlSerializer(typeof(MRUList));

            using (StreamReader stream = new StreamReader(path))
            {
                mrus = (MRUList)serial.Deserialize(stream);
            }
        }
        # endregion

        # region Deck
        private void DeckUpdate()
        {
            int count = 0;
            foreach (MagicCard mc in Deck.cards)
            {
                count += mc.quantity;
            }

            label2.Text = count.ToString() + " cards.";
            deckStats1.LoadCard(Deck.cards);
        }

        private void DeckAdd(ListView.SelectedListViewItemCollection list, bool all)
        {
            Output.Write("There are {0} items selected.", list.Count);

            foreach (ListViewItem o in list)
            {
                int j = Deck.getIndex(o.Text);

                # region add to Deck
                if (j > -1)
                {
                    # region increment existing item
                    MagicCard mc = Deck.getCard(o.Text);

                    int x = LibCards.getCard(mc.Name).quantity;

                    if (mc.quantity < x)
                    {
                        # region set max amount
                        int count = 4;
                        if (mc.Type.Contains("Basic Land"))
                        {
                            count = x;
                        }
                        if (count > x) { count = x; }
                        # endregion

                        if (mc.quantity < count)
                        {
                            //'all' switch
                            if (all)
                            {
                                mc.quantity = count;
                            }
                            else
                            {
                                mc.quantity++;
                            }
                        }
                    }
                    # endregion
                }
                else
                {
                    # region new item
                    MagicCard temp = LibCards.getCard(o.Text).Clone() as MagicCard;

                    if (!all)
                    {
                        temp.quantity = 1;
                    }

                    Deck.cards.Add(temp);
                    # endregion
                }
                # endregion
            }

            Deck.index();

            listView2_refresh();
        }

        private void DeckRemove(ListView.SelectedListViewItemCollection list, bool all)
        {
            Output.Write("There are {0} items selected.", list.Count);
            foreach (ListViewItem lvi in list)
            {
                int i = lvi.Index;
                if (all)
                {
                    Deck.cards.RemoveAt(i);
                }
                else
                {
                    //remove 1
                    Deck.cards[i].quantity--;
                    if (Deck.cards[i].quantity < 1)
                    {
                        Deck.cards.RemoveAt(i);
                    }
                }
            }
            Deck.index();
            listView2_refresh();
        }
        # endregion

        # region Images
        private void LoadImages()
        {
            Debug.WriteLine("LoadImages()");
            string path = @"C:\Users\Chris\Downloads\Magic Images\";
            path = Properties.Settings.Default.ImageLoc;

            if (Directory.Exists(path))
            {
                string[] paths = Directory.GetDirectories(path);

                foreach (string p in paths)
                {
                    foreach (string s in Directory.GetFiles(p))
                    {
                        string filename = Path.GetFileNameWithoutExtension(s).ToUpper();
                        //filename = filename.Replace(p.ToUpper(), "");
                        filename = filename.Replace("’", "'");
                        //filename = filename.Replace(".JPG", "");
                        filename = filename.Replace("\\", "");

                        if (!Lib.image.ContainsKey(filename))
                        {
                            Lib.image.Add(filename, s);    //add filename to List<string> image
                        }
                    }
                }
            }

            label1_updateText();
        }

        private void LoadCard(MagicCard mc)
        {
            cardViewerLarge1.LoadCard(mc);
        }

        private void loadCardviewer(int index)
        {
            if (index > -1)
            {
                LoadCard(lvLink[index]);
                cardViewerLarge1.BackgroundImage = lvLink[index].get();
            }
        }

        private string fetchImage(string s)
        {
            string result = "";

            string temp = s.ToUpper().Replace("/", " & ");  //adjust for 'fuse' cards.

            if (Lib.image.ContainsKey(temp))
            {
                result = Lib.image[temp];
            }

            return result;
        }

        private void imageList_Load()
        {
            imageListLarge.Images.Clear();
            imageListSmall.Images.Clear();

            listView1.OwnerDraw = true;
            foreach (MagicCard mc in LibCards.cards)
            {
                string name = mc.Name.ToUpper();
                Image i = mc.get();

                imageListLarge.Images.Add(name, i);
                imageListSmall.Images.Add(name, i);
            }
            listView1.OwnerDraw = false;
        }

        private void Database_loadImages()
        {
            for (int i = 0; i < Database.cards.Count; i++)
            {
                if (!File.Exists(Database.cards[i].imgLoc))
                {
                    Database.cards[i].imgLoc = fetchImage(Database.cards[i].Name);
                }
            }
        }

        private void updateCardImages()
        {
            foreach (MagicCard mc in LibCards.cards)
            {
                if (!File.Exists(mc.imgLoc))
                {
                    mc.set(fetchImage(mc.Name));
                }
            }
            foreach (MagicCard mc in Deck.cards)
            {
                if (!File.Exists(mc.imgLoc))
                {
                    mc.set(fetchImage(mc.Name));
                }
            }
        }
        # endregion

        private List<int> SearchLibrary(string s)
        {
            List<int> results = new List<int>();
            foreach (ListViewItem l in listView1.Items)
            {
                if (l.Text.ToUpper().Contains(s.ToUpper()))
                {
                    results.Add(l.Index);
                }
            }

            return results;
        }

        private List<string> SearchDatabase(string s)
        {
            List<string> results = new List<string>();

            foreach (MagicCard mc in Database.cards)
            {
                if (mc.Name.ToUpper().Contains(s.ToUpper()))
                {
                    results.Add(mc.Name);
                }
            }

            return results;
        }

        public void show_control()
        {
            panel2.Hide();
        }

        private void label1_updateText()
        {
            label1.Text = Database.cards.Count + " records/" + Lib.image.Count + " images.";
        }
        # endregion

        # region clear/load/save
        private void clearAll()
        {
            Debug.WriteLine("clearAll()");
            LibCards.Clear();

            Deck.Clear();

            lvLink.Clear();

            listView1.Items.Clear();
            listView2.Items.Clear();

            imageListSmall.Images.Clear();
            imageListLarge.Images.Clear();
        }

        private void ConvertSaves(string directory)
        {
            foreach (string s in Directory.GetFiles(directory))
            {
                if (Path.GetExtension(s) == ".mcxd")
                {
                    Deck_Load(s);
                    string path = s.Replace(".mcxd", ".txt");
                    Deck_SaveBasic(path);
                }
            }
        }

        private void Deck_Load(string file)
        {
            if (File.Exists(file))
            {
                Deck.Clear();

                string s = Path.GetExtension(file);
                if (s == ".mcxd")
                {
                    using (Stream stream = File.Open(file, FileMode.Open))
                    {
                        XmlSerializer serial = new XmlSerializer(typeof(CardCollection));

                        Deck = (CardCollection)serial.Deserialize(stream);
                        listView2_refresh();

                        Output.Write("Deck loaded.");
                    }
                }
                else if (s == ".txt")
                {
                    Deck_LoadBasic(file);
                }

                Deck.Filename = file;
                Text = "Magic Viewer - " + file;//Path.GetFileName(file);
            }

            foreach (MagicCard mc in Deck.cards)
            {
                mc.set(fetchImage(mc.Name));
            }
        }

        private void Deck_LoadBasic(string file)
        {
            List<MagicCard> cards = new List<MagicCard>();
            using (StreamReader reader = new StreamReader(file))
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    string[] edit = s.Split('#');

                    MagicCard mc = CardMethods.GetClass(edit[0]);
                    mc.quantity = int.Parse(edit[1]);
                    cards.Add(mc);
                }
            }
            Deck.cards = cards;
            listView2_refresh();
        }

        private void Deck_SaveBasic(string file)
        {
            File.Delete(file);
            List<string> lines = new List<string>();

            foreach (MagicCard mc in Deck.cards)
            {
                lines.Add(mc.Name + "#" + mc.quantity);
            }

            File.WriteAllLines(file, lines, Encoding.Default);
        }

        private void ImportFile(string file)
        {
            if (!File.Exists(file))
            { return; }
            int zero = LibCards.cards.Count;

            using (StreamReader reader = new StreamReader(file))
            {
                string line = "";

                mrus.add(file);
                MRU_Update();

                # region load text file
                while ((line = reader.ReadLine()) != null)
                {
                    # region prepare values
                    string[] card = line.Split('#');
                    int count = 0;
                    int a = 0;
                    int b = 1;
                    # endregion

                    # region set type
                    int f = 0;
                    if (card.Length > 1 && int.TryParse(card[1], out f))
                    {
                        a = 0; b = 1;
                    }
                    else
                    {
                        int ind = line.IndexOf(' ');
                        if (ind > -1)
                        {
                            string t1 = line.Substring(0, ind).Trim();
                            string t2 = line.Substring(ind, line.Length - ind).Trim();
                            card = new string[] { t2, t1 };
                        }
                    }
                    # endregion

                    # region set quantity for card
                    if (card.Length < 2) count = 1;
                    else int.TryParse(card[b], out count);
                    # endregion

                    int index = Database.getIndex(card[a]);
                    int jIndex = LibCards.getIndex(card[a]);

                    if ((jIndex) > -1)
                    {
                        //increment existing item
                        LibCards.cards[jIndex].quantity += count;
                    }
                    else
                    {
                        # region create new items
                        # region create MagicCard
                        MagicCard temp;

                        //if (index > -1) { temp = Database.cards[index].Clone() as MagicCard; }
                        if (index > -1) { temp = CardMethods.GetClass(Database.cards[index]); }
                        else { temp = new MagicCard { Name = card[a] }; }

                        temp.quantity = count;
                        # endregion

                        # region set up image etc
                        if (temp.imgLoc.Length < 1)
                        {
                            temp.set(fetchImage(card[a].ToUpper()));
                        }
                        # endregion

                        LibCards.Add(temp);
                        # endregion
                    }
                }
                # endregion
            }

            imageList_Load();
            listView1_refresh();
        }

        private void Serial_Load(string file)
        {
            clearAll();

            if (!File.Exists(file)) return;

            mrus.add(file);
            MRU_Update();

            XmlSerializer serial = new XmlSerializer(typeof(CardCollection));

            # region
            using (Stream stream = File.Open(file, FileMode.Open))
            {
                try
                {
                    LibCards = (CardCollection)serial.Deserialize(stream);
                    Output.Write("Serial load completed.");
                }
                catch
                {
                    Output.Write("Failed to load.");
                }
            }
            # endregion

            LibCards.index();
            imageList_Load();
            listView1_refresh();
            updateCardImages();
        }

        private void Serial_Save(string file)
        {
            XmlSerializer serial = new XmlSerializer(typeof(CardCollection));

            using (Stream stream = File.Open(file, FileMode.Create))
            {
                serial.Serialize(stream, LibCards);
                Output.Write("Saved.");
            }
        }

        private void Database_Load(string file)
        {
            # region run if file exists
            if (File.Exists(file))
            {
                # region file exists
                Properties.Settings.Default.DatabaseLoc = file;
                Properties.Settings.Default.Save();

                string extension = Path.GetExtension(file);

                if (extension == ".csv")
                {
                    ImportDatabase(file);
                }
                else if (extension == ".mxd")
                {
                    try
                    {
                        using (StreamReader reader = new StreamReader(file))
                        {
                            XmlSerializer serial = new XmlSerializer(typeof(CardCollection));
                            Database = serial.Deserialize(reader) as CardCollection;
                        }
                    }
                    catch
                    {
                        progressDialog1.show_text("Failed to load database.");
                    }
                }
                # endregion
            }
            else
            {
                return;
            }
            # endregion

            listView_resize(listView1);

            Database.cards = Database.cards.OrderBy(o => o.Name).ToList();
            Database.index();
            MRU_Update();
            label1_updateText();
        }

        private void LoadDatabaseCollection(string loc)
        {
            if (!Directory.Exists(loc))
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    loc = fbd.SelectedPath;
                    Properties.Settings.Default.DatabaseDir = loc;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    return;
                }
            }

            CardCollection result = new CardCollection();

            foreach (string s in Directory.GetFiles(loc))
            {
                string ext = Path.GetExtension(s);
                if (ext == ".mxd")
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        XmlSerializer serial = new XmlSerializer(typeof(CardCollection));
                        CardCollection cards = (CardCollection)serial.Deserialize(reader);
                        result.cards.AddRange(cards.cards);
                    }
                }
            }

            Database = result;

            listView_resize(listView1);

            Database.cards = Database.cards.OrderBy(o => o.Name).ToList();
            Database.index();
            MRU_Update();
            label1_updateText();
        }

        private void ImportDatabase(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string input = reader.ReadToEnd().Replace("\r", ";");

                string[] test = SplitString.splitSafe(input, ';', '"');

                List<string[]> split = SplitString.split_number(test, 9);

                # region add in each card
                foreach (string[] sa in split)
                {
                    //"Name";"Edition";"Rarity";"Color";"Cost";"P/T";"Type";"Text";"Flavor"
                    MagicCard temp = new MagicCard
                    {
                        Name = sa[0].Trim(),
                        Edition = sa[1].Trim(),
                        Rarity = sa[2].Trim(),
                        Color = sa[3].Trim(),
                        Cost = sa[4].Trim(),
                        PT = sa[5].Trim(),
                        Type = sa[6].Trim(),
                        Text = sa[7].Trim(),
                        Flavor = sa[8].Trim()
                    };
                    Database.cards.Add(temp);
                }
                # endregion
            }
        }

        private void Database_Save()
        {
            XmlSerializer serial = new XmlSerializer(typeof(CardCollection));

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".mcxd";
            sfd.AddExtension = true;
            sfd.Filter = "Magic Xml Database (*.mxd)|*.mxd";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = File.Create(sfd.FileName))
                {
                    serial.Serialize(stream, Database);
                }
            }
        }

        private void Database_AddIn()
        {
            MessageBox.Show("Called Database_AddIn()!?");

            foreach (MagicCard mc in Database.cards)
            {
                listView1.Items.Add(mc.toListViewItem());
            }
        }

        private void ExportDeckList()
        {
            using (RichTextBox tb = new RichTextBox())
            {
                foreach (MagicCard mc in Deck.cards)
                {
                    tb.AppendText(mc.quantity + " " + mc.Name + "\r\n");
                }
                tb.SelectAll(); tb.Copy();
            }
        }
        # endregion

        private void updateDeckDetails()
        {
            for (int i = 0; i < Deck.cards.Count; i++)
            {
                MagicCard mc = Deck.cards[i];
                int j = Database.getIndex(mc.Name);
                int c = mc.quantity;

                if (j > -1 && j < Database.cards.Count)
                {
                    Deck.cards[i] = CardMethods.GetClass(Database.cards[j]);//.Copy();
                    Deck.cards[i].quantity = c;
                }

                mc.ParseText();
                mc.checkPT();
            }
        }

        private void updateClassType()
        {
            //List<string> strings = new List<string>();
            List<string> cards = new List<string>();
            char c = 'A';

            foreach (MagicCard mc in Database.cards)
            {
                string Edit = mc.Name.Replace(",", "").Replace("'", "").Replace("-", "").Replace(" ", "").Replace("/", "").Replace(":", "");

                string line = "$r [Name]#public class [Edit] : MagicCard#{#$public [Edit]()#${#$$ Name = ~[Name]~;#$$ Edition = ~[Edition]~;#$$ Rarity = ~[Rarity]~;#$$ Color = ~[Colour]~;#$$ Cost = ~[Cost]~;#$$ PT = ~[PT]~;#$$ Type = ~[Type]~;#$$ Text = ~[Text]~;#$$ Flavor = ~[Flavour]~;#$}#}#$e##";
                string lines = "$r [Name]#case ^[Name]^:#mcn = new [Edit]();#break;#$e##";

                line = line.Replace("[Edit]", Edit + mc.Edition);
                line = line.Replace("[Name]", mc.Name);
                line = line.Replace("[Edition]", mc.Edition);
                line = line.Replace("[Rarity]", mc.Rarity);
                line = line.Replace("[Colour]", mc.Color);
                line = line.Replace("[Cost]", mc.Cost);
                line = line.Replace("[PT]", mc.PT.Replace("#", ""));
                line = line.Replace("[Type]", mc.Type);
                line = line.Replace("[Text]", mc.Text.Replace("\n", "^").Replace("#", "@"));
                line = line.Replace("[Flavour]", mc.Flavor.Replace("\n", "^").Replace("#", "@"));

                line = ParseText(line);

                //strings.Add(line);

                lines = lines.Replace("[Edit]", Edit + mc.Edition);
                lines = lines.Replace("[Name]", mc.Name);

                lines = ParseText(lines);

                File.AppendAllText(@"c:\users\topher\files\" + mc.Edition + ".txt", line);
                File.AppendAllText(@"c:\users\topher\file\" + mc.Edition + ".txt", lines);

                if (mc.Name[0] != c)
                {
                    c = mc.Name[0];
                    Debug.WriteLine(c);
                }
            }
        }

        private static string ParseText(string lines)
        {

            lines = lines.Replace("#", Environment.NewLine);
            lines = lines.Replace("$r", "# region");
            lines = lines.Replace("$e", "# endregion");
            lines = lines.Replace('"', '^');
            lines = lines.Replace('~', '"');
            lines = lines.Replace('$', '\t');

            return lines;
        }

        private void updateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateClassType();
        }

        private void collapsablePanel2_CollapsedChanged()
        {
            form1_Resize(this, EventArgs.Empty);
        }

        private void convertSavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                ConvertSaves(fbd.SelectedPath);
            }
        }
    }
}