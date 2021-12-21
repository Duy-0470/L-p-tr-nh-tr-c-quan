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
    public partial class FormSWSettings : Form
    {
        public static int number_question;
        public static int time;
        bool choose1 = false;
        public FormSWSettings()
        {
            InitializeComponent();
            Bounds = Screen.PrimaryScreen.Bounds;
            btn_Next.Visible = false;
            btn_Start.Visible = false;
            pictureBox1.Location = new Point((ClientSize.Width / 2) - (pictureBox1.Width / 2), (ClientSize.Height / 2) - (pictureBox1.Height / 2));
            pictureBox1.Anchor = AnchorStyles.None;
            //btn_Back.Location = new Point(0, Height - btn_Back.Height);
            btn_Start.Location = new Point((Width / 2) - (btn_Start.Width / 2), (Height / 2) - (btn_Start.Height / 2));
            btn_Next.Location = new Point(Width - btn_Next.Width, Height - btn_Next.Height);
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
                    radioButton3.Checked = false;
                    number_question = 20;
                }
                else if (radioButton4.Checked)
                {
                    radioButton4.Checked = false;
                    number_question = 50;
                }
                else
                {
                    MessageBox.Show("You haven't selected an option", "Alert");
                    return;
                }
                label1.Text = "Select the time limit for a question";
                radioButton1.Text = "10 sec";
                radioButton2.Text = "15 sec";
                radioButton3.Text = "20 sec";
                radioButton4.Text = "30 sec";
                btn_Next.Visible = false;
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
                    MessageBox.Show("You haven't selected an option", "Alert");
                    return;
                }
                Controls.Remove(label1);
                Controls.Remove(radioButton1);
                Controls.Remove(radioButton2);
                Controls.Remove(radioButton3);
                Controls.Remove(radioButton4);
                Controls.Remove(btn_Next);
                pictureBox3.Visible = false;
                panel1.Visible = false;
                btn_Start.Visible = true;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                btn_Next.Visible = true;
            if (radioButton2.Checked)
                btn_Next.Visible = true;
            if (radioButton3.Checked)
                btn_Next.Visible = true;
            if (radioButton4.Checked)
                btn_Next.Visible = true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Close();
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
            btn_Play.Visible = false;
            btn_Back.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2, ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;  
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSWSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "btn_Back_Click"))
            {
                FormGamesSelect fgs = new FormGamesSelect();
                fgs.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "btn_Start_Click"))
            {
                FormSW fsw = new FormSW();
                fsw.Show();
            }
        }
    }
  }
