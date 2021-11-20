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
    public partial class WordResultPanel : UserControl
    {
        public WordResultPanel()
        {
            InitializeComponent();
        }
        private void ScrollPanel(object sender, EventArgs eventArgs)
        {
            this.Refresh();

            MouseEventArgs args = eventArgs as MouseEventArgs;
           /* int inc = args.Delta *this.VerticalScroll.SmallChange;
            this.AutoScrollPosition = new Point(
                this.AutoScrollPosition.X,
                -this.AutoScrollPosition.Y - inc);*/
            int newY = this.otherResultsPanel.Location.Y - args.Delta;
            if (newY < 0)
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X,0);
            }else if (newY > this.wordDefinition.PreferredSize.Height - this.otherResultsPanel.PreferredSize.Height)
            {
                this.otherResultsPanel.Location = new Point(this.otherResultsPanel.Location.X,
                        this.wordDefinition.PreferredSize.Height - this.otherResultsPanel.PreferredSize.Height);
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
            this.wordDefinition.Invalidate();
            this.Focus();


        }
    }
}
