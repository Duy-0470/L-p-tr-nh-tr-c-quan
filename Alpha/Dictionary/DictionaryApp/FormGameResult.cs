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
using System.Xml;

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
            LabelComment.Text = "";
        }

        private void FormGameResult_Load(object sender, EventArgs e)
        {
            if (FormGamesSelect.gameType == FormGamesSelect.GameType.Quizzes)
            {
                LabelScoreNum.Text = FormQuiz.score.ToString();
                LabelSpeedNum.Text = (FormQuiz.avg_time / 1000 / 20).ToString();
                LabelAccNum.Text = Convert.ToDouble(FormQuiz.correct / 20 * 100).ToString();
                LabelTopic.Text = "   Quizzes - " + FormQuiz.q_topic.ToString().Replace('_', ' ');
                LabelComment.Visible = true;
                if (FormQuiz.avg_time / 1000 / 20 < 3 && FormQuiz.correct < 4)
                    LabelComment.Text = "Your accuracy was below average, yet you spent very little time on a question.\nYou were too hasty in making decisions. Try to be more careful";
                else if (FormQuiz.avg_time / 1000 / 20 > 12 && FormQuiz.correct >= 12)
                    LabelComment.Text = "Your accuracy was above average, yet your speed was not.\nWhile being careful is always a good thing, you would still need the speed to be perfect";
                else if (FormQuiz.avg_time / 1000 / 20 > 12 && FormQuiz.correct < 12)
                    LabelComment.Text = "Both of your speed and accuracy were below average, but they can still be improved over time.";
                else if (FormQuiz.avg_time / 1000 / 20 <= 12 && FormQuiz.correct >= 12)
                    LabelComment.Text = "Well done! Both of your speed and accuracy was above average.\nPerfection was never impossible";
                else if (FormQuiz.avg_time / 1000 / 20 <= 12 && FormQuiz.correct < 12)
                    LabelComment.Text = "Your speed was above average, yet your accuracy was not.\nYou were reasonably fast but that would not be enough, slow down to try to improve your accuracy";
                if (FormQuiz.highscore)
                    PictureBoxHS.Visible = true;
                else
                {
                    LabelPB.Visible = true;
                    LabelPBNum.Visible = true;
                    LabelPBNum.Text = FormQuiz.pb.ToString();
                }
            }
            else if (FormGamesSelect.gameType == FormGamesSelect.GameType.SW)
            {
                LabelTopic.Text = "   Word Scrambler";
                LabelScoreNum.Text = FormSW.total.ToString();
                LabelSpeedNum.Text = (FormSW.avg_time / 1000 / FormSW.number_question).ToString();
                LabelAccNum.Text = Convert.ToDouble(FormSW.correct / FormSW.number_question * 100).ToString();
                LabelSpeed.Text = LabelSpeed.Text.Replace("question", "round");
                if (FormSW.highscore)
                    PictureBoxHS.Visible = true;
                else
                {
                    LabelPB.Visible = true;
                    LabelPBNum.Visible = true;
                    LabelPBNum.Text = FormSW.pb.ToString();
                }
                if (FormSW.avg_time / 1000 / FormSW.number_question <= 3 && Convert.ToDouble(FormSW.correct / FormSW.number_question * 100) < 30)
                    LabelComment.Text = "Your accuracy was very low, unlike your speed.\nSeems like rushing is not always a good idea";
                else if (FormSW.avg_time / 1000 / FormSW.number_question > 7 && Convert.ToDouble(FormSW.correct / FormSW.number_question * 100) < 50)
                    LabelComment.Text = "Both of your speed and accuracy was below average.\nMaybe you should try raising the time limit a bit and comeback when you are better";
                else if (FormSW.avg_time / 1000 / FormSW.number_question > 7 && Convert.ToDouble(FormSW.correct / FormSW.number_question * 100) > 50)
                    LabelComment.Text = "You sacraficed speed for accuracy.\nThere is nothing wrong in being careful, but the lack of speed might prevent you from being perfect";
                else if (FormSW.avg_time / 1000 / FormSW.number_question < 7 && Convert.ToDouble(FormSW.correct / FormSW.number_question * 100) > 50)
                    LabelComment.Text = "Well done! Both of your speed and accuracy was above average.\nPerfection was never impossible";
                else if (FormSW.avg_time / 1000 / FormSW.number_question > 7 && Convert.ToDouble(FormSW.correct / FormSW.number_question * 100) < 50)
                    LabelComment.Text = "Find yourself struggling? Try increasing the time limit and the number of question";

            }
            else if (FormGamesSelect.gameType == FormGamesSelect.GameType.Hangman)
            {
                LabelTopic.Text = "   Hangman";
                LabelComment.Visible = true;
                LabelAccNum.Text = FormHangman.accuracy.ToString();
                LabelScoreNum.Text = FormHangman.score.ToString();
                LabelSpeedNum.Text = FormHangman.time.ToString();
                LabelSpeed.Text = LabelSpeed.Text.Replace("question", "round");
                if (FormHangman.score >= 50000)
                    LabelComment.Text = "Congratulations! You escaped the hang with ease.";
                else if (FormHangman.score < 50000 && FormHangman.score >= 10000)
                    LabelComment.Text = "Congratulations! You struggled a bit but escaped eventually.";
                else if (FormHangman.score < 10000 && FormHangman.score > 0)
                    LabelComment.Text = "Congratulations! You barely escaped death, but ultimately, a win is a win";
                else if (FormHangman.score == 0)
                    LabelComment.Text = "Unfortunately, you were not able to escape the hang.\nBut it is not over. Come back if you want to improve";
                if (FormHangman.highscore)
                    PictureBoxHS.Visible = true;
                else
                {
                    LabelPB.Visible = true;
                    LabelPBNum.Visible = true;
                    LabelPBNum.Text = FormHangman.pb.ToString();
                }
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
                if (FormGamesSelect.gameType == FormGamesSelect.GameType.Quizzes)
                {
                    FormQuiz fq = new FormQuiz();
                    fq.Show();
                }
                else if (FormGamesSelect.gameType == FormGamesSelect.GameType.SW)
                {
                    FormSWSettings sw = new FormSWSettings();
                    sw.Show();
                }
                else if (FormGamesSelect.gameType == FormGamesSelect.GameType.Hangman)
                {
                    FormHangman fh = new FormHangman();
                    fh.Show();
                }
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonHome_Click" || x.GetMethod().Name == "ButtonSubHome_Click"))
                Form1.GetInstance().Show();
            else
                Application.Exit();
        }

        private void ButtonReplay_MouseEnter(object sender, EventArgs e)
        {
            ButtonSubReplay.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void ButtonReplay_MouseLeave(object sender, EventArgs e)
        {
            ButtonSubReplay.BackColor = Color.FromArgb(153, 167, 153);
        }

        private void ButtonBackToGames_MouseEnter(object sender, EventArgs e)
        {
            ButtonSubBack.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void ButtonBackToGames_MouseLeave(object sender, EventArgs e)
        {
            ButtonSubBack.BackColor = Color.FromArgb(153, 167, 153);
        }

        private void ButtonHome_MouseEnter(object sender, EventArgs e)
        {
            ButtonSubHome.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void ButtonHome_MouseLeave(object sender, EventArgs e)
        {
            ButtonSubHome.BackColor = Color.FromArgb(153, 167, 153);
        }

        private void ButtonSubReplay_MouseEnter(object sender, EventArgs e)
        {
            ButtonReplay.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void ButtonSubReplay_MouseLeave(object sender, EventArgs e)
        {
            ButtonReplay.BackColor = Color.White;
        }

        private void ButtonSubBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonBackToGames.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void ButtonSubBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonBackToGames.BackColor = Color.White;
        }

        private void ButtonSubHome_MouseEnter(object sender, EventArgs e)
        {
            ButtonHome.BackColor = Color.FromArgb(200, 200, 200);
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
