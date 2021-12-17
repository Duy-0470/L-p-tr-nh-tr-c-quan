using DictionaryApp.Classes;
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
        private static Form1 instance;
        public static Form1 GetInstance()
        {
            return instance;
        }
        public Form1()
        {
            InitializeComponent();
            Text = "Your Dictionaries";

            DatabaseHandle.GetDataHandle();
            instance = this;

            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            this.TypeSelectionButton.Location = new Point((int)(this.Size.Width - (
                                            this.TypeSelectionButton.Size.Width + this.SearchInputBorder.Size.Width + this.GoButton.Size.Width)) / 2, 10);
            
            this.SearchInputBorder.Location = new Point(this.TypeSelectionButton.Location.X+this.TypeSelectionButton.Size.Width, 10);
            this.GoButton.Location = new Point(this.SearchInputBorder.Location.X+ this.SearchInputBorder.Size.Width, 10);
            this.picturesView.Location = new Point((int)(this.Size.Width - this.picturesView.PreferredSize.Width) / 2, 130);
            this.wordResultPanel.Location = new Point((int)(this.Size.Width - this.wordResultPanel.PreferredSize.Width) / 2, 180);
            this.idiomResultPanel.Location = new Point((int)(this.Size.Width - this.idiomResultPanel.PreferredSize.Width) / 2, 180);
            this.review1.Location = new Point((int)(this.Size.Width - this.review1.PreferredSize.Width) / 2, 150);
            this.topics.Location = new Point((int)(this.Size.Width - this.topics.PreferredSize.Width) / 2-20, 130);

            this.PicturesButton.Click += TopicsButton_Click;
            this.review1.Visible = false;
            this.idiomResultPanel.Visible = false;
        }
        private void TopicsButton_Click(object sender, EventArgs e)
        {
            this.SearchBar.Visible = false;
            this.wordResultPanel.Visible = false;
            this.review1.Visible = false;
            this.picturesView.Visible = false;
            this.idiomResultPanel.Visible = false;
            this.topics.Visible = true;

        }
        private void PicturesButton_Click(object sender, EventArgs e)
        {
            this.SearchBar.Visible = false;
            this.wordResultPanel.Visible = false;
            this.review1.Visible = false;
            this.picturesView.Visible = true;
            this.idiomResultPanel.Visible = false;
            this.topics.Visible = false;

        }

        private void idiomButton_Click(object sender, System.EventArgs e)
        {
            this.SearchBar.Visible = true;
            this.wordResultPanel.Visible = false;
            this.review1.Visible = false;
            this.picturesView.Visible = false;
            this.idiomResultPanel.Visible = true;
            this.TypeSelectionButton.Text = "Idioms ...";
            this.topics.Visible = false;


        }
        private void EngengButton_Click(object sender, System.EventArgs e)
        {
            this.SearchBar.Visible = true;
            this.wordResultPanel.Visible = true;
            this.review1.Visible = false;
            this.picturesView.Visible = false;
            this.idiomResultPanel.Visible = false;
            this.TypeSelectionButton.Text = "English - English ...";
            this.topics.Visible = false;

        }

        private void ReviewButton_Click(object sender, System.EventArgs e)
        {
            this.SearchBar.Visible = false;
            this.wordResultPanel.Visible = false;
            this.picturesView.Visible = false;
            this.review1.Visible = true;
            this.review1.SetPanel(null, DatabaseHandle.GetDataHandle().GetMarkedWord(), DatabaseHandle.GetDataHandle().LoadHistory());
            this.review1.Location = new Point((int)(this.Size.Width - this.review1.PreferredSize.Width) / 2, 150);
            this.topics.Visible = false;
            this.idiomResultPanel.Visible=false;

        }

        private void dictionaryOptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickAtDictionaries(object sender, EventArgs e)
        {
            Debug.WriteLine( this.VerticalScroll.Value);
            dictionariesOptionBorder.Visible = !dictionariesOptionBorder.Visible;
            Debug.WriteLine(this.VerticalScroll.Value);

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
            if(this.TypeSelectionButton.Text.Contains("English")){
                this.wordResultPanel.Visible = true;
                this.idiomResultPanel.Visible = false;
            }
            else
            {
                this.wordResultPanel.Visible = false;
                this.idiomResultPanel.Visible = true;
            }
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
        public void SetWordResultPanelGivenWord(string word)
        {
            List<Word> mw = new List<Word>();
            List<string> mm = new List<string>(), saw = new List<string>();
            Word w = DatabaseHandle.GetDataHandle().Find(word.ToLower(), ref mw, ref mm, ref saw);
            Debug.WriteLine(w);
            Debug.WriteLine(mw);
            Debug.WriteLine(mm);
            Debug.WriteLine(saw);
            if (w != null)
            {
                this.wordResultPanel.SetPanel(w, mw, mm, saw);
                this.wordResultPanel.Location = new Point((int)(this.Size.Width - this.wordResultPanel.PreferredSize.Width) / 2, 180);

            }
        }
        public void SetWordResultPanelGivenId(string id)
        {
            List<Word> mw = new List<Word>();
            List<string> mm = new List<string>(), saw = new List<string>();
            Word w = DatabaseHandle.GetDataHandle().FindGivenId(id.ToLower(), ref mw, ref mm, ref saw);
            Debug.WriteLine(w);
            Debug.WriteLine(mw);
            Debug.WriteLine(mm);
            Debug.WriteLine(saw);
            if (w != null)
            {
                
            }
            this.wordResultPanel.SetPanel(w, mw, mm, saw);
            this.wordResultPanel.Location = new Point((int)(this.Size.Width - this.wordResultPanel.PreferredSize.Width) / 2, 180);

        }
        public void SetIdiomResultPanelGivenId(string id)
        {
            
            this.idiomResultPanel.SetPanel(
                        DatabaseHandle.GetDataHandle().GetIdiomsGivenWordId(id),
                        DatabaseHandle.GetDataHandle().GetAlspMatchingIdioms(id.Replace("_", "").Replace("4", "").Replace("3", "").Replace("2", "").Replace("1", "")));
            this.idiomResultPanel.Location = new Point((int)(this.Size.Width - this.wordResultPanel.PreferredSize.Width) / 2, 180);

        }
        public void SetTopicResultPanelGivenId(string id)
        {

            this.topics.SetWordPanel(DatabaseHandle.GetDataHandle().GetWordGivenId(id));
            this.topics.Location = new Point((int)(this.Size.Width - this.topics.PreferredSize.Width) / 2 - 20, 130);

        }
        private void ClickAtGoButton(object sender, EventArgs e)
        {
            if (this.TypeSelectionButton.Text.Contains("English"))
            {
                if (this.SearchInput.ForeColor != Color.FromArgb(Convert.ToInt32("d9d9d9", 16)) && this.SearchInput.Text != "")
                {
                    List<Word> mw = new List<Word>();
                    List<string> mm = new List<string>(), saw = new List<string>();
                    Word w = DatabaseHandle.GetDataHandle().Find(this.SearchInput.Text.Replace(' ', '-'), ref mw, ref mm, ref saw);
                    Debug.WriteLine(w);
                    Debug.WriteLine(mw);
                    Debug.WriteLine(mm);
                    Debug.WriteLine(saw);
                    this.wordResultPanel.SetPanel(w, mw, mm, saw);
                }

                this.wordResultPanel.Location = new Point((int)(this.Size.Width - this.wordResultPanel.PreferredSize.Width) / 2, 180);

                this.SearchInput.ForeColor = Color.FromArgb(Convert.ToInt32("d9d9d9", 16));
                this.SearchInput.Text = "Search";
            }
            else
            {
                if (this.SearchInput.ForeColor != Color.FromArgb(Convert.ToInt32("d9d9d9", 16)) && this.SearchInput.Text != "")
                {
                    this.idiomResultPanel.SetPanel(
                        DatabaseHandle.GetDataHandle().GetIdiomsGivenWord(this.SearchInput.Text.Replace(' ', '-')),
                        DatabaseHandle.GetDataHandle().GetAlspMatchingIdioms(this.SearchInput.Text.Replace(' ', '-')));
                }

                this.idiomResultPanel.Location = new Point((int)(this.Size.Width - this.idiomResultPanel.PreferredSize.Width) / 2, 180);

                this.SearchInput.ForeColor = Color.FromArgb(Convert.ToInt32("d9d9d9", 16));
                this.SearchInput.Text = "Search";
            }
        }
        private void ButtonGames_Click(object sender, EventArgs e)
        {
            Hide();
            FormGamesSelect fgs = new FormGamesSelect();
            fgs.Show();
        }
    }
}
