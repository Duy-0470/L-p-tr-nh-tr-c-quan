using DictionaryApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class OtherResultsPanel : UserControl
    {
        static Word w = new Word();
        public List<Word> seeAlsoWords = new List<Word>() { w, w, w, w, w, w, w, w };
        public List<string> mainMeanings = new List<string> { "1231231", "1231231", "1231231", "1231231", "1231231" };
        public List<Word> matchingWords = new List<Word>() { w, w, w, w, w, w, w, w };

        public OtherResultsPanel()
        {
            InitializeComponent();
            this.seeAlsoButton.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.mainMeaningsButton.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.allMatchesButton.Click += new System.EventHandler(this.OpenOrHidePanels);
        }
        public void SetLists(List<Word> mw, List<string> mm, List<Word> saw)
        {
            this.seeAlsoWords = saw;
            this.matchingWords = mw;
            this.mainMeanings = mm;
        }
        public void OpenOrHidePanels(object sender, EventArgs eventArgs)
        {
            if((sender as Label).Name.ToLower().Contains("seealso"))
            {
                
                this.seeAlsoButton.Text = this.seeAlsoButton.Text == "+" ? "-" : "+";
                this.mainMeaningsButton.Text = "-";
                this.allMatchesButton.Text = "-";
            }else if ((sender as Label).Name.ToLower().Contains("mainmeanings"))
            {
                this.mainMeaningsButton.Text = this.mainMeaningsButton.Text == "+" ? "-" : "+";
                this.seeAlsoButton.Text = "-";
                this.allMatchesButton.Text = "-";
            }
            else if ((sender as Label).Name.ToLower().Contains("allmatches"))
            {
                this.allMatchesButton.Text = this.allMatchesButton.Text == "+" ? "-" : "+";
                this.seeAlsoButton.Text = "-";
                this.mainMeaningsButton.Text = "-";
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
            this.allMatchesPanel.Controls.Clear();
            this.seeAlsoPanel.Controls.Clear();
            this.mainMeaningPanel.Controls.Clear();
            if (this.allMatchesButton.Text == "+")
            {
                foreach (Word word in matchingWords)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allMatchesPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.allMatchesPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(245, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word.wordHeader.word;
                    wl.Name = word.id;
                    if (word.wordHeader.type == "noun")
                    {
                        wl.Text = wl.Text + "   (n)";
                    }
                    else if (word.wordHeader.type == "verb")
                    {
                        wl.Text = wl.Text + "   (v)";
                    }
                    else if (word.wordHeader.type == "adjective")
                    {
                        wl.Text = wl.Text + "   (adj)";
                    }
                    else if (word.wordHeader.type == "adverb")
                    {
                        wl.Text = wl.Text + "   (adv)";
                    }
                    else if (word.wordHeader.type == "preposition")
                    {
                        wl.Text = wl.Text + "   (prep)";
                    }
                    else if (word.wordHeader.type == "NA")
                    {
                        wl.Text = wl.Text + "";
                    }
                    else
                    {
                        wl.Text = wl.Text + "   (" + word.wordHeader.type.Substring(0,
                            3 > word.wordHeader.type.Length ? word.wordHeader.type.Length : 3) + ")";
                    }
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    this.allMatchesPanel.Controls.Add(p);
                }

            }
            this.mainMeaningHorizonBar.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.allMatchesPanel.PreferredSize.Height + this.allMatchesPanel.Location.Y);
            this.mainMeaningsHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningHorizonBar.Height + this.mainMeaningHorizonBar.Location.Y);
            this.mainMeaningPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningsHeaderPanel.Height + this.mainMeaningsHeaderPanel.Location.Y);
            if (this.mainMeaningsButton.Text == "+")
            {
                foreach (string meaning in mainMeanings)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allMatchesPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.mainMeaningPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(245, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = meaning;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    this.mainMeaningPanel.Controls.Add(p);
                }

            }
            this.seeAlsoHorizonBar.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningPanel.PreferredSize.Height + this.mainMeaningPanel.Location.Y);
            this.seeAlsoHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.seeAlsoHorizonBar.PreferredSize.Height + this.seeAlsoHorizonBar.Location.Y);
            this.seeAlsoPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.seeAlsoHeaderPanel.Height + this.seeAlsoHeaderPanel.Location.Y);
            if (this.seeAlsoButton.Text == "+")
            {
                foreach (Word word in seeAlsoWords)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allMatchesPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.seeAlsoPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(245, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word.wordHeader.word;
                    wl.Name = word.id;
                    if (word.wordHeader.type == "noun")
                    {
                        wl.Text = wl.Text + "   (n)";
                    }
                    else if (word.wordHeader.type == "verb")
                    {
                        wl.Text = wl.Text + "   (v)";
                    }
                    else if (word.wordHeader.type == "adjective")
                    {
                        wl.Text = wl.Text + "   (adj)";
                    }
                    else if (word.wordHeader.type == "adverb")
                    {
                        wl.Text = wl.Text + "   (adv)";
                    }
                    else if (word.wordHeader.type == "preposition")
                    {
                        wl.Text = wl.Text + "   (prep)";
                    }
                    else if (word.wordHeader.type == "NA")
                    {
                        wl.Text = wl.Text + "";
                    }
                    else
                    {
                        wl.Text = wl.Text + "   (" + word.wordHeader.type.Substring(0,
                            3 > word.wordHeader.type.Length ? word.wordHeader.type.Length : 3) + ")";
                    }
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    this.seeAlsoPanel.Controls.Add(p);
                }
            }
            
        }
    }
}
