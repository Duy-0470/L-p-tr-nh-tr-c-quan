namespace Dictionary_Beta_1
{
    partial class Form_StartScreen
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
            this.button_Translate = new System.Windows.Forms.Button();
            this.button_Quizzes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(95, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Dictionary";
            // 
            // button_Translate
            // 
            this.button_Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Translate.Location = new System.Drawing.Point(146, 171);
            this.button_Translate.Name = "button_Translate";
            this.button_Translate.Size = new System.Drawing.Size(90, 38);
            this.button_Translate.TabIndex = 1;
            this.button_Translate.Text = "Dịch";
            this.button_Translate.UseVisualStyleBackColor = true;
            this.button_Translate.Click += new System.EventHandler(this.button_Translate_Click);
            // 
            // button_Quizzes
            // 
            this.button_Quizzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quizzes.Location = new System.Drawing.Point(146, 226);
            this.button_Quizzes.Name = "button_Quizzes";
            this.button_Quizzes.Size = new System.Drawing.Size(90, 41);
            this.button_Quizzes.TabIndex = 2;
            this.button_Quizzes.Text = "Trò chơi";
            this.button_Quizzes.UseVisualStyleBackColor = true;
            this.button_Quizzes.Click += new System.EventHandler(this.button_Quizzes_Click);
            // 
            // Form_StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.button_Quizzes);
            this.Controls.Add(this.button_Translate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Translate;
        private System.Windows.Forms.Button button_Quizzes;
    }
}