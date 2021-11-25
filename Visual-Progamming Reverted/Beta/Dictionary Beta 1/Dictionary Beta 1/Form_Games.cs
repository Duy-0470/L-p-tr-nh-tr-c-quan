using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Beta_1
{
    public partial class Form_Games : Form
    {
        public static IEnumerable<string> EnumerateLines(TextReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }

        public static string[] ReadAllResourceLines(string resourceText)
        {
            using (StringReader reader = new StringReader(resourceText))
            {
                return EnumerateLines(reader).ToArray();
            }
        }
        private static string[] questions;
        private static string[] answers;
        private static List<int> q_index = new List<int>();
        private static int score = 0, count = 0;
        private static string current_question = "", current_answers = "";
        private static int r, a, b, c, d, k;

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (count < 10)
            {                
                button_Next.Visible = false;
                Display();
            }
            else
            {
                MessageBox.Show("Điểm của bạn là: " + score + "/10" , "Chúc mừng", MessageBoxButtons.OK);
                count = 0;
                score = 0;
                q_index.Clear();
                Close();
            }
        }

        private void button_Quit_Click(object sender, EventArgs e)
        {
            count = 0;
            score = 0;
            q_index.Clear();
            Close();
        }

        public Form_Games()
        {
            InitializeComponent();
            if (Form_Quizzes.instance.topic == Form_Quizzes.Topic.Collocation)
            {
                questions = ReadAllResourceLines(Properties.Resources.Collocation_Quizzes);
                answers = ReadAllResourceLines(Properties.Resources.Collocation_Answers);
            }
            else if (Form_Quizzes.instance.topic == Form_Quizzes.Topic.Idiom)
            {
                questions = ReadAllResourceLines(Properties.Resources.Idiom_Quizzes);
                answers = ReadAllResourceLines(Properties.Resources.Idiom_Answers);
            }
            else
            {
                questions = ReadAllResourceLines(Properties.Resources.Phrasal_Verbs_Quizzes);
                answers = ReadAllResourceLines(Properties.Resources.Phrasal_Verbs_Answers);
            }
            Display();
        }

        private void Display()
        {
            button_A.Enabled = true;
            button_B.Enabled = true;
            button_C.Enabled = true;
            button_D.Enabled = true;
            button_A.BackColor = Color.White;
            button_B.BackColor = Color.White;
            button_C.BackColor = Color.White;
            button_D.BackColor = Color.White;

            r = new Random().Next(0, questions.Length + 1);
            for (int i = 0; i < q_index.Count; i++)
            {
                while (q_index[i] == r)
                {
                    r = new Random().Next(0, questions.Length + 1);
                    i = 0;
                }
            }
            q_index.Add(r);
            
            current_question = questions[r];
            a = current_question.IndexOf("_A.");
            b = current_question.IndexOf("_B.");
            c = current_question.IndexOf("_C.");
            d = current_question.IndexOf("_D.");
            k = current_question.IndexOf(". ");
            label_Question.Text = current_question.Substring(k + 2, a - k - 2);
            button_A.Text = current_question.Substring(a + 1, b - a - 1);
            button_B.Text = current_question.Substring(b + 1, c - b - 1);
            button_C.Text = current_question.Substring(c + 1, d - c - 1);
            button_D.Text = current_question.Substring(d + 1);
        }

        private void DisableAnswerButtons()
        {
            button_A.Enabled = false;
            button_B.Enabled = false;  
            button_C.Enabled = false;
            button_D.Enabled = false;
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            current_answers = answers[r].Substring(answers[r].Length - 1);
            if (current_answers == "A")
            {
                button_A.BackColor = Color.Green;
                score++;
            }
            else
            {
                button_A.BackColor = Color.Red;
            }
            if (current_answers == "B")
            {
                button_B.BackColor = Color.Green;
            }
            if (current_answers == "C")
            {
                button_C.BackColor = Color.Green;
            }
            if (current_answers == "D")
            {
                button_D.BackColor = Color.Green;
            }
            DisableAnswerButtons();
            count++;
            button_Next.Visible = true;
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            current_answers = answers[r].Substring(answers[r].Length - 1);
            if (current_answers == "B")
            {
                button_B.BackColor = Color.Green;
                score++;
            }
            else
            {
                button_B.BackColor = Color.Red;
            }
            if (current_answers == "A")
            {
                button_A.BackColor = Color.Green;
            }
            if (current_answers == "C")
            {
                button_C.BackColor = Color.Green;
            }
            if (current_answers == "D")
            {
                button_D.BackColor = Color.Green;
            }
            DisableAnswerButtons();
            count++;
            button_Next.Visible = true;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            current_answers = answers[r].Substring(answers[r].Length - 1);
            if (current_answers == "C")
            {
                button_C.BackColor = Color.Green;
                score++;
            }
            else
            {
                button_C.BackColor = Color.Red;
            }
            if (current_answers == "B")
            {
                button_B.BackColor = Color.Green;
            }
            if (current_answers == "A")
            {
                button_A.BackColor = Color.Green;
            }
            if (current_answers == "D")
            {
                button_D.BackColor = Color.Green;
            }
            DisableAnswerButtons();
            count++;
            button_Next.Visible = true;
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            current_answers = answers[r].Substring(answers[r].Length - 1);
            if (current_answers == "D")
            {
                button_D.BackColor = Color.Green;
                score++;
            }
            else
            {
                button_D.BackColor = Color.Red;
            }
            if (current_answers == "B")
            {
                button_B.BackColor = Color.Green;
            }
            if (current_answers == "C")
            {
                button_C.BackColor = Color.Green;
            }
            if (current_answers == "A")
            {
                button_A.BackColor = Color.Green;
            }
            DisableAnswerButtons();
            count++;
            button_Next.Visible = true;
        }
    }
}
