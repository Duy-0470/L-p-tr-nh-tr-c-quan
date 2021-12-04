using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class FormQuiz : Form
    {
        private readonly Database.DatabaseHandle databaseHandle = new Database.DatabaseHandle();
        private List<Classes.Quizz> quizzes = new List<Classes.Quizz>();
        private int counter = 0, timeleft = 30;
        public static int score = 0;

        public FormQuiz()
        {
            InitializeComponent();
        }

        private void FormCollocation_Load(object sender, EventArgs e)
        {
            Width = 854;
            Height = 520;
            PanelMain.Location = new Point(0, 0);
            PanelRules.Location = new Point(227, 138);
            PanelMain.Visible = false;
            PanelRules.Visible = true;

            switch (FormQuizTopic.q_topic)
            {
                case FormQuizTopic.QuizTopic.Collocation:
                    Text = "Collocation";
                    quizzes = databaseHandle.SelectNCollocationQuizzes(20);
                    break;
                case FormQuizTopic.QuizTopic.Phrasal_Verb:
                    Text = "Phrasal Verbs";
                    quizzes = databaseHandle.SelectNPhrasalVerbQuizzes(20);
                    break;
                case FormQuizTopic.QuizTopic.Idiom:
                    Text = "Idioms";
                    quizzes = databaseHandle.SelectNIdiomQuizzes(20);
                    break;
                case FormQuizTopic.QuizTopic.Word_Meaning:
                    Text = "Word Meaning";
                    quizzes = databaseHandle.SelectNWordMeaningQuizzes(20);
                    break;
                case FormQuizTopic.QuizTopic.Word_Form:
                    Text = "Word Forms";
                    quizzes = databaseHandle.SelectNWordFormQuizzes(20);
                    break;
                default:
                    break;
            }

            LabelQuestion.Text = quizzes[counter].question;
            ButtonA.Text = quizzes[counter].A;
            ButtonB.Text = quizzes[counter].B;
            ButtonC.Text = quizzes[counter].C;
            ButtonD.Text = quizzes[counter].D;
            Debug.WriteLine(counter.ToString() + " " + quizzes[counter].rightAnswer);
        }

        private void ButtonOKRules_Click(object sender, EventArgs e)
        {
            PanelRules.Visible = false;
            PanelMain.Visible = true;
            TimeLimit.Start();
            Timer1sec.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormCollocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimeLimit.Stop();
            TimeLimit.Dispose();
            Timer1sec.Stop();
            Timer1sec.Dispose();
            counter = score = 0;
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "button1_Click"))
            {
                FormResult fr = new FormResult();
                fr.Show();
            }
            else
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 1)
            {
                ButtonA.BackColor = Color.Green;
                score++;
                LabelScore.Text = "Your score: " + score.ToString() + @"\20";
            }
            else
            {
                ButtonA.BackColor = Color.Red;
                if (quizzes[counter].rightAnswer == 2)
                    ButtonB.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 3)
                    ButtonC.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 4)
                    ButtonD.BackColor = Color.Green;
            }
            TimeLimit.Stop();
            Timer1sec.Stop();
            ButtonNext.Visible = true;
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 2)
            {
                ButtonB.BackColor = Color.Green;
                score++;
                LabelScore.Text = "Your score: " + score.ToString() + @"\20";
            }
            else
            {
                ButtonB.BackColor = Color.Red;
                if (quizzes[counter].rightAnswer == 1)
                    ButtonA.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 3)
                    ButtonC.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 4)
                    ButtonD.BackColor = Color.Green;
            }
            TimeLimit.Stop();
            Timer1sec.Stop();
            ButtonNext.Visible = true;
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 3)
            {
                ButtonC.BackColor = Color.Green;
                score++;
                LabelScore.Text = "Your score: " + score.ToString() + @"\20";
            }
            else
            {
                ButtonC.BackColor = Color.Red;
                if (quizzes[counter].rightAnswer == 1)
                    ButtonA.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 2)
                    ButtonB.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 4)
                    ButtonD.BackColor = Color.Green;
            }
            TimeLimit.Stop();
            Timer1sec.Stop();
            ButtonNext.Visible = true;
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 4)
            {
                ButtonD.BackColor = Color.Green;
                score++;
                LabelScore.Text = "Your score: " + score.ToString() + @"\20";
            }
            else
            {
                ButtonD.BackColor = Color.Red;
                if (quizzes[counter].rightAnswer == 1)
                    ButtonA.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 2)
                    ButtonB.BackColor = Color.Green;
                if (quizzes[counter].rightAnswer == 3)
                    ButtonC.BackColor = Color.Green;
            }
            TimeLimit.Stop();
            Timer1sec.Stop();
            ButtonNext.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter < 20)
            {
                Debug.WriteLine(counter.ToString() + " " + quizzes[counter].rightAnswer);
                timeleft = 30;
                LabelQuestion.Text = quizzes[counter].question;
                ButtonA.Text = quizzes[counter].A;
                ButtonB.Text = quizzes[counter].B;
                ButtonC.Text = quizzes[counter].C;
                ButtonD.Text = quizzes[counter].D;
                ButtonNext.Visible = false;
                ButtonA.BackColor = ButtonB.BackColor = ButtonC.BackColor = ButtonD.BackColor = Color.White;
                ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = true;
                LabelTimeLeft.Text = "Time left: 30s";
                TimeLimit.Start();
                Timer1sec.Start();
            }
            else
                Close();
        }

        private void Timer1sec_Tick(object sender, EventArgs e)
        {
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

        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            TimeLimit.Stop();
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;

            if (quizzes[counter].rightAnswer == 1)
                ButtonA.BackColor = Color.Green;
            if (quizzes[counter].rightAnswer == 2)
                ButtonB.BackColor = Color.Green;
            if (quizzes[counter].rightAnswer == 3)
                ButtonC.BackColor = Color.Green;
            if (quizzes[counter].rightAnswer == 4)
                ButtonD.BackColor = Color.Green;

            ButtonNext.Visible = true;
        }
    }
}
