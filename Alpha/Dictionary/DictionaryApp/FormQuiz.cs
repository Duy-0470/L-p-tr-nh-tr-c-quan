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
using DictionaryApp.Properties;

namespace DictionaryApp
{
    public partial class FormQuiz : Form
    {
        public enum QuizTopic
        {
            Collocation, Phrasal_Verb, Idiom, Word_Meaning, Word_Form
        }
        public static QuizTopic q_topic;
        private readonly Database.DatabaseHandle databaseHandle = new Database.DatabaseHandle();
        private List<Classes.Quizz> quizzes = new List<Classes.Quizz>();
        public static int score = 0;
        private int counter = 0, timeleft = 15, ready = 3;
        //private bool showrules;
        private readonly Stopwatch stopwatch = new Stopwatch();
        public static double avg_time = 0;

        public FormQuiz()
        {
            InitializeComponent();
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            Width = 854;
            Height = 520;
            PanelQuiz.Location = new Point(0, 0);
            PanelRules.Location = new Point(0, 0);
            LabelReady.Location = new Point(0, 0);
            //Settings.Default.ShowQuizRules = true;
            //Settings.Default.Save();
            //showrules = Settings.Default.ShowQuizRules;
        }

        private void LoadQuiz()
        {
            score = 0;
            switch (q_topic)
            {
                case QuizTopic.Collocation:
                    quizzes = databaseHandle.SelectNCollocationQuizzes(20);
                    break;
                case QuizTopic.Phrasal_Verb:
                    quizzes = databaseHandle.SelectNPhrasalVerbQuizzes(20);
                    break;
                case QuizTopic.Idiom:
                    quizzes = databaseHandle.SelectNIdiomQuizzes(20);
                    break;
                case QuizTopic.Word_Meaning:
                    quizzes = databaseHandle.SelectNWordMeaningQuizzes(20);
                    break;
                case QuizTopic.Word_Form:
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

        private void PanelCollocations_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelTopic.Visible = false;
                q_topic = QuizTopic.Collocation;
                LoadQuiz();
                //Debug.WriteLine("Show Rules Enabled: " + Settings.Default.ShowQuizRules.ToString());
                if (Settings.Default.ShowQuizRules)
                    PanelRules.Visible = true;
                else
                {
                    LabelReady.Visible = true;
                    TimerReady.Start();
                }
            }
        }

        private void LabelCollocations_MouseClick(object sender, MouseEventArgs e)
        {
            PanelCollocations_MouseClick(sender, e);
        }

        private void LabelCollocationsDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelCollocations_MouseClick(sender, e);
        }

        private void PanelWM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelTopic.Visible = false;
                q_topic = QuizTopic.Word_Meaning;
                LoadQuiz();
                //Debug.WriteLine("Show Rules Enabled: " + Settings.Default.ShowQuizRules.ToString());
                if (Settings.Default.ShowQuizRules)
                    PanelRules.Visible = true;
                else
                {
                    LabelReady.Visible = true;
                    TimerReady.Start();
                }
            }
        }

        private void LabelWMDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelWM_MouseClick(sender, e);
        }

        private void LabelWM_MouseClick(object sender, MouseEventArgs e)
        {
            PanelWM_MouseClick(sender, e);
        }

        private void PanelPhrasalVerbs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelTopic.Visible = false;
                q_topic = QuizTopic.Phrasal_Verb;
                LoadQuiz();
                //Debug.WriteLine("Show Rules Enabled: " + Settings.Default.ShowQuizRules.ToString());
                if (Settings.Default.ShowQuizRules) 
                    PanelRules.Visible = true;
                else
                {
                    LabelReady.Visible = true;
                    TimerReady.Start();
                }
            }
        }

        private void LabelPV_MouseClick(object sender, MouseEventArgs e)
        {
            PanelPhrasalVerbs_MouseClick(sender, e);
        }

        private void LabelPVDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelPhrasalVerbs_MouseClick(sender, e);
        }

        private void PanelWF_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelTopic.Visible = false;
                q_topic = QuizTopic.Word_Form;
                LoadQuiz();
                //Debug.WriteLine("Show Rules Enabled: " + Settings.Default.ShowQuizRules.ToString());
                if (Settings.Default.ShowQuizRules)
                    PanelRules.Visible = true;
                else
                {
                    LabelReady.Visible = true;
                    TimerReady.Start();
                }
            }
        }

        private void LabelWF_MouseClick(object sender, MouseEventArgs e)
        {
            PanelWF_MouseClick(sender, e);
        }

        private void LabelWFDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelWF_MouseClick(sender, e);
        }

        private void PanelIdioms_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelTopic.Visible = false;
                q_topic = QuizTopic.Idiom;
                LoadQuiz();
                //Debug.WriteLine("Show Rules Enabled: " + Settings.Default.ShowQuizRules.ToString());
                if (Settings.Default.ShowQuizRules)
                    PanelRules.Visible = true;
                else
                {
                    LabelReady.Visible = true;
                    TimerReady.Start();
                }
            }
        }

        private void LabelIdioms_MouseClick(object sender, MouseEventArgs e)
        {
            PanelIdioms_MouseClick(sender, e);
        }

        private void LabelIdiomsDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelIdioms_MouseClick(sender, e);
        }

        private void ButtonOKRules_Click(object sender, EventArgs e)
        {
            if (CheckBoxShowRules.Checked == true)
            {
                Settings.Default.ShowQuizRules = false;
                Settings.Default.Save();
                Debug.WriteLine(Settings.Default.ShowQuizRules.ToString());
            }
            PanelRules.Visible = false;
            LabelReady.Visible = true;            
            TimerReady.Start();
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
            stopwatch.Stop();
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            avg_time += Convert.ToDouble(stopwatch.ElapsedMilliseconds);
            ButtonNext.Visible = true;
            ButtonNext.Focus();
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
            stopwatch.Stop();
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            avg_time += Convert.ToDouble(stopwatch.ElapsedMilliseconds);
            ButtonNext.Visible = true;
            ButtonNext.Focus();
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
            stopwatch.Stop();
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            avg_time += Convert.ToDouble(stopwatch.ElapsedMilliseconds);
            ButtonNext.Visible = true;
            ButtonNext.Focus();
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
            stopwatch.Stop();
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            avg_time += Convert.ToDouble(stopwatch.ElapsedMilliseconds);
            ButtonNext.Visible = true;
            ButtonNext.Focus();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter < 20)
            {
                Debug.WriteLine(counter.ToString() + " " + quizzes[counter].rightAnswer);
                timeleft = 30;
                LabelTimeLeft.ForeColor = Color.Black;
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
                stopwatch.Reset();
                stopwatch.Start();
                if (counter == 18)
                    ButtonNext.Text = "Finish";
            }
            else
                Close();
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


        private void Timer1sec_Tick(object sender, EventArgs e)
        {
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

        private void CheckBoxShowRules_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TimerReady_Tick(object sender, EventArgs e)
        {
            ready--;
            LabelReady.Text = ready.ToString();
            if (ready == 0)
            {
                TimerReady.Stop();
                LabelReady.Visible = false;
                PanelQuiz.Visible = true;
                Timer1sec.Start();
                TimeLimit.Start();
                stopwatch.Start();
            }
        }

        private void FormQuiz_Resize(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            Top = (area.Height - Height) / 2;
            Left = (area.Width - Width) / 2;
        }

        private void FormQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonNext_Click"))
            {
                FormGameResult fgr = new FormGameResult();
                fgr.Show();
            }
            else
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            PanelQuiz.Visible = false;
            counter = score = 0;
            timeleft = 30;
            ready = 3;
            quizzes.Clear();
            Timer1sec.Stop();
            TimeLimit.Stop();
            PanelTopic.Visible = true;
            Close();
        }

        private void FormQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
