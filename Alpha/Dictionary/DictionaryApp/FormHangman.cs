using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        public static int score = 0;
        public static double accuracy = 0;
        public static double time = 0, pb = 0;
        public static bool highscore = false;
        private Classes.Word getWord = new Classes.Word();
        //private readonly Random rand = new Random();
        private int round = 0;
        private int choose = 0;
        private readonly int[] roundscore = new int[5];

        public FormHangman()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
            PictureBoxHint.Location = new Point((Width - PictureBoxHint.Width) / 2, LabelMeaning.Location.Y + LabelMeaning.Height);
            PictureBoxHangman.Location = new Point(PictureBoxHint.Width - 40 - PictureBoxHangman.Width, LabelGuess.Location.Y - 20 - PictureBoxHangman.Height);
            Debug.WriteLine(PictureBoxHangman.Location.ToString());
            LabelGuess.Text = "";
            LabelGuess.Width = Width;
            LabelGuess.Location = new Point((Width - LabelGuess.Width) / 2, (Height - LabelGuess.Height) / 2 + 40);
            PanelLetters.Location = new Point((Width - PanelLetters.Width) / 2, LabelGuess.Location.Y + LabelGuess.Height + 60);
            LabelReady.Location = new Point((Width - LabelReady.Width) / 2, (Height - LabelReady.Height) / 2);
            PanelRules.Location = new Point(0, 0);
            PanelRules.Size = Size;
            LabelMeaning.Location = new Point((Width - LabelMeaning.Width) / 2, 25);
            LabelResult.Location = new Point(PanelLetters.Location.X + PanelLetters.Width / 2 - LabelResult.Width / 2, PanelLetters.Location.Y + PanelLetters.Height / 2 - LabelResult.Height / 2);
            LabelResult.Width = PanelLetters.Width;           
            for (int i = 0; i < roundscore.Length; i++)
            {
                roundscore[i] = 60000;
            }
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
            PictureBoxHint.SizeMode = PictureBoxSizeMode.Zoom;
            do
            {
                hintImage = databaseHandle.RandomImage();
                getWord = databaseHandle.FindWord(hintImage.name);
            } while (getWord == null);
            answer = hintImage.name.Substring(0, hintImage.name.IndexOf('_')).ToUpper();
            PictureBoxHint.Image = Image.FromFile(hintImage.link);
            LabelMeaning.Text = getWord.senses[0/*rand.Next(0, getWord.senses.Count())*/].meaning.Replace("=", string.Empty);
            LabelMeaning.Text = LabelMeaning.Text[0].ToString().ToUpper() + LabelMeaning.Text.Substring(1);
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
            choose++;
            Button button = (Button)sender;
            Debug.WriteLine(button.Name.Last().ToString());
            button.Enabled = false;
            if (answer.Contains(button.Name.Last()))
            {
                accuracy++;
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
                            roundscore[round] += 10000;
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
                                roundscore[round] += 10000;
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
                                roundscore[round] += 10000;
                            }
                        }
                    }
                }
                if ((!answer.Contains('-') && correct == answer.Length) || (answer.Contains('-') && correct == answer.Length - 1))
                {
                    finished = true;
                    PictureBoxHint.Visible = true;
                    TimeLimit.Stop();
                    stopwatch.Stop();
                    time += Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000;
                    LabelGuess.ForeColor = Color.Green;
                    PanelLetters.Visible = false;
                    LabelResult.Visible = true;
                    LabelResult.Text = "Correct! You avoided the hang";
                    score += roundscore[round];
                    LabelScore.Text = "Score: " + score.ToString();
                    ButtonCont.Visible = true;
                }
            }
            else
            {
                incorrect++;
                if (roundscore[round] > 0)
                    roundscore[round] -= 5000;
                PictureBoxHangman.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\Files\\images\\hangman" + incorrect + ".png");
                if (incorrect == 6)
                {
                    TimeLimit.Stop();
                    stopwatch.Stop();
                    roundscore[round] = 0;
                    finished = true;
                    PictureBoxHint.Visible = true;
                    time += Convert.ToDouble(stopwatch.ElapsedMilliseconds) / 1000;
                    LabelGuess.Text = "";
                    LabelGuess.ForeColor = Color.Red;
                    for (int i = 0; i < answer.Length; i++)
                    {
                        LabelGuess.Text += answer[i] + " ";
                    }
                    LabelGuess.Text = LabelGuess.Text.Replace('-', ' ');
                    PanelLetters.Visible = false;
                    LabelResult.Visible = true;
                    LabelResult.Text = "You lost. You were hung";
                    score += roundscore[round];
                    LabelScore.Text = "Score: " + score.ToString();
                    ButtonCont.Visible = true;
                }
            }
        }

        private void SaveProgress()
        {
            XmlDocument xmlDocument = new XmlDocument();
            if (!File.Exists(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Saved\\hangman.xml"))
            {
                highscore = true;
                XmlElement root = xmlDocument.DocumentElement;

                XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDocument.InsertBefore(xmlDeclaration, root);

                XmlElement mainElement = xmlDocument.CreateElement(string.Empty, "MainInfo", string.Empty);
                mainElement.InnerText = "Do not modify the contents of this file, or risk losing your saved progress!";
                xmlDocument.AppendChild(mainElement);

                XmlElement bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                bestScore.InnerText = score.ToString();
                mainElement.AppendChild(bestScore);
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
                    XmlNode mainElement = xmlDocument.SelectSingleNode("/MainInfo");
                    XmlNode bestScore = xmlDocument.DocumentElement.SelectSingleNode("/MainInfo/BestScore");
                    if (bestScore != null && mainElement != null)
                    {
                        if (double.TryParse(bestScore.InnerText, out double s))
                        {
                            if (score > s)
                            {
                                highscore = true;
                                bestScore.InnerText = score.ToString();
                            }
                            else
                                pb = s;
                        }
                        else
                            bestScore.InnerText = score.ToString();
                    }
                    else
                    {
                        XmlElement root = xmlDocument.DocumentElement;

                        XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
                        xmlDocument.InsertBefore(xmlDeclaration, root);

                        mainElement = xmlDocument.CreateElement(string.Empty, "MainInfo", string.Empty);
                        mainElement.InnerText = "Do not modify the contents of this file, or risk losing your saved progress!";
                        xmlDocument.AppendChild(mainElement);

                        bestScore = xmlDocument.CreateElement(string.Empty, "BestScore", string.Empty);
                        bestScore.InnerText = score.ToString();
                        mainElement.AppendChild(bestScore);
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
                LabelGuess.Visible = true;
                LabelTimeLeft.Visible = true;
                LabelMeaning.Visible = true;
                LabelRound.Visible = true;
                ButtonQuit.Visible = true;
                LabelScore.Visible = true;
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
            round++;
            if (round < 5)
            {               
                LabelGuess.Text = "";
                LoadQuestion();
                finished = false;
                PanelLetters.Visible = true;
                foreach (Button button in PanelLetters.Controls)
                {
                    button.Enabled = true;
                }
                LabelGuess.ForeColor = Color.Black;
                LabelResult.Visible = false;
                PictureBoxHint.Visible = false;                
                PictureBoxHangman.Load(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\Files\\images\\hangman0.png");
                LabelTimeLeft.Text = "Time left: " + timelimit.ToString();
                LabelRound.Text = "Round: " + (round + 1).ToString();
                if (round == 4)
                    ButtonCont.Text = "Finish";
                TimeLimit.Start();
                stopwatch.Reset();
                stopwatch.Start();
                ButtonCont.Visible = false;
            }
            else
            {
                time = time / 5;
                accuracy = accuracy / choose * 100;
                SaveProgress();
                Close();
            }
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
                if (roundscore[round] > 0)
                    roundscore[round] -= 1000;
                LabelTimeLeft.Text = "Time left: " + timelimit.ToString() + "s";
            }
            else
            {
                LabelTimeLeft.Text = "Time left: 0s";
                TimeLimit.Stop();
                stopwatch.Stop();
                PanelLetters.Visible = false;
                ButtonCont.Visible = true;
                LabelResult.Visible = true;
                PictureBoxHint.Visible = true;
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
            if (MessageBox.Show("Quit now? You will lose any unsaved your progress", "Alert", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Close();
            else
            {
                if (!finished)
                {
                    TimeLimit.Start();
                    stopwatch.Start();
                }
            }
        }
    }
}
