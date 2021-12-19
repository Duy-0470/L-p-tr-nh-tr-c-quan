namespace DictionaryApp
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
            this.PanelResultMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelScore.Location = new System.Drawing.Point(594, 125);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(168, 32);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "Your score:";
            this.LabelScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpeed.Location = new System.Drawing.Point(295, 185);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(467, 29);
            this.LabelSpeed.TabIndex = 0;
            this.LabelSpeed.Text = "Average time spent on a question (s):";
            this.LabelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSpeed.Click += new System.EventHandler(this.LabelAvgTime_Click);
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
            this.LabelTopic.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.LabelTopic.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.LabelTopic.Location = new System.Drawing.Point(0, -1);
            this.LabelTopic.Name = "LabelTopic";
            this.LabelTopic.Size = new System.Drawing.Size(1832, 71);
            this.LabelTopic.TabIndex = 0;
            this.LabelTopic.Text = "   Game type";
            this.LabelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelResultMenu
            // 
            this.PanelResultMenu.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.LabelAccuracy.AutoSize = true;
            this.LabelAccuracy.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccuracy.Location = new System.Drawing.Point(574, 244);
            this.LabelAccuracy.Name = "LabelAccuracy";
            this.LabelAccuracy.Size = new System.Drawing.Size(188, 29);
            this.LabelAccuracy.TabIndex = 0;
            this.LabelAccuracy.Text = "Accuracy (%):";
            this.LabelAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAccuracy.Click += new System.EventHandler(this.LabelAvgTime_Click);
            // 
            // LabelScoreNum
            // 
            this.LabelScoreNum.AutoSize = true;
            this.LabelScoreNum.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScoreNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelScoreNum.Location = new System.Drawing.Point(768, 125);
            this.LabelScoreNum.Name = "LabelScoreNum";
            this.LabelScoreNum.Size = new System.Drawing.Size(65, 32);
            this.LabelScoreNum.TabIndex = 0;
            this.LabelScoreNum.Text = "000";
            this.LabelScoreNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSpeedNum
            // 
            this.LabelSpeedNum.AutoSize = true;
            this.LabelSpeedNum.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpeedNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSpeedNum.Location = new System.Drawing.Point(768, 182);
            this.LabelSpeedNum.Name = "LabelSpeedNum";
            this.LabelSpeedNum.Size = new System.Drawing.Size(65, 32);
            this.LabelSpeedNum.TabIndex = 0;
            this.LabelSpeedNum.Text = "000";
            this.LabelSpeedNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelAccNum
            // 
            this.LabelAccNum.AutoSize = true;
            this.LabelAccNum.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAccNum.Location = new System.Drawing.Point(768, 241);
            this.LabelAccNum.Name = "LabelAccNum";
            this.LabelAccNum.Size = new System.Drawing.Size(65, 32);
            this.LabelAccNum.TabIndex = 0;
            this.LabelAccNum.Text = "000";
            this.LabelAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAccNum.Click += new System.EventHandler(this.LabelAccNum_Click);
            // 
            // LabelComment
            // 
            this.LabelComment.AutoSize = true;
            this.LabelComment.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComment.Location = new System.Drawing.Point(295, 431);
            this.LabelComment.Name = "LabelComment";
            this.LabelComment.Size = new System.Drawing.Size(125, 29);
            this.LabelComment.TabIndex = 4;
            this.LabelComment.Text = "comment";
            this.LabelComment.Visible = false;
            // 
            // FormGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1833, 1061);
            this.Controls.Add(this.LabelComment);
            this.Controls.Add(this.PanelResultMenu);
            this.Controls.Add(this.ButtonBackToGames);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonReplay);
            this.Controls.Add(this.LabelTopic);
            this.Controls.Add(this.LabelAccuracy);
            this.Controls.Add(this.LabelSpeed);
            this.Controls.Add(this.LabelAccNum);
            this.Controls.Add(this.LabelSpeedNum);
            this.Controls.Add(this.LabelScoreNum);
            this.Controls.Add(this.LabelScore);
            this.Name = "FormGameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Dictionaries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameResult_FormClosing);
            this.Load += new System.EventHandler(this.FormGameResult_Load);
            this.PanelResultMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}