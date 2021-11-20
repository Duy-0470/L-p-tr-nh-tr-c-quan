using DictionaryApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class DefintionHeader : Panel
    {
        public DefintionHeader()
        {
            InitializeComponent(new DictionaryApp.Classes.WordHeader());
        }

        public DefintionHeader(IContainer container, WordHeader wordHeader)
        {
            container.Add(this);

            InitializeComponent(wordHeader);
        }
        public void ToggleWordFormPanel(object sender, EventArgs eventArgs)
        {
            this.WordFormPanel.Visible = !this.WordFormPanel.Visible;
            this.WordFormSign.Text = this.WordFormSign.Text == "+" ? "-" : "+";
            this.Size = new System.Drawing.Size(this.Size.Width, this.WordFormBar.Location.Y + this.WordFormBar.Size.Height);
            (this.Parent as WordDefinition).ToggleWordFormPanel();
        }
        public int GetHeight()
        {
            if (WordFormPanel.Controls.Count != 0)
            {
                if(this.WordFormSign.Text == "+")
                {
                    return this.WordFormPanel.Location.Y + this.WordFormPanel.Size.Height;

                }
                else
                {
                    return this.WordFormBar.Location.Y + this.WordFormBar.Size.Height;
                }
            }
            else
            {
                return this.NAButton.Location.Y + this.NAButton.Size.Height;

            }
        }
    }
}
