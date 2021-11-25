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
using WMPLib;

namespace Dictionary
{
    public partial class WordMeaning : Form
    {
        public Database.DatabaseHandle databaseHandle = new Database.DatabaseHandle();
        private Random rand = new Random();
        private int r1, r2, r3;

        public WordMeaning()
        {
            InitializeComponent();
            RichTextBoxWordInfo.BorderStyle = BorderStyle.None;
            ButtonSpeak.FlatAppearance.BorderSize = 0;
            ButtonMarkWord.FlatAppearance.BorderSize = 0;          
        }

        private void WordMeaning_Load(object sender, EventArgs e)
        {
            if (MainMenu.current_language == "English - Vietnamese")
            {
                EngVietWord engVietWord = databaseHandle.FindEVWordMeaning(FormSearch.search, MainMenu.data);
                if (engVietWord.Name != "" && engVietWord.Meaning != "")
                {
                    LabelWord.Text = engVietWord.Name;
                    LabelSpelling.Text = engVietWord.Spelling;
                    RichTextBoxWordInfo.Text = engVietWord.Meaning;

                    while (r1 == r2 && r2 == r3 && r1 == r3 && !MainMenu.hints[r1].Contains('=') && !MainMenu.hints[r2].Contains('=') && !MainMenu.hints[r3].Contains('='))
                    {
                        r1 = rand.Next(0, MainMenu.hints.Length);
                        r2 = rand.Next(0, MainMenu.hints.Length);
                        r3 = rand.Next(0, MainMenu.hints.Length);
                    }

                    if (MainMenu.hints[r1].Contains('/'))
                        LinkLabelSeeAlso1.Text = MainMenu.hints[r1].Substring(0, MainMenu.hints[r1].IndexOf('/') - 1).Replace('@', ' ').Trim();
                    else
                        LinkLabelSeeAlso1.Text = MainMenu.hints[r1].Replace('@', ' ').Trim();

                    if (MainMenu.hints[r2].Contains('/'))
                        LinkLabelSeeAlso2.Text = MainMenu.hints[r2].Substring(0, MainMenu.hints[r1].IndexOf('/') - 1).Replace('@', ' ').Trim();
                    else
                        LinkLabelSeeAlso2.Text = MainMenu.hints[r2].Replace('@', ' ').Trim();

                    if (MainMenu.hints[r3].Contains('/'))
                        LinkLabelSeeAlso3.Text = MainMenu.hints[r3].Substring(0, MainMenu.hints[r3].IndexOf('/') - 1).Replace('@', ' ').Trim();
                    else
                        LinkLabelSeeAlso3.Text = MainMenu.hints[r3].Replace('@', ' ').Trim();
                }
                else
                {
                    LabelWord.Text = "";
                    LabelSpelling.Text = "";
                    ButtonMarkWord.Visible = false;
                    ButtonSpeak.Visible = false;
                    RichTextBoxWordInfo.Text = "We can't find what you're looking for :(";
                    LabelMore.Visible = false;
                    LinkLabelSeeAlso1.Visible = false;
                    LinkLabelSeeAlso2.Visible = false;
                    LinkLabelSeeAlso3.Visible = false;
                }
            }
            else if (MainMenu.current_language == "English - English")
            {
                EngEngWord engEngWord = databaseHandle.FindEEWordMeaning(FormSearch.search, MainMenu.data);
                if (engEngWord.Name != "" && engEngWord.Meaning != "")
                {
                    LabelWord.Text = engEngWord.Name;
                    LabelSpelling.Text = engEngWord.Spelling;
                    RichTextBoxWordInfo.Text = engEngWord.Meaning;
                    while (r1 == r2 && r2 == r3 && r1 == r3)
                    {
                        r1 = rand.Next(0, MainMenu.hints.Length);
                        r2 = rand.Next(0, MainMenu.hints.Length);
                        r3 = rand.Next(0, MainMenu.hints.Length);
                    }
                    LinkLabelSeeAlso1.Text = MainMenu.hints[r1];
                    LinkLabelSeeAlso2.Text = MainMenu.hints[r2];
                    LinkLabelSeeAlso3.Text = MainMenu.hints[r3];
                }
                else
                {
                    LabelWord.Text = "";
                    LabelSpelling.Text = "";
                    ButtonMarkWord.Visible = false;
                    ButtonSpeak.Visible = false;
                    RichTextBoxWordInfo.Text = "We can't find what you're looking for :(";
                    LabelMore.Visible = false;
                    LinkLabelSeeAlso1.Visible = false;
                    LinkLabelSeeAlso2.Visible = false;
                    LinkLabelSeeAlso3.Visible = false;
                }
            }


        }

        private void ButtonSpeak_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            // mark/unmark favorite word
        }

        private void WordMeaning_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
        }

        private void WordMeaning_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemFavorites_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkLabelSeeAlso1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSearch.search = LinkLabelSeeAlso1.Text;
            Close();
        }

        private void LinkLabelSeeAlso2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSearch.search = LinkLabelSeeAlso2.Text;
            Close();
        }

        private void LinkLabelSeeAlso3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSearch.search = LinkLabelSeeAlso3.Text;
            Close();
        }

        private void gamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "recentToolStripMenuItem_Click"))
            {
                FormRecent fr = new FormRecent();
                fr.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "toolStripMenuItem1_Click"))
            {
                FormFavorites ff = new FormFavorites();
                ff.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ToolStripMenuItemFavorites_Click"))
            {
                FormGames fg = new FormGames();
                fg.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "homeToolStripMenuItem_Click"))
            {
                MainMenu.instance.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "LinkLabelSeeAlso1_LinkClicked")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "LinkLabelSeeAlso2_LinkClicked")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "LinkLabelSeeAlso3_LinkClicked"))
            {
                WordMeaning wm = new WordMeaning();
                wm.Show();
            }
            else
            {
                FormSearch fs = new FormSearch();
                fs.Show();
            }
        }

    }
}
