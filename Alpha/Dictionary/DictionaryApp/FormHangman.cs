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
    public partial class FormHangman : Form
    {
        private string answer = "", hint = "";


        public FormHangman()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
            PanelLetters.Location = new Point((Width - PanelLetters.Width) / 2, Height / 2 + 50);
        }

        private void FormHangman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoadQuestion()
        {
            answer = "rehabilitation";
            //hint = get image path function;
            //PictureBoxHint.Load(hint);
            
        }

        private void FormHangman_Load(object sender, EventArgs e)
        {
            LoadQuestion();

        }
    }
}
