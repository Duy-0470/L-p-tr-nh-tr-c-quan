namespace DictionaryApp
{
    partial class FormGTW
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
            this.PanelGTWRules = new System.Windows.Forms.Panel();
            this.CheckBoxShowGTWRules = new System.Windows.Forms.CheckBox();
            this.ButtonOKGTWRules = new System.Windows.Forms.Button();
            this.LabelRules = new System.Windows.Forms.Label();
            this.LabelMeaning = new System.Windows.Forms.Label();
            this.LabelAnswer = new System.Windows.Forms.Label();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelReady = new System.Windows.Forms.Label();
            this.TimeLimit = new System.Windows.Forms.Timer(this.components);
            this.Timer1sec = new System.Windows.Forms.Timer(this.components);
            this.TimerReady = new System.Windows.Forms.Timer(this.components);
            this.LabelScore = new System.Windows.Forms.Label();
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.LabelCorrectAns = new System.Windows.Forms.Label();
            this.PanelGTWRules.SuspendLayout();
            this.PanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGTWRules
            // 
            this.PanelGTWRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelGTWRules.AutoScroll = true;
            this.PanelGTWRules.Controls.Add(this.CheckBoxShowGTWRules);
            this.PanelGTWRules.Controls.Add(this.ButtonOKGTWRules);
            this.PanelGTWRules.Controls.Add(this.LabelRules);
            this.PanelGTWRules.Location = new System.Drawing.Point(0, 0);
            this.PanelGTWRules.Name = "PanelGTWRules";
            this.PanelGTWRules.Size = new System.Drawing.Size(908, 380);
            this.PanelGTWRules.TabIndex = 7;
            this.PanelGTWRules.Visible = false;
            // 
            // CheckBoxShowGTWRules
            // 
            this.CheckBoxShowGTWRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckBoxShowGTWRules.AutoSize = true;
            this.CheckBoxShowGTWRules.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxShowGTWRules.Location = new System.Drawing.Point(276, 238);
            this.CheckBoxShowGTWRules.Name = "CheckBoxShowGTWRules";
            this.CheckBoxShowGTWRules.Size = new System.Drawing.Size(149, 20);
            this.CheckBoxShowGTWRules.TabIndex = 2;
            this.CheckBoxShowGTWRules.Text = "Don\'t show this again";
            this.CheckBoxShowGTWRules.UseVisualStyleBackColor = true;
            this.CheckBoxShowGTWRules.CheckedChanged += new System.EventHandler(this.CheckBoxShowGTWRules_CheckedChanged);
            // 
            // ButtonOKGTWRules
            // 
            this.ButtonOKGTWRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonOKGTWRules.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOKGTWRules.Location = new System.Drawing.Point(527, 234);
            this.ButtonOKGTWRules.Name = "ButtonOKGTWRules";
            this.ButtonOKGTWRules.Size = new System.Drawing.Size(98, 27);
            this.ButtonOKGTWRules.TabIndex = 1;
            this.ButtonOKGTWRules.Text = "OK";
            this.ButtonOKGTWRules.UseVisualStyleBackColor = true;
            this.ButtonOKGTWRules.Click += new System.EventHandler(this.ButtonOKGTWRules_Click);
            // 
            // LabelRules
            // 
            this.LabelRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelRules.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRules.Location = new System.Drawing.Point(0, 89);
            this.LabelRules.Name = "LabelRules";
            this.LabelRules.Size = new System.Drawing.Size(908, 106);
            this.LabelRules.TabIndex = 0;
            this.LabelRules.Text = "Reorganize the letters to form a word in 20 seconds\r\nEach word you make that corr" +
    "esponds to the given meaning earns you 1 point";
            this.LabelRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelMeaning
            // 
            this.LabelMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMeaning.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMeaning.Location = new System.Drawing.Point(180, 417);
            this.LabelMeaning.Name = "LabelMeaning";
            this.LabelMeaning.Size = new System.Drawing.Size(1182, 91);
            this.LabelMeaning.TabIndex = 8;
            this.LabelMeaning.Text = "meaning here";
            this.LabelMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelMeaning.Visible = false;
            // 
            // LabelAnswer
            // 
            this.LabelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAnswer.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAnswer.Location = new System.Drawing.Point(24, 710);
            this.LabelAnswer.Name = "LabelAnswer";
            this.LabelAnswer.Size = new System.Drawing.Size(1863, 91);
            this.LabelAnswer.TabIndex = 8;
            this.LabelAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAnswer.Visible = false;
            this.LabelAnswer.TextChanged += new System.EventHandler(this.LabelAnswer_TextChanged);
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.Location = new System.Drawing.Point(34, 975);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(144, 49);
            this.ButtonQuit.TabIndex = 9;
            this.ButtonQuit.TabStop = false;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Visible = false;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.Location = new System.Drawing.Point(1736, 975);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(144, 49);
            this.ButtonSubmit.TabIndex = 10;
            this.ButtonSubmit.TabStop = false;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Visible = false;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelReady
            // 
            this.LabelReady.AutoSize = true;
            this.LabelReady.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReady.Location = new System.Drawing.Point(1195, 235);
            this.LabelReady.Name = "LabelReady";
            this.LabelReady.Size = new System.Drawing.Size(98, 107);
            this.LabelReady.TabIndex = 11;
            this.LabelReady.Text = "3";
            this.LabelReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelReady.Visible = false;
            // 
            // TimeLimit
            // 
            this.TimeLimit.Interval = 20000;
            this.TimeLimit.Tick += new System.EventHandler(this.TimeLimit_Tick);
            // 
            // Timer1sec
            // 
            this.Timer1sec.Interval = 1000;
            this.Timer1sec.Tick += new System.EventHandler(this.Timer1sec_Tick);
            // 
            // TimerReady
            // 
            this.TimerReady.Interval = 1000;
            this.TimerReady.Tick += new System.EventHandler(this.TimerReady_Tick);
            // 
            // LabelScore
            // 
            this.LabelScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelScore.AutoSize = true;
            this.LabelScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.Location = new System.Drawing.Point(29, 13);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(151, 23);
            this.LabelScore.TabIndex = 13;
            this.LabelScore.Text = "Your score: 0/20";
            // 
            // PanelInfo
            // 
            this.PanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelInfo.Controls.Add(this.LabelTimeLeft);
            this.PanelInfo.Controls.Add(this.LabelScore);
            this.PanelInfo.Location = new System.Drawing.Point(1707, 0);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(202, 82);
            this.PanelInfo.TabIndex = 14;
            this.PanelInfo.Visible = false;
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.AutoSize = true;
            this.LabelTimeLeft.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimeLeft.Location = new System.Drawing.Point(30, 49);
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(126, 23);
            this.LabelTimeLeft.TabIndex = 15;
            this.LabelTimeLeft.Text = "Time left: 20s";
            // 
            // LabelCorrectAns
            // 
            this.LabelCorrectAns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelCorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCorrectAns.Location = new System.Drawing.Point(186, 564);
            this.LabelCorrectAns.Name = "LabelCorrectAns";
            this.LabelCorrectAns.Size = new System.Drawing.Size(1176, 36);
            this.LabelCorrectAns.TabIndex = 15;
            this.LabelCorrectAns.Text = "The answer is: ";
            this.LabelCorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCorrectAns.Visible = false;
            // 
            // FormGTW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 1061);
            this.Controls.Add(this.LabelCorrectAns);
            this.Controls.Add(this.PanelInfo);
            this.Controls.Add(this.LabelReady);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.ButtonQuit);
            this.Controls.Add(this.LabelAnswer);
            this.Controls.Add(this.LabelMeaning);
            this.Controls.Add(this.PanelGTWRules);
            this.Name = "FormGTW";
            this.Text = "FormGTW";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGTW_FormClosed);
            this.Load += new System.EventHandler(this.FormGTW_Load);
            this.PanelGTWRules.ResumeLayout(false);
            this.PanelGTWRules.PerformLayout();
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGTWRules;
        private System.Windows.Forms.CheckBox CheckBoxShowGTWRules;
        private System.Windows.Forms.Button ButtonOKGTWRules;
        private System.Windows.Forms.Label LabelRules;
        private System.Windows.Forms.Label LabelMeaning;
        private System.Windows.Forms.Label LabelAnswer;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Label LabelReady;
        private System.Windows.Forms.Timer TimeLimit;
        private System.Windows.Forms.Timer Timer1sec;
        private System.Windows.Forms.Timer TimerReady;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Panel PanelInfo;
        private System.Windows.Forms.Label LabelTimeLeft;
        private System.Windows.Forms.Label LabelCorrectAns;
    }
}