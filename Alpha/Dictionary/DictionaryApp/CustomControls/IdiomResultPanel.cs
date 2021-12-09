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
    public partial class IdiomResultPanel : UserControl
    {
        List<Idiom> w = new List<Idiom>();
        List<string> mw = new List<string>();
        int height;
        public IdiomResultPanel()
        {
            InitializeComponent();
            height = this.PreferredSize.Height;
        }
        public IdiomResultPanel(List<Idiom> word, List<string> mw)
        {
            this.w = word;
            this.mw = mw;
            InitializeComponent();
            height = this.PreferredSize.Height;

        }
        public void SetPanel(List<Idiom> word, List<string> mw)
        {
            this.w = word;
            this.mw = mw;
            this.Controls.Clear();
            InitializeComponent();
            height = this.PreferredSize.Height;

        }
        private void ScrollPanel(object sender, EventArgs eventArgs)
        {
            this.Refresh();
            if (this.wordDefinition == null) return;
            MouseEventArgs args = eventArgs as MouseEventArgs;
            if (w == null) return;
           /* int inc = args.Delta *this.VerticalScroll.SmallChange;
            this.AutoScrollPosition = new Point(
                this.AutoScrollPosition.X,
                -this.AutoScrollPosition.Y - inc);*/
            int newY = this.otherResultsPanel.Location.Y - args.Delta;
            if (newY < 0)
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X,0);
            }else if (newY > height - this.otherResultsPanel.PreferredSize.Height - 600)
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X,
                        height - this.otherResultsPanel.PreferredSize.Height - 600);
            }
            else
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X,newY);
            }

            if(this.VerticalScroll.Value + args.Delta < this.VerticalScroll.Minimum)
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
            if (this.wordDefinition != null)
            {
                this.wordDefinition.Invalidate();

            }
            this.Focus();


        }
    }
}
