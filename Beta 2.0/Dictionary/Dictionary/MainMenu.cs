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
using WMPLib;

namespace Dictionary
{
    public partial class MainMenu : Form
    {
        public static MainMenu instance;
        public static string search = "", current_language = "";
        public static string[] data, randomizer;
        public Random rand = new Random();
        public int index;

        public static IEnumerable<string> EnumerateLines(TextReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }

        public static string[] ReadAllResourceLines(string resourceText)
        {
            using (StringReader reader = new StringReader(resourceText))
            {
                return EnumerateLines(reader).ToArray();
            }
        }

        public MainMenu()
        {
            InitializeComponent();
            instance = this;
            ComboBoxLanguage.SelectedIndex = 0;
            ComboBoxLanguage.SelectionChangeCommitted += ComboBoxLanguage_SelectionChangeCommitted;
            ButtonRMSpeak.FlatAppearance.BorderSize = 0;           
            TextBoxSearchInput.LostFocus += TextBoxSearchInput_LostFocus;
        }

        private void ComboBoxLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            current_language = ComboBoxLanguage.SelectedItem.ToString();
            Array.Clear(data, 0, data.Length);
            switch (current_language)
            {
                case "English - Vietnamese":
                    data = ReadAllResourceLines(Properties.Resources.EngViet);
                    randomizer = ReadAllResourceLines(Properties.Resources.EVWordAndSpelling);
                    break;
                case "English - English":
                    data = ReadAllResourceLines(Properties.Resources.words);
                    randomizer = new string[data.Length];
                    for (int i = 0; i < data.Length; i++)
                    {
                        string[] tokens = data[i].Split('|');
                        randomizer[i] = tokens[0] + "|" + tokens[3];
                    }
                    break;
                default:
                    break;
            }
        }

        private void TextBoxSearchInput_LostFocus(object sender, EventArgs e)
        {
            TextBoxSearchInput.ForeColor = Color.FromArgb(Convert.ToInt32("d9d9d9", 16));
            TextBoxSearchInput.Text = "Search";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            Hide();
            WordMeaning wm = new WordMeaning();
            wm.Show();
        }

        private void PanelRandomWord_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PanelRandomWord.ClientRectangle, Color.DarkBlue, 4, ButtonBorderStyle.Solid, Color.DarkBlue, 4, ButtonBorderStyle.Solid, Color.DarkBlue, 4, ButtonBorderStyle.Solid, Color.DarkBlue, 4, ButtonBorderStyle.Solid);            
        }

        private void TextBoxSearchInput_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;                        
        }

        private void TextBoxSearchInput_Leave(object sender, EventArgs e)
        {
            
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            index = rand.Next(0, randomizer.Length);
            if (randomizer[index].Contains('/'))
                FormSearch.search = randomizer[index].Substring(0, randomizer[index].IndexOf('/') - 1).Replace('@', ' ').Trim();
            else
                FormSearch.search = randomizer[index];
            Hide();
            WordMeaning wm = new WordMeaning();
            wm.Show();
        }

        private void ButtonRandom_MouseHover(object sender, EventArgs e)
        {
            ToolTipMainMenu.SetToolTip(ButtonRandom, "Randomize a word");
        }

        private void ButtonGames_MouseHover(object sender, EventArgs e)
        {
            ToolTipMainMenu.SetToolTip(ButtonGames, "Play some games");
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Graphics g = PanelRandomWord.CreateGraphics();
            ControlPaint.DrawBorder(g, PanelRandomWord.ClientRectangle, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid,
                PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid,
                PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid);

            current_language = ComboBoxLanguage.SelectedItem.ToString();
            data = ReadAllResourceLines(Properties.Resources.EngViet);
            randomizer = ReadAllResourceLines(Properties.Resources.EVWordAndSpelling);
            WordRandomizer();
        }

        private void ButtonGames_Click(object sender, EventArgs e)
        {
            Hide();
            FormGames fg = new FormGames();
            fg.Show();
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormRecent fr = new FormRecent();
            fr.Show();
        }

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormFavorites ff = new FormFavorites();
            ff.Show();
        }

        private void wordGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormGames fg = new FormGames();
            fg.Show();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quit the app?", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void TextBoxSearchInput_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
            FormSearch fs = new FormSearch();
            fs.Show();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            WordRandomizer();
        }

        public void WordRandomizer()
        {
            index = rand.Next(0, randomizer.Length);
            if (current_language == "English - Vietnamese")
            {
                if (randomizer[index].Contains('/'))
                {
                    LabelRandomizedWord.Text = randomizer[index].Substring(0, randomizer[index].IndexOf('/') - 1).Replace('@', ' ').Trim();
                    LabelRWSpelling.Text = randomizer[index].Substring(randomizer[index].IndexOf('/'));
                }
                else
                {
                    LabelRandomizedWord.Text = randomizer[index].Replace('@', ' ').Trim();
                    LabelRWSpelling.Text = "";
                }
                if (LabelRWSpelling.Text == "")
                    ButtonRMSpeak.Visible = false;
                else
                    ButtonRMSpeak.Visible = true;
            }
            else if (current_language == "English - English")
            {
                string[] tokens = randomizer[index].Split('|');
                LabelRandomizedWord.Text = tokens[0];
                LabelRWSpelling.Text = tokens[1];
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSearch.search = LabelRandomizedWord.Text;
            Hide();
            WordMeaning wm = new WordMeaning();
            wm.Show();
        }
    }
}
