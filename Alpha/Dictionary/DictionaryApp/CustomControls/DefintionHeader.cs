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
        }
    }
}
