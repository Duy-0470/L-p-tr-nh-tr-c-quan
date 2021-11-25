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
    public partial class Form_Quizzes : Form
    {
        public static Form_Quizzes instance = new Form_Quizzes();
        public enum Topic {
            Collocation, Idiom, PhrasalVerbs
        };
        public Topic topic;

        public Form_Quizzes()
        {
            InitializeComponent();
            instance = this;
        }

        private void button_Collocation_Click(object sender, EventArgs e)
        {
            topic = Topic.Collocation;
            Hide();
            Form_Games ga = new Form_Games();
            ga.ShowDialog();
            Show();
        }

        private void button_Idioms_Click(object sender, EventArgs e)
        {
            topic = Topic.Idiom;
            Hide();
            Form_Games ga = new Form_Games();
            ga.ShowDialog();
            Show();
        }

        private void button_PhrasalVerbs_Click(object sender, EventArgs e)
        {
            topic = Topic.PhrasalVerbs;
            Hide();
            Form_Games ga = new Form_Games();
            ga.ShowDialog();
            Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
