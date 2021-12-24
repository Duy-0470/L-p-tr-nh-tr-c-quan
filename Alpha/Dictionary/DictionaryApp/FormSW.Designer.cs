namespace DictionaryApp
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Question = new System.Windows.Forms.Label();
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.lb_TimeLeftNum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Meaning = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LabelResult = new System.Windows.Forms.Label();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(1742, 451);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(150, 58);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.TabStop = false;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1701, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // lb_Score
            // 
            this.lb_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Score.AutoSize = true;
            this.lb_Score.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Score.ForeColor = System.Drawing.Color.Black;
            this.lb_Score.Location = new System.Drawing.Point(1784, 9);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(28, 31);
            this.lb_Score.TabIndex = 3;
            this.lb_Score.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1668, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Question:";
            // 
            // lb_Question
            // 
            this.lb_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Question.AutoSize = true;
            this.lb_Question.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Question.ForeColor = System.Drawing.Color.Black;
            this.lb_Question.Location = new System.Drawing.Point(1784, 41);
            this.lb_Question.Name = "lb_Question";
            this.lb_Question.Size = new System.Drawing.Size(28, 31);
            this.lb_Question.TabIndex = 5;
            this.lb_Question.Text = "1";
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTimeLeft.AutoSize = true;
            this.LabelTimeLeft.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeLeft.ForeColor = System.Drawing.Color.Black;
            this.LabelTimeLeft.Location = new System.Drawing.Point(1666, 73);
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(117, 31);
            this.LabelTimeLeft.TabIndex = 6;
            this.LabelTimeLeft.Text = "Time left:";
            // 
            // lb_TimeLeftNum
            // 
            this.lb_TimeLeftNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_TimeLeftNum.AutoSize = true;
            this.lb_TimeLeftNum.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeLeftNum.ForeColor = System.Drawing.Color.Black;
            this.lb_TimeLeftNum.Location = new System.Drawing.Point(1784, 73);
            this.lb_TimeLeftNum.Name = "lb_TimeLeftNum";
            this.lb_TimeLeftNum.Size = new System.Drawing.Size(38, 31);
            this.lb_TimeLeftNum.TabIndex = 7;
            this.lb_TimeLeftNum.Text = "0s";
            // 
            // timer1
            // 
            this.timer1.Interval = 3;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Meaning
            // 
            this.lb_Meaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Meaning.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Meaning.Location = new System.Drawing.Point(174, 233);
            this.lb_Meaning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Meaning.Name = "lb_Meaning";
            this.lb_Meaning.Size = new System.Drawing.Size(1552, 137);
            this.lb_Meaning.TabIndex = 8;
            this.lb_Meaning.Text = "meaning";
            this.lb_Meaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LabelResult
            // 
            this.LabelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(175, 453);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(1546, 56);
            this.LabelResult.TabIndex = 9;
            this.LabelResult.Text = "res";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelResult.Visible = false;
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonQuit.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.Location = new System.Drawing.Point(25, 970);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(150, 49);
            this.ButtonQuit.TabIndex = 1;
            this.ButtonQuit.TabStop = false;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // FormSW
            // 
            this.AcceptButton = this.btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.lb_Meaning);
            this.Controls.Add(this.lb_TimeLeftNum);
            this.Controls.Add(this.LabelTimeLeft);
            this.Controls.Add(this.lb_Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.btn_Submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Dictionaries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSW_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Question;
        private System.Windows.Forms.Label LabelTimeLeft;
        private System.Windows.Forms.Label lb_TimeLeftNum;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Meaning;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button ButtonQuit;
    }
}