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
    public partial class FormFavorites : Form
    {
        public FormFavorites()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void favoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFavorites_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "recentToolStripMenuItem_Click"))
            {
                FormRecent fr = new FormRecent();
                fr.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "wordGamesToolStripMenuItem_Click"))
            {
                FormGames fg = new FormGames();
                fg.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewFavorites_SelectedIndexChanged"))
            {
                FormSearch fs = new FormSearch();
                fs.Show();
            }
            else
                MainMenu.instance.Show();
        }

        private void ListViewFavorites_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewFavorites.SelectedItems[0].Text;
            Close();
        }
    }
}
