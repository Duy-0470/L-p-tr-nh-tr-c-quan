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
    public partial class ImageSelectionPanel : UserControl
    {
        List<string> words, topics;
        List<MyImage> others;
        public ImageSelectionPanel()
        {
            words = DatabaseHandle.GetDataHandle().GetAllImageWords();
            topics = DatabaseHandle.GetDataHandle().GetImageTopics();
            others = DatabaseHandle.GetDataHandle().GetOtherTopics();
            InitializeComponent();
            this.allWordsHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.topicsHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
            this.othersHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
        }
        public void OpenOrHidePanels(object sender, EventArgs eventArgs)
        {

            if ((sender as Panel).Name.Contains("allWordsHeaderPanel"))
            {
                Debug.WriteLine("allWordsHeaderPanel");
                this.allWordsButton.Text = this.allWordsButton.Text == "+" ? "-" : "+";
                this.topicsButton.Text = "-";
                this.othersButton.Text = "-";
            }
            else if ((sender as Panel).Name.Contains("topicsHeaderPanel"))
            {
                Debug.WriteLine("topicsHeaderPanel");
                this.topicsButton.Text = this.topicsButton.Text == "+" ? "-" : "+";
                this.allWordsButton.Text = "-";
                this.othersButton.Text = "-";
            }
            else if ((sender as Panel).Name.Contains("othersHeaderPanel"))
            {
                Debug.WriteLine("othersHeaderPanel");
                this.othersButton.Text = this.othersButton.Text == "+" ? "-" : "+";
                this.allWordsButton.Text = "-";
                this.topicsButton.Text = "-";
            }
            RefreshPanels();
        }

        private void RefreshPanels()
        {
            this.allWordsPanel.Controls.Clear();
            this.othersPanel.Controls.Clear();
            this.topicsPanel.Controls.Clear();
            if (this.allWordsButton.Text == "+")
            {
                Debug.WriteLine("All");
                foreach (string word in words)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.allWordsPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word.Replace("1"," ").Replace("2"," ");
                    wl.Name = word.Replace(" ", "_");
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += clickLetterItem;

                    this.allWordsPanel.Controls.Add(p);
                }

            }
            this.topicsHorizonBar.Location = new System.Drawing.Point(this.allWordsPanel.Location.X, this.allWordsPanel.PreferredSize.Height + this.allWordsPanel.Location.Y);
            this.topicsHeaderPanel.Location = new System.Drawing.Point(this.topHorizonBar.Location.X, this.topicsHorizonBar.Height + this.topicsHorizonBar.Location.Y);
            this.topicsPanel.Location = new System.Drawing.Point(this.topicsHeaderPanel.Location.X, this.topicsHeaderPanel.Height + this.topicsHeaderPanel.Location.Y);
            if (this.topicsButton.Text == "+")
            {
                Debug.WriteLine("Topics");
                foreach (string topic in topics)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.topicsPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = topic;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += clickTopicItem;

                    this.topicsPanel.Controls.Add(p);
                }

            }
            this.othersHorizonBar.Location = new System.Drawing.Point(this.topicsPanel.Location.X, this.topicsPanel.PreferredSize.Height + this.topicsPanel.Location.Y);
            this.othersHeaderPanel.Location = new System.Drawing.Point(this.topicsHorizonBar.Location.X, this.othersHorizonBar.PreferredSize.Height + this.othersHorizonBar.Location.Y);
            this.othersPanel.Location = new System.Drawing.Point(this.othersHeaderPanel.Location.X, this.othersHeaderPanel.Height + this.othersHeaderPanel.Location.Y);
            if (this.othersButton.Text == "+")
            {
                Debug.WriteLine("Others");
                foreach (MyImage word in others)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.othersPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = char.ToUpper(word.name[0]) + word.name.Substring(1).ToLower();
                    wl.Name = word.link;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.Click += clickOthersItem;

                    p.Controls.Add(wl);
                    this.othersPanel.Controls.Add(p);
                }
            }

        }
        private void clickLetterItem(object sender, EventArgs e)
        {
            (this.Parent as PicturesView).ChangeCatalogueWithLetter((sender as Label).Text);

        }
        private void clickTopicItem(object sender, EventArgs e)
        {
            (this.Parent as PicturesView).ChangeCatalogueWithTopic((sender as Label).Text);
        }
        private void clickOthersItem(object sender, EventArgs e)
        {
            (this.Parent as PicturesView).DisplayImage((sender as Label).Name);
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            if (sender is Panel)
                (sender as Panel).BackColor = Color.FromArgb(245, 245, 245); // or Color.Red or whatever you want
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
    }
}
