using DictionaryApp.Database;
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

namespace DictionaryApp
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            DatabaseHandle.GetDataHandle();
        }

        private void dictionaryOptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickAtDictionaries(object sender, EventArgs e)
        {
            dictionariesOptionBorder.Visible = !dictionariesOptionBorder.Visible;
        }
        private void TopBarButtonGetsFocus(object sender, EventArgs e)
        {
            Button p = sender as Button;
            p.BackColor = Color.FromArgb(Convert.ToInt32("DEEAFA", 16));
            p.Font = new Font(p.Font, FontStyle.Bold);
            this.RightBorderOfDictionaries.Visible = false;

            if (p.Name == "DictionariesButton")
            {
                this.dictionariesOptionBorder.Visible = true;
            }
        }
        private void TopBarButtonLosesFocus(object sender, EventArgs e)
        {
            Button p = sender as Button;
            p.BackColor = Color.White;
            p.Font = new Font(p.Font, FontStyle.Regular);
            this.RightBorderOfDictionaries.Visible = true;

            if (p.Name == "DictionariesButton")
            {
                Debug.WriteLine(MousePosition.ToString());
                Debug.WriteLine(this.dictionariesOptions.ClientRectangle.ToString());
                if (!this.dictionariesOptionBorder.ClientRectangle.Contains(this.dictionariesOptionBorder.PointToClient(Cursor.Position)))
                {
                    this.dictionariesOptionBorder.Visible = false;
                }
            }
        }
        private void OptionLabelGetsFocused(object sender, EventArgs e)
        {
            Button p = sender as Button;
            p.BackColor = Color.FromArgb(Convert.ToInt32("CFE4F9", 16));
            p.Font = new Font(p.Font, FontStyle.Bold);
        }
        private void OptionLabelLosesFocused(object sender, EventArgs e)
        {
            Button p = sender as Button;
            p.BackColor = Color.White;
            p.Font = new Font(p.Font, FontStyle.Italic);
        }
        private void LeaveOptionPanel(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (!p.ClientRectangle.Contains(p.PointToClient(Cursor.Position)))
            {
                p.Visible = false;

            }
        }
        private void LeaveTypeSelectionButton(object sender, EventArgs e)
        {

            if (!this.TypePanelBorder.ClientRectangle.Contains(TypePanelBorder.PointToClient(Cursor.Position)))
            {
                TypePanelBorder.Visible = false;

            }
        }
        private void LeaveTypePanel(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            if (!p.ClientRectangle.Contains(p.PointToClient(Cursor.Position)))
            {
                p.Visible = false;

            }
        }

        private void OpenTypePanel(object sender, EventArgs e)
        {
            this.TypePanelBorder.Visible = !this.TypePanelBorder.Visible;
            this.TypePanelBorder.Location = new System.Drawing.Point(this.TypeSelectionButton.Location.X,
                                        this.SearchBar.Location.Y + 58);

        }
        private void ChooseType(object sender, EventArgs e)
        {
            this.TypePanelBorder.Visible = false;
            this.TypeSelectionButton.Text = (sender as Button).Text + " ...";
        }
        private void ClickAtSearchArea(object sender, EventArgs e)
        {
            if (this.SearchInput.ForeColor != Color.Black)
            {
                this.SearchInput.ForeColor = Color.Black;
                this.SearchInput.Text = "";
            }
            this.SearchInput.Focus();

        }
        private void ClickAtGoButton(object sender, EventArgs e)
        {
            this.SearchInput.ForeColor = Color.FromArgb(Convert.ToInt32("d9d9d9", 16));
            this.SearchInput.Text = "Search";
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            Hide();
            FormGamesSelect fgs = new FormGamesSelect();
            fgs.Show();
        }
    }
}
