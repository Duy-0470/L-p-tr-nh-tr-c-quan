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
        public MainMenu()
        {
            InitializeComponent();
            ComboBoxLanguage.SelectionChangeCommitted += ComboBoxLanguage_SelectionChangeCommitted;
            ButtonSpeak.FlatAppearance.BorderSize = 0;
            ButtonGo.FlatAppearance.BorderSize = 0;
            Graphics g = PanelRandomWord.CreateGraphics();
            ControlPaint.DrawBorder(g, PanelRandomWord.ClientRectangle, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid, PanelSearchBar.BackColor, 4, ButtonBorderStyle.Solid);
        }

        private void ComboBoxLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {

        }

        private void PanelRandomWord_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, PanelRandomWord.ClientRectangle, Color.DarkBlue, 4, ButtonBorderStyle.Solid, Color.DarkBlue, 4, ButtonBorderStyle.Solid, Color.DarkBlue, 4, ButtonBorderStyle.Solid, Color.DarkBlue, 4, ButtonBorderStyle.Solid);            
        }
    }
}
