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

namespace DictionaryApp
{
    public partial class FormHangman : Form
    {
        private string answer = "";
        private int incorrect = 0, correct = 0, timelimit = 30, ready = 3;
        private readonly Database.DatabaseHandle databaseHandle = new Database.DatabaseHandle();
        private Classes.MyImage hintImage = new Classes.MyImage();
        private readonly Stopwatch stopwatch = new Stopwatch();

        public FormHangman()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
            PanelLetters.Location = new Point((Width - PanelLetters.Width) / 2, Height - PanelLetters.Height - 80);
            PictureBoxHint.Location = new Point((Width - PictureBoxHint.Width) / 2, 10);
            LabelGuess.Location = new Point(0, (Height - LabelGuess.Height) / 2);
            LabelGuess.Text = "";
            LabelReady.Location = new Point((Width - LabelReady.Width) / 2, (Height - LabelReady.Height) / 2);
        }

        private void FormHangman_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonQuit_Click"))
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
            else
                Application.Exit();
        }

        private void LoadQuestion()
        {
            incorrect = correct = 0;
            hintImage = databaseHandle.RandomImage();
            answer = hintImage.name.Substring(0, hintImage.name.IndexOf('_')).ToUpper();
            PictureBoxHint.Load(hintImage.link);
            Debug.WriteLine(answer + " " + hintImage.link);
            if (!answer.Contains('-'))
            {
                for (int i = 0; i < answer.Length * 2; i++)
                {
                    if (i % 2 == 0)
                        LabelGuess.Text += "_";
                    else
                        LabelGuess.Text += " ";
                }
            }
            else
            {
                string[] part = answer.Split('-');
                for (int i = 0; i < part[0].Length * 2; i++)
                {
                    if (i % 2 != 0)
                        LabelGuess.Text += "_";
                    else
                        LabelGuess.Text += " ";
                }
                LabelGuess.Text += " - ";
                for (int i = 0; i < part[1].Length * 2; i++)
                {
                    if (i % 2 != 0)
                        LabelGuess.Text += "_";
                    else
                        LabelGuess.Text += " ";
                }
            }
        }

        private void ButtonLettersClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Debug.WriteLine(button.Name.Last().ToString());
            button.Enabled = false;
            if (answer.Contains(button.Name.Last()))
            {
                timelimit += 5;
                for (int i = 0; i < answer.Length; i++)
                {
                    if (answer[i] == button.Name.Last())
                    {
                        StringBuilder showletter = new StringBuilder(LabelGuess.Text);
                        showletter[i * 2] = answer[i];
                        LabelGuess.Text = showletter.ToString();
                        correct++;
                    }
                }
                if (correct == answer.Length)
                {
                    TimeLimit.Stop();
                    LabelGuess.ForeColor = Color.Green;
                    PanelLetters.Controls.Clear();
                    Label result = new Label()
                    {
                        Text = "You win!",
                        Font = new Font(new Font("Times New Roman", 28), FontStyle.Regular),
                        AutoSize = true
                    };
                    PanelLetters.Controls.Add(result);
                    result.Location = new Point((PanelLetters.Width - result.Width) / 2, (PanelLetters.Height - result.Height) / 2 - 30);
                }
            }
            else
            {
                incorrect++;
                PictureBoxHangman.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\Files\\images\\hangman" + incorrect + ".png");
                if (incorrect == 6)
                {
                    TimeLimit.Stop();
                    LabelGuess.Text = "";
                    LabelGuess.ForeColor = Color.Red;
                    for (int i = 0; i < answer.Length; i++)
                    {
                        LabelGuess.Text += answer[i] + " ";
                    }
                    PanelLetters.Controls.Clear();
                    Label result = new Label()
                    {
                        Text = "You are hung",
                        Font = new Font(new Font("Times New Roman", 28), FontStyle.Regular),
                        AutoSize = true
                    };
                    PanelLetters.Controls.Add(result);
                    result.Location = new Point((PanelLetters.Width - result.Width) / 2, (PanelLetters.Height - result.Height) / 2 - 30);
                }
            }
        }

        private void TimerReady_Tick(object sender, EventArgs e)
        {
            ready--;
            LabelReady.Text = ready.ToString();
            if (ready == 0)
            {
                TimerReady.Stop();
                LabelReady.Visible = false;
                PanelLetters.Visible = true;
                PictureBoxHangman.Visible = true;
                PictureBoxHint.Visible = true;
                LabelGuess.Visible = true;
                LabelTimeLeft.Visible = true;
                TimeLimit.Start();
                stopwatch.Start();
            }
        }

        //private void EnabledPanelContents(Panel panel, bool enabled)
        //{
        //    foreach (Control ctrl in panel.Controls)
        //    {
        //        ctrl.Enabled = enabled;
        //    }
        //}

        private void FormHangman_Load(object sender, EventArgs e)
        {
            LoadQuestion();
            TimerReady.Start();
        }

        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            if (timelimit <= 5)
                LabelTimeLeft.ForeColor = Color.Red;
            else
                LabelTimeLeft.ForeColor = Color.Black;

            if (timelimit > 0)
            {
                timelimit--;                
                LabelTimeLeft.Text = "Time left: " + timelimit.ToString() + "s";
            }
            else
            {
                LabelTimeLeft.Text = "Time left: 0s";
                TimeLimit.Stop();
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
