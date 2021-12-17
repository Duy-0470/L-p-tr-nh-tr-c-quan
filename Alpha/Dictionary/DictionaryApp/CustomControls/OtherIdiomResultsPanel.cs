using DictionaryApp.Classes;
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
    public partial class OtherIdiomResultsPanel : UserControl
    {
        static Word w = new Word();
        public List<string> matchingWords = new List<string>() { "w", "w", "w", "w" };
        
        public OtherIdiomResultsPanel()
        {
            InitializeComponent();
            this.allMatchesHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
        }
        public OtherIdiomResultsPanel(List<string> mw)
        {

            this.matchingWords = mw;
            
            InitializeComponent();

            this.allMatchesHeaderPanel.Click += new System.EventHandler(this.OpenOrHidePanels);
        }
        public void OpenOrHidePanels(object sender, EventArgs eventArgs)
        {
            Debug.WriteLine("Hello");
            if((sender as Label) != null)
            {
                if (((sender as Label).Parent as Panel).Name.Contains("seeAlsoHeaderPanel"))
                {
                    this.allMatchesButton.Text = "-";
                }
                else if (((sender as Label).Parent as Panel).Name.Contains("mainMeaningsHeaderPanel"))
                {
                    this.allMatchesButton.Text = "-";
                }
                else if (((sender as Label).Parent as Panel).Name.Contains("allMatchesHeaderPanel"))
                {
                    this.allMatchesButton.Text = this.allMatchesButton.Text == "+" ? "-" : "+";
                }
            }
            else
            {
                if ((sender as Panel).Name.Contains("seeAlsoHeaderPanel"))
                {
                    this.allMatchesButton.Text = "-";
                }
                else if ((sender as Panel).Name.Contains("mainMeaningsHeaderPanel"))
                {
                    this.allMatchesButton.Text = "-";
                }
                else if ((sender as Panel).Name.Contains("allMatchesHeaderPanel"))
                {
                    this.allMatchesButton.Text = this.allMatchesButton.Text == "+" ? "-" : "+";
                }

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
                    wl.Text = word[0].ToString().ToUpper() + word.Substring(1).Replace("_1", "").Replace("_2", " (2)").Replace("_3", " (3)").Replace("_4", " (4)");
                    wl.Name = word;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += MW_Click;
                    p.Click += MWPanel_Click;
                    this.allMatchesPanel.Controls.Add(p);
                }

            
            }
        }

        private void SA_Click(object sender, EventArgs e)
        {
            Form1.GetInstance().SetWordResultPanelGivenWord((sender as Label).Text.Trim(new char[]{ '(', '1', '2', ')'}).Replace(' ', '-'));
        }

        private void MW_Click(object sender, EventArgs e)
        {
            Form1.GetInstance().SetIdiomResultPanelGivenId((sender as Label).Name);
        }
        private void MWPanel_Click(object sender, EventArgs e)
        {
            Form1.GetInstance().SetIdiomResultPanelGivenId((sender as Panel).Controls[0].Name);
        }
    }
}
