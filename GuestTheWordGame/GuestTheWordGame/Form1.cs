using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestTheWordGame
{
    public partial class Form1 : Form
    {
        public List<Button> listButtonShow = new List<Button>();
        public List<Button> listButtonSelected = new List<Button>();
        public List<int> check = new List<int>();
        public int[] Link;
        public string word, sences, oldWord = "";
        public int selected = 0;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            word = "reconcile";
            sences = "sences";
            label2.Text = "0";
            richTextBox1.Text = sences;
            Link = new int[word.Length];
        }
        public void InitButtonShow()
        {
            for (int i = 0; i < word.Length; i++)
            {
                ButtonShow btn = new ButtonShow();
                btn.ID = i;
                btn.Height = 20;
                btn.Width = 20;
                if (word.Length % 2 == 0)
                {
                    btn.Location = new Point(Width / 2 - 20 * word.Length + 10 + 40 * i - 7, Height * 80 / 100);
                }
                else
                {
                    btn.Location = new Point(Width / 2 - 20 * (word.Length - 1) + 10 + 40 * i - 7, Height * 80 / 100);
                }
                btn.Click += new EventHandler(ButtonShow_Click);
                listButtonShow.Add(btn);
            }
        }
        public void InitButtonSelected()
        {
            for (int i = 0; i < word.Length; i++)
            {
                ButtonSelected btn = new ButtonSelected();
                btn.ID = i;
                btn.Height = 20;
                btn.Width = 20;
                if (word.Length % 2 == 0)
                {
                    btn.Location = new Point(Width / 2 - 20 * word.Length + 10 + 40 * i - 7, Height * 80 / 100);
                }
                else
                {
                    btn.Location = new Point(Width / 2 - 20 * (word.Length - 1) + 10 + 40 * i - 7, Height * 80 / 100);
                }
                btn.Click += new EventHandler(ButtonSelected_Click);
                btn.Visible = false;
                listButtonSelected.Add(btn);
                this.Controls.Add(listButtonSelected[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowQuestion(word, sences);
        }

        public void ShowQuestion(string word, string sences)
        {
            RemoveCheck();
            RemoveButtonSelected();
            RemoveButtonShow();
            InitButtonShow();
            InitButtonSelected();
            for (int i = 0; i < word.Length; i++)
            {
                int k;
                bool flag;
                do
                {
                    flag = false;
                    Random rd = new Random();
                    k = rd.Next(0, word.Length);
                    for (int j = 0; j < check.Count; j++)
                    {
                        if (check[j] == k)
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                while (flag);
                check.Add(k);
                string word1 = "" + word[k];
                listButtonShow[i].Text = word1;
                listButtonShow[i].Visible = true;
                this.Controls.Add(listButtonShow[i]);
            }
        }
        public void RemoveButtonShow()
        {
            for (int i =0; i < oldWord.Length; i++)
            {
                this.Controls.Remove(listButtonShow[i]);
            }
            listButtonShow.Clear();
        }
        public void RemoveButtonSelected()
        {
            for (int i = 0; i < oldWord.Length; i++)
            {
                this.Controls.Remove(listButtonSelected[i]);
            }
            listButtonSelected.Clear();
        }
        public void RemoveCheck()
        {
            check.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string answer = "";
            for (int i = 0; i < listButtonSelected.Count; i++)
            {
                answer += listButtonSelected[i].Text;
            }
            if (answer == word)
            {
                int score = int.Parse(label2.Text);
                score += 1000;
                label2.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("Your answer is incorrect!");
            }
        }

        public void ButtonShow_Click(object sender, EventArgs e)
        {
            ButtonShow Sender = (ButtonShow)sender;
            ButtonSelected btn = (ButtonSelected)listButtonSelected[selected];
            btn.ID = selected;
            btn.Text = Sender.Text;
            btn.Height = 20;
            btn.Width = 20;
            btn.Visible = true;
            Sender.Visible = false;
            Link[selected] = Sender.ID;
            if (word.Length % 2 == 0)
            {
                btn.Location = new Point(Width / 2 - 20 * word.Length + 10 + 40 * selected - 7, Height * 30 / 100);
            }
            else
            {
                btn.Location = new Point(Width / 2 - 20 * (word.Length - 1) + 10 + 40 * selected - 7, Height * 30 / 100);
            }
            selected++;
        }
        public void ButtonSelected_Click(object sender, EventArgs e)
        {
            ButtonSelected Sender = (ButtonSelected)sender;
            listButtonShow[Link[Sender.ID]].Visible = true;
            int k = Sender.ID;
            for (int i = k; i < listButtonSelected.Count - 1; i++)
            {
                listButtonSelected[i].Text = listButtonSelected[i + 1].Text;
                Link[i] = Link[i + 1];
            }
            listButtonSelected[selected - 1].Visible = false;
            selected--;
        }
    }
}
