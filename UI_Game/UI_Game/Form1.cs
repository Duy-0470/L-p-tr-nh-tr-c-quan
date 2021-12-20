using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Game
{
    public partial class Form1 : Form
    {
        public static int number_question;
        public static int time;
        bool choose1 = false;
        public Form1()
        {
            InitializeComponent();
            btn_Submit.Visible = false;
            btn_Start.Visible = false;           
            Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (choose1 == false)
            {
                if (radioButton1.Checked)
                {
                    radioButton1.Checked = false;
                    number_question = 10;
                }
                else if (radioButton2.Checked)
                {
                    radioButton2.Checked = false;
                    number_question = 15;
                }
                else if (radioButton3.Checked)
                {
                    radioButton3 .Checked = false;
                    number_question = 20;
                }
                else if (radioButton4.Checked)
                {
                    radioButton4 .Checked = false;
                    number_question = 50;
                }
                else
                {
                    MessageBox.Show("Chua chon kia thang ngu", "Thong bao");
                    return;
                }
                label1.Text = "How long do you want to answer a question?";
                radioButton1.Text = "10 sec";
                radioButton2.Text = "15 sec";
                radioButton3.Text = "20 sec";
                radioButton4.Text = "30 sec";
                btn_Submit.Visible = false;
                choose1 = true;
            }
            else
            {
                if (radioButton1.Checked)
                    time = 10;
                else if (radioButton2.Checked)
                    time = 15;
                else if (radioButton3.Checked)
                    time = 20;
                else if (radioButton4.Checked)
                    time = 30;
                else
                {
                    MessageBox.Show("Chua chon kia thang ngu", "Thong bao");
                    return;
                }
                Controls.Remove(label1);
                Controls.Remove(radioButton1);
                Controls.Remove(radioButton2);
                Controls.Remove(radioButton3);
                Controls.Remove(radioButton4);
                Controls.Remove(btn_Submit);
                pictureBox3.Visible = false;
                panel1.Visible = false;
                btn_Start.Visible = true;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                btn_Submit.Visible = true;
            if (radioButton2.Checked)
                btn_Submit.Visible = true;
            if (radioButton3.Checked)
                btn_Submit.Visible = true;
            if (radioButton4.Checked)
                btn_Submit.Visible = true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_MainMenu_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox3.Visible = true;
            panel1.Visible = true;
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            button4.Visible = false;
            button2.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
