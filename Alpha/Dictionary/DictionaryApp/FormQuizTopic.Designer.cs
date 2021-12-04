namespace DictionaryApp
{
    partial class FormQuizTopic
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
            this.PanelCollocations = new System.Windows.Forms.Panel();
            this.LabelCollocationsDes = new System.Windows.Forms.Label();
            this.LabelCollocations = new System.Windows.Forms.Label();
            this.PanelPhrasalVerbs = new System.Windows.Forms.Panel();
            this.LabelPVDes = new System.Windows.Forms.Label();
            this.LabelPV = new System.Windows.Forms.Label();
            this.PanelIdioms = new System.Windows.Forms.Panel();
            this.LabelIdiomsDes = new System.Windows.Forms.Label();
            this.LabelIdioms = new System.Windows.Forms.Label();
            this.PanelWM = new System.Windows.Forms.Panel();
            this.LabelWM = new System.Windows.Forms.Label();
            this.LabelWMDes = new System.Windows.Forms.Label();
            this.PanelWF = new System.Windows.Forms.Panel();
            this.LabelWF = new System.Windows.Forms.Label();
            this.LabelWFDes = new System.Windows.Forms.Label();
            this.PanelCollocations.SuspendLayout();
            this.PanelPhrasalVerbs.SuspendLayout();
            this.PanelIdioms.SuspendLayout();
            this.PanelWM.SuspendLayout();
            this.PanelWF.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a topic";
            // 
            // PanelCollocations
            // 
            this.PanelCollocations.BackColor = System.Drawing.Color.Yellow;
            this.PanelCollocations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCollocations.Controls.Add(this.LabelCollocationsDes);
            this.PanelCollocations.Controls.Add(this.LabelCollocations);
            this.PanelCollocations.Location = new System.Drawing.Point(115, 94);
            this.PanelCollocations.Name = "PanelCollocations";
            this.PanelCollocations.Size = new System.Drawing.Size(237, 72);
            this.PanelCollocations.TabIndex = 2;
            this.PanelCollocations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // LabelCollocationsDes
            // 
            this.LabelCollocationsDes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCollocationsDes.Location = new System.Drawing.Point(-1, 32);
            this.LabelCollocationsDes.Name = "LabelCollocationsDes";
            this.LabelCollocationsDes.Size = new System.Drawing.Size(237, 23);
            this.LabelCollocationsDes.TabIndex = 3;
            this.LabelCollocationsDes.Text = "How words work together";
            this.LabelCollocationsDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCollocationsDes.Click += new System.EventHandler(this.LabelCollocationsDes_Click);
            this.LabelCollocationsDes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label3_MouseClick);
            // 
            // LabelCollocations
            // 
            this.LabelCollocations.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCollocations.Location = new System.Drawing.Point(-1, 9);
            this.LabelCollocations.Name = "LabelCollocations";
            this.LabelCollocations.Size = new System.Drawing.Size(237, 23);
            this.LabelCollocations.TabIndex = 3;
            this.LabelCollocations.Text = "Collocations";
            this.LabelCollocations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCollocations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            // 
            // PanelPhrasalVerbs
            // 
            this.PanelPhrasalVerbs.BackColor = System.Drawing.Color.Cyan;
            this.PanelPhrasalVerbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPhrasalVerbs.Controls.Add(this.LabelPVDes);
            this.PanelPhrasalVerbs.Controls.Add(this.LabelPV);
            this.PanelPhrasalVerbs.Location = new System.Drawing.Point(115, 199);
            this.PanelPhrasalVerbs.Name = "PanelPhrasalVerbs";
            this.PanelPhrasalVerbs.Size = new System.Drawing.Size(237, 72);
            this.PanelPhrasalVerbs.TabIndex = 2;
            this.PanelPhrasalVerbs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelPhrasalVerbs_MouseClick);
            // 
            // LabelPVDes
            // 
            this.LabelPVDes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPVDes.Location = new System.Drawing.Point(-1, 32);
            this.LabelPVDes.Name = "LabelPVDes";
            this.LabelPVDes.Size = new System.Drawing.Size(237, 23);
            this.LabelPVDes.TabIndex = 3;
            this.LabelPVDes.Text = "Different combinations of words";
            this.LabelPVDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPVDes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelPVDes_MouseClick);
            // 
            // LabelPV
            // 
            this.LabelPV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPV.Location = new System.Drawing.Point(-1, 9);
            this.LabelPV.Name = "LabelPV";
            this.LabelPV.Size = new System.Drawing.Size(237, 23);
            this.LabelPV.TabIndex = 3;
            this.LabelPV.Text = "Phrasal Verbs";
            this.LabelPV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelPV_MouseClick);
            // 
            // PanelIdioms
            // 
            this.PanelIdioms.BackColor = System.Drawing.Color.Lime;
            this.PanelIdioms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelIdioms.Controls.Add(this.LabelIdiomsDes);
            this.PanelIdioms.Controls.Add(this.LabelIdioms);
            this.PanelIdioms.Location = new System.Drawing.Point(274, 320);
            this.PanelIdioms.Name = "PanelIdioms";
            this.PanelIdioms.Size = new System.Drawing.Size(237, 72);
            this.PanelIdioms.TabIndex = 2;
            this.PanelIdioms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelIdioms_MouseClick);
            // 
            // LabelIdiomsDes
            // 
            this.LabelIdiomsDes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdiomsDes.Location = new System.Drawing.Point(-1, 32);
            this.LabelIdiomsDes.Name = "LabelIdiomsDes";
            this.LabelIdiomsDes.Size = new System.Drawing.Size(237, 23);
            this.LabelIdiomsDes.TabIndex = 3;
            this.LabelIdiomsDes.Text = "Other ways to express";
            this.LabelIdiomsDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelIdiomsDes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelIdiomsDes_MouseClick);
            // 
            // LabelIdioms
            // 
            this.LabelIdioms.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIdioms.Location = new System.Drawing.Point(-1, 9);
            this.LabelIdioms.Name = "LabelIdioms";
            this.LabelIdioms.Size = new System.Drawing.Size(237, 23);
            this.LabelIdioms.TabIndex = 3;
            this.LabelIdioms.Text = "Idioms";
            this.LabelIdioms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelIdioms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelIdioms_MouseClick);
            // 
            // PanelWM
            // 
            this.PanelWM.BackColor = System.Drawing.Color.Tomato;
            this.PanelWM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelWM.Controls.Add(this.LabelWMDes);
            this.PanelWM.Controls.Add(this.LabelWM);
            this.PanelWM.Location = new System.Drawing.Point(429, 94);
            this.PanelWM.Name = "PanelWM";
            this.PanelWM.Size = new System.Drawing.Size(237, 72);
            this.PanelWM.TabIndex = 3;
            this.PanelWM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelWM_MouseClick);
            // 
            // LabelWM
            // 
            this.LabelWM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWM.Location = new System.Drawing.Point(0, 9);
            this.LabelWM.Name = "LabelWM";
            this.LabelWM.Size = new System.Drawing.Size(236, 23);
            this.LabelWM.TabIndex = 3;
            this.LabelWM.Text = "Word Meaning";
            this.LabelWM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelWM_MouseClick);
            // 
            // LabelWMDes
            // 
            this.LabelWMDes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWMDes.Location = new System.Drawing.Point(-1, 32);
            this.LabelWMDes.Name = "LabelWMDes";
            this.LabelWMDes.Size = new System.Drawing.Size(237, 23);
            this.LabelWMDes.TabIndex = 3;
            this.LabelWMDes.Text = "Test your vocabulary";
            this.LabelWMDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWMDes.Click += new System.EventHandler(this.LabelCollocationsDes_Click);
            this.LabelWMDes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelWMDes_MouseClick);
            // 
            // PanelWF
            // 
            this.PanelWF.BackColor = System.Drawing.Color.Violet;
            this.PanelWF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelWF.Controls.Add(this.LabelWFDes);
            this.PanelWF.Controls.Add(this.LabelWF);
            this.PanelWF.Location = new System.Drawing.Point(432, 199);
            this.PanelWF.Name = "PanelWF";
            this.PanelWF.Size = new System.Drawing.Size(234, 72);
            this.PanelWF.TabIndex = 4;
            this.PanelWF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelWF_MouseClick);
            // 
            // LabelWF
            // 
            this.LabelWF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWF.Location = new System.Drawing.Point(-2, 10);
            this.LabelWF.Name = "LabelWF";
            this.LabelWF.Size = new System.Drawing.Size(237, 23);
            this.LabelWF.TabIndex = 3;
            this.LabelWF.Text = "Word Forms";
            this.LabelWF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelWF_MouseClick);
            // 
            // LabelWFDes
            // 
            this.LabelWFDes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWFDes.Location = new System.Drawing.Point(-3, 33);
            this.LabelWFDes.Name = "LabelWFDes";
            this.LabelWFDes.Size = new System.Drawing.Size(237, 23);
            this.LabelWFDes.TabIndex = 3;
            this.LabelWFDes.Text = "Variants of words";
            this.LabelWFDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelWFDes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelWFDes_MouseClick);
            // 
            // FormQuizTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.PanelWF);
            this.Controls.Add(this.PanelWM);
            this.Controls.Add(this.PanelIdioms);
            this.Controls.Add(this.PanelPhrasalVerbs);
            this.Controls.Add(this.PanelCollocations);
            this.Controls.Add(this.label1);
            this.Name = "FormQuizTopic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizzes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuizTopic_FormClosed);
            this.PanelCollocations.ResumeLayout(false);
            this.PanelPhrasalVerbs.ResumeLayout(false);
            this.PanelIdioms.ResumeLayout(false);
            this.PanelWM.ResumeLayout(false);
            this.PanelWF.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelCollocations;
        private System.Windows.Forms.Label LabelCollocations;
        private System.Windows.Forms.Label LabelCollocationsDes;
        private System.Windows.Forms.Panel PanelPhrasalVerbs;
        private System.Windows.Forms.Label LabelPVDes;
        private System.Windows.Forms.Label LabelPV;
        private System.Windows.Forms.Panel PanelIdioms;
        private System.Windows.Forms.Label LabelIdiomsDes;
        private System.Windows.Forms.Label LabelIdioms;
        private System.Windows.Forms.Panel PanelWM;
        private System.Windows.Forms.Label LabelWMDes;
        private System.Windows.Forms.Label LabelWM;
        private System.Windows.Forms.Panel PanelWF;
        private System.Windows.Forms.Label LabelWFDes;
        private System.Windows.Forms.Label LabelWF;
    }
}