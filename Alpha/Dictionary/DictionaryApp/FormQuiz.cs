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
using System.Xml;
using System.IO;

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
        private int counter = 0, timeleft = 20, ready = 3;
        private readonly Stopwatch stopwatch = new Stopwatch();
        public static double avg_time = 0, correct = 0;
        public static bool highscore = false;
        private bool finished = false;

        public FormQuiz()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            PanelQuiz.Location = new Point(0, 0);
            PanelRules.Location = new Point(0, 0);
            LabelReady.Location = new Point(0, 0);
            PanelQuiz.Size = Size;
            PanelRules.Size = Size;
            LabelReady.Size = Size;
            PanelTopic.Size = Size;
            PanelCollocations.Size = PanelWF.Size = PanelWM.Size = PanelPhrasalVerbs.Size = PanelIdioms.Size = new Size(400, 100);
            PanelCollocations.Location = new Point(Width / 2 - PanelCollocations.Width - 100, LabelChooseTP.Location.Y + LabelChooseTP.Height + 200);
            PanelWM.Location = new Point(Width / 2 + 100, LabelChooseTP.Location.Y + LabelChooseTP.Height + 200);
            PanelPhrasalVerbs.Location = new Point(Width / 2 - PanelPhrasalVerbs.Width - 100, PanelCollocations.Location.Y + PanelCollocations.Height + 80);
            PanelWF.Location = new Point(Width / 2 + 100, PanelWM.Location.Y + PanelWM.Height + 80);
            PanelIdioms.Location = new Point((Width - PanelIdioms.Width) / 2, PanelPhrasalVerbs.Location.Y + PanelPhrasalVerbs.Height + 80);
            ButtonBack.FlatAppearance.BorderSize = 0;
            LabelQuestion.Width = Width - 40;
            LabelQuestion.Location = new Point((Width - LabelQuestion.Width) / 2, Height * 30 / 100);
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
            Timer1sec.Stop();
            stopwatch.Stop();
            finished = true;
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 1)
            {
                ButtonA.BackColor = Color.Green;
                score += (15 - unchecked((int)stopwatch.ElapsedMilliseconds) / 1000) * 1000;
                LabelScore.Text = "Your score: " + score.ToString();
                correct++;
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
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            avg_time += Convert.ToDouble(stopwatch.ElapsedMilliseconds);
            ButtonNext.Visible = true;
            ButtonNext.Focus();
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            Timer1sec.Stop();
            stopwatch.Stop();
            finished = true;
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 2)
            {
                ButtonB.BackColor = Color.Green;
                score += (15 - unchecked((int)stopwatch.ElapsedMilliseconds) / 1000) * 1000;
                LabelScore.Text = "Your score: " + score.ToString();
                correct++;
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
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            avg_time += Convert.ToDouble(stopwatch.ElapsedMilliseconds);
            ButtonNext.Visible = true;
            ButtonNext.Focus();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            Timer1sec.Stop();
            stopwatch.Stop();
            finished = true;
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 3)
            {
                ButtonC.BackColor = Color.Green;
                score += (15 - unchecked((int)stopwatch.ElapsedMilliseconds) / 1000) * 1000;
                LabelScore.Text = "Your score: " + score.ToString();
                correct++;
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
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            avg_time += Convert.ToDouble(stopwatch.ElapsedMilliseconds);
            ButtonNext.Visible = true;
            ButtonNext.Focus();
        }

        private void ButtonD_Click(object sender, EventArgs e)
        {
            Timer1sec.Stop();
            stopwatch.Stop();
            finished = true;
            ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = false;
            if (quizzes[counter].rightAnswer == 4)
            {
                ButtonD.BackColor = Color.Green;
                score += (15 - unchecked((int)stopwatch.ElapsedMilliseconds) / 1000) * 1000;
                LabelScore.Text = "Your score: " + score.ToString();
                correct++;
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
                finished = false;
                LabelQuesNum.Text = "Question: " + (counter + 1).ToString() + " / 20";
                Debug.WriteLine(counter.ToString() + " " + quizzes[counter].rightAnswer);
                timeleft = 20;
                LabelTimeLeft.ForeColor = Color.Black;
                LabelQuestion.Text = quizzes[counter].question;
                ButtonA.Text = quizzes[counter].A;
                ButtonB.Text = quizzes[counter].B;
                ButtonC.Text = quizzes[counter].C;
                ButtonD.Text = quizzes[counter].D;
                ButtonNext.Visible = false;
                ButtonA.BackColor = ButtonB.BackColor = ButtonC.BackColor = ButtonD.BackColor = Color.White;
                ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = true;
                LabelTimeLeft.Text = "Time left: 20s";
                Timer1sec.Start();
                stopwatch.Reset();
                stopwatch.Start();
                if (counter == 19)
                    ButtonNext.Text = "Finish";
            }
            else
            {
                SaveProgress();
                Close();
            }
        }

        private void SaveProgress()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (!File.Exists(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Saved\\quiz.xml"))
            {
                XmlElement root = xmlDocument.DocumentElement;

                // main node
                XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDocument.InsertBefore(xmlDeclaration, root);

                XmlElement mainElement = xmlDocument.CreateElement(string.Empty, "MainInfo", string.Empty);
                mainElement.InnerText = "Do not modify the contents of this file, or risk losing your saved progress!";
                xmlDocument.AppendChild(mainElement);

                // best score
                XmlElement bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                mainElement.AppendChild(bestScore);

                XmlElement bestScoreCol = xmlDocument.CreateElement(string.Empty, "Col", string.Empty);
                bestScoreCol.InnerText = 0.ToString();
                bestScore.AppendChild(bestScoreCol);

                XmlElement bestScoreWM = xmlDocument.CreateElement(string.Empty, "WM", string.Empty);
                bestScoreWM.InnerText = 0.ToString();
                bestScore.AppendChild(bestScoreWM);

                XmlElement bestScorePV = xmlDocument.CreateElement(string.Empty, "PV", string.Empty);
                bestScorePV.InnerText = 0.ToString();
                bestScore.AppendChild(bestScorePV);

                XmlElement bestScoreWF = xmlDocument.CreateElement(string.Empty, "WF", string.Empty);
                bestScoreWF.InnerText = 0.ToString();
                bestScore.AppendChild(bestScoreWF);

                XmlElement bestScoreIdiom = xmlDocument.CreateElement(string.Empty, "Idiom", string.Empty);
                bestScoreIdiom.InnerText = 0.ToString();
                bestScore.AppendChild(bestScoreIdiom);

                switch (q_topic)
                {
                    case QuizTopic.Collocation:
                        bestScoreCol.InnerText = score.ToString();
                        break;
                    case QuizTopic.Phrasal_Verb:
                        bestScorePV.InnerText = score.ToString();
                        break;
                    case QuizTopic.Idiom:
                        bestScoreIdiom.InnerText = score.ToString();
                        break;
                    case QuizTopic.Word_Meaning:
                        bestScoreWM.InnerText = score.ToString();
                        break;
                    case QuizTopic.Word_Form:
                        bestScoreWF.InnerText = score.ToString();
                        break;
                }
            }
            else
            {
                bool success = true;
                try
                {                    
                    xmlDocument.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Saved\\quiz.xml");
                }
                catch (XmlException exception)
                {
                    success = false;
                    Debug.WriteLine(exception.Message);
                }
                if (success)
                {
                    XmlNode main = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo");
                    XmlNode bestScore = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore");
                    if (main != null && bestScore != null)
                    {                       
                        if (bestScore != null)
                        {
                            switch (q_topic)
                            {
                                case QuizTopic.Collocation:
                                    XmlNode bestScoreCol = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore/Col");
                                    if (bestScoreCol != null)
                                    {
                                        if (int.TryParse(bestScoreCol.InnerText, out int sCol))
                                        {
                                            if (score > sCol)
                                            {
                                                highscore = true;
                                                bestScoreCol.InnerText = score.ToString();
                                            }
                                        }
                                        else
                                            bestScoreCol.InnerText = score.ToString();
                                    }
                                    else
                                    {
                                        bestScoreCol = xmlDocument.CreateElement(string.Empty, "Col", string.Empty);
                                        bestScoreCol.InnerText = score.ToString();
                                        bestScore.AppendChild(bestScoreCol);
                                    }
                                    break;
                                case QuizTopic.Phrasal_Verb:
                                    XmlNode bestScorePV = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore/PV");
                                    if (bestScorePV != null)
                                    {
                                        if (int.TryParse(bestScorePV.InnerText, out int sPV))
                                        {
                                            if (score > sPV)
                                            {
                                                highscore = true;
                                                bestScorePV.InnerText = score.ToString();
                                            }
                                        }
                                        else
                                            bestScorePV.InnerText = score.ToString();
                                    }
                                    else
                                    {
                                        bestScorePV = xmlDocument.CreateElement(string.Empty, "PV", string.Empty);
                                        bestScorePV.InnerText = score.ToString();
                                        main.AppendChild(bestScorePV);
                                    }                                  
                                    break;
                                case QuizTopic.Idiom:                                   
                                    XmlNode bestScoreIdiom = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore/Idiom");
                                    if (bestScoreIdiom != null)
                                    {
                                        if (int.TryParse(bestScoreIdiom.InnerText, out int sIdiom))
                                        {
                                            if (score > sIdiom)
                                            {
                                                highscore = true;
                                                bestScoreIdiom.InnerText = score.ToString();
                                            }
                                        }
                                        else
                                            bestScoreIdiom.InnerText = score.ToString();
                                    }
                                    else
                                    {
                                        bestScoreIdiom = xmlDocument.CreateElement(string.Empty, "Idiom", string.Empty);
                                        bestScoreIdiom.InnerText = score.ToString();
                                        bestScore.AppendChild(bestScoreIdiom);
                                    }
                                    break;
                                case QuizTopic.Word_Meaning:
                                    XmlNode bestScoreWM = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore/WM");
                                    if (bestScoreWM != null)
                                    {
                                        if (int.TryParse(bestScoreWM.InnerText, out int sWM))
                                        {
                                            if (score > sWM)
                                            {
                                                highscore = true;
                                                bestScoreWM.InnerText = score.ToString();
                                            }
                                        }
                                        else
                                            bestScoreWM.InnerText = score.ToString();
                                    }
                                    else
                                    {
                                        bestScoreWM = xmlDocument.CreateElement(string.Empty, "WM", string.Empty);
                                        bestScoreWM.InnerText = score.ToString();
                                        bestScore.AppendChild(bestScoreWM);
                                    }
                                    break;
                                case QuizTopic.Word_Form:
                                    XmlNode bestScoreWF = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore/WF");
                                    if (bestScoreWF != null)
                                    {
                                        if (int.TryParse(bestScoreWF.InnerText, out int sWF))
                                        {
                                            if (score > sWF)
                                            {
                                                highscore = true;
                                                bestScoreWF.InnerText = score.ToString();
                                            }
                                        }
                                        else
                                            bestScoreWF.InnerText = score.ToString();
                                    }
                                    else
                                    {
                                        bestScoreWF = xmlDocument.CreateElement(string.Empty, "WF", string.Empty);
                                        bestScoreWF.InnerText = score.ToString();
                                        bestScore.AppendChild(bestScoreWF);
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            XmlElement root = xmlDocument.DocumentElement;

                            // main node
                            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                            xmlDocument.InsertBefore(xmlDeclaration, root);

                            XmlElement mainElement = xmlDocument.CreateElement(string.Empty, "MainInfo", string.Empty);
                            mainElement.InnerText = "Do not modify the contents of this file, or risk losing your saved progress!";
                            xmlDocument.AppendChild(mainElement);

                            // best score
                            bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                            mainElement.AppendChild(bestScore);

                            XmlElement bestScoreCol = xmlDocument.CreateElement(string.Empty, "Col", string.Empty);
                            bestScoreCol.InnerText = 0.ToString();
                            bestScore.AppendChild(bestScoreCol);

                            XmlElement bestScoreWM = xmlDocument.CreateElement(string.Empty, "WM", string.Empty);
                            bestScoreWM.InnerText = 0.ToString();
                            bestScore.AppendChild(bestScoreWM);

                            XmlElement bestScorePV = xmlDocument.CreateElement(string.Empty, "PV", string.Empty);
                            bestScorePV.InnerText = 0.ToString();
                            bestScore.AppendChild(bestScorePV);

                            XmlElement bestScoreWF = xmlDocument.CreateElement(string.Empty, "WF", string.Empty);
                            bestScoreWF.InnerText = 0.ToString();
                            bestScore.AppendChild(bestScoreWF);

                            XmlElement bestScoreIdiom = xmlDocument.CreateElement(string.Empty, "Idiom", string.Empty);
                            bestScoreIdiom.InnerText = 0.ToString();
                            bestScore.AppendChild(bestScoreIdiom);

                            switch (q_topic)
                            {
                                case QuizTopic.Collocation:
                                    bestScoreCol.InnerText = score.ToString();
                                    break;
                                case QuizTopic.Phrasal_Verb:
                                    bestScorePV.InnerText = score.ToString();
                                    break;
                                case QuizTopic.Idiom:
                                    bestScoreIdiom.InnerText = score.ToString();
                                    break;
                                case QuizTopic.Word_Meaning:
                                    bestScoreWM.InnerText = score.ToString();
                                    break;
                                case QuizTopic.Word_Form:
                                    bestScoreWF.InnerText = score.ToString();
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    XmlElement root = xmlDocument.DocumentElement;

                    // main node
                    XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDocument.InsertBefore(xmlDeclaration, root);

                    XmlElement mainElement = xmlDocument.CreateElement(string.Empty, "MainInfo", string.Empty);
                    mainElement.InnerText = "Do not modify the contents of this file, or risk losing your saved progress!";
                    xmlDocument.AppendChild(mainElement);

                    // best score
                    XmlElement bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                    mainElement.AppendChild(bestScore);

                    XmlElement bestScoreCol = xmlDocument.CreateElement(string.Empty, "Col", string.Empty);
                    bestScoreCol.InnerText = 0.ToString();
                    bestScore.AppendChild(bestScoreCol);

                    XmlElement bestScoreWM = xmlDocument.CreateElement(string.Empty, "WM", string.Empty);
                    bestScoreWM.InnerText = 0.ToString();
                    bestScore.AppendChild(bestScoreWM);

                    XmlElement bestScorePV = xmlDocument.CreateElement(string.Empty, "PV", string.Empty);
                    bestScorePV.InnerText = 0.ToString();
                    bestScore.AppendChild(bestScorePV);

                    XmlElement bestScoreWF = xmlDocument.CreateElement(string.Empty, "WF", string.Empty);
                    bestScoreWF.InnerText = 0.ToString();
                    bestScore.AppendChild(bestScoreWF);

                    XmlElement bestScoreIdiom = xmlDocument.CreateElement(string.Empty, "Idiom", string.Empty);
                    bestScoreIdiom.InnerText = 0.ToString();
                    bestScore.AppendChild(bestScoreIdiom);

                    switch (q_topic)
                    {
                        case QuizTopic.Collocation:
                            bestScoreCol.InnerText = score.ToString();
                            break;
                        case QuizTopic.Phrasal_Verb:
                            bestScorePV.InnerText = score.ToString();
                            break;
                        case QuizTopic.Idiom:
                            bestScoreIdiom.InnerText = score.ToString();
                            break;
                        case QuizTopic.Word_Meaning:
                            bestScoreWM.InnerText = score.ToString();
                            break;
                        case QuizTopic.Word_Form:
                            bestScoreWF.InnerText = score.ToString();
                            break;
                    }
                }
            }

            xmlDocument.Save(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Saved\\quiz.xml");
        }

        private void Timer1sec_Tick(object sender, EventArgs e)
        {
            if (timeleft <= 6)
                LabelTimeLeft.ForeColor = Color.Red;
            if (timeleft > 1)
            {
                timeleft--;
                LabelTimeLeft.Text = "Time left: " + timeleft.ToString() + "s";
            }
            else
            {
                LabelTimeLeft.Text = "Time left: 0s";
                Timer1sec.Stop();
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
                stopwatch.Start();
            }
        }

        private void FormQuiz_Resize(object sender, EventArgs e)
        {

        }

        private void FormQuiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonNext_Click"))
            {
                FormGameResult fgr = new FormGameResult();
                fgr.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonBack_Click"))
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
            else
                Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonBack_MouseHover(object sender, EventArgs e)
        {
            ToolTipQuiz.SetToolTip(ButtonBack, "Back to Games");
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            Timer1sec.Stop();
            stopwatch.Stop();
            if (MessageBox.Show("Quit now? You will lose any unsaved progress", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PanelQuiz.Visible = false;
                counter = score = 0;
                timeleft = 15;
                LabelTimeLeft.Text = "Time left: 15s";
                ready = 3;
                LabelReady.Text = ready.ToString();
                quizzes.Clear();
                Timer1sec.Stop();
                PanelTopic.Visible = true;
                ButtonA.Enabled = ButtonB.Enabled = ButtonC.Enabled = ButtonD.Enabled = true;
                ButtonA.BackColor = ButtonB.BackColor = ButtonC.BackColor = ButtonD.BackColor = Color.White;
            }
            else
            {
                if (!finished)
                {
                    Timer1sec.Start();
                    stopwatch.Start();
                }
            }
        }

        private void FormQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
