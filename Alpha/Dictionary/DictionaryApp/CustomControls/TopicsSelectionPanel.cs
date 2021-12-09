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
    public partial class TopicsSelectionPanel : UserControl
    {
        static Word w = new Word();
        public List<string> seeAlsoWords = new List<string>() { "2" };
        public List<string> mainMeanings = new List<string> { "1231231", "1231231", "1231231", "1231231", "1231231" };
        public List<string> matchingWords = DatabaseHandle.GetDataHandle().GetTopics();
        string topic="", subtopic="";

        public TopicsSelectionPanel()
        {
            InitializeComponent();
            this.seeAlsoHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
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
                if(DatabaseHandle.GetDataHandle().CheckTopicandSubtopic(topic, subtopic))
                {
                    this.seeAlsoButton.Text = this.seeAlsoButton.Text == "+" ? "-" : "+";
                    this.mainMeaningsButton.Text = "-";
                    this.allMatchesButton.Text = "-";
                }
                else
                {
                    this.seeAlsoButton.Text = "-";
                }
                
            }else if ((sender as Panel).Name.Contains("mainMeaningsHeaderPanel"))
            {
                if (topic != "")
                {
                    this.mainMeaningsButton.Text = this.mainMeaningsButton.Text == "+" ? "-" : "+";
                    this.seeAlsoButton.Text = "-";
                    this.allMatchesButton.Text = "-";
                }
                else
                {
                    this.mainMeaningsButton.Text = "-";
                }
                
            }
            else if ((sender as Panel).Name.Contains("allMatchesHeaderPanel"))
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
                    wl.Text = word[0].ToString().ToUpper() + word.Substring(1).Replace("-"," ");
                    wl.Name = word;
                    Debug.WriteLine(word);
                    wl.AutoSize = true;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += Topic_Click;
                    this.allMatchesPanel.Controls.Add(p);
                }

            }
            this.mainMeaningHorizonBar.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.allMatchesPanel.PreferredSize.Height + this.allMatchesPanel.Location.Y);
            this.mainMeaningsHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningHorizonBar.Height + this.mainMeaningHorizonBar.Location.Y);
            this.mainMeaningPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningsHeaderPanel.Height + this.mainMeaningsHeaderPanel.Location.Y);
            if (this.mainMeaningsButton.Text == "+")
            {
                foreach (string word in mainMeanings)
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
                    wl.Text = word[0].ToString().ToUpper() + word.Substring(1).Replace("-", " ");
                    wl.Name = word;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.AutoSize = true;
                    wl.Click += Subtopic_Click;

                    this.mainMeaningPanel.Controls.Add(p);
                }

            }
            this.seeAlsoHorizonBar.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.mainMeaningPanel.PreferredSize.Height + this.mainMeaningPanel.Location.Y);
            this.seeAlsoHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.seeAlsoHorizonBar.PreferredSize.Height + this.seeAlsoHorizonBar.Location.Y);
            this.seeAlsoPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.seeAlsoHeaderPanel.Height + this.seeAlsoHeaderPanel.Location.Y);
            if (this.seeAlsoButton.Text == "+")
            {
                foreach (string word in seeAlsoWords)
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
                    wl.Text = word[0].ToString().ToUpper() + word.Substring(1).Replace("-", " ").Replace("_", " ");
                    wl.Name = word;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.AutoSize = true;
                    wl.Click += SA_Click;
                    this.seeAlsoPanel.Controls.Add(p);
                }
            }
        }

        private void SA_Click(object sender, EventArgs e)
        {
            (this.Parent as Topics).SetWordList(DatabaseHandle.GetDataHandle().GetWordsGivenTopic(topic, subtopic, (sender as Label).Name));
        }

        private void MW_Click(object sender, EventArgs e)
        {
            // Form1.GetInstance().SetWordResultPanelGivenId((sender as Label).Name);
        }

        private void Topic_Click(object sender, EventArgs e)
        {
            this.topic = (sender as Label).Name;
            mainMeanings = DatabaseHandle.GetDataHandle().GetSubTopics(this.topic);
            this.mainMeaningsButton.Text = "+";
            this.seeAlsoButton.Text = "-";
            this.allMatchesButton.Text = "-";

            RefreshPanels();

        }
        private void Subtopic_Click(object sender, EventArgs e)
        {
            this.subtopic = (sender as Label).Name;
            seeAlsoWords = DatabaseHandle.GetDataHandle().GetSubsubTopics(this.topic, this.subtopic);
            this.mainMeaningsButton.Text = "-";
            this.seeAlsoButton.Text = "+";
            this.allMatchesButton.Text = "-";

            RefreshPanels();

        }

    }
}
