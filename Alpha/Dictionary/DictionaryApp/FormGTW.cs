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
    public partial class FormGTW : Form
    {
        private readonly Random rand = new Random();
        private string meaning = "", answer = "", shuffle = "";
        private Rectangle area;
        public static int score = 0;
        private int counter = 0, timeleft = 20, ready = 3;
        private readonly Stopwatch stopwatch = new Stopwatch();
        public static double avg_time = 0;
        private bool submitted = false;
        List<Button> letters = new List<Button>();

        public FormGTW()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
            area = Screen.FromControl(this).WorkingArea;
            PanelGTWRules.Size = Size;
            LabelMeaning.Location = new Point(0, 100);
            LabelMeaning.Width = Width;
            LabelAnswer.Location = new Point(0, (Height - LabelAnswer.Height) / 2);
            LabelAnswer.Width = Width;
            LabelCorrectAns.Width = Width;
            LabelCorrectAns.Location = new Point(0, LabelAnswer.Location.Y + LabelAnswer.Height + 10);
            LabelReady.Location = new Point((Width - LabelReady.Width) / 2, (Height - LabelReady.Height) / 2);
            Debug.WriteLine((Width - LabelReady.Width) / 2);
        }

        private void LoadQuestion() // to be modified
        {
            submitted = false;            
            meaning = "The act of....HAPPINESS";
            answer = shuffle = "suffering";      // testing purposes
            LabelMeaning.Text = meaning;
            shuffle = new string(shuffle.ToCharArray().OrderBy(s => (rand.Next(2) % 2) == 0).ToArray());
            Debug.WriteLine(shuffle);
            if (shuffle.Length % 2 == 0)
            {
                for (int i = 0; i < shuffle.Length; i++)
                {
                    Button letter = new Button
                    {
                        Text = shuffle[i].ToString(),
                        Size = new Size(60, 60),
                        Font = new Font(new Font("Verdana", 14), FontStyle.Regular),
                        Cursor = Cursors.Hand,
                        TabStop = false
                    };
                    if (i % 2 == 0)
                        letter.Location = new Point((area.Width / 2) + i * 60, LabelAnswer.Location.Y + 170);
                    else
                        letter.Location = new Point((area.Width / 2) - (i + 1) * 60, LabelAnswer.Location.Y + 170);
                    letter.Click += new EventHandler(Letter_Click);
                    Controls.Add(letter);
                    letters.Add(letter);
                }
            }
            else
            {
                Button firstletter = new Button
                {
                    Text = shuffle[0].ToString(),
                    Size = new Size(60, 60),
                    Font = new Font(new Font("Verdana", 14), FontStyle.Regular),
                    Cursor = Cursors.Hand,
                    TabStop = false
                };
                firstletter.Location = new Point((area.Width - firstletter.Width) / 2, LabelAnswer.Location.Y + 120);
                firstletter.Click += new EventHandler(Letter_Click);
                Controls.Add(firstletter);
                letters.Add(firstletter);

                for (int i = 1; i < shuffle.Length; i++)
                {
                    Button letter = new Button
                    {
                        Text = shuffle[i].ToString(),
                        Size = new Size(60, 60),
                        Font = new Font(new Font("Verdana", 14), FontStyle.Regular),
                        Cursor = Cursors.Hand,
                        TabStop = false
                    };
                    if (i % 2 != 0)
                        letter.Location = new Point(firstletter.Location.X - firstletter.Width - i * 60, LabelAnswer.Location.Y + 120);
                    else
                        letter.Location = new Point(firstletter.Location.X + firstletter.Width + (i - 1) * 60, LabelAnswer.Location.Y + 120);
                    letter.Click += new EventHandler(Letter_Click);
                    Controls.Add(letter);
                    letters.Add(letter);
                }
            }
        }

        private void Letter_Click(object sender, EventArgs e)
        {
            Button selected = sender as Button;
            selected.Visible = false;
            LabelAnswer.Text += selected.Text.ToString();
        }

        private void ButtonOKGTWRules_Click(object sender, EventArgs e)
        {
            PanelGTWRules.Visible = false;
            LabelReady.Visible = true;
            if (CheckBoxShowGTWRules.Checked)
            {
                Properties.Settings.Default.ShowGTWRules = false;
                Properties.Settings.Default.Save();
            }
            TimerReady.Start();
        }

        private void CheckBoxShowGTWRules_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void FormGTW_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonQuit_Click"))
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
            else
                Application.Exit();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            TimeLimit.Stop();
            LabelTimeLeft.Text = "Time left: 0s";
            submitted = true;
            counter++;
            stopwatch.Stop();
            stopwatch.Reset();
            avg_time += stopwatch.ElapsedMilliseconds;
            ButtonSubmit.Visible = true;
            ButtonSubmit.Text = "Next";
            LabelCorrectAns.Visible = true;
            LabelCorrectAns.Text = "The answer is: " + answer;
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            counter++;
            stopwatch.Stop();
            stopwatch.Reset();
            TimeLimit.Stop();
            Timer1sec.Stop();
            avg_time += stopwatch.ElapsedMilliseconds;
            if (!submitted && counter < 10)
            {
                if (LabelAnswer.Text == answer)
                {
                    score++;
                    LabelAnswer.ForeColor = Color.Green;
                    if (counter < 8)
                        ButtonSubmit.Text = "Next";
                    else
                        ButtonSubmit.Text = "Finish";
                    submitted = true;
                }
                else
                {
                    LabelAnswer.ForeColor = Color.Red;
                    LabelCorrectAns.Text = "The answer is: " + answer;
                    LabelCorrectAns.Visible = true;
                }
                return;
            }
            else if (submitted && counter < 10)
            {
                for (int i = 0; i < letters.Count; i++)
                {
                    Controls.Remove(letters[i]);
                }
                letters.Clear();
                LabelAnswer.Text = "";
                LoadQuestion();
                ButtonSubmit.Text = "Submit";
                ButtonSubmit.Visible = false;
                LabelCorrectAns.Visible = false;
                timeleft = 20;
                LabelTimeLeft.ForeColor = Color.Black;
                LabelTimeLeft.Text = "Time left: " + timeleft + "s";
                TimeLimit.Start();
                Timer1sec.Start();
            }
            else if (counter > 10)
            {
                FormGameResult fgs = new FormGameResult();
                fgs.Show();
            }          
        }

        private void LabelTimeLeft_Click(object sender, EventArgs e)
        {

        }

        private void LabelAnswer_TextChanged(object sender, EventArgs e)
        {
            if (LabelAnswer.Text != "")
                ButtonSubmit.Visible = true;
        }

        private void Timer1sec_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(timeleft + "s");
            if (timeleft <= 5)
            {
                LabelTimeLeft.ForeColor = Color.Red;
            }
            if (timeleft > 0)
            {
                timeleft--;
                LabelTimeLeft.Text = "Time left: " + timeleft.ToString() + "s";
            }
            else
            {
                LabelTimeLeft.Text = "Time left: 0s";
                Timer1sec.Stop();
            }
        }

        private void TimerReady_Tick(object sender, EventArgs e)
        {
            ready--;
            LabelReady.Text = ready.ToString();
            
            if (ready == 0)
            {
                TimerReady.Stop();
                PanelGTWRules.Visible = false;
                LabelReady.Visible = false;
                LabelMeaning.Visible = true;
                LabelAnswer.Visible = true;
                ButtonQuit.Visible = true;
                ButtonSubmit.Visible = true;
                PanelInfo.Visible = true;
                LoadQuestion();
                Debug.WriteLine(LabelTimeLeft.Visible.ToString() + "\n" + LabelTimeLeft.Text);
                Timer1sec.Start();
                TimeLimit.Start();
                stopwatch.Start();
            }
        }

        private void FormGTW_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShowGTWRules)
                PanelGTWRules.Visible = true;
            else
            {
                //LoadQuestion();
                TimerReady.Start();
            }
        }
    }
}
