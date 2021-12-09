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
    public partial class TopicWordsSelectionPanel : UserControl
    {
        static Word w = new Word();
        public List<string> seeAlsoWords = new List<string>() { "2" };
        public List<string> matchingWords = new List<string> { "A1", "A2", "B1", "B2", "C1", "C2" };
        public List<WordHeader> mainMeanings = new List<WordHeader>();
        public string levels = "a1a2b1b2c1c2";
        public TopicWordsSelectionPanel()
        {
            InitializeComponent();
            this.mainMeaningsHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.allMatchesHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
        }
       /* public TopicsSelectionPanel()
        {

            this.seeAlsoWords = saw;
            this.mainMeanings = mm;
            foreach(string s in mm)
            {
                Debug.WriteLine(s);
            }
            foreach (Word s in mw)
            {
                Debug.WriteLine(s.id);
            }
            InitializeComponent();

            this.seeAlsoHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.mainMeaningsHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.allMatchesHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
        }*/
        public void OpenOrHidePanels(object sender, EventArgs eventArgs)
        {
            Debug.WriteLine("Hello");
            if((sender as Panel).Name.Contains("seeAlsoHeaderPanel"))
            {

                
            }else if ((sender as Panel).Name.Contains("mainMeaningsHeaderPanel"))
            {
                this.mainMeaningsButton.Text = this.mainMeaningsButton.Text == "+" ? "-" : "+";
                this.allMatchesButton.Text = "-";

            }
            else if ((sender as Panel).Name.Contains("allMatchesHeaderPanel"))
            {
                this.allMatchesButton.Text = this.allMatchesButton.Text == "+" ? "-" : "+";
                this.mainMeaningsButton.Text = "-";
            }
            RefreshPanels();
        }
        private void OnMouseEnterButton(object sender, EventArgs e)
        {

            if (sender is Panel)
            {
                if((sender as Panel).BackColor != Color.FromArgb(245, 245, 245))
                {
                    (sender as Panel).BackColor = Color.FromArgb(245, 245, 245); // or Color.Red or whatever you want
                }
            }
            else
            {
                if ((sender as Label).BackColor != Color.FromArgb(245, 245, 245))
                {
                    (sender as Label).BackColor = Color.FromArgb(245, 245, 245); // or Color.Red or whatever you want
                    ((sender as Label).Parent as Panel).BackColor = Color.FromArgb(245, 245, 245);
                    if (levels.Contains((sender as Label).Text.ToLower()))
                    {
                        ((sender as Label)).BackColor = Color.FromArgb(245, 245, 245);
                    }
                }
                
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

                if (levels.Contains((sender as Label).Text.ToLower())){

                    ((sender as Label)).BackColor = Color.FromArgb(245, 245, 245);
                }
            }
        }
        public void RefreshPanels()
        {
            this.allMatchesPanel.Controls.Clear();
            this.mainMeaningPanel.Controls.Clear();
            if (this.allMatchesButton.Text == "+")
            {
                foreach (string word in matchingWords)
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
                    wl.Text = word[0].ToString().ToUpper() + word.Substring(1).Replace("-", " ");
                    wl.Name = word;
                    wl.AutoSize = true;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    if (levels.Contains(word.ToLower()))
                    {
                        wl.BackColor = Color.FromArgb(245, 245, 245);
                    }
                    wl.Click += LevelLabel_Click;
                    p.Click += LevelPanel_Click;
                    this.allMatchesPanel.Controls.Add(p);
                }

            }
            this.mainMeaningHorizonBar.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.allMatchesPanel.PreferredSize.Height + this.allMatchesPanel.Location.Y);
            this.mainMeaningsHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningHorizonBar.Height + this.mainMeaningHorizonBar.Location.Y);
            this.mainMeaningPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningsHeaderPanel.Height + this.mainMeaningsHeaderPanel.Location.Y);
            if (this.mainMeaningsButton.Text == "+")
            {
                foreach (WordHeader word in mainMeanings)
                {
                    if (levels.Contains(word.level.ToLower()))
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
                        wl.Text = word.word;
                        wl.Name = word.id;
                        wl.BackColor = Color.Transparent;
                        p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                        p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                        wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                        wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                        p.Controls.Add(wl);
                        wl.AutoSize = true;
                        wl.Click += wordclick;

                        this.mainMeaningPanel.Controls.Add(p);
                    }
                    
                }

            }
           }

        private void wordclick(object sender, EventArgs e)
        {
            Form1.GetInstance().SetTopicResultPanelGivenId((sender as Label).Name);
        }

        private void LevelLabel_Click(object sender, EventArgs e)
        {
            if(levels.Contains((sender as Label).Text.ToLower()))
            {
                levels = levels.Replace((sender as Label).Text.ToLower(), "");
            }
            else
            {
                levels = levels + (sender as Label).Text.ToLower();
            }

            RefreshPanels();
        }

        private void LevelPanel_Click(object sender, EventArgs e)
        {
            
            if (levels.Contains(((sender as Panel).Controls[0] as Label).Text.ToLower()))
            {
                levels = levels.Replace(((sender as Panel).Controls[0] as Label).Text.ToLower(), "");
            }
            else
            {
                levels = levels + (((sender as Panel).Controls[0] as Label)).Text.ToLower();
            }

            RefreshPanels();

        }
    }
}
