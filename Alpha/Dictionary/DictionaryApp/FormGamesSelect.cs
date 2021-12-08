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
        public FormGamesSelect()
        {
            InitializeComponent();
            ButtonHome.FlatAppearance.BorderSize = 0;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Close();
        }

        private void PanelQuizzesBorder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    Hide();
            //    FormQuizTopic fqt = new FormQuizTopic();
            //    fqt.Show();
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    Hide();
            //    FormQuizTopic fqt = new FormQuizTopic();
            //    fqt.Show();
            //}
        }

        private void PanelQuizzes_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Close();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Close();
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Close();
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
    }
}
