using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class FormSearch : Form
    {
        bool search;
        
        public FormSearch()
        {
            InitializeComponent();
            ButtonGo.FlatAppearance.BorderSize = 0;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search = false;
            Close();
        }

        private void FormSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!search)
                MainMenu.instance.Show();
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            // if (search == data)
            search = true;
            Close();
            WordMeaning wm = new WordMeaning();
            wm.Show();
        }
    }
}
