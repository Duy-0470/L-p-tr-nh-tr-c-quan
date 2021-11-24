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

namespace Dictionary
{
    public partial class FormRecent : Form
    {
        public FormRecent()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewRecent.SelectedItems[0].Text;
            Close();
        }

        private void FormRecent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void favoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRecent_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void wordGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "favoriteToolStripMenuItem_Click"))
            {
                FormFavorites ff = new FormFavorites();
                ff.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "wordGamesToolStripMenuItem_Click"))
            {
                FormGames fg = new FormGames();
                fg.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "listView1_SelectedIndexChanged"))
            {
                FormSearch fs = new FormSearch();
                fs.Show();
            }
            else
                MainMenu.instance.Show();
        }
    }
}
