﻿namespace DictionaryApp
{
    partial class FormGamesSelect
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PanelQuizzes = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelQuizzesBorder = new System.Windows.Forms.Panel();
            this.LabelIntro = new System.Windows.Forms.Label();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.PanelQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelQuizzesBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Games";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelQuizzes
            // 
            this.PanelQuizzes.BackColor = System.Drawing.Color.White;
            this.PanelQuizzes.Controls.Add(this.label3);
            this.PanelQuizzes.Controls.Add(this.pictureBox1);
            this.PanelQuizzes.Controls.Add(this.label2);
            this.PanelQuizzes.Location = new System.Drawing.Point(21, 13);
            this.PanelQuizzes.Name = "PanelQuizzes";
            this.PanelQuizzes.Size = new System.Drawing.Size(265, 130);
            this.PanelQuizzes.TabIndex = 1;
            this.PanelQuizzes.Click += new System.EventHandler(this.PanelQuizzes_Click);
            this.PanelQuizzes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pick the correct answer";
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label3_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DictionaryApp.Properties.Resources.ABCD;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quizzes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // PanelQuizzesBorder
            // 
            this.PanelQuizzesBorder.BackColor = System.Drawing.Color.Yellow;
            this.PanelQuizzesBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelQuizzesBorder.Controls.Add(this.PanelQuizzes);
            this.PanelQuizzesBorder.Location = new System.Drawing.Point(88, 157);
            this.PanelQuizzesBorder.Name = "PanelQuizzesBorder";
            this.PanelQuizzesBorder.Size = new System.Drawing.Size(307, 158);
            this.PanelQuizzesBorder.TabIndex = 2;
            this.PanelQuizzesBorder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelQuizzesBorder_MouseClick);
            // 
            // LabelIntro
            // 
            this.LabelIntro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelIntro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIntro.Location = new System.Drawing.Point(12, 60);
            this.LabelIntro.Name = "LabelIntro";
            this.LabelIntro.Size = new System.Drawing.Size(968, 35);
            this.LabelIntro.TabIndex = 4;
            this.LabelIntro.Text = "Improve your English with these sets of games";
            this.LabelIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackgroundImage = global::DictionaryApp.Properties.Resources.icons8_home_48px;
            this.ButtonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Location = new System.Drawing.Point(1, 1);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(30, 30);
            this.ButtonHome.TabIndex = 5;
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // FormGamesSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 790);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.LabelIntro);
            this.Controls.Add(this.PanelQuizzesBorder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGamesSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Dictionaries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGamesSelect_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGamesSelect_FormClosed);
            this.PanelQuizzes.ResumeLayout(false);
            this.PanelQuizzes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelQuizzesBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelQuizzes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelQuizzesBorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelIntro;
        private System.Windows.Forms.Button ButtonHome;
    }
}