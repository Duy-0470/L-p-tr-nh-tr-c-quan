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
            this.PanelTopic = new System.Windows.Forms.Panel();
            this.LabelChooseTP = new System.Windows.Forms.Label();
            this.PanelWF = new System.Windows.Forms.Panel();
            this.LabelWFDes = new System.Windows.Forms.Label();
            this.LabelWF = new System.Windows.Forms.Label();
            this.PanelWM = new System.Windows.Forms.Panel();
            this.LabelWMDes = new System.Windows.Forms.Label();
            this.LabelWM = new System.Windows.Forms.Label();
            this.PanelIdioms = new System.Windows.Forms.Panel();
            this.LabelIdiomsDes = new System.Windows.Forms.Label();
            this.LabelIdioms = new System.Windows.Forms.Label();
            this.PanelPhrasalVerbs = new System.Windows.Forms.Panel();
            this.LabelPVDes = new System.Windows.Forms.Label();
            this.LabelPV = new System.Windows.Forms.Label();
            this.PanelCollocations = new System.Windows.Forms.Panel();
            this.LabelCollocationsDes = new System.Windows.Forms.Label();
            this.LabelCollocations = new System.Windows.Forms.Label();
            this.PanelQuiz = new System.Windows.Forms.Panel();
            this.ButtonQuit = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.LabelTimeLeft = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonD = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.ButtonA = new System.Windows.Forms.Button();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.PanelRules = new System.Windows.Forms.Panel();
            this.CheckBoxShowRules = new System.Windows.Forms.CheckBox();
            this.ButtonOKRules = new System.Windows.Forms.Button();
            this.LabelRules = new System.Windows.Forms.Label();
            this.TimeLimit = new System.Windows.Forms.Timer(this.components);
            this.Timer1sec = new System.Windows.Forms.Timer(this.components);
            this.LabelReady = new System.Windows.Forms.Label();
            this.TimerReady = new System.Windows.Forms.Timer(this.components);
            this.PanelTopic.SuspendLayout();
            this.PanelWF.SuspendLayout();
            this.PanelWM.SuspendLayout();
            this.PanelIdioms.SuspendLayout();
            this.PanelPhrasalVerbs.SuspendLayout();
            this.PanelCollocations.SuspendLayout();
            this.PanelQuiz.SuspendLayout();
            this.PanelRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopic
            // 
            this.PanelTopic.Controls.Add(this.LabelChooseTP);
            this.PanelTopic.Controls.Add(this.PanelWF);
            this.PanelTopic.Controls.Add(this.PanelWM);
            this.PanelTopic.Controls.Add(this.PanelIdioms);
            this.PanelTopic.Controls.Add(this.PanelPhrasalVerbs);
            this.PanelTopic.Controls.Add(this.PanelCollocations);
            this.PanelTopic.Location = new System.Drawing.Point(0, 0);
            this.PanelTopic.Name = "PanelTopic";
            this.PanelTopic.Size = new System.Drawing.Size(837, 480);
            this.PanelTopic.TabIndex = 4;
            // 
            // LabelChooseTP
            // 
            this.LabelChooseTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelChooseTP.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChooseTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.LabelChooseTP.Location = new System.Drawing.Point(0, 9);
            this.LabelChooseTP.Name = "LabelChooseTP";
            this.LabelChooseTP.Size = new System.Drawing.Size(834, 31);
            this.LabelChooseTP.TabIndex = 10;
            this.LabelChooseTP.Text = "Choose a topic";
            this.LabelChooseTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelWF
            // 
            this.PanelWF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelWF.BackColor = System.Drawing.Color.Violet;
            this.PanelWF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelWF.Controls.Add(this.LabelWFDes);
            this.PanelWF.Controls.Add(this.LabelWF);
            this.PanelWF.Location = new System.Drawing.Point(462, 212);
            this.PanelWF.Name = "PanelWF";
            this.PanelWF.Size = new System.Drawing.Size(234, 72);
            this.PanelWF.TabIndex = 9;
            this.PanelWF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelWF_MouseClick);
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
            // PanelWM
            // 
            this.PanelWM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelWM.BackColor = System.Drawing.Color.Tomato;
            this.PanelWM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelWM.Controls.Add(this.LabelWMDes);
            this.PanelWM.Controls.Add(this.LabelWM);
            this.PanelWM.Location = new System.Drawing.Point(459, 107);
            this.PanelWM.Name = "PanelWM";
            this.PanelWM.Size = new System.Drawing.Size(237, 72);
            this.PanelWM.TabIndex = 8;
            this.PanelWM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelWM_MouseClick);
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
            this.LabelWMDes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelWMDes_MouseClick);
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
            // PanelIdioms
            // 
            this.PanelIdioms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelIdioms.BackColor = System.Drawing.Color.Lime;
            this.PanelIdioms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelIdioms.Controls.Add(this.LabelIdiomsDes);
            this.PanelIdioms.Controls.Add(this.LabelIdioms);
            this.PanelIdioms.Location = new System.Drawing.Point(304, 333);
            this.PanelIdioms.Name = "PanelIdioms";
            this.PanelIdioms.Size = new System.Drawing.Size(237, 72);
            this.PanelIdioms.TabIndex = 5;
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
            // PanelPhrasalVerbs
            // 
            this.PanelPhrasalVerbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelPhrasalVerbs.BackColor = System.Drawing.Color.Cyan;
            this.PanelPhrasalVerbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPhrasalVerbs.Controls.Add(this.LabelPVDes);
            this.PanelPhrasalVerbs.Controls.Add(this.LabelPV);
            this.PanelPhrasalVerbs.Location = new System.Drawing.Point(145, 212);
            this.PanelPhrasalVerbs.Name = "PanelPhrasalVerbs";
            this.PanelPhrasalVerbs.Size = new System.Drawing.Size(237, 72);
            this.PanelPhrasalVerbs.TabIndex = 6;
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
            // PanelCollocations
            // 
            this.PanelCollocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelCollocations.BackColor = System.Drawing.Color.Yellow;
            this.PanelCollocations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCollocations.Controls.Add(this.LabelCollocationsDes);
            this.PanelCollocations.Controls.Add(this.LabelCollocations);
            this.PanelCollocations.Location = new System.Drawing.Point(145, 107);
            this.PanelCollocations.Name = "PanelCollocations";
            this.PanelCollocations.Size = new System.Drawing.Size(237, 72);
            this.PanelCollocations.TabIndex = 7;
            this.PanelCollocations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelCollocations_MouseClick);
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
            this.LabelCollocationsDes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelCollocationsDes_MouseClick);
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
            this.LabelCollocations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabelCollocations_MouseClick);
            // 
            // PanelQuiz
            // 
            this.PanelQuiz.BackColor = System.Drawing.Color.White;
            this.PanelQuiz.Controls.Add(this.ButtonQuit);
            this.PanelQuiz.Controls.Add(this.ButtonNext);
            this.PanelQuiz.Controls.Add(this.LabelTimeLeft);
            this.PanelQuiz.Controls.Add(this.LabelScore);
            this.PanelQuiz.Controls.Add(this.ButtonC);
            this.PanelQuiz.Controls.Add(this.ButtonD);
            this.PanelQuiz.Controls.Add(this.ButtonB);
            this.PanelQuiz.Controls.Add(this.ButtonA);
            this.PanelQuiz.Controls.Add(this.LabelQuestion);
            this.PanelQuiz.Location = new System.Drawing.Point(0, 486);
            this.PanelQuiz.Name = "PanelQuiz";
            this.PanelQuiz.Size = new System.Drawing.Size(837, 480);
            this.PanelQuiz.TabIndex = 5;
            this.PanelQuiz.Visible = false;
            // 
            // ButtonQuit
            // 
            this.ButtonQuit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuit.Location = new System.Drawing.Point(12, 434);
            this.ButtonQuit.Name = "ButtonQuit";
            this.ButtonQuit.Size = new System.Drawing.Size(94, 29);
            this.ButtonQuit.TabIndex = 3;
            this.ButtonQuit.TabStop = false;
            this.ButtonQuit.Text = "Quit";
            this.ButtonQuit.UseVisualStyleBackColor = true;
            this.ButtonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNext.Location = new System.Drawing.Point(729, 434);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(94, 29);
            this.ButtonNext.TabIndex = 3;
            this.ButtonNext.TabStop = false;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Visible = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
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
            // LabelQuestion
            // 
            this.LabelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuestion.Location = new System.Drawing.Point(24, 71);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(790, 103);
            this.LabelQuestion.TabIndex = 1;
            this.LabelQuestion.Text = "Question here";
            this.LabelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRules
            // 
            this.PanelRules.AutoScroll = true;
            this.PanelRules.Controls.Add(this.CheckBoxShowRules);
            this.PanelRules.Controls.Add(this.ButtonOKRules);
            this.PanelRules.Controls.Add(this.LabelRules);
            this.PanelRules.Location = new System.Drawing.Point(858, 0);
            this.PanelRules.Name = "PanelRules";
            this.PanelRules.Size = new System.Drawing.Size(837, 480);
            this.PanelRules.TabIndex = 6;
            this.PanelRules.Visible = false;
            // 
            // CheckBoxShowRules
            // 
            this.CheckBoxShowRules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBoxShowRules.AutoSize = true;
            this.CheckBoxShowRules.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxShowRules.Location = new System.Drawing.Point(241, 264);
            this.CheckBoxShowRules.Name = "CheckBoxShowRules";
            this.CheckBoxShowRules.Size = new System.Drawing.Size(149, 20);
            this.CheckBoxShowRules.TabIndex = 2;
            this.CheckBoxShowRules.Text = "Don\'t show this again";
            this.CheckBoxShowRules.UseVisualStyleBackColor = true;
            this.CheckBoxShowRules.CheckedChanged += new System.EventHandler(this.CheckBoxShowRules_CheckedChanged);
            // 
            // ButtonOKRules
            // 
            this.ButtonOKRules.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonOKRules.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOKRules.Location = new System.Drawing.Point(492, 260);
            this.ButtonOKRules.Name = "ButtonOKRules";
            this.ButtonOKRules.Size = new System.Drawing.Size(98, 27);
            this.ButtonOKRules.TabIndex = 1;
            this.ButtonOKRules.Text = "OK";
            this.ButtonOKRules.UseVisualStyleBackColor = true;
            this.ButtonOKRules.Click += new System.EventHandler(this.ButtonOKRules_Click);
            // 
            // LabelRules
            // 
            this.LabelRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRules.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRules.Location = new System.Drawing.Point(0, 116);
            this.LabelRules.Name = "LabelRules";
            this.LabelRules.Size = new System.Drawing.Size(838, 106);
            this.LabelRules.TabIndex = 0;
            this.LabelRules.Text = resources.GetString("LabelRules.Text");
            this.LabelRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // LabelReady
            // 
            this.LabelReady.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReady.Location = new System.Drawing.Point(861, 486);
            this.LabelReady.Name = "LabelReady";
            this.LabelReady.Size = new System.Drawing.Size(834, 480);
            this.LabelReady.TabIndex = 7;
            this.LabelReady.Text = "3";
            this.LabelReady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelReady.Visible = false;
            // 
            // TimerReady
            // 
            this.TimerReady.Interval = 1000;
            this.TimerReady.Tick += new System.EventHandler(this.TimerReady_Tick);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1714, 973);
            this.Controls.Add(this.LabelReady);
            this.Controls.Add(this.PanelRules);
            this.Controls.Add(this.PanelQuiz);
            this.Controls.Add(this.PanelTopic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQuiz_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuiz_FormClosed);
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.Resize += new System.EventHandler(this.FormQuiz_Resize);
            this.PanelTopic.ResumeLayout(false);
            this.PanelWF.ResumeLayout(false);
            this.PanelWM.ResumeLayout(false);
            this.PanelIdioms.ResumeLayout(false);
            this.PanelPhrasalVerbs.ResumeLayout(false);
            this.PanelCollocations.ResumeLayout(false);
            this.PanelQuiz.ResumeLayout(false);
            this.PanelQuiz.PerformLayout();
            this.PanelRules.ResumeLayout(false);
            this.PanelRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopic;
        private System.Windows.Forms.Panel PanelWF;
        private System.Windows.Forms.Label LabelWFDes;
        private System.Windows.Forms.Label LabelWF;
        private System.Windows.Forms.Panel PanelWM;
        private System.Windows.Forms.Label LabelWMDes;
        private System.Windows.Forms.Label LabelWM;
        private System.Windows.Forms.Panel PanelIdioms;
        private System.Windows.Forms.Label LabelIdiomsDes;
        private System.Windows.Forms.Label LabelIdioms;
        private System.Windows.Forms.Panel PanelPhrasalVerbs;
        private System.Windows.Forms.Label LabelPVDes;
        private System.Windows.Forms.Label LabelPV;
        private System.Windows.Forms.Panel PanelCollocations;
        private System.Windows.Forms.Label LabelCollocationsDes;
        private System.Windows.Forms.Label LabelCollocations;
        private System.Windows.Forms.Label LabelChooseTP;
        private System.Windows.Forms.Panel PanelQuiz;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Label LabelTimeLeft;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonD;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.Panel PanelRules;
        private System.Windows.Forms.CheckBox CheckBoxShowRules;
        private System.Windows.Forms.Button ButtonOKRules;
        private System.Windows.Forms.Label LabelRules;
        private System.Windows.Forms.Timer TimeLimit;
        private System.Windows.Forms.Timer Timer1sec;
        private System.Windows.Forms.Button ButtonQuit;
        private System.Windows.Forms.Label LabelReady;
        private System.Windows.Forms.Timer TimerReady;
    }
}