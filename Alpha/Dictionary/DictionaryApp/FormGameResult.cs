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
        }

        private void FormGameResult_Load(object sender, EventArgs e)
        {
            if (FormGamesSelect.gameType == FormGamesSelect.GameType.Quizzes)
            {
                LabelScore.Text = "Your score: " + FormQuiz.score.ToString() + " / 20";
                LabelAvgTime.Text += " " + (FormQuiz.avg_time / 1000 / 20).ToString() + " seconds";
                LabelTopic.Text = FormQuiz.q_topic.ToString();
            }
            else if (FormGamesSelect.gameType == FormGamesSelect.GameType.GTW)
            {
                LabelScore.Text = "Your score: " + FormGTW.score.ToString() + " / 10";
                LabelAvgTime.Text += " " + (FormGTW.avg_time / 1000 / 10).ToString() + " seconds";
            }
            // more to be added
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
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonRetry_Click"))
            {
                FormQuiz fq = new FormQuiz();
                fq.Show();
            }
            else
            {
                //if (MessageBox.Show("You are about to close the app. Are you sure?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
                //    e.Cancel = true;
                //else
                    Application.Exit();
            }
        }
    }
}
