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

        private void ButtonSpeak_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ButtonMarkWord.Enabled = !ButtonMarkWord.Enabled;
            //if (!ButtonMarkWord.Enabled) ButtonMarkWord.BackgroundImage = Properties.Resources.marked2;
            //else ButtonMarkWord.BackgroundImage = Properties.Resources.unmarked;
            // mark/unmark favorite word
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

        private void LinkLabelSeeAlso1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabelSeeAlso2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabelSeeAlso3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
