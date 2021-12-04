using DictionaryApp.Classes;
using DictionaryApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class DefintionHeader : Panel
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WordHeader header;
        public DefintionHeader()
        {
            InitializeComponent(new DictionaryApp.Classes.WordHeader());
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (this.header.starred == 1)
            {
                if (DatabaseHandle.GetDataHandle().UnmarkWord(header.id))
                {
                    this.header.starred = 0;
                }
                

            }
            else
            {
                if (DatabaseHandle.GetDataHandle().MarkWord(header.id))
                {
                    this.header.starred = 1;
                }
            }
            string path;
            if (header.starred == 1)
            {
                path = System.IO.Directory.GetCurrentDirectory().Substring(0, 71) + "\\Database\\Files\\images\\marked.png";
            }
            else
            {
                path = System.IO.Directory.GetCurrentDirectory().Substring(0, 71) + "\\Database\\Files\\images\\unmarked.png";

            }
            Bitmap picture = new Bitmap(new Bitmap(path), new Size(50, 50));
            if (this.pictureBox.Image != null)
                this.pictureBox.Image.Dispose();
            if (picture != null)
            {
                int w = 175, h = 175;
                this.pictureBox.Image = picture;
            }
        }

        private void Sound(object sender, EventArgs e)
        {
            Debug.WriteLine((sender as Button).Name);
            string p;
            if((sender as Button).Name.Contains("uk")){
                p=(System.IO.Directory.GetCurrentDirectory().Substring(0, 71) + "\\Database\\Files\\sounds\\british\\" + (sender as Button).Name.Replace("/","_"));

            }
            else
            {
                p=(System.IO.Directory.GetCurrentDirectory().Substring(0, 71) + "\\Database\\Files\\sounds\\north_america\\" + (sender as Button).Name.Replace("/", "_"));

            }
            player.URL = p;
            player.controls.play();
        }
        public DefintionHeader(IContainer container, WordHeader wordHeader)
        {
            container.Add(this);

            InitializeComponent(wordHeader);
            this.header = wordHeader;
        }
        public void ToggleWordFormPanel(object sender, EventArgs eventArgs)
        {
            this.WordFormPanel.Visible = !this.WordFormPanel.Visible;
            this.WordFormSign.Text = this.WordFormSign.Text == "+" ? "-" : "+";
            this.Size = new System.Drawing.Size(this.Size.Width, this.WordFormBar.Location.Y + this.WordFormBar.Size.Height);
            (this.Parent as WordDefinition).ToggleWordFormPanel();
        }
        public int GetHeight()
        {
            if (WordFormPanel.Controls.Count != 0)
            {
                if(this.WordFormSign.Text == "+")
                {
                    return this.WordFormPanel.Location.Y + this.WordFormPanel.Size.Height;

                }
                else
                {
                    return this.WordFormBar.Location.Y + this.WordFormBar.Size.Height;
                }
            }
            else
            {
                return this.NAButton.Location.Y + this.NAButton.Size.Height;

            }
        }
    }
}
