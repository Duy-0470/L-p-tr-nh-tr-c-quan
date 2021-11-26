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
        public static string[] data, randomizer, hints;
        public Random rand = new Random();
        public int index;
        public static string[] sound = ReadAllResourceLines(Properties.Resources.words);

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
                    hints = ReadAllResourceLines(Properties.Resources.EVWordList);
                    randomizer = ReadAllResourceLines(Properties.Resources.EVWordAndSpelling);
                    break;
                case "English - English":
                    data = ReadAllResourceLines(Properties.Resources.words);
                    hints = ReadAllResourceLines(Properties.Resources.EEWordList);
                    randomizer = ReadAllResourceLines(Properties.Resources.EEWordAndSpelling);
                    break;
                default:
                    break;
            }
            WordRandomizer();
        }

        private void TextBoxSearchInput_LostFocus(object sender, EventArgs e)
        {
            //TextBoxSearchInput.ForeColor = Color.FromArgb(Convert.ToInt32("d9d9d9", 16));
            //TextBoxSearchInput.Text = "Search";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            current_language = ComboBoxLanguage.SelectedItem.ToString();
            data = ReadAllResourceLines(Properties.Resources.EngViet);
            hints = ReadAllResourceLines(Properties.Resources.EVWordName);
            randomizer = ReadAllResourceLines(Properties.Resources.EVWordAndSpelling);
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

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            index = rand.Next(0, randomizer.Length);
            if (current_language == "English - Vietnamese")
            {
                if (randomizer[index].Contains('/'))
                    FormSearch.search = randomizer[index].Substring(0, randomizer[index].IndexOf('/') - 1).Replace('@', ' ').Trim();
                else
                    FormSearch.search = randomizer[index];
            }
            else if (current_language == "English - English")
            {
                string[] tokens = randomizer[index].Split('|');
                FormSearch.search = tokens[0];
            }
            Hide();
            WordMeaning wm = new WordMeaning();
            wm.Show();
        }

        private void ButtonRandom_MouseHover(object sender, EventArgs e)
        {
            ToolTipMainMenu.SetToolTip(ButtonRandom, "Randomize a word");
        }

        public void WordRandomizer()
        {
            index = rand.Next(0, randomizer.Length);
            if (current_language == "English - Vietnamese")
            {
                if (randomizer[index].Contains('@'))
                {
                    LabelRandomizedWord.Text = randomizer[index].Substring(0, randomizer[index].IndexOf('/') - 1).Replace('@', ' ').Trim();
                    LabelRWSpelling.Text = randomizer[index].Substring(randomizer[index].IndexOf('/'));
                }
                else
                {
                    LabelRandomizedWord.Text = randomizer[index].Substring(0, randomizer[index].IndexOf('/') - 1);
                    LabelRWSpelling.Text = randomizer[index].Substring(randomizer[index].IndexOf('/'));
                }
            }
            else if (current_language == "English - English")
            {
                string[] tokens = randomizer[index].Split('|');
                while (tokens[1] == "NA")
                {
                    Array.Clear(tokens, 0, tokens.Length);
                    index = rand.Next(0, randomizer.Length);
                    tokens = randomizer[index].Split('|');
                }
                LabelRandomizedWord.Text = tokens[0];
                LabelRWSpelling.Text = tokens[1];
            }
            for (int i = 0; i < sound.Length; i++)
            {
                string[] tokens = sound[i].Split('|');
                if (tokens[0].Substring(0, tokens[0].IndexOf('|') - 2) == LabelRandomizedWord.Text)
                {
                    ButtonRMSpeak.Visible = true;
                    break;
                }
                else
                    ButtonRMSpeak.Visible = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Debug.WriteLine(LabelRandomizedWord.Text);
            FormSearch.search = LabelRandomizedWord.Text;
            Hide();
            WordMeaning wm = new WordMeaning();
            wm.Show();
        }

        private void PanelRandomWord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ComboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonRMSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

            }
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormBrowse fb = new FormBrowse();
            fb.Show();
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
    }
}
