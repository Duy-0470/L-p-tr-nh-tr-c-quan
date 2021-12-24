using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class FormGamesSelect : Form
    {
        public enum GameType
        {
            Quizzes, SW, Hangman
        }
        public static GameType gameType;
        
        public FormGamesSelect()
        {
            InitializeComponent();
            ButtonHome.FlatAppearance.BorderSize = 0;
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            PanelQuizzesBorder_MouseClick(sender, e);
        }

        private void PanelQuizzesBorder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gameType = GameType.Quizzes;
                Close();
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            PanelQuizzesBorder_MouseClick(sender, e);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PanelQuizzesBorder_MouseClick(sender, e);
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            PanelQuizzesBorder_MouseClick(sender, e);
        }

        private void FormGamesSelect_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void FormGamesSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "panel1_MouseClick" || x.GetMethod().Name == "PanelQuizzesBorder_MouseClick"
                || x.GetMethod().Name == "label2_MouseClick" || x.GetMethod().Name == "pictureBox1_MouseClick" || x.GetMethod().Name == "label3_MouseClick"))
            {
                FormQuiz fq = new FormQuiz();
                fq.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "PanelGTW_MouseClick" || x.GetMethod().Name == "LabelGTWDes_MouseClick"
                || x.GetMethod().Name == "PictureBoxGTW_MouseClick" || x.GetMethod().Name == "label4_MouseClick" || x.GetMethod().Name == "PanelGTWDes_MouseClick"))
            {
                FormSWSettings fss = new FormSWSettings();
                fss.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "PanelHangman_MouseClick" || x.GetMethod().Name == "PanelHangmanDes_MouseClick"
                || x.GetMethod().Name == "LabelHangmanDes_MouseClick" || x.GetMethod().Name == "LabelHangman_MouseClick" || x.GetMethod().Name == "PictureBoxHangman_MouseClick"))
            {
                FormHangman fh = new FormHangman();
                fh.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonHome_Click"))
                Form1.GetInstance().Show();
            else
            {
                Application.Exit();
            }
        }

        private void PanelGTW_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gameType = GameType.SW;
                Close();
            }
        }

        private void LabelGTWDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelGTW_MouseClick(sender, e);
        }

        private void PictureBoxGTW_MouseClick(object sender, MouseEventArgs e)
        {
            PanelGTW_MouseClick(sender, e);
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            PanelGTW_MouseClick(sender, e);
        }

        private void PanelGTWDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelGTW_MouseClick(sender, e);
        }

        private void PanelHangman_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gameType = GameType.Hangman;
                Close();
            }
        }

        private void PanelHangmanDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelHangman_MouseClick(sender, e);
        }

        private void LabelHangmanDes_MouseClick(object sender, MouseEventArgs e)
        {
            PanelHangman_MouseClick(sender, e);
        }

        private void LabelHangman_MouseClick(object sender, MouseEventArgs e)
        {
            PanelHangman_MouseClick(sender, e);
        }

        private void PictureBoxHangman_MouseClick(object sender, MouseEventArgs e)
        {
            PanelHangman_MouseClick(sender, e);
        }

        private void PanelQuizzesBorder_MouseEnter(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.OrangeRed;
        }

        private void PanelQuizzes_MouseEnter(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.OrangeRed;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.OrangeRed;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.OrangeRed;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.OrangeRed;
        }

        private void PanelGTW_MouseEnter(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.OrangeRed;
        }

        private void LabelGTW_MouseLeave(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void PictureBoxWS_MouseEnter(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.OrangeRed;
        }

        private void LabelWSDes_MouseEnter(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.OrangeRed;
        }

        private void PanelWSDes_MouseEnter(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.OrangeRed;
        }

        private void PanelHangman_MouseEnter(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.OrangeRed;
        }

        private void LabelHangman_MouseEnter(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.OrangeRed;
        }

        private void PictureBoxHangman_MouseEnter(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.OrangeRed;
        }

        private void LabelHangmanDes_MouseEnter(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.OrangeRed;
        }

        private void PanelHangmanDes_MouseEnter(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.OrangeRed;
        }

        private void PanelQuizzesBorder_MouseLeave(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.FromArgb(150, 199, 193);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.FromArgb(150, 199, 193);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.FromArgb(150, 199, 193);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.FromArgb(150, 199, 193);
        }

        private void PanelQuizzes_MouseLeave(object sender, EventArgs e)
        {
            PanelQuizzesBorder.BackColor = Color.FromArgb(150, 199, 193);
        }

        private void PanelGTW_MouseLeave(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void LabelGTW_MouseEnter(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.OrangeRed;
        }

        private void PictureBoxWS_MouseLeave(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void LabelWSDes_MouseLeave(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void PanelWSDes_MouseLeave(object sender, EventArgs e)
        {
            PanelWS.BackColor = Color.FromArgb(137, 181, 175);
        }

        private void PanelHangman_MouseLeave(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.FromArgb(208, 202, 178);
        }

        private void LabelHangman_MouseLeave(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.FromArgb(208, 202, 178);
        }

        private void PictureBoxHangman_MouseLeave(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.FromArgb(208, 202, 178);
        }

        private void LabelHangmanDes_MouseLeave(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.FromArgb(208, 202, 178);
        }

        private void PanelHangmanDes_MouseLeave(object sender, EventArgs e)
        {
            PanelHangman.BackColor = Color.FromArgb(208, 202, 178);
        }
    }
}
