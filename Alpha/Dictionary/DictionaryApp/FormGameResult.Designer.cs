﻿namespace DictionaryApp
{
    partial class FormGameResult
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
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.ButtonReplay = new System.Windows.Forms.Button();
            this.ButtonBackToGames = new System.Windows.Forms.Button();
            this.LabelTopic = new System.Windows.Forms.Label();
            this.PanelResultMenu = new System.Windows.Forms.Panel();
            this.ButtonSubHome = new System.Windows.Forms.Button();
            this.ButtonSubBack = new System.Windows.Forms.Button();
            this.ButtonSubReplay = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.LabelAccuracy = new System.Windows.Forms.Label();
            this.LabelScoreNum = new System.Windows.Forms.Label();
            this.LabelSpeedNum = new System.Windows.Forms.Label();
            this.LabelAccNum = new System.Windows.Forms.Label();
            this.LabelComment = new System.Windows.Forms.Label();
            this.PictureBoxHS = new System.Windows.Forms.PictureBox();
            this.LabelPB = new System.Windows.Forms.Label();
            this.LabelPBNum = new System.Windows.Forms.Label();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.PanelResultMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHS)).BeginInit();
            this.PanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelScore
            // 
            this.LabelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelScore.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelScore.Location = new System.Drawing.Point(202, 103);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(659, 32);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "Your score:";
            this.LabelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSpeed.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpeed.Location = new System.Drawing.Point(202, 160);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(659, 32);
            this.LabelSpeed.TabIndex = 0;
            this.LabelSpeed.Text = "Average time spent on a question (s):";
            this.LabelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonReplay
            // 
            this.ButtonReplay.BackColor = System.Drawing.Color.White;
            this.ButtonReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReplay.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReplay.Location = new System.Drawing.Point(103, 861);
            this.ButtonReplay.Name = "ButtonReplay";
            this.ButtonReplay.Size = new System.Drawing.Size(196, 46);
            this.ButtonReplay.TabIndex = 1;
            this.ButtonReplay.Text = "Replay";
            this.ButtonReplay.UseVisualStyleBackColor = false;
            this.ButtonReplay.Click += new System.EventHandler(this.ButtonRetry_Click);
            this.ButtonReplay.MouseEnter += new System.EventHandler(this.ButtonReplay_MouseEnter);
            this.ButtonReplay.MouseLeave += new System.EventHandler(this.ButtonReplay_MouseLeave);
            // 
            // ButtonBackToGames
            // 
            this.ButtonBackToGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBackToGames.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackToGames.Location = new System.Drawing.Point(103, 921);
            this.ButtonBackToGames.Name = "ButtonBackToGames";
            this.ButtonBackToGames.Size = new System.Drawing.Size(196, 46);
            this.ButtonBackToGames.TabIndex = 2;
            this.ButtonBackToGames.Text = "Back to Games";
            this.ButtonBackToGames.UseVisualStyleBackColor = true;
            this.ButtonBackToGames.Click += new System.EventHandler(this.ButtonBackToGames_Click);
            this.ButtonBackToGames.MouseEnter += new System.EventHandler(this.ButtonBackToGames_MouseEnter);
            this.ButtonBackToGames.MouseLeave += new System.EventHandler(this.ButtonBackToGames_MouseLeave);
            // 
            // LabelTopic
            // 
            this.LabelTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(194)))), ((int)(((byte)(169)))));
            this.LabelTopic.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.LabelTopic.Location = new System.Drawing.Point(0, 0);
            this.LabelTopic.Name = "LabelTopic";
            this.LabelTopic.Size = new System.Drawing.Size(1832, 71);
            this.LabelTopic.TabIndex = 0;
            this.LabelTopic.Text = "   Game type";
            this.LabelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelResultMenu
            // 
            this.PanelResultMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(167)))), ((int)(((byte)(153)))));
            this.PanelResultMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelResultMenu.Controls.Add(this.ButtonSubHome);
            this.PanelResultMenu.Controls.Add(this.ButtonSubBack);
            this.PanelResultMenu.Controls.Add(this.ButtonSubReplay);
            this.PanelResultMenu.Location = new System.Drawing.Point(0, 71);
            this.PanelResultMenu.Name = "PanelResultMenu";
            this.PanelResultMenu.Size = new System.Drawing.Size(103, 990);
            this.PanelResultMenu.TabIndex = 3;
            // 
            // ButtonSubHome
            // 
            this.ButtonSubHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubHome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubHome.Image = global::DictionaryApp.Properties.Resources.icons8_home_24px;
            this.ButtonSubHome.Location = new System.Drawing.Point(0, 910);
            this.ButtonSubHome.Name = "ButtonSubHome";
            this.ButtonSubHome.Size = new System.Drawing.Size(103, 46);
            this.ButtonSubHome.TabIndex = 4;
            this.ButtonSubHome.UseVisualStyleBackColor = true;
            this.ButtonSubHome.Click += new System.EventHandler(this.ButtonSubHome_Click);
            this.ButtonSubHome.MouseEnter += new System.EventHandler(this.ButtonSubHome_MouseEnter);
            this.ButtonSubHome.MouseLeave += new System.EventHandler(this.ButtonSubHome_MouseLeave);
            // 
            // ButtonSubBack
            // 
            this.ButtonSubBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubBack.Image = global::DictionaryApp.Properties.Resources.icons8_back_24px;
            this.ButtonSubBack.Location = new System.Drawing.Point(0, 850);
            this.ButtonSubBack.Name = "ButtonSubBack";
            this.ButtonSubBack.Size = new System.Drawing.Size(103, 46);
            this.ButtonSubBack.TabIndex = 4;
            this.ButtonSubBack.UseVisualStyleBackColor = true;
            this.ButtonSubBack.Click += new System.EventHandler(this.ButtonSubBack_Click);
            this.ButtonSubBack.MouseEnter += new System.EventHandler(this.ButtonSubBack_MouseEnter);
            this.ButtonSubBack.MouseLeave += new System.EventHandler(this.ButtonSubBack_MouseLeave);
            // 
            // ButtonSubReplay
            // 
            this.ButtonSubReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSubReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubReplay.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubReplay.Image = global::DictionaryApp.Properties.Resources.icons8_rotate_26px;
            this.ButtonSubReplay.Location = new System.Drawing.Point(0, 790);
            this.ButtonSubReplay.Name = "ButtonSubReplay";
            this.ButtonSubReplay.Size = new System.Drawing.Size(103, 46);
            this.ButtonSubReplay.TabIndex = 4;
            this.ButtonSubReplay.UseVisualStyleBackColor = true;
            this.ButtonSubReplay.Click += new System.EventHandler(this.ButtonSubReplay_Click);
            this.ButtonSubReplay.MouseEnter += new System.EventHandler(this.ButtonSubReplay_MouseEnter);
            this.ButtonSubReplay.MouseLeave += new System.EventHandler(this.ButtonSubReplay_MouseLeave);
            // 
            // ButtonHome
            // 
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.Location = new System.Drawing.Point(103, 981);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(196, 46);
            this.ButtonHome.TabIndex = 1;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            this.ButtonHome.MouseEnter += new System.EventHandler(this.ButtonHome_MouseEnter);
            this.ButtonHome.MouseLeave += new System.EventHandler(this.ButtonHome_MouseLeave);
            // 
            // LabelAccuracy
            // 
            this.LabelAccuracy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAccuracy.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccuracy.Location = new System.Drawing.Point(202, 219);
            this.LabelAccuracy.Name = "LabelAccuracy";
            this.LabelAccuracy.Size = new System.Drawing.Size(659, 32);
            this.LabelAccuracy.TabIndex = 0;
            this.LabelAccuracy.Text = "Accuracy (%):";
            this.LabelAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelScoreNum
            // 
            this.LabelScoreNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelScoreNum.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelScoreNum.Location = new System.Drawing.Point(867, 103);
            this.LabelScoreNum.Name = "LabelScoreNum";
            this.LabelScoreNum.Size = new System.Drawing.Size(768, 32);
            this.LabelScoreNum.TabIndex = 0;
            this.LabelScoreNum.Text = "000";
            this.LabelScoreNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSpeedNum
            // 
            this.LabelSpeedNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSpeedNum.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpeedNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSpeedNum.Location = new System.Drawing.Point(867, 160);
            this.LabelSpeedNum.Name = "LabelSpeedNum";
            this.LabelSpeedNum.Size = new System.Drawing.Size(718, 32);
            this.LabelSpeedNum.TabIndex = 0;
            this.LabelSpeedNum.Text = "000";
            this.LabelSpeedNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelAccNum
            // 
            this.LabelAccNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAccNum.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAccNum.Location = new System.Drawing.Point(867, 219);
            this.LabelAccNum.Name = "LabelAccNum";
            this.LabelAccNum.Size = new System.Drawing.Size(718, 32);
            this.LabelAccNum.TabIndex = 0;
            this.LabelAccNum.Text = "000";
            this.LabelAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelComment
            // 
            this.LabelComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelComment.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComment.Location = new System.Drawing.Point(0, 458);
            this.LabelComment.Name = "LabelComment";
            this.LabelComment.Size = new System.Drawing.Size(1726, 63);
            this.LabelComment.TabIndex = 4;
            this.LabelComment.Text = "comment";
            this.LabelComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBoxHS
            // 
            this.PictureBoxHS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxHS.BackgroundImage = global::DictionaryApp.Properties.Resources.highscore;
            this.PictureBoxHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxHS.Location = new System.Drawing.Point(1145, 80);
            this.PictureBoxHS.Name = "PictureBoxHS";
            this.PictureBoxHS.Size = new System.Drawing.Size(271, 78);
            this.PictureBoxHS.TabIndex = 5;
            this.PictureBoxHS.TabStop = false;
            this.PictureBoxHS.Visible = false;
            // 
            // LabelPB
            // 
            this.LabelPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPB.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelPB.Location = new System.Drawing.Point(185, 312);
            this.LabelPB.Name = "LabelPB";
            this.LabelPB.Size = new System.Drawing.Size(659, 32);
            this.LabelPB.TabIndex = 0;
            this.LabelPB.Text = "Your best score:";
            this.LabelPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelPB.Visible = false;
            // 
            // LabelPBNum
            // 
            this.LabelPBNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelPBNum.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPBNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelPBNum.Location = new System.Drawing.Point(850, 312);
            this.LabelPBNum.Name = "LabelPBNum";
            this.LabelPBNum.Size = new System.Drawing.Size(768, 32);
            this.LabelPBNum.TabIndex = 0;
            this.LabelPBNum.Text = "000";
            this.LabelPBNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelPBNum.Visible = false;
            // 
            // PanelInfo
            // 
            this.PanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInfo.Controls.Add(this.LabelScore);
            this.PanelInfo.Controls.Add(this.LabelComment);
            this.PanelInfo.Controls.Add(this.PictureBoxHS);
            this.PanelInfo.Controls.Add(this.LabelPB);
            this.PanelInfo.Controls.Add(this.LabelScoreNum);
            this.PanelInfo.Controls.Add(this.LabelPBNum);
            this.PanelInfo.Controls.Add(this.LabelSpeedNum);
            this.PanelInfo.Controls.Add(this.LabelAccNum);
            this.PanelInfo.Controls.Add(this.LabelSpeed);
            this.PanelInfo.Controls.Add(this.LabelAccuracy);
            this.PanelInfo.Location = new System.Drawing.Point(103, 71);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(1729, 735);
            this.PanelInfo.TabIndex = 6;
            // 
            // FormGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1833, 1061);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.PanelResultMenu);
            this.Controls.Add(this.ButtonBackToGames);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonReplay);
            this.Controls.Add(this.LabelTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyDictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameResult_FormClosing);
            this.Load += new System.EventHandler(this.FormGameResult_Load);
            this.PanelResultMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHS)).EndInit();
            this.PanelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelSpeed;
        private System.Windows.Forms.Button ButtonReplay;
        private System.Windows.Forms.Button ButtonBackToGames;
        private System.Windows.Forms.Label LabelTopic;
        private System.Windows.Forms.Panel PanelResultMenu;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Button ButtonSubHome;
        private System.Windows.Forms.Button ButtonSubBack;
        private System.Windows.Forms.Button ButtonSubReplay;
        private System.Windows.Forms.Label LabelAccuracy;
        private System.Windows.Forms.Label LabelScoreNum;
        private System.Windows.Forms.Label LabelSpeedNum;
        private System.Windows.Forms.Label LabelAccNum;
        private System.Windows.Forms.Label LabelComment;
        private System.Windows.Forms.PictureBox PictureBoxHS;
        private System.Windows.Forms.Label LabelPB;
        private System.Windows.Forms.Label LabelPBNum;
        private System.Windows.Forms.Panel PanelInfo;
    }
}