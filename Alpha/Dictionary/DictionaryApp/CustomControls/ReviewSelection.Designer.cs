
using DictionaryApp.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class ReviewSelection
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;


            this.OtherResultLabel = new System.Windows.Forms.Label();
            this.topHorizonBar = new System.Windows.Forms.Panel();
            this.markedWordsHeaderPanel = new System.Windows.Forms.Panel();
            this.markedWordsButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.markedWordsPanel = new System.Windows.Forms.Panel();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.historyHeaderPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Label();
            this.historyHorizonBar = new System.Windows.Forms.Panel();

            // 
            // OtherResultLabel
            // 
            this.OtherResultLabel.AutoSize = true;
            this.OtherResultLabel.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherResultLabel.ForeColor = System.Drawing.Color.Black;
            this.OtherResultLabel.Location = new System.Drawing.Point(10, 10);
            this.OtherResultLabel.Name = "OtherResultLabel";
            this.OtherResultLabel.Size = new System.Drawing.Size(108, 19);
            this.OtherResultLabel.TabIndex = 0;
            this.OtherResultLabel.Text = "Review";
            // 
            // topHorizonBar
            // 
            this.topHorizonBar.BackColor = System.Drawing.Color.Black;
            this.topHorizonBar.Location = new System.Drawing.Point(10, 30);
            this.topHorizonBar.Name = "topHorizonBar";
            this.topHorizonBar.Size = new System.Drawing.Size(250, 1);
            this.topHorizonBar.TabIndex = 1;
            // 
            // markedWordsHeaderPanel
            // 
            this.markedWordsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.markedWordsHeaderPanel.Controls.Add(this.label2);
            this.markedWordsHeaderPanel.Controls.Add(this.markedWordsButton);
            this.markedWordsHeaderPanel.Location = new System.Drawing.Point(10, 38);
            this.markedWordsHeaderPanel.Name = "markedWordsHeaderPanel";
            this.markedWordsHeaderPanel.Size = new System.Drawing.Size(250, 45);
            this.markedWordsHeaderPanel.TabIndex = 2;

            PictureBox pictureBox3 = new PictureBox();
            string pa = System.IO.Directory.GetCurrentDirectory().Substring(0, 71) + "\\Database\\Files\\images\\sort.png";
            Bitmap picture = new Bitmap(new Bitmap(pa), new Size(20, 20));
            if (pictureBox3.Image != null)
                pictureBox3.Image.Dispose();
            if (picture != null)
            {
                pictureBox3.Image = picture;
            }
            pictureBox3.Location = new Point(225, 13);
            pictureBox3.Click += FlipMarkedWords;
            this.markedWordsHeaderPanel.Controls.Add(pictureBox3);

            // 
            // markedWordsButton
            // 
            this.markedWordsButton.AutoSize = true;
            this.markedWordsButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markedWordsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.markedWordsButton.Location = new System.Drawing.Point(11, 10);
            this.markedWordsButton.Name = "markedWordsButton";
            this.markedWordsButton.Size = new System.Drawing.Size(22, 24);
            this.markedWordsButton.TabIndex = 0;
            this.markedWordsButton.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marked words";
            // 
            // markedWordsPanel
            // 
            this.markedWordsPanel.AutoScroll = false;
            this.markedWordsPanel.HorizontalScroll.Enabled = false;
            this.markedWordsPanel.HorizontalScroll.Maximum = 0;
            this.markedWordsPanel.HorizontalScroll.Visible = false;
            this.markedWordsPanel.AutoScroll = true;

            this.markedWordsPanel.BackColor = System.Drawing.Color.White;
            this.markedWordsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.markedWordsPanel.Location = new System.Drawing.Point(10, 83);
            this.markedWordsPanel.Name = "markedWordsPanel";
            this.markedWordsPanel.Size = new System.Drawing.Size(250, 0);
            this.markedWordsPanel.TabIndex = 3;
            this.markedWordsPanel.MaximumSize = new Size(250, 300);
            this.markedWordsPanel.AutoSize = true;
            if (markedWordsButton.Text == "+")
            {
                foreach (WordHeader word in markWords)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(markedWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.markedWordsPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word.word;
                    wl.Name = word.id;
                    if (word.type == "noun")
                    {
                        wl.Text = wl.Text + "   (n)";
                    }
                    else if (word.type == "verb")
                    {
                        wl.Text = wl.Text + "   (v)";
                    }
                    else if (word.type == "adjective")
                    {
                        wl.Text = wl.Text + "   (adj)";
                    }
                    else if (word.type == "adverb")
                    {
                        wl.Text = wl.Text + "   (adv)";
                    }
                    else if (word.type == "preposition")
                    {
                        wl.Text = wl.Text + "   (prep)";
                    }
                    else if (word.type == "NA")
                    {
                        wl.Text = wl.Text + "";
                    }
                    else
                    {
                        wl.Text = wl.Text + "   (" + word.type.Substring(0,
                            3 > word.type.Length ? word.type.Length : 3) + ")";
                    }
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click +=MW_Click;

                    this.markedWordsPanel.Controls.Add(p);
                }

            }

            // 
            // historyHorizonBar
            // 
            this.historyHorizonBar.BackColor = System.Drawing.Color.Black;
            this.historyHorizonBar.Location = new System.Drawing.Point(10, this.markedWordsPanel.PreferredSize.Height + this.markedWordsPanel.Location.Y);
            this.historyHorizonBar.Name = "historyHorizonBar";
            this.historyHorizonBar.Size = new System.Drawing.Size(250, 1);
            this.historyHorizonBar.TabIndex = 6;
            // 
            // historyButton
            // 
            this.historyButton.AutoSize = true;
            this.historyButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.historyButton.Location = new System.Drawing.Point(11, 10);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(22, 24);
            this.historyButton.TabIndex = 0;
            this.historyButton.Text = "-";
            // 
            // historyHeaderPanel
            // 
            this.historyHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            
            this.historyHeaderPanel.Location = new System.Drawing.Point(10, this.historyHorizonBar.Height + this.historyHorizonBar.Location.Y);
            this.historyHeaderPanel.Name = "historyHeaderPanel";
            this.historyHeaderPanel.Size = new System.Drawing.Size(250, 45);
            this.historyHeaderPanel.TabIndex = 4;

            PictureBox pictureBox1 = new PictureBox();
            string path;
            path = System.IO.Directory.GetCurrentDirectory().Substring(0, 71) + "\\Database\\Files\\images\\close.png";
            picture = new Bitmap(new Bitmap(path), new Size(20, 20));
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            if (picture != null)
            {
                pictureBox1.Image = picture;
            }
            pictureBox1.Location = new Point(225,13);
            pictureBox1.Click += ClearHistory;

            PictureBox pictureBox2 = new PictureBox();
            path = System.IO.Directory.GetCurrentDirectory().Substring(0, 71) + "\\Database\\Files\\images\\sort.png";
            picture = new Bitmap(new Bitmap(path), new Size(20, 20));
            if (pictureBox2.Image != null)
                pictureBox2.Image.Dispose();
            if (picture != null)
            {
                pictureBox2.Image = picture;
            }
            pictureBox2.Location = new Point(190, 13);
            pictureBox2.Click += FlipHistory;
            this.historyHeaderPanel.Controls.Add(pictureBox1);
            this.historyHeaderPanel.Controls.Add(pictureBox2);
            this.historyHeaderPanel.Controls.Add(this.label3);
            this.historyHeaderPanel.Controls.Add(this.historyButton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label3.Location = new System.Drawing.Point(39, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "History";
            // 
            // historyPanel
            // 
            this.historyPanel.AutoScroll = false;
            this.historyPanel.HorizontalScroll.Enabled = false;
            this.historyPanel.HorizontalScroll.Maximum = 0;
            this.historyPanel.HorizontalScroll.Visible = false;
            this.historyPanel.AutoScroll = true;
            this.historyPanel.BackColor = System.Drawing.Color.White;
            this.historyPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.historyPanel.Location = new System.Drawing.Point(10, this.historyHeaderPanel.Height + this.historyHeaderPanel.Location.Y);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(250, 50);
            this.historyPanel.MaximumSize = new System.Drawing.Size(250, 300);
            this.historyPanel.AutoSize = true;
            this.historyPanel.TabIndex = 5;
            if (this.historyButton.Text == "+")
            {
                foreach (FoundWord w in history)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(markedWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.historyPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Name = w.id;
                    wl.Text = w.word;

                    if (w.type == "noun")
                    {
                        wl.Text = wl.Text + "   (n)";
                    }
                    else if (w.type == "verb")
                    {
                        wl.Text = wl.Text + "   (v)";
                    }
                    else if (w.type == "adjective")
                    {
                        wl.Text = wl.Text + "   (adj)";
                    }
                    else if (w.type == "adverb")
                    {
                        wl.Text = wl.Text + "   (adv)";
                    }
                    else if (w.type == "preposition")
                    {
                        wl.Text = wl.Text + "   (prep)";
                    }
                    else if (w.type == "NA")
                    {
                        wl.Text = wl.Text + "";
                    }
                    else
                    {
                        wl.Text = wl.Text + "   (" + w.type.Substring(0,
                            3 > w.type.Length ? w.type.Length : 3) + ")";
                    }
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += SA_Click;
                    this.historyPanel.Controls.Add(p);
                }

            }
            this.Size = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.historyHorizonBar);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.historyHeaderPanel);
            this.Controls.Add(this.markedWordsPanel);
            this.Controls.Add(this.markedWordsHeaderPanel);
            this.Controls.Add(this.topHorizonBar);
            this.Controls.Add(this.OtherResultLabel);
            this.BackColor=Color.White;

        }


        #endregion

        private System.Windows.Forms.Panel historyHorizonBar;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Panel historyHeaderPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label historyButton;
        private System.Windows.Forms.Panel markedWordsPanel;
        private System.Windows.Forms.Panel markedWordsHeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label markedWordsButton;
        private System.Windows.Forms.Panel topHorizonBar;
        private System.Windows.Forms.Label OtherResultLabel;
    }
}
