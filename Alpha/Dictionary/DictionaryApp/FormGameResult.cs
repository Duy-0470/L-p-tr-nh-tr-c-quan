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
    public partial class FormGameResult : Form
    {
        public FormGameResult()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
            ButtonReplay.FlatAppearance.BorderSize = 0;
            ButtonBackToGames.FlatAppearance.BorderSize = 0;
            ButtonHome.FlatAppearance.BorderSize = 0;
            ButtonSubBack.FlatAppearance.BorderSize = 0;
            ButtonSubHome.FlatAppearance.BorderSize = 0;
            ButtonSubReplay.FlatAppearance.BorderSize = 0;
            ButtonReplay.Location = new Point(PanelResultMenu.Width, 861);
            ButtonBackToGames.Location = new Point(PanelResultMenu.Width, 921);
            ButtonHome.Location = new Point(PanelResultMenu.Width, 981);
            
        }

        private void FormGameResult_Load(object sender, EventArgs e)
        {
            if (FormGamesSelect.gameType == FormGamesSelect.GameType.Quizzes)
            {
                LabelScoreNum.Text = FormQuiz.score.ToString();
                LabelSpeedNum.Text = (FormQuiz.avg_time / 1000 / 20).ToString();
                LabelAccNum.Text = Convert.ToDouble(FormQuiz.correct / 20 * 100).ToString();
                LabelTopic.Text = "Quizzes - " + FormQuiz.q_topic.ToString().Replace('_', ' ');
                LabelComment.Visible = true;
                if (FormQuiz.avg_time / 1000 / 20 < 3 && FormQuiz.correct < 4)
                    LabelComment.Text = "Your accuracy was below average, yet you spent very little time on a question.\nYou were too hasty in making decisions. Try to be more careful";
                else if (FormQuiz.avg_time / 1000 / 20 > 12 && FormQuiz.correct >= 12)
                    LabelComment.Text = "Your accuracy was above average, yet your speed was not.\n";
                else if (FormQuiz.avg_time / 1000 / 20 > 12 && FormQuiz.correct < 12)
                    LabelComment.Text = "Both of your speed and accuracy were below average, but they can still be improved over time.";
                else if (FormQuiz.avg_time / 1000 / 20 <= 12 && FormQuiz.correct >= 12)
                    LabelComment.Text = "Well done! Both of your speed and accuracy was above average.";
                else if (FormQuiz.avg_time / 1000 / 20 <= 12 && FormQuiz.correct < 12)
                    LabelComment.Text = "Your speed was above average, yet your accuracy was not.\nYou were reasonably fast but that would not be enough, slow down to try to improve your accuracy";

            }
            else if (FormGamesSelect.gameType == FormGamesSelect.GameType.GTW)
            {
                LabelScore.Text = "Your score: " + FormGTW.score.ToString();
                LabelSpeed.Text += " " + (FormGTW.avg_time / 1000 / 10).ToString() + " seconds";
                LabelTopic.Text = "Word Scrambler";
            }
            else if (FormGamesSelect.gameType == FormGamesSelect.GameType.Hangman)
            {
                LabelAccuracy.Visible = false;
                LabelAccNum.Visible = false;
                LabelScoreNum.Text = FormHangman.score.ToString();
                LabelSpeedNum.Text = FormHangman.time.ToString();
                LabelSpeed.Text = "Time (s):";
                if (FormHangman.score >= 50000)
                    LabelComment.Text = "Congratulations! You escaped the hang with ease.";
                else if (FormHangman.score < 50000 && FormHangman.score >= 10000)
                    LabelComment.Text = "Congratulations! You struggled a bit but escaped eventually.";
                else if (FormHangman.score < 10000 && FormHangman.score > 0)
                    LabelComment.Text = "Congratulations! You barely escaped death, but ultimstely, a win is a win";
                else if (FormHangman.score == 0)
                    LabelComment.Text = "Unfortunately, you were not able to escape the hang.\nBut it is not over. Come back if you want to improve";
            }
        }

        private void ButtonBackToGames_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void ButtonRetry_Click(object sender, EventArgs e)
        {
            Close();            
        }

        private void FormGameResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonBackToGames_Click"))
            {
                FormGameResult fgs = new FormGameResult();
                fgs.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonRetry_Click" || x.GetMethod().Name == "ButtonSubReplay_Click"))
            {
                FormQuiz fq = new FormQuiz();
                fq.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonHome_Click" || x.GetMethod().Name == "ButtonSubHome_Click"))
                Form1.GetInstance().Show();
            else
                Application.Exit();
        }

        private void LabelAvgTime_Click(object sender, EventArgs e)
        {

        }

        private void LabelAccNum_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReplay_MouseEnter(object sender, EventArgs e)
        {
            ButtonSubReplay.BackColor = SystemColors.ButtonHighlight;
        }

        private void ButtonReplay_MouseLeave(object sender, EventArgs e)
        {
            ButtonSubReplay.BackColor = Color.LightSkyBlue;
        }

        private void ButtonBackToGames_MouseEnter(object sender, EventArgs e)
        {
            ButtonSubBack.BackColor = SystemColors.ButtonHighlight;
        }

        private void ButtonBackToGames_MouseLeave(object sender, EventArgs e)
        {
            ButtonSubBack.BackColor = Color.LightSkyBlue;
        }

        private void ButtonHome_MouseEnter(object sender, EventArgs e)
        {
            ButtonSubHome.BackColor = SystemColors.ButtonHighlight;
        }

        private void ButtonHome_MouseLeave(object sender, EventArgs e)
        {
            ButtonSubHome.BackColor = Color.LightSkyBlue;
        }

        private void ButtonSubReplay_MouseEnter(object sender, EventArgs e)
        {
            ButtonReplay.BackColor = SystemColors.ButtonHighlight;
        }

        private void ButtonSubReplay_MouseLeave(object sender, EventArgs e)
        {
            ButtonReplay.BackColor = Color.White;
        }

        private void ButtonSubBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonBackToGames.BackColor = SystemColors.ButtonHighlight;
        }

        private void ButtonSubBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonBackToGames.BackColor = Color.White;
        }

        private void ButtonSubHome_MouseEnter(object sender, EventArgs e)
        {
            ButtonHome.BackColor = SystemColors.ButtonHighlight;
        }

        private void ButtonSubHome_MouseLeave(object sender, EventArgs e)
        {
            ButtonHome.BackColor = Color.White;
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSubHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSubReplay_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
