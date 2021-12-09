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
            this.LabelAvgTime = new System.Windows.Forms.Label();
            this.ButtonRetry = new System.Windows.Forms.Button();
            this.ButtonBackToGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelScore
            // 
            this.LabelScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelScore.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(12, 9);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(814, 56);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "Your score: 0 / 20";
            this.LabelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAvgTime
            // 
            this.LabelAvgTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAvgTime.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAvgTime.Location = new System.Drawing.Point(13, 90);
            this.LabelAvgTime.Name = "LabelAvgTime";
            this.LabelAvgTime.Size = new System.Drawing.Size(813, 36);
            this.LabelAvgTime.TabIndex = 0;
            this.LabelAvgTime.Text = "Average time spent on a question:";
            this.LabelAvgTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonRetry
            // 
            this.ButtonRetry.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRetry.Location = new System.Drawing.Point(12, 432);
            this.ButtonRetry.Name = "ButtonRetry";
            this.ButtonRetry.Size = new System.Drawing.Size(109, 37);
            this.ButtonRetry.TabIndex = 1;
            this.ButtonRetry.Text = "Try again";
            this.ButtonRetry.UseVisualStyleBackColor = true;
            this.ButtonRetry.Click += new System.EventHandler(this.ButtonRetry_Click);
            // 
            // ButtonBackToGames
            // 
            this.ButtonBackToGames.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackToGames.Location = new System.Drawing.Point(681, 432);
            this.ButtonBackToGames.Name = "ButtonBackToGames";
            this.ButtonBackToGames.Size = new System.Drawing.Size(145, 37);
            this.ButtonBackToGames.TabIndex = 2;
            this.ButtonBackToGames.Text = "Back to Games";
            this.ButtonBackToGames.UseVisualStyleBackColor = true;
            this.ButtonBackToGames.Click += new System.EventHandler(this.ButtonBackToGames_Click);
            // 
            // FormGameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 481);
            this.Controls.Add(this.ButtonBackToGames);
            this.Controls.Add(this.ButtonRetry);
            this.Controls.Add(this.LabelAvgTime);
            this.Controls.Add(this.LabelScore);
            this.Name = "FormGameResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameResult";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameResult_FormClosing);
            this.Load += new System.EventHandler(this.FormGameResult_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelAvgTime;
        private System.Windows.Forms.Button ButtonRetry;
        private System.Windows.Forms.Button ButtonBackToGames;
    }
}