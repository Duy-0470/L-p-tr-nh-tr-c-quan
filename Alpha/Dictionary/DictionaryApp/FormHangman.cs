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
    public partial class FormHangman : Form
    {
        private string answer = "";
        private int incorrect = 0, correct = 0, timelimit = 60, ready = 3;
        private readonly Database.DatabaseHandle databaseHandle = new Database.DatabaseHandle();
        private Classes.MyImage hintImage = new Classes.MyImage();
        private readonly Stopwatch stopwatch = new Stopwatch();
        private string[] ansPart;
        private bool finished = false;
        public static int score = 60000;
        public static double time = 0;

        public FormHangman()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
            PanelLetters.Location = new Point((Width - PanelLetters.Width) / 2, Height - PanelLetters.Height - 80);
            PictureBoxHint.Location = new Point((Width - PictureBoxHint.Width) / 2, 10);
            LabelGuess.Text = "";
            LabelGuess.Width = Width;
            LabelReady.Location = new Point((Width - LabelReady.Width) / 2, (Height - LabelReady.Height) / 2);
            PanelRules.Location = new Point(0, 0);
            PanelRules.Size = Size;
        }

        private void FormHangman_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonQuit_Click"))
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonCont_Click"))
            {
                FormGameResult fgs = new FormGameResult();
                fgs.Show();
            }
            else
                Application.Exit();
        }

        private void LoadQuestion()
        {
            incorrect = correct = 0;
            timelimit = 60;
            hintImage = databaseHandle.RandomImage();
            answer = hintImage.name.Substring(0, hintImage.name.IndexOf('_')).ToUpper();
            PictureBoxHint.Load(hintImage.link);
            PictureBoxHint.SizeMode = PictureBoxSizeMode.Zoom;
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
                ansPart = answer.Split('-');
                for (int i = 0; i < ansPart[0].Length * 2; i++)
                {
                    if (i % 2 == 0)
                        LabelGuess.Text += "_";
                    else
                        LabelGuess.Text += " ";
                }
                LabelGuess.Text += "   ";
                for (int i = 0; i < ansPart[1].Length * 2; i++)
                {
                    if (i % 2 == 0)
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
                if (correct < answer.Length)
                {
                    timelimit += 5;
                    LabelTimeLeft.Text = "Time left: " + timelimit + "s";
                }
                if (!answer.Contains('-'))
                {
                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (answer[i] == button.Name.Last())
                        {
                            StringBuilder showletter = new StringBuilder(LabelGuess.Text);
                            showletter[i * 2] = answer[i];
                            LabelGuess.Text = showletter.ToString();
                            correct++;
                            score += 10000;
                        }
                    }
                }
                else
                {                 
                    if (ansPart[0].Contains(button.Name.Last()))
                    {
                        for (int i = 0; i < ansPart[0].Length; i++)
                        {
                            if (ansPart[0][i] == button.Name.Last())
                            {
                                StringBuilder showletter = new StringBuilder(LabelGuess.Text);
                                showletter[i * 2] = ansPart[0][i];
                                LabelGuess.Text = showletter.ToString();
                                correct++;
                                score += 10000;
                            }
                        }
                    }
                    if (ansPart[1].Contains(button.Name.Last()))
                    {
                        for (int i = 0; i < ansPart[1].Length; i++)
                        {
                            if (ansPart[1][i] == button.Name.Last())
                            {
                                StringBuilder showletter = new StringBuilder(LabelGuess.Text);
                                showletter[ansPart[0].Length * 2 + 3 + i * 2] = ansPart[1][i];
                                LabelGuess.Text = showletter.ToString();
                                correct++;
                                score += 10000;
                            }
                        }
                    }
                }
                if ((!answer.Contains('-') && correct == answer.Length) || (answer.Contains('-') && correct == answer.Length - 1))
                {
                    finished = true;
                    TimeLimit.Stop();
                    stopwatch.Stop();
                    time = Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000;
                    LabelGuess.ForeColor = Color.Green;
                    PanelLetters.Controls.Clear();
                    Label result = new Label()
                    {
                        Text = "You won! You escaped.",
                        Font = new Font(new Font("Times New Roman", 28), FontStyle.Regular),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    PanelLetters.Controls.Add(result);
                    result.Location = new Point((PanelLetters.Width - result.Width) / 2, (PanelLetters.Height - result.Height) / 2 - 30);
                    SaveProgress();
                    ButtonCont.Visible = true;
                }
            }
            else
            {
                incorrect++;
                score -= 5000;
                PictureBoxHangman.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\Files\\images\\hangman" + incorrect + ".png");
                if (incorrect == 6)
                {
                    TimeLimit.Stop();
                    stopwatch.Stop();
                    time = Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000;
                    LabelGuess.Text = "";
                    LabelGuess.ForeColor = Color.Red;
                    score = 0;
                    for (int i = 0; i < answer.Length; i++)
                    {
                        LabelGuess.Text += answer[i] + " ";
                    }
                    LabelGuess.Text = LabelGuess.Text.Replace('-', ' ');
                    PanelLetters.Controls.Clear();
                    Label result = new Label()
                    {
                        Text = "You lost. You were hung",
                        Font = new Font(new Font("Times New Roman", 28), FontStyle.Regular),
                        AutoSize = true,
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    PanelLetters.Controls.Add(result);
                    result.Location = new Point((PanelLetters.Width - result.Width) / 2, (PanelLetters.Height - result.Height) / 2 - 30);
                    ButtonCont.Visible = true;
                }
            }
        }

        private void SaveProgress()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (!File.Exists(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Saved\\hangman.xml"))
            {
                XmlElement root = xmlDocument.DocumentElement;

                XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDocument.InsertBefore(xmlDeclaration, root);

                XmlElement mainElement = xmlDocument.CreateElement(string.Empty, "MainInfo", string.Empty);
                mainElement.InnerText = "Do not modify the contents of this file, or risk losing your saved progress!";
                xmlDocument.AppendChild(mainElement);

                XmlElement bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                bestScore.InnerText = score.ToString();
                mainElement.AppendChild(bestScore);

                //XmlElement bestTime = xmlDocument.CreateElement(string.Empty, "BestTime", string.Empty);
                //bestTime.InnerText = (Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000).ToString();
                //mainElement.AppendChild(bestTime);
            }
            else
            {
                bool success = true;
                try
                {
                    xmlDocument.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Saved\\hangman.xml");
                }
                catch (XmlException exception)
                {
                    success = false;
                    Debug.WriteLine(exception.Message);
                }
                if (success)
                {
                    XmlNode bestScore = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore");
                    //XmlNode bestTime = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestTime");
                    if (bestScore != null/* && bestTime != null*/)
                    {
                        if (double.TryParse(bestScore.InnerText, out double s))
                        {
                            if (score > s)
                                bestScore.InnerText = score.ToString();
                        }
                        else
                            bestScore.InnerText = score.ToString();

                        //if (double.TryParse(bestTime.InnerText, out double t))
                        //{
                        //    if ((Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000) < t)
                        //        bestTime.InnerText = (Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000).ToString();
                        //}
                        //else
                        //    bestTime.InnerText = (Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000).ToString();
                    }
                    else
                    {
                        XmlNode mainElement = xmlDocument.SelectSingleNode("/MainInfo");

                        bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                        bestScore.InnerText = score.ToString();
                        mainElement.AppendChild(bestScore);

                        ////bestTime = xmlDocument.CreateElement(string.Empty, "BestTime", string.Empty);
                        ////bestTime.InnerText = (Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000).ToString();
                        ////mainElement.AppendChild(bestTime);
                    }
                }
                else
                {
                    XmlElement root = xmlDocument.DocumentElement;

                    XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDocument.InsertBefore(xmlDeclaration, root);

                    XmlElement mainElement = xmlDocument.CreateElement(string.Empty, "MainInfo", string.Empty);
                    mainElement.InnerText = "Do not modify the contents of this file, or risk losing your saved progress!";
                    xmlDocument.AppendChild(mainElement);

                    XmlElement bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                    bestScore.InnerText = score.ToString();
                    mainElement.AppendChild(bestScore);

                    //XmlElement bestTime = xmlDocument.CreateElement(string.Empty, "BestTime", string.Empty);
                    //bestTime.InnerText = (Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000).ToString();
                    //mainElement.AppendChild(bestTime);
                }
            }
            xmlDocument.Save(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Saved\\hangman.xml");
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
                ButtonQuit.Visible = true;
                TimeLimit.Start();
                stopwatch.Start();
            }
        }

        private void ButtonOKRules_Click(object sender, EventArgs e)
        {
            if (CheckBoxShowRules.Checked)
            {
                Properties.Settings.Default.ShowHMRules = false;
                Properties.Settings.Default.Save();
            }
            PanelRules.Visible = false;
            LabelReady.Visible = true;
            TimerReady.Start();
        }

        private void ButtonCont_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormHangman_Load(object sender, EventArgs e)
        {
            LoadQuestion();
            if (Properties.Settings.Default.ShowHMRules)
                PanelRules.Visible = true;
            else
            {
                LabelReady.Visible = true;
                TimerReady.Start();
            }
        }

        private void TimeLimit_Tick(object sender, EventArgs e)
        {
            if (timelimit <= 6)
                LabelTimeLeft.ForeColor = Color.Red;
            else
                LabelTimeLeft.ForeColor = Color.Black;

            if (timelimit > 1)
            {
                timelimit--;
                score -= 1000;
                LabelTimeLeft.Text = "Time left: " + timelimit.ToString() + "s";
            }
            else
            {
                LabelTimeLeft.Text = "Time left: 0s";
                TimeLimit.Stop();
                stopwatch.Stop();
                PanelLetters.Controls.Clear();
                Label result = new Label()
                {
                    Text = "You ran out of time\nYou were hung",
                    Font = new Font(new Font("Times New Roman", 28), FontStyle.Regular),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                PanelLetters.Controls.Add(result);
                result.Location = new Point((PanelLetters.Width - result.Width) / 2, (PanelLetters.Height - result.Height) / 2 - 30);
                PictureBoxHangman.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\Files\\images\\hangman6.png");
                LabelGuess.Text = "";
                LabelGuess.ForeColor = Color.Red;
                for (int i = 0; i < answer.Length; i++)
                {
                    LabelGuess.Text += answer[i] + " ";
                }
                LabelGuess.Text = LabelGuess.Text.Replace('-', ' ');
            }
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            TimeLimit.Stop();
            stopwatch.Stop();
            if (!finished)
            {
                if (MessageBox.Show("Quit now? You will lose any unsaved your progress", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Close();
                else
                {
                    TimeLimit.Start();
                    stopwatch.Start();
                }
            }
            else
                Close();
        }
    }
}
