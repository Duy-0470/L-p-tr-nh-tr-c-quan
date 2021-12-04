using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
            LabelScore.Text = "Your score: " + FormQuiz.score.ToString() + " / 20";
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            // more to be added
        }

        private void FormResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGamesSelect fgs = new FormGamesSelect();
            fgs.Show();
        }
    }
}
