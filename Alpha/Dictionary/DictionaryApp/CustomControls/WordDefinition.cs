using DictionaryApp.Classes;
using DictionaryApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class WordDefinition : UserControl
    {
        public WordDefinition(Word word)
        {
            InitializeComponent(word);
        }
        public WordDefinition()
        {
            InitializeComponent(DatabaseHandle.GetDataHandle().FindWord("kill_1"));
        }
        public void ToggleWordFormPanel()
        {
            this.sensePanel.Location = new System.Drawing.Point(0, defintionHeader1.Location.Y + defintionHeader1.GetHeight()+20);
        }
    }
}
