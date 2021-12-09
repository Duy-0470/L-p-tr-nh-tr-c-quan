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
    public partial class Review : UserControl
    {
        Word w = null;
        List<WordHeader> mw = new List<WordHeader>();
        List<FoundWord> mm = new List<FoundWord>();
        public Review()
        {
            InitializeComponent();
        }
        public Review(Word word, List<WordHeader> mw, List<FoundWord> mm)
        {
            this.w = word;
            this.mw = mw;
            this.mm = mm;
            InitializeComponent();
        }
        public void SetPanel(Word word, List<WordHeader> mw, List<FoundWord> mm)
        {
            this.w = word;
            this.mw = mw;
            this.mm = mm;
            this.Controls.Clear();
            InitializeComponent();
        }
        private void ScrollPanel(object sender, EventArgs eventArgs)
        {
            this.Refresh();

            MouseEventArgs args = eventArgs as MouseEventArgs;
            if (w == null) return;
            /* int inc = args.Delta *this.VerticalScroll.SmallChange;
             this.AutoScrollPosition = new Point(
                 this.AutoScrollPosition.X,
                 -this.AutoScrollPosition.Y - inc);*/
            int newY = this.otherResultsPanel.Location.Y - args.Delta;
            if (newY < 0)
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X, 0);
            }
            else if (newY > this.wordDefinition.PreferredSize.Height - this.otherResultsPanel.PreferredSize.Height)
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X,
                        this.wordDefinition.PreferredSize.Height - this.otherResultsPanel.PreferredSize.Height);
            }
            else
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X, newY);
            }
            if (this.VerticalScroll.Value + args.Delta < this.VerticalScroll.Minimum)
            {
                this.VerticalScroll.Value = this.VerticalScroll.Minimum;
            }
            else if (this.VerticalScroll.Value + args.Delta > this.VerticalScroll.Maximum)
            {
                this.VerticalScroll.Value = this.VerticalScroll.Maximum;
            }
            else
            {
                this.VerticalScroll.Value += args.Delta;

            }
            this.otherResultsPanel.Invalidate();
            this.wordDefinition.Invalidate();
            this.Focus();


        }

        public void SetWordPanel(Word word)
        {
            this.w = word;
            this.Controls.Remove(this.wordDefinition);
            // Debug.WriteLine(word.id);
            if (w != null)
            {
                this.wordDefinition = new DictionaryApp.CustomControls.WordDefinition(w);
                this.wordDefinition.AutoSize = true;
                this.wordDefinition.BackColor = System.Drawing.Color.White;
                this.wordDefinition.Location = new System.Drawing.Point(300, 0);
                this.wordDefinition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                this.wordDefinition.MaximumSize = new System.Drawing.Size(648, 0);
                this.wordDefinition.Name = "wordDefinition";
                this.wordDefinition.Size = new System.Drawing.Size(500, 1466);
                this.wordDefinition.MaximumSize = new System.Drawing.Size(500, 0);
                this.wordDefinition.TabIndex = 11;
                this.text.Visible = false;
                this.wordDefinition.Visible = true;
                this.Controls.Add(this.wordDefinition);
                Debug.WriteLine(word.id);

            }
            else
            {
                this.text = new System.Windows.Forms.TextBox();
                this.text.BackColor = System.Drawing.Color.White;
                this.text.Location = new System.Drawing.Point(300, 80);
                this.text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                this.text.Name = "wordDefinition";
                this.text.Size = new System.Drawing.Size(500, 200);
                this.text.AutoSize = false;
                this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.text.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.text.TabIndex = 11;
                this.text.Text = "Oops, no tracked word is found";
                this.text.ForeColor = Color.FromArgb(150, 150, 150);
                this.text.Visible = true;
                if(wordDefinition!=null)
                    this.wordDefinition.Visible = false;
                this.Controls.Add(this.text);

            }
        }
    }
}
