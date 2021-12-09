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
    public partial class IdiomDefinition : UserControl
    {
        public IdiomDefinition(Idiom word)
        {
            InitializeComponent(word);
        }
        public IdiomDefinition()
        {
            InitializeComponent(DatabaseHandle.GetDataHandle().GetIdiomsGivenWordId("account_1")[0]);
        }
    }
}
