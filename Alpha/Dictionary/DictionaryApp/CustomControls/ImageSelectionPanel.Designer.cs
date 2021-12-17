
using DictionaryApp.Classes;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class ImageSelectionPanel
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
            this.allWordsHeaderPanel = new System.Windows.Forms.Panel();
            this.allWordsButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allWordsPanel = new System.Windows.Forms.Panel();
            this.topicsPanel = new System.Windows.Forms.Panel();
            this.topicsHeaderPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.topicsButton = new System.Windows.Forms.Label();
            this.topicsHorizonBar = new System.Windows.Forms.Panel();
            this.othersHorizonBar = new System.Windows.Forms.Panel();
            this.othersPanel = new System.Windows.Forms.Panel();
            this.othersHeaderPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.othersButton = new System.Windows.Forms.Label();
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
            this.OtherResultLabel.Text = "Filters";
            // 
            // topHorizonBar
            // 
            this.topHorizonBar.BackColor = System.Drawing.Color.Black;
            this.topHorizonBar.Location = new System.Drawing.Point(10, 30);
            this.topHorizonBar.Name = "topHorizonBar";
            this.topHorizonBar.Size = new System.Drawing.Size(250, 1);
            this.topHorizonBar.TabIndex = 1;
            // 
            // allWordsHeaderPanel
            // 
            this.allWordsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.allWordsHeaderPanel.Controls.Add(this.label2);
            this.allWordsHeaderPanel.Controls.Add(this.allWordsButton);
            this.allWordsHeaderPanel.Location = new System.Drawing.Point(10, 38);
            this.allWordsHeaderPanel.Name = "allWordsHeaderPanel";
            this.allWordsHeaderPanel.Size = new System.Drawing.Size(250, 45);
            this.allWordsHeaderPanel.TabIndex = 2;

            // 
            // allWordsButton
            // 
            this.allWordsButton.AutoSize = true;
            this.allWordsButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allWordsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.allWordsButton.Location = new System.Drawing.Point(11, 10);
            this.allWordsButton.Name = "allWordsButton";
            this.allWordsButton.Size = new System.Drawing.Size(22, 24);
            this.allWordsButton.TabIndex = 0;
            this.allWordsButton.Text = "-";
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
            this.label2.Text = "Alphabetical";
            // 
            // allWordsPanel
            // 
            this.allWordsPanel.AutoScroll = false;
            this.allWordsPanel.HorizontalScroll.Enabled = false;
            this.allWordsPanel.HorizontalScroll.Maximum = 0;
            this.allWordsPanel.HorizontalScroll.Visible = false;
            this.allWordsPanel.AutoScroll = true;

            this.allWordsPanel.BackColor = System.Drawing.Color.White;
            this.allWordsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.allWordsPanel.Location = new System.Drawing.Point(10, 83);
            this.allWordsPanel.Name = "allWordsPanel";
            this.allWordsPanel.Size = new System.Drawing.Size(250, 0);
            this.allWordsPanel.TabIndex = 3;
            this.allWordsPanel.MaximumSize = new Size(250, 300);
            this.allWordsPanel.AutoSize = true;
            if (allWordsButton.Text == "+")
            {
                foreach (string word in words)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.allWordsPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word;
                    wl.Name = word.Replace(" ", "_");
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += clickLetterItem;

                    this.allWordsPanel.Controls.Add(p);
                }

            }

            // 
            // topicsHorizonBar
            // 
            this.topicsHorizonBar.BackColor = System.Drawing.Color.Black;
            this.topicsHorizonBar.Location = new System.Drawing.Point(10, this.allWordsPanel.PreferredSize.Height + this.allWordsPanel.Location.Y);
            this.topicsHorizonBar.Name = "topicsHorizonBar";
            this.topicsHorizonBar.Size = new System.Drawing.Size(250, 1);
            this.topicsHorizonBar.TabIndex = 6;
            // 
            // topicsButton
            // 
            this.topicsButton.AutoSize = true;
            this.topicsButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.topicsButton.Location = new System.Drawing.Point(11, 10);
            this.topicsButton.Name = "topicsButton";
            this.topicsButton.Size = new System.Drawing.Size(22, 24);
            this.topicsButton.TabIndex = 0;
            this.topicsButton.Text = "-";
            // 
            // topicsHeaderPanel
            // 
            this.topicsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.topicsHeaderPanel.Controls.Add(this.label3);
            this.topicsHeaderPanel.Controls.Add(this.topicsButton);
            this.topicsHeaderPanel.Location = new System.Drawing.Point(10, this.topicsHorizonBar.Height + this.topicsHorizonBar.Location.Y);
            this.topicsHeaderPanel.Name = "topicsHeaderPanel";
            this.topicsHeaderPanel.Size = new System.Drawing.Size(250, 45);
            this.topicsHeaderPanel.TabIndex = 4;
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
            this.label3.Text = "Topics";
            // 
            // topicsPanel
            // 
            this.topicsPanel.AutoScroll = false;
            this.topicsPanel.HorizontalScroll.Enabled = false;
            this.topicsPanel.HorizontalScroll.Maximum = 0;
            this.topicsPanel.HorizontalScroll.Visible = false;
            this.topicsPanel.AutoScroll = true;
            this.topicsPanel.BackColor = System.Drawing.Color.White;
            this.topicsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.topicsPanel.Location = new System.Drawing.Point(10, this.topicsHeaderPanel.Height + this.topicsHeaderPanel.Location.Y);
            this.topicsPanel.Name = "topicsPanel";
            this.topicsPanel.Size = new System.Drawing.Size(250, 50);
            this.topicsPanel.MaximumSize = new System.Drawing.Size(250, 300);
            this.topicsPanel.AutoSize = true;
            this.topicsPanel.TabIndex = 5;
            if (this.topicsButton.Text == "+")
            {
                foreach (string topic in topics)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.topicsPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = topic;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += clickTopicItem;

                    this.topicsPanel.Controls.Add(p);
                }

            }
            // 
            // othersHorizonBar
            // 
            this.othersHorizonBar.BackColor = System.Drawing.Color.Black;
            this.othersHorizonBar.Location = new System.Drawing.Point(10, this.topicsPanel.PreferredSize.Height + this.topicsPanel.Location.Y);
            this.othersHorizonBar.Name = "othersHorizonBar";
            this.othersHorizonBar.Size = new System.Drawing.Size(250, 1);
            // 
            // othersHeaderPanel
            // 
            this.othersHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.othersHeaderPanel.Controls.Add(this.label5);
            this.othersHeaderPanel.Controls.Add(this.othersButton);
            this.othersHeaderPanel.Location = new System.Drawing.Point(10, this.othersHorizonBar.PreferredSize.Height + this.othersHorizonBar.Location.Y);
            this.othersHeaderPanel.Name = "othersHeaderPanel";
            this.othersHeaderPanel.Size = new System.Drawing.Size(250, 45);
            this.othersHeaderPanel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.label5.Location = new System.Drawing.Point(39, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Others";
            // 
            // othersButton
            // 
            this.othersButton.AutoSize = true;
            this.othersButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.othersButton.Location = new System.Drawing.Point(11, 10);
            this.othersButton.Name = "othersButton";
            this.othersButton.Size = new System.Drawing.Size(22, 24);
            this.othersButton.TabIndex = 0;
            this.othersButton.Text = "+";
            // 
            // othersPanel
            // 
            this.othersPanel.AutoScroll = false;
            this.othersPanel.HorizontalScroll.Enabled = false;
            this.othersPanel.HorizontalScroll.Maximum = 0;
            this.othersPanel.HorizontalScroll.Visible = false;
            this.othersPanel.AutoScroll = true;
            this.othersPanel.AutoScroll = true;
            this.othersPanel.BackColor = System.Drawing.Color.White;
            this.othersPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.othersPanel.Location = new System.Drawing.Point(10, this.othersHeaderPanel.Height + this.othersHeaderPanel.Location.Y);
            this.othersPanel.Name = "othersPanel";
            this.othersPanel.Size = new System.Drawing.Size(250, 50);
            this.othersPanel.MaximumSize = new System.Drawing.Size(250, 300);
            this.othersPanel.AutoSize = true;
            this.othersPanel.TabIndex = 8;

            if (othersButton.Text == "+")
            {
                foreach (MyImage word in others)
                {
                    if (word.name.Length < 2)
                    {
                        continue;
                    }
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allWordsPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.othersPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    string w = word.name.Split(' ')[word.name.Split(' ').Length - 2];
                    Debug.WriteLine(word);
                    Debug.WriteLine(w);
                    wl.Text = char.ToUpper(w[0]) + w.Substring(1).ToLower(); ;
                    wl.Name = word.link;

                    Debug.WriteLine(word.name);
                    Debug.WriteLine(word.link);

                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click += clickOthersItem;

                    this.othersPanel.Controls.Add(p);
                }
            }
            this.Size = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.othersHorizonBar);
            this.Controls.Add(this.othersPanel);
            this.Controls.Add(this.othersHeaderPanel);
            this.Controls.Add(this.topicsHorizonBar);
            this.Controls.Add(this.topicsPanel);
            this.Controls.Add(this.topicsHeaderPanel);
            this.Controls.Add(this.allWordsPanel);
            this.Controls.Add(this.allWordsHeaderPanel);
            this.Controls.Add(this.topHorizonBar);
            this.Controls.Add(this.OtherResultLabel);
            this.BackColor=Color.White;
        }

        #endregion
        private System.Windows.Forms.Panel othersHorizonBar;
        private System.Windows.Forms.Panel othersPanel;
        private System.Windows.Forms.Panel othersHeaderPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label othersButton;
        private System.Windows.Forms.Panel topicsHorizonBar;
        private System.Windows.Forms.Panel topicsPanel;
        private System.Windows.Forms.Panel topicsHeaderPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label topicsButton;
        private System.Windows.Forms.Panel allWordsPanel;
        private System.Windows.Forms.Panel allWordsHeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label allWordsButton;
        private System.Windows.Forms.Panel topHorizonBar;
        private System.Windows.Forms.Label OtherResultLabel;
    }
}
