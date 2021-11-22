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
    public partial class MainMenu : Form
    {
        public static MainMenu instance;
        public string search = "";
        
        public MainMenu()
        {
            InitializeComponent();
            instance = this;
            ComboBoxLanguage.SelectionChangeCommitted += ComboBoxLanguage_SelectionChangeCommitted;
            ButtonRMSpeak.FlatAppearance.BorderSize = 0;
            ButtonGo.FlatAppearance.BorderSize = 0;
            Graphics g = PanelRandomWord.CreateGraphics();
            ControlPaint.DrawBorder(g, PanelRandomWord.ClientRectangle, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid);
            TextBoxSearchInput.LostFocus += TextBoxSearchInput_LostFocus;
        }

        private void TextBoxSearchInput_LostFocus(object sender, EventArgs e)
        {
            PanelRandomWord.Visible = true;
            TextBoxSearchInput.ForeColor = Color.FromArgb(Convert.ToInt32("d9d9d9", 16));
            TextBoxSearchInput.Text = "Search";
        }

        private void ComboBoxLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListViewHint.Visible = true;
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
            if (TextBoxSearchInput.ForeColor != Color.Black)
            {
                TextBoxSearchInput.ForeColor = Color.Black;
                TextBoxSearchInput.Text = "";
            }
            PanelRandomWord.Visible = false;
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
            ActiveControl = null;
            ListViewHint.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            search = LabelRandomizedWord.Text;
            Hide();
            WordMeaning wm = new WordMeaning();
            wm.Show();
        }
    }
}
