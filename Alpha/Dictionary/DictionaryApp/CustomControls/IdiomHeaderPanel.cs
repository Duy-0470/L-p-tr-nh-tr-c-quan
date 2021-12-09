using DictionaryApp.Classes;
using DictionaryApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class IdiomHeaderPanel : Panel
    {

        IdiomHeader header;
        public IdiomHeaderPanel()
        {
            InitializeComponent(new IdiomHeader());
        }

        
        public IdiomHeaderPanel(IContainer container, IdiomHeader wordHeader)
        {
            container.Add(this);

            InitializeComponent(wordHeader);
            this.header = wordHeader;
        }
    }
}
