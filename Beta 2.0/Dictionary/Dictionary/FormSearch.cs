using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class FormSearch : Form
    {
        public static string search = "";
        private readonly string DataDirectories = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\";

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
            ButtonGo.Enabled = AreControlsValid(Controls);

            if (TextBoxSearchInput.Text != "")
            {
                int j = 0;
                if (MainMenu.current_language == "English - Vietnamese")
                {
                    string[] hnt = File.ReadAllLines(DataDirectories + "words\\EnglishVietnamese\\list\\EV" + TextBoxSearchInput.Text[0] + ".txt");
                    for (int i = 0; i < hnt.Length; i++)
                    {
                        if (hnt[i].StartsWith(TextBoxSearchInput.Text))
                        {
                            ListViewHint.Items.Add(hnt[i]);
                            j++;
                        }
                        if (j > 19)
                            break;
                    }
                }
                else if (MainMenu.current_language == "English - English")
                {
                    string[] hnt = File.ReadAllLines(DataDirectories + "words\\EnglishEnglish\\list\\EE" + TextBoxSearchInput.Text[0] + ".txt");
                    for (int i = 0; i < hnt.Length; i++)
                    {
                        if (hnt[i].StartsWith(TextBoxSearchInput.Text))
                        {
                            ListViewHint.Items.Add(hnt[i]);
                            j++;
                        }
                        if (j > 19)
                            break;
                    }
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
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "browseToolStripMenuItem_Click"))
            {
                FormBrowse fb = new FormBrowse();
                fb.Show();
            }
            else
                MainMenu.instance.Show();
        }

        private void ListViewHint_SelectedIndexChanged(object sender, EventArgs e)
        {
            search = ListViewHint.SelectedItems[0].Text;
            Close();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
