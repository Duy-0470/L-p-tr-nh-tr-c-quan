using DictionaryApp.Classes;
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
    public partial class SensePanel : UserControl
    {
        public SensePanel(int or, Sense sense)
        {
            InitializeComponent(or, sense);
        }
    }
}
