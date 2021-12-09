
using DictionaryApp.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class OtherIdiomResultsPanel
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
            this.OtherResultLabel.Text = "Other results";
            // 
            // topHorizonBar
            // 
            this.topHorizonBar.BackColor = System.Drawing.Color.Black;
            this.topHorizonBar.Location = new System.Drawing.Point(10, 30);
            this.topHorizonBar.Name = "topHorizonBar";
            this.topHorizonBar.Size = new System.Drawing.Size(250, 1);
            this.topHorizonBar.TabIndex = 1;
            // 
            // allMatchesHeaderPanel
            // 
            this.allMatchesHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.allMatchesHeaderPanel.Controls.Add(this.label2);
            this.allMatchesHeaderPanel.Controls.Add(this.allMatchesButton);
            this.allMatchesHeaderPanel.Location = new System.Drawing.Point(10, 38);
            this.allMatchesHeaderPanel.Name = "allMatchesHeaderPanel";
            this.allMatchesHeaderPanel.Size = new System.Drawing.Size(250, 45);
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
            this.label2.Text = "All matches";
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
            this.allMatchesPanel.Size = new System.Drawing.Size(250, 0);
            this.allMatchesPanel.TabIndex = 3;
            this.allMatchesPanel.MaximumSize = new Size(250, 300);
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
                    wl.Text = word[0].ToString().ToUpper() + word.Substring(1).Replace("_1", "").Replace("_2", " (2)").Replace("_3", " (3)").Replace("_4", " (4)");
                    wl.Name = word;
                    wl.BackColor = Color.Transparent;
                    p.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    p.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    wl.MouseEnter += new System.EventHandler(this.OnMouseEnterButton);
                    wl.MouseLeave += new System.EventHandler(this.OnMouseLeaveButton);
                    p.Controls.Add(wl);
                    wl.Click +=MW_Click;

                    this.allMatchesPanel.Controls.Add(p);
                }

            }

            this.Size = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.allMatchesPanel);
            this.Controls.Add(this.allMatchesHeaderPanel);
            this.Controls.Add(this.topHorizonBar);
            this.Controls.Add(this.OtherResultLabel);
            this.BackColor=Color.White;

        }


        #endregion
        private System.Windows.Forms.Panel allMatchesPanel;
        private System.Windows.Forms.Panel allMatchesHeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label allMatchesButton;
        private System.Windows.Forms.Panel topHorizonBar;
        private System.Windows.Forms.Label OtherResultLabel;
    }
}
