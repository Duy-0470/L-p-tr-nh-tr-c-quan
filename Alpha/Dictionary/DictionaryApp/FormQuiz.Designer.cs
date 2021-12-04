namespace DictionaryApp
{
    partial class FormQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuiz));
            this.PanelRules = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ButtonOKRules = new System.Windows.Forms.Button();
            this.LabelRules = new System.Windows.Forms.Label();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonD = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.ButtonA = new System.Windows.Forms.Button();
            this.TimeLimit = new System.Windows.Forms.Timer(this.components);
            this.Timer1sec = new System.Windows.Forms.Timer(this.components);
            this.PanelRules.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelRules
            // 
            this.PanelRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelRules.AutoScroll = true;
            this.PanelRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRules.Controls.Add(this.checkBox1);
            this.PanelRules.Controls.Add(this.ButtonOKRules);
            this.PanelRules.Controls.Add(this.LabelRules);
            this.PanelRules.Location = new System.Drawing.Point(871, 88);
            this.PanelRules.Name = "PanelRules";
            this.PanelRules.Size = new System.Drawing.Size(369, 173);
            this.PanelRules.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(32, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 18);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Don\'t show this again";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ButtonOKRules
            // 
            this.ButtonOKRules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonOKRules.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOKRules.Location = new System.Drawing.Point(258, 126);
            this.ButtonOKRules.Name = "ButtonOKRules";
            this.ButtonOKRules.Size = new System.Drawing.Size(75, 23);
            this.ButtonOKRules.TabIndex = 1;
            this.ButtonOKRules.Text = "OK";
            this.ButtonOKRules.UseVisualStyleBackColor = true;
            this.ButtonOKRules.Click += new System.EventHandler(this.ButtonOKRules_Click);
            // 
            // LabelRules
            // 
            this.LabelRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRules.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRules.Location = new System.Drawing.Point(-1, 0);
            this.LabelRules.Name = "LabelRules";
            this.LabelRules.Size = new System.Drawing.Size(369, 106);
            this.LabelRules.TabIndex = 0;
            this.LabelRules.Text = resources.GetString("LabelRules.Text");
            this.LabelRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuestion.Location = new System.Drawing.Point(3, 71);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(831, 103);
            this.LabelQuestion.TabIndex = 1;
            this.LabelQuestion.Text = "Question here";
            this.LabelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            this.PanelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelMain.BackColor = System.Drawing.Color.White;
            this.PanelMain.Controls.Add(this.ButtonNext);
            this.PanelMain.Controls.Add(this.LabelTimeLeft);
            this.PanelMain.Controls.Add(this.LabelScore);
            this.PanelMain.Controls.Add(this.ButtonC);
            this.PanelMain.Controls.Add(this.ButtonD);
            this.PanelMain.Controls.Add(this.ButtonB);
            this.PanelMain.Controls.Add(this.ButtonA);
            this.PanelMain.Controls.Add(this.LabelQuestion);
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(837, 480);
            this.PanelMain.TabIndex = 2;
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(729, 434);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(94, 29);
            this.ButtonNext.TabIndex = 3;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Visible = false;
            this.ButtonNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTimeLeft.AutoSize = true;
            this.LabelTimeLeft.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeLeft.Location = new System.Drawing.Point(700, 35);
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(95, 17);
            this.LabelTimeLeft.TabIndex = 3;
            this.LabelTimeLeft.Text = "Time left: 30s";
            // 
            // LabelScore
            // 
            this.LabelScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(700, 9);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(114, 17);
            this.LabelScore.TabIndex = 3;
            this.LabelScore.Text = "Your score: 0/20";
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.Color.White;
            this.ButtonC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonC.Location = new System.Drawing.Point(112, 317);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(292, 66);
            this.ButtonC.TabIndex = 2;
            this.ButtonC.TabStop = false;
            this.ButtonC.Text = "A";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonD
            // 
            this.ButtonD.BackColor = System.Drawing.Color.White;
            this.ButtonD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonD.Location = new System.Drawing.Point(432, 317);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new System.Drawing.Size(292, 66);
            this.ButtonD.TabIndex = 2;
            this.ButtonD.TabStop = false;
            this.ButtonD.Text = "A";
            this.ButtonD.UseVisualStyleBackColor = false;
            this.ButtonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // ButtonB
            // 
            this.ButtonB.BackColor = System.Drawing.Color.White;
            this.ButtonB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonB.Location = new System.Drawing.Point(432, 220);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(292, 65);
            this.ButtonB.TabIndex = 2;
            this.ButtonB.TabStop = false;
            this.ButtonB.Text = "A";
            this.ButtonB.UseVisualStyleBackColor = false;
            this.ButtonB.Click += new System.EventHandler(this.ButtonB_Click);
            // 
            // ButtonA
            // 
            this.ButtonA.BackColor = System.Drawing.Color.White;
            this.ButtonA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonA.Location = new System.Drawing.Point(112, 220);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(292, 65);
            this.ButtonA.TabIndex = 2;
            this.ButtonA.TabStop = false;
            this.ButtonA.Text = "A";
            this.ButtonA.UseVisualStyleBackColor = false;
            this.ButtonA.Click += new System.EventHandler(this.ButtonA_Click);
            // 
            // TimeLimit
            // 
            this.TimeLimit.Interval = 30000;
            this.TimeLimit.Tick += new System.EventHandler(this.TimeLimit_Tick);
            // 
            // Timer1sec
            // 
            this.Timer1sec.Interval = 1000;
            this.Timer1sec.Tick += new System.EventHandler(this.Timer1sec_Tick);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1269, 501);
            this.Controls.Add(this.PanelRules);
            this.Controls.Add(this.PanelMain);
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCollocation_FormClosed);
            this.Load += new System.EventHandler(this.FormCollocation_Load);
            this.PanelRules.ResumeLayout(false);
            this.PanelRules.PerformLayout();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelRules;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ButtonOKRules;
        private System.Windows.Forms.Label LabelRules;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonD;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Timer TimeLimit;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Label LabelTimeLeft;
        private System.Windows.Forms.Timer Timer1sec;
    }
}