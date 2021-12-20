namespace UI_Game
{
    partial class FormSW
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Question = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TimeLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(760, 130);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(661, 132);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(111, 35);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Location = new System.Drawing.Point(692, 9);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(13, 13);
            this.lb_Score.TabIndex = 3;
            this.lb_Score.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Question:";
            // 
            // lb_Question
            // 
            this.lb_Question.AutoSize = true;
            this.lb_Question.Location = new System.Drawing.Point(692, 39);
            this.lb_Question.Name = "lb_Question";
            this.lb_Question.Size = new System.Drawing.Size(13, 13);
            this.lb_Question.TabIndex = 5;
            this.lb_Question.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time left:";
            // 
            // lb_TimeLeft
            // 
            this.lb_TimeLeft.AutoSize = true;
            this.lb_TimeLeft.Location = new System.Drawing.Point(692, 72);
            this.lb_TimeLeft.Name = "lb_TimeLeft";
            this.lb_TimeLeft.Size = new System.Drawing.Size(13, 13);
            this.lb_TimeLeft.TabIndex = 7;
            this.lb_TimeLeft.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.lb_TimeLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TimeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}