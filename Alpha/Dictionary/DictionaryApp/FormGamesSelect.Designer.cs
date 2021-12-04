namespace DictionaryApp
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
            this.PanelQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelQuizzesBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Improve your English";
            // 
            // PanelQuizzes
            // 
            this.PanelQuizzes.BackColor = System.Drawing.Color.White;
            this.PanelQuizzes.Controls.Add(this.label3);
            this.PanelQuizzes.Controls.Add(this.pictureBox1);
            this.PanelQuizzes.Controls.Add(this.label2);
            this.PanelQuizzes.Location = new System.Drawing.Point(21, 13);
            this.PanelQuizzes.Name = "PanelQuizzes";
            this.PanelQuizzes.Size = new System.Drawing.Size(255, 122);
            this.PanelQuizzes.TabIndex = 1;
            this.PanelQuizzes.Click += new System.EventHandler(this.PanelQuizzes_Click);
            this.PanelQuizzes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 69);
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
            this.pictureBox1.Location = new System.Drawing.Point(22, 52);
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
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 23);
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
            this.PanelQuizzesBorder.Location = new System.Drawing.Point(40, 78);
            this.PanelQuizzesBorder.Name = "PanelQuizzesBorder";
            this.PanelQuizzesBorder.Size = new System.Drawing.Size(296, 150);
            this.PanelQuizzesBorder.TabIndex = 2;
            this.PanelQuizzesBorder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelQuizzesBorder_MouseClick);
            // 
            // FormGamesSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.PanelQuizzesBorder);
            this.Controls.Add(this.label1);
            this.Name = "FormGamesSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGamesSelect_FormClosed);
            this.PanelQuizzes.ResumeLayout(false);
            this.PanelQuizzes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelQuizzesBorder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelQuizzes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelQuizzesBorder;
        private System.Windows.Forms.Label label3;
    }
}