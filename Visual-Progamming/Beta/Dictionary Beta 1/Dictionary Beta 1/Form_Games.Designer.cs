namespace Dictionary_Beta_1
{
    partial class Form_Games
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
            this.label_Question = new System.Windows.Forms.Label();
            this.button_A = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Question
            // 
            this.label_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.Location = new System.Drawing.Point(12, 21);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(776, 66);
            this.label_Question.TabIndex = 0;
            this.label_Question.Text = "Question here";
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_A
            // 
            this.button_A.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_A.Location = new System.Drawing.Point(179, 133);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(152, 50);
            this.button_A.TabIndex = 1;
            this.button_A.Text = "A";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.button_A_Click);
            // 
            // button_B
            // 
            this.button_B.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_B.Location = new System.Drawing.Point(473, 133);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(152, 50);
            this.button_B.TabIndex = 1;
            this.button_B.Text = "B";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // button_D
            // 
            this.button_D.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_D.Location = new System.Drawing.Point(473, 253);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(152, 52);
            this.button_D.TabIndex = 1;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.Location = new System.Drawing.Point(179, 253);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(152, 52);
            this.button_C.TabIndex = 1;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_Next
            // 
            this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.Location = new System.Drawing.Point(646, 373);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(119, 41);
            this.button_Next.TabIndex = 2;
            this.button_Next.Text = "Tiếp theo";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Visible = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Quit.Location = new System.Drawing.Point(48, 373);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(119, 41);
            this.button_Quit.TabIndex = 2;
            this.button_Quit.Text = "Thoát";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // Form_Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_D);
            this.Controls.Add(this.button_B);
            this.Controls.Add(this.button_A);
            this.Controls.Add(this.label_Question);
            this.MaximizeBox = false;
            this.Name = "Form_Games";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizzes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Quit;
    }
}