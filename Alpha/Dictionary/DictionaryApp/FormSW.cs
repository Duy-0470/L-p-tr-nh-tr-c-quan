﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class FormSW : Form
    {
        private string meaning = "meaning";
        private string word = "word1";
        private string shuffle;
        private int select;
        private int desX, desY, disX, disY;
        private int move = 0;
        private CustomControls.BtnChar tempBtnChar;
        private List<CustomControls.BtnChar> listBtn;
        private List<CustomControls.BtnChar> listAnswer;
        private readonly Random random = new Random();

        public FormSW()
        {
            InitializeComponent();
            richTextBox1.Text = meaning;
            Bounds = Screen.PrimaryScreen.Bounds;
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
            InitlistBtn();
            select = 0;
        }

        private void ButtonChar_Click(object sender, EventArgs e)
        {
            CustomControls.BtnChar btn = (CustomControls.BtnChar)sender;
            int mid = word.Length / 2;
            if (btn.X == btn.Location.X && btn.Y == btn.Location.Y)
            {
                desX = (Width - btn.Width) / 2 - ((mid - select) * 2 - 1) * btn.Width;
                ///// Day nua ne ----------------------------------------------------
                desY = Height * 20 / 100;
                disX = Math.Abs(desX - btn.Location.X);
                disY = Math.Abs(desY - btn.Location.Y);
                btn.Selected = select;
                listAnswer.Add(btn);
                select++;
                move = 1;
                timer1.Start();
            }
            else
            {
                listAnswer.Remove(btn);
                for (int i = btn.Selected; i < listAnswer.Count; i++)
                {
                    listAnswer[i].Selected = i;
                    int x = (Width - btn.Width) / 2 - ((mid - i) * 2 - 1) * btn.Width;
                    int y = Height * 20 / 100;
                    listAnswer[i].Location = new Point(x, y);
                }
                desX = btn.X;
                desY = btn.Y;
                disX = Math.Abs(btn.Location.X - desX);
                disY = Math.Abs(btn.Location.Y - desY);
                btn.Selected = -1;
                select--;
                move = -1;
                tempBtnChar = btn;
                timer1.Start();
            }
        }

        void InitListButton()
        {
            listBtn = new List<CustomControls.BtnChar>();
            for (int i = 0; i < word.Length; i++)
            {
                CustomControls.BtnChar btn = new CustomControls.BtnChar();
                listBtn.Add(btn);
            }
            listAnswer = new List<CustomControls.BtnChar>();
        }
        void InitlistBtn()
        {
            shuffle = new string(word.ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());
            int mid = shuffle.Length / 2;
            for (int i = 0; i < shuffle.Length; i++)
            {
                listBtn[i].Text = shuffle[i].ToString();
                listBtn[i].Height = 30;
                listBtn[i].Width = 30;
                listBtn[i].ID1 = i;
                if (word.Length % 2 == 0)
                {
                    listBtn[i].X = (Width - listBtn[i].Width) / 2 - ((mid - i) * 2 - 1) * listBtn[i].Width;
                    listBtn[i].Y = Height * 80 / 100;
                }
                else
                {
                    listBtn[i].X = (Width - listBtn[i].Width) / 2 - ((mid - i) * 2 - 1) * listBtn[i].Width;
                    listBtn[i].Y = Height * 80 / 100;
                }
                listBtn[i].Location = new Point(listBtn[i].X, listBtn[i].Y);
                listBtn[i].Visible = true;
                Controls.Add(listBtn[i]);
                listBtn[i].Click += new EventHandler(ButtonChar_Click);
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string answer = "";
            if (select != word.Length)
            {
                lb_Question.Text = (int.Parse(lb_Question.Text) + 1).ToString();
                return;
            }
            for (int i = 0; i < word.Length; i++)
            {
                answer += listAnswer[i].Text;
            }
            if (answer == word)
            {
                lb_Score.Text = (int.Parse(lb_Score.Text) + 1000).ToString();
            }
            lb_Question.Text = (int.Parse(lb_Question.Text) + 1).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = disX / 20;
            int y = disY / 20;
            if (move > 0)
            {
                int X, Y;
                if (listAnswer[select - 1].Location.X < desX)
                {
                    X = (int)listAnswer[select - 1].Location.X + x;
                }
                else
                {
                    X = (int)listAnswer[select - 1].Location.X - x;
                }
                if (listAnswer[select - 1].Location.Y < desY)
                {
                    Y = listAnswer[select - 1].Location.Y + y;
                }
                else
                {
                    Y = listAnswer[select - 1].Location.Y - y;
                }
                listAnswer[select - 1].Location = new Point(X, Y);
                if (Math.Abs(desX - listAnswer[select - 1].Location.X) < x || Math.Abs(desY - listAnswer[select - 1].Location.Y) < y)
                {
                    listAnswer[select - 1].Location = new Point(desX, desY);
                    move = 0;
                    timer1.Stop();
                }
            }
            if (move < 0)
            {
                int X, Y;
                if (tempBtnChar.Location.X > desX)
                {
                    X = tempBtnChar.Location.X - x;
                }
                else
                {
                    X = tempBtnChar.Location.X + x;
                }
                if (tempBtnChar.Location.Y > desY)
                {
                    Y = tempBtnChar.Location.Y - y;
                }
                else
                {
                    Y = tempBtnChar.Location.Y + y;
                }
                tempBtnChar.Location = new Point(X, Y);
                if (Math.Abs(desX - tempBtnChar.Location.X) < x || Math.Abs(desY - tempBtnChar.Location.Y) < y)
                {
                    tempBtnChar.Location = new Point(desX, desY);
                    move = 0;
                    timer1.Stop();
                }
            }
        }
    }
}