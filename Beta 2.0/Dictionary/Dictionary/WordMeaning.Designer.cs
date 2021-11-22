namespace Dictionary
{
    partial class WordMeaning
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
            this.LabelWord = new System.Windows.Forms.Label();
            this.LabelSpelling = new System.Windows.Forms.Label();
            this.RichTextBoxWordInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolTipWordMeaning = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quizzesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordPuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonMarkWord = new System.Windows.Forms.Button();
            this.ButtonSpeak = new System.Windows.Forms.Button();
            this.LinkLabelSeeAlso1 = new System.Windows.Forms.LinkLabel();
            this.LinkLabelSeeAlso2 = new System.Windows.Forms.LinkLabel();
            this.LinkLabelSeeAlso3 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelWord
            // 
            this.LabelWord.AutoSize = true;
            this.LabelWord.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWord.Location = new System.Drawing.Point(12, 24);
            this.LabelWord.Name = "LabelWord";
            this.LabelWord.Size = new System.Drawing.Size(170, 41);
            this.LabelWord.TabIndex = 0;
            this.LabelWord.Text = "Word here";
            // 
            // LabelSpelling
            // 
            this.LabelSpelling.AutoSize = true;
            this.LabelSpelling.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpelling.Location = new System.Drawing.Point(14, 70);
            this.LabelSpelling.Name = "LabelSpelling";
            this.LabelSpelling.Size = new System.Drawing.Size(117, 21);
            this.LabelSpelling.TabIndex = 1;
            this.LabelSpelling.Text = "/spelling here/";
            // 
            // RichTextBoxWordInfo
            // 
            this.RichTextBoxWordInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxWordInfo.BackColor = System.Drawing.Color.White;
            this.RichTextBoxWordInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxWordInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxWordInfo.Location = new System.Drawing.Point(17, 105);
            this.RichTextBoxWordInfo.Name = "RichTextBoxWordInfo";
            this.RichTextBoxWordInfo.ReadOnly = true;
            this.RichTextBoxWordInfo.Size = new System.Drawing.Size(717, 509);
            this.RichTextBoxWordInfo.TabIndex = 3;
            this.RichTextBoxWordInfo.TabStop = false;
            this.RichTextBoxWordInfo.Text = "Info here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 629);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "SEE ALSO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripComboBox1});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Image = global::Dictionary.Properties.Resources.menu3;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quizzesToolStripMenuItem,
            this.wordPuzzleToolStripMenuItem});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(147, 22);
            this.toolStripComboBox1.Text = "Word Games";
            // 
            // quizzesToolStripMenuItem
            // 
            this.quizzesToolStripMenuItem.Name = "quizzesToolStripMenuItem";
            this.quizzesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.quizzesToolStripMenuItem.Text = "Quizzes";
            // 
            // wordPuzzleToolStripMenuItem
            // 
            this.wordPuzzleToolStripMenuItem.Name = "wordPuzzleToolStripMenuItem";
            this.wordPuzzleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.wordPuzzleToolStripMenuItem.Text = "Word Puzzles";
            // 
            // ButtonMarkWord
            // 
            this.ButtonMarkWord.BackgroundImage = global::Dictionary.Properties.Resources.unmarked;
            this.ButtonMarkWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMarkWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMarkWord.ForeColor = System.Drawing.Color.White;
            this.ButtonMarkWord.Location = new System.Drawing.Point(704, 63);
            this.ButtonMarkWord.Name = "ButtonMarkWord";
            this.ButtonMarkWord.Size = new System.Drawing.Size(30, 30);
            this.ButtonMarkWord.TabIndex = 9;
            this.ButtonMarkWord.UseVisualStyleBackColor = true;
            this.ButtonMarkWord.Click += new System.EventHandler(this.button1_Click);
            this.ButtonMarkWord.MouseHover += new System.EventHandler(this.ButtonMarkWord_MouseHover);
            // 
            // ButtonSpeak
            // 
            this.ButtonSpeak.BackgroundImage = global::Dictionary.Properties.Resources.speaker;
            this.ButtonSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSpeak.ForeColor = System.Drawing.Color.White;
            this.ButtonSpeak.Location = new System.Drawing.Point(180, 68);
            this.ButtonSpeak.Name = "ButtonSpeak";
            this.ButtonSpeak.Size = new System.Drawing.Size(25, 25);
            this.ButtonSpeak.TabIndex = 8;
            this.ButtonSpeak.UseVisualStyleBackColor = true;
            this.ButtonSpeak.Click += new System.EventHandler(this.ButtonSpeak_Click);
            this.ButtonSpeak.MouseHover += new System.EventHandler(this.ButtonSpeak_MouseHover);
            // 
            // LinkLabelSeeAlso1
            // 
            this.LinkLabelSeeAlso1.AutoSize = true;
            this.LinkLabelSeeAlso1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSeeAlso1.Location = new System.Drawing.Point(31, 655);
            this.LinkLabelSeeAlso1.Name = "LinkLabelSeeAlso1";
            this.LinkLabelSeeAlso1.Size = new System.Drawing.Size(47, 19);
            this.LinkLabelSeeAlso1.TabIndex = 11;
            this.LinkLabelSeeAlso1.TabStop = true;
            this.LinkLabelSeeAlso1.Text = "extra1";
            this.LinkLabelSeeAlso1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSeeAlso1_LinkClicked);
            // 
            // LinkLabelSeeAlso2
            // 
            this.LinkLabelSeeAlso2.AutoSize = true;
            this.LinkLabelSeeAlso2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSeeAlso2.Location = new System.Drawing.Point(31, 687);
            this.LinkLabelSeeAlso2.Name = "LinkLabelSeeAlso2";
            this.LinkLabelSeeAlso2.Size = new System.Drawing.Size(47, 19);
            this.LinkLabelSeeAlso2.TabIndex = 11;
            this.LinkLabelSeeAlso2.TabStop = true;
            this.LinkLabelSeeAlso2.Text = "extra2";
            this.LinkLabelSeeAlso2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSeeAlso2_LinkClicked);
            // 
            // LinkLabelSeeAlso3
            // 
            this.LinkLabelSeeAlso3.AutoSize = true;
            this.LinkLabelSeeAlso3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSeeAlso3.Location = new System.Drawing.Point(31, 716);
            this.LinkLabelSeeAlso3.Name = "LinkLabelSeeAlso3";
            this.LinkLabelSeeAlso3.Size = new System.Drawing.Size(47, 19);
            this.LinkLabelSeeAlso3.TabIndex = 11;
            this.LinkLabelSeeAlso3.TabStop = true;
            this.LinkLabelSeeAlso3.Text = "extra3";
            this.LinkLabelSeeAlso3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSeeAlso3_LinkClicked);
            // 
            // WordMeaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 749);
            this.Controls.Add(this.LinkLabelSeeAlso2);
            this.Controls.Add(this.LinkLabelSeeAlso3);
            this.Controls.Add(this.LinkLabelSeeAlso1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ButtonMarkWord);
            this.Controls.Add(this.ButtonSpeak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBoxWordInfo);
            this.Controls.Add(this.LabelSpelling);
            this.Controls.Add(this.LabelWord);
            this.Name = "WordMeaning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordMeaning";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordMeaning_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWord;
        private System.Windows.Forms.Label LabelSpelling;
        private System.Windows.Forms.RichTextBox RichTextBoxWordInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSpeak;
        private System.Windows.Forms.ToolTip ToolTipWordMeaning;
        private System.Windows.Forms.Button ButtonMarkWord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem quizzesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordPuzzleToolStripMenuItem;
        private System.Windows.Forms.LinkLabel LinkLabelSeeAlso1;
        private System.Windows.Forms.LinkLabel LinkLabelSeeAlso2;
        private System.Windows.Forms.LinkLabel LinkLabelSeeAlso3;
    }
}