using DictionaryApp.Classes;
using DictionaryApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class ReviewSelection : UserControl
    {

        public List<WordHeader> markWords = new List<WordHeader>() ;
        public List<FoundWord> history = new List<FoundWord>();
        
        public ReviewSelection()
        {
            InitializeComponent();
            this.historyHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.markedWordsHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
        }
        public ReviewSelection(List<WordHeader> mw, List<FoundWord> mm)
        {

            this.markWords = mw;
            this.history = mm;
            mw.OrderBy(w => w.word);
            mm.OrderBy(w => Convert.ToDateTime(w.time));
            InitializeComponent();

            // this.seeAlsoHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.historyHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.markedWordsHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
        }
        public void OpenOrHidePanels(object sender, EventArgs eventArgs)
        {
            Debug.WriteLine("Hello");
            if((sender as Panel).Name.Contains("seeAlsoHeaderPanel"))
            {
                
                // this.seeAlsoButton.Text = // this.seeAlsoButton.Text == "+" ? "-" : "+";
                this.historyButton.Text = "-";
                this.markedWordsButton.Text = "-";
            }else if ((sender as Panel).Name.Contains("historyHeaderPanel"))
            {
                this.historyButton.Text = this.historyButton.Text == "+" ? "-" : "+";
                // this.seeAlsoButton.Text = "-";
                this.markedWordsButton.Text = "-";
            }
            else if ((sender as Panel).Name.Contains("markedWordsHeaderPanel"))
            {
                this.markedWordsButton.Text = this.markedWordsButton.Text == "+" ? "-" : "+";
                // this.seeAlsoButton.Text = "-";
                this.historyButton.Text = "-";
            }
            RefreshPanels();
        }
        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            if(sender is Panel)
                (sender as Panel).BackColor = Color.FromArgb(245,245,245); // or Color.Red or whatever you want
            else
            {
                (sender as Label).BackColor = Color.FromArgb(245, 245, 245); // or Color.Red or whatever you want
                ((sender as Label).Parent as Panel).BackColor = Color.FromArgb(245, 245, 245);
            }

        }
        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            if (sender is Panel)
                (sender as Panel).BackColor = Color.White; // or Color.Red or whatever you want
            else
            {
                (sender as Label).BackColor = Color.Transparent; // or Color.Red or whatever you want
                ((sender as Label).Parent as Panel).BackColor = Color.White;
            }
        }
        private void RefreshPanels()
        {
            this.markedWordsPanel.Controls.Clear();
            // this.seeAlsoPanel.Controls.Clear();
            this.historyPanel.Controls.Clear();
            if (this.markedWordsButton.Text == "+")
            {
                foreach (WordHeader word in markWords)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(markedWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.markedWordsPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(245, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word.word;
                    wl.Name = word.id;
                    if (word.type == "noun")
                    {
                        wl.Text = wl.Text + "   (n)";
                    }
                    else if (word.type == "verb")
                    {
                        wl.Text = wl.Text + "   (v)";
                    }
                    else if (word.type == "adjective")
                    {
                        wl.Text = wl.Text + "   (adj)";
                    }
                    else if (word.type == "adverb")
                    {
                        wl.Text = wl.Text + "   (adv)";
                    }
                    else if (word.type == "preposition")
                    {
                        wl.Text = wl.Text + "   (prep)";
                    }
                    else if (word.type == "NA")
                    {
                        wl.Text = wl.Text + "";
                    }
                    else
                    {
                        wl.Text = wl.Text + "   (" + word.type.Substring(0,
                            3 > word.type.Length ? word.type.Length : 3) + ")";
                    }
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += MW_Click;
                    this.markedWordsPanel.Controls.Add(p);
                }

            }
            this.historyHorizonBar.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.markedWordsPanel.PreferredSize.Height + this.markedWordsPanel.Location.Y);
            this.historyHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.historyHorizonBar.Height + this.historyHorizonBar.Location.Y);
            this.historyPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.historyHeaderPanel.Height + this.historyHeaderPanel.Location.Y);
            if (this.historyButton.Text == "+")
            {
                foreach (FoundWord word in history)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(markedWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.historyPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(245, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word.word;
                    wl.Name = word.id;
                    if (word.type == "noun")
                    {
                        wl.Text = wl.Text + "   (n)";
                    }
                    else if (word.type == "verb")
                    {
                        wl.Text = wl.Text + "   (v)";
                    }
                    else if (word.type == "adjective")
                    {
                        wl.Text = wl.Text + "   (adj)";
                    }
                    else if (word.type == "adverb")
                    {
                        wl.Text = wl.Text + "   (adv)";
                    }
                    else if (word.type == "preposition")
                    {
                        wl.Text = wl.Text + "   (prep)";
                    }
                    else if (word.type == "NA")
                    {
                        wl.Text = wl.Text + "";
                    }
                    else
                    {
                        wl.Text = wl.Text + "   (" + word.type.Substring(0,
                            3 > word.type.Length ? word.type.Length : 3) + ")";
                    }
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += SA_Click;

                    this.historyPanel.Controls.Add(p);
                }

            }
            // this.seeAlsoHorizonBar.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.historyPanel.PreferredSize.Height + this.historyPanel.Location.Y);
            // this.seeAlsoHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, // this.seeAlsoHorizonBar.PreferredSize.Height + // this.seeAlsoHorizonBar.Location.Y);
            // this.seeAlsoPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, // this.seeAlsoHeaderPanel.Height + // this.seeAlsoHeaderPanel.Location.Y);
            
        }

        private void SA_Click(object sender, EventArgs e)
        {
            (this.Parent as Review).SetWordPanel(DatabaseHandle.GetDataHandle().GetWordGivenId((sender as Label).Name));
        }

        private void MW_Click(object sender, EventArgs e)
        {
            (this.Parent as Review).SetWordPanel(DatabaseHandle.GetDataHandle().GetWordGivenId((sender as Label).Name));
        }
        private void FlipMarkedWords(object sender, EventArgs e)
        {
            this.markWords.Reverse();
            RefreshPanels();           
        }
        private void FlipHistory(object sender, EventArgs e)
        {
            this.history.Reverse();
            RefreshPanels();
        }
        private void ClearHistory(object sender, EventArgs e)
        {
            DatabaseHandle.GetDataHandle().ClearHistory();
            this.history.Clear();
            RefreshPanels();
            (this.Parent as Review).SetWordPanel(null);

        }

    }
}
