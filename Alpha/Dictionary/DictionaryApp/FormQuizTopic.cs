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
    public partial class FormQuizTopic : Form
    {
        public enum QuizTopic
        {
            Collocation, Phrasal_Verb, Idiom, Word_Meaning, Word_Form
        }
        public static QuizTopic q_topic;

        public FormQuizTopic()
        {
            InitializeComponent();
        }

        private void FormQuizTopic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "panel1_MouseClick" || x.GetMethod().Name == "label2_MouseClick" || x.GetMethod().Name == "label3_MouseClick"
                || x.GetMethod().Name == "PanelPhrasalVerbs_MouseClick" || x.GetMethod().Name == "LabelPV_MouseClick" || x.GetMethod().Name == "LabelPVDes_MouseClick"
                || x.GetMethod().Name == "PanelIdioms_MouseClick" || x.GetMethod().Name == "LabelIdioms_MouseClick" || x.GetMethod().Name == "LabelIdiomsDes_MouseClick"
                || x.GetMethod().Name == "PanelWM_MouseClick" || x.GetMethod().Name == "LabelWM_MouseClick" || x.GetMethod().Name == "LabelWMDes_MouseClick"
                || x.GetMethod().Name == "PanelWF_MouseClick" || x.GetMethod().Name == "LabelWF_MouseClick" || x.GetMethod().Name == "LabelWFDes_MouseClick"))
            {
                FormQuiz fq = new FormQuiz();
                fq.Show();
            }
            else
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Collocation;
                Close();
            }
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Collocation;
                Close();
            }
        }

        private void PanelPhrasalVerbs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Phrasal_Verb;
                Close();
            }
        }

        private void LabelPV_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Phrasal_Verb;
                Close();
            }
        }

        private void LabelPVDes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Phrasal_Verb;
                Close();
            }
        }

        private void PanelIdioms_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Idiom;
                Close();
            }
        }

        private void LabelIdioms_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Idiom;
                Close();
            }
        }

        private void LabelIdiomsDes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Idiom;
                Close();
            }
        }

        private void LabelCollocationsDes_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Collocation;
                Close();
            }
        }

        private void PanelWM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Word_Meaning;
                Close();
            }
        }

        private void LabelWM_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Word_Meaning;
                Close();
            }
        }

        private void LabelWMDes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Word_Meaning;
                Close();
            }
        }

        private void PanelWF_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Word_Form;
                Close();
            }
        }

        private void LabelWF_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Word_Form;
                Close();
            }
        }

        private void LabelWFDes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                q_topic = QuizTopic.Word_Form;
                Close();
            }
        }
    }
}
