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
    public partial class FormSearch : Form
    {
        public static string search = "";
        public static string[] hints = MainMenu.ReadAllResourceLines(Properties.Resources.EVWordName);

        public FormSearch()
        {
            InitializeComponent();
            ButtonGo.FlatAppearance.BorderSize = 0;            
        }

        private bool AreControlsValid(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox tb && c.Visible)
                {
                    if (string.IsNullOrEmpty(tb.Text))
                        return false;
                }

                if (c.HasChildren)
                    AreControlsValid(c.Controls);
            }
            return true;
        }

        private void ComboBoxLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            TextBoxSearchInput.Select();
            TextBoxSearchInput.Focus();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSearch_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            search = TextBoxSearchInput.Text;
            Close();
        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemFavorites_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxSearchInput_TextChanged(object sender, EventArgs e)
        {
            ListViewHint.Items.Clear();
            int j = 0, i = 0;
            
            ButtonGo.Enabled = AreControlsValid(Controls);
            if (TextBoxSearchInput.Text != "")
            {
                while (i < hints.Count() && j < 19)
                {
                    bool flag = false;
                    for (int k = 0; k < TextBoxSearchInput.Text.Length; k++)
                    {
                        if (hints[i].Length < TextBoxSearchInput.Text.Length || hints[i][k] != TextBoxSearchInput.Text[k])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag && hints[i] != "")
                    { 
                        if (ListViewHint.FindItemWithText(hints[i]) == null)
                            ListViewHint.Items.Add(hints[i]);
                        j++;
                    }
                    i++;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "recentToolStripMenuItem_Click"))
            {
                FormRecent fr = new FormRecent();
                fr.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "toolStripMenuItem1_Click"))
            {
                FormFavorites ff = new FormFavorites();
                ff.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ToolStripMenuItemFavorites_Click"))
            {
                FormGames fg = new FormGames();
                fg.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonGo_Click")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewHint_SelectedIndexChanged"))
            {
                WordMeaning wm = new WordMeaning();
                wm.Show();
            }
            else
                MainMenu.instance.Show();
        }

        private void ListViewHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            search = ListViewHint.SelectedItems[0].Text;
            Close();
        }
    }
}
