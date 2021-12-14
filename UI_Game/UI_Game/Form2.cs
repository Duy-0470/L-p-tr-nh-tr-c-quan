using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Game
{
    public partial class Form2 : Form
    {
        string meaning = "meaning";
        string word = "word1";
        string shuffle;
        int select;
        int[] LinkFromSelectedToShow; 
        List<BtnChar> ShowButton;
        List<BtnChar> SelectedButton;
        Random random = new Random();
        public Form2()
        {
            InitializeComponent();
            richTextBox1.Text = meaning;
            Init();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void Init()
        {
            richTextBox1.Text = meaning;
            InitListButton();
            InitShowButton();
            InitSelectedButton();
            LinkFromSelectedToShow = new int[word.Length];
            select = 0;
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            BtnChar show = (BtnChar)sender;
            SelectedButton[select].Text = show.Text;
            show.Visible = false;
            SelectedButton[select].Visible = true;
            SelectedButton[select].ID1 = select;
            LinkFromSelectedToShow[select] = show.ID1;
            select++;
        }

        void InitListButton()
        {
            ShowButton = new List<BtnChar>();
            for (int i = 0; i < word.Length; i++)
            {
                ShowButton.Add(new BtnChar());
            }
            SelectedButton = new List<BtnChar>();
            for (int i = 0; i < word.Length; i++)
            {
                SelectedButton.Add(new BtnChar());
            }
        }
        void InitShowButton()
        {
            shuffle = new string(word.ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());
            int mid = shuffle.Length / 2;
            for (int i = 0; i < shuffle.Length; i++)
            {
                ShowButton[i].Text = shuffle[i].ToString();
                ShowButton[i].Height = 30;
                ShowButton[i].Width = 30;
                ShowButton[i].ID1 = i;
                if (word.Length % 2 == 0)
                {
                    ShowButton[i].Location = new Point((Width - ShowButton[i].Width) / 2 - ((mid - i) * 2 - 1) * ShowButton[i].Width, Height * 80 / 100);
                }
                else
                {
                    ShowButton[i].Location = new Point((Width - ShowButton[i].Width) / 2 - (mid - i) * 2 * ShowButton[i].Width, Height * 80 / 100);
                }
                ShowButton[i].Visible = true;
                Controls.Add(ShowButton[i]);
                ShowButton[i].Click += new EventHandler(ButtonShow_Click);
            }
        }
        void InitSelectedButton()
        {
            int mid = word.Length / 2;
            for (int i = 0; i < word.Length; i++)
            {
                SelectedButton[i].Text = word[i].ToString();
                SelectedButton[i].Height = 30;
                SelectedButton[i].Width = 30;
                SelectedButton[i].ID1 = i;
                if (word.Length % 2 == 0)
                {
                    SelectedButton[i].Location = new Point((Width - SelectedButton[i].Width) / 2 - ((mid - i) * 2 - 1) * SelectedButton[i].Width, Height * 20 / 100);
                }
                else
                {
                    SelectedButton[i].Location = new Point((Width - SelectedButton[i].Width) / 2 - (mid - i) * 2 * SelectedButton[i].Width, Height * 20 / 100);
                }
                SelectedButton[i].Visible = false;
                Controls.Add(SelectedButton[i]);
                SelectedButton[i].Click += new EventHandler(ButtonSelected_Click);
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string answer = "";
            for (int i = 0; i < SelectedButton.Count; i++)
            {
                answer += SelectedButton[i].Text;
            }
            if (answer == word)
            {
                lb_Score.Text = (int.Parse(lb_Score.Text) + 1000).ToString();
            }
            lb_Question.Text = (int.Parse(lb_Question.Text) + 1).ToString();
        }

        private void ButtonSelected_Click(object sender, EventArgs e)
        {
            BtnChar selected = (BtnChar)sender;
            ShowButton[LinkFromSelectedToShow[selected.ID1]].Visible = true;
            for (int i = selected.ID1; i < select - 1; i++)
            {
                LinkFromSelectedToShow[i] = LinkFromSelectedToShow[i + 1];
                SelectedButton[i].Text = SelectedButton[i + 1].Text;
            }
            SelectedButton[select - 1].Visible = false;
            select--;
        }
    }
}