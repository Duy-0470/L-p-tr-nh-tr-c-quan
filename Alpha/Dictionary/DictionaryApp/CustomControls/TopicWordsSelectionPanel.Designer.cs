
using DictionaryApp.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class TopicWordsSelectionPanel
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
            this.allMatchesHeaderPanel = new System.Windows.Forms.Panel();
            this.allMatchesButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.allMatchesPanel = new System.Windows.Forms.Panel();
            this.mainMeaningPanel = new System.Windows.Forms.Panel();
            this.mainMeaningsHeaderPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mainMeaningsButton = new System.Windows.Forms.Label();
            this.mainMeaningHorizonBar = new System.Windows.Forms.Panel();
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
            this.OtherResultLabel.Text = "Select words";
            // 
            // topHorizonBar
            // 
            this.topHorizonBar.BackColor = System.Drawing.Color.Black;
            this.topHorizonBar.Location = new System.Drawing.Point(10, 30);
            this.topHorizonBar.Name = "topHorizonBar";
            this.topHorizonBar.Size = new System.Drawing.Size(190, 1);
            this.topHorizonBar.TabIndex = 1;
            // 
            // allMatchesHeaderPanel
            // 
            this.allMatchesHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.allMatchesHeaderPanel.Controls.Add(this.label2);
            this.allMatchesHeaderPanel.Controls.Add(this.allMatchesButton);
            this.allMatchesHeaderPanel.Location = new System.Drawing.Point(10, 38);
            this.allMatchesHeaderPanel.Name = "allMatchesHeaderPanel";
            this.allMatchesHeaderPanel.Size = new System.Drawing.Size(190, 45);
            this.allMatchesHeaderPanel.TabIndex = 2;

            // 
            // allMatchesButton
            // 
            this.allMatchesButton.AutoSize = true;
            this.allMatchesButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allMatchesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.allMatchesButton.Location = new System.Drawing.Point(11, 10);
            this.allMatchesButton.Name = "allMatchesButton";
            this.allMatchesButton.Size = new System.Drawing.Size(22, 24);
            this.allMatchesButton.TabIndex = 0;
            this.allMatchesButton.Text = "-";
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
            this.label2.Text = "Levels";
            // 
            // allMatchesPanel
            // 
            this.allMatchesPanel.AutoScroll = false;
            this.allMatchesPanel.HorizontalScroll.Enabled = false;
            this.allMatchesPanel.HorizontalScroll.Maximum = 0;
            this.allMatchesPanel.HorizontalScroll.Visible = false;
            this.allMatchesPanel.AutoScroll = true;

            this.allMatchesPanel.BackColor = System.Drawing.Color.White;
            this.allMatchesPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.allMatchesPanel.Location = new System.Drawing.Point(10, 83);
            this.allMatchesPanel.Name = "allMatchesPanel";
            this.allMatchesPanel.Size = new System.Drawing.Size(190, 0);
            this.allMatchesPanel.TabIndex = 3;
            this.allMatchesPanel.MaximumSize = new Size(190, 300);
            this.allMatchesPanel.AutoSize = true;
            if (allMatchesButton.Text == "+")
            {
                foreach (string word in matchingWords)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allMatchesPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.allMatchesPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word;

                    Debug.WriteLine(word);
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    if (levels.Contains(word.ToLower()))
                    {
                        wl.BackColor = Color.FromArgb(245, 245, 245);
                    }

                        /*                    wl.Click +=Topic_Click;
                        */
                    this.allMatchesPanel.Controls.Add(p);
                }

            }

            // 
            // mainMeaningHorizonBar
            // 
            this.mainMeaningHorizonBar.BackColor = System.Drawing.Color.Black;
            this.mainMeaningHorizonBar.Location = new System.Drawing.Point(10, this.allMatchesPanel.PreferredSize.Height + this.allMatchesPanel.Location.Y);
            this.mainMeaningHorizonBar.Name = "mainMeaningHorizonBar";
            this.mainMeaningHorizonBar.Size = new System.Drawing.Size(190, 1);
            this.mainMeaningHorizonBar.TabIndex = 6;
            // 
            // mainMeaningsButton
            // 
            this.mainMeaningsButton.AutoSize = true;
            this.mainMeaningsButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMeaningsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.mainMeaningsButton.Location = new System.Drawing.Point(11, 10);
            this.mainMeaningsButton.Name = "mainMeaningsButton";
            this.mainMeaningsButton.Size = new System.Drawing.Size(22, 24);
            this.mainMeaningsButton.TabIndex = 0;
            this.mainMeaningsButton.Text = "-";
            // 
            // mainMeaningsHeaderPanel
            // 
            this.mainMeaningsHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.mainMeaningsHeaderPanel.Controls.Add(this.label3);
            this.mainMeaningsHeaderPanel.Controls.Add(this.mainMeaningsButton);
            this.mainMeaningsHeaderPanel.Location = new System.Drawing.Point(10, this.mainMeaningHorizonBar.Height + this.mainMeaningHorizonBar.Location.Y);
            this.mainMeaningsHeaderPanel.Name = "mainMeaningsHeaderPanel";
            this.mainMeaningsHeaderPanel.Size = new System.Drawing.Size(190, 45);
            this.mainMeaningsHeaderPanel.TabIndex = 4;
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
            this.label3.Text = "Words";
            // 
            // mainMeaningPanel
            // 
            this.mainMeaningPanel.AutoScroll = false;
            this.mainMeaningPanel.HorizontalScroll.Enabled = false;
            this.mainMeaningPanel.HorizontalScroll.Maximum = 0;
            this.mainMeaningPanel.HorizontalScroll.Visible = false;
            this.mainMeaningPanel.AutoScroll = true;
            this.mainMeaningPanel.BackColor = System.Drawing.Color.White;
            this.mainMeaningPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.mainMeaningPanel.Location = new System.Drawing.Point(10, this.mainMeaningsHeaderPanel.Height + this.mainMeaningsHeaderPanel.Location.Y);
            this.mainMeaningPanel.Name = "mainMeaningPanel";
            this.mainMeaningPanel.Size = new System.Drawing.Size(190, 50);
            this.mainMeaningPanel.MaximumSize = new System.Drawing.Size(190, 300);
            this.mainMeaningPanel.AutoSize = true;
            this.mainMeaningPanel.TabIndex = 5;
            if (this.mainMeaningsButton.Text == "+")
            {
                foreach (WordHeader word in mainMeanings)
                {
                    Panel p = new Panel();
                    p.BackColor = Color.White;
                    p.Size = new Size(allMatchesPanel.Size.Width, 35);
                    p.Location = new Point(0,
                        p.Size.Height * this.mainMeaningPanel.Controls.Count);
                    p.AutoScroll = false;
                    Label wl = new Label();
                    wl.MaximumSize = new Size(220, 40);
                    wl.BackColor = System.Drawing.Color.White;
                    wl.ForeColor = System.Drawing.Color.Black;
                    wl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    wl.Location = new System.Drawing.Point(20, 8);
                    wl.Text = word.word;
                    wl.Name = word.id;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);

                    p.Controls.Add(wl);
/*                    wl.Click += Subtopic_Click;
*/
                    this.mainMeaningPanel.Controls.Add(p);
                }

            }
            this.Size = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.mainMeaningHorizonBar);
            this.Controls.Add(this.mainMeaningPanel);
            this.Controls.Add(this.mainMeaningsHeaderPanel);
            this.Controls.Add(this.allMatchesPanel);
            this.Controls.Add(this.allMatchesHeaderPanel);
            this.Controls.Add(this.topHorizonBar);
            this.Controls.Add(this.OtherResultLabel);
            this.BackColor=Color.White;

        }


        #endregion
        private System.Windows.Forms.Panel mainMeaningHorizonBar;
        private System.Windows.Forms.Panel mainMeaningPanel;
        private System.Windows.Forms.Panel mainMeaningsHeaderPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mainMeaningsButton;
        private System.Windows.Forms.Panel allMatchesPanel;
        private System.Windows.Forms.Panel allMatchesHeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label allMatchesButton;
        private System.Windows.Forms.Panel topHorizonBar;
        private System.Windows.Forms.Label OtherResultLabel;
    }
}
