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
    public partial class FormGames : Form
    {       
        public FormGames()
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

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wordGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormGames_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "recentToolStripMenuItem_Click"))
            {
                FormRecent fr = new FormRecent();
                fr.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "favoritesToolStripMenuItem_Click"))
            {
                FormFavorites ff = new FormFavorites();
                ff.Show();
            }
            else
                MainMenu.instance.Show();
        }
    }
}
