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
    public partial class FormGamesSelect : Form
    {
        public enum GameType
        {
            Quizzes, GTW, Hangman
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
                FormGTW fgtw = new FormGTW();
                fgtw.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "PanelHangman_MouseClick" || x.GetMethod().Name == "PanelHangmanDes_MouseClick"
                || x.GetMethod().Name == "LabelHangmanDes_MouseClick" || x.GetMethod().Name == "LabelHangman_MouseClick" || x.GetMethod().Name == "PictureBoxHangman_MouseClick"))
            {
                FormHangman fh = new FormHangman();
                fh.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ButtonHome_Click"))
            {
                Form1.GetInstance().Show();
            }
            else
            {
                //if (MessageBox.Show("Quit the app now?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
                //    e.Cancel = true;
                //else
                    Application.Exit();
            }
        }

        private void PanelGTW_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gameType = GameType.GTW;
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
    }
}
