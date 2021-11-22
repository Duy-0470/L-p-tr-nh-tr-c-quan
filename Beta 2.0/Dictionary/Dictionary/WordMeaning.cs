using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class WordMeaning : Form
    {
        public WordMeaning()
        {
            InitializeComponent();
            RichTextBoxWordInfo.BorderStyle = BorderStyle.None;
            ButtonSpeak.FlatAppearance.BorderSize = 0;
            ButtonMarkWord.FlatAppearance.BorderSize = 0;
        }

        private void LabelSeeAlso1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LabelSeeAlso2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LabelSeeAlso3_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LabelSeeAlso1_MouseHover(object sender, EventArgs e)
        {
            LabelSeeAlso1.ForeColor = Color.Blue;
        }

        private void LabelSeeAlso2_MouseHover(object sender, EventArgs e)
        {
            LabelSeeAlso2.ForeColor = Color.Blue;
        }

        private void LabelSeeAlso3_MouseHover(object sender, EventArgs e)
        {
            LabelSeeAlso3.ForeColor = Color.Blue;
        }

        private void ButtonSpeak_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ButtonMarkWord.Enabled = !ButtonMarkWord.Enabled;
            //if (!ButtonMarkWord.Enabled) ButtonMarkWord.BackgroundImage = Properties.Resources.marked2;
            //else ButtonMarkWord.BackgroundImage = Properties.Resources.unmarked;
        }

        private void WordMeaning_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu.instance.Show();
        }

        private void ButtonMarkWord_MouseHover(object sender, EventArgs e)
        {
            ToolTipWordMeaning.SetToolTip(ButtonMarkWord, "Mark this word as favorite");
        }

        private void ButtonSpeak_MouseHover(object sender, EventArgs e)
        {
            ToolTipWordMeaning.SetToolTip(ButtonSpeak, "Speak this word");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            MainMenu.instance.Show();
        }
    }
}
