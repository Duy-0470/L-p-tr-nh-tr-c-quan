using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_Beta_1
{
    public partial class Form_StartScreen : Form
    {
        public Form_StartScreen()
        {
            InitializeComponent();
        }

        private void button_Translate_Click(object sender, EventArgs e)
        {
            Hide();
            LookUp lu = new LookUp();
            lu.ShowDialog();
            Show();
        }

        private void button_Quizzes_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Quizzes qu = new Form_Quizzes();
            qu.ShowDialog();
            Show();
        }
    }
}
