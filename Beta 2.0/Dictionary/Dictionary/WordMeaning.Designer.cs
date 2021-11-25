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
            this.ToolTipWordMeaning = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonMarkWord = new System.Windows.Forms.Button();
            this.ButtonSpeak = new System.Windows.Forms.Button();
            this.LabelMore = new System.Windows.Forms.Label();
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
            this.RichTextBoxWordInfo.DetectUrls = false;
            this.RichTextBoxWordInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxWordInfo.Location = new System.Drawing.Point(17, 105);
            this.RichTextBoxWordInfo.Name = "RichTextBoxWordInfo";
            this.RichTextBoxWordInfo.ReadOnly = true;
            this.RichTextBoxWordInfo.Size = new System.Drawing.Size(717, 449);
            this.RichTextBoxWordInfo.TabIndex = 3;
            this.RichTextBoxWordInfo.TabStop = false;
            this.RichTextBoxWordInfo.Text = "Info here";
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
            this.toolStripSeparator1,
            this.recentToolStripMenuItem,
            this.ToolStripMenuItemFavorites,
            this.toolStripSeparator2,
            this.gamesToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Image = global::Dictionary.Properties.Resources.menu3;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = global::Dictionary.Properties.Resources.Home_16x;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Image = global::Dictionary.Properties.Resources.history;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            this.recentToolStripMenuItem.Click += new System.EventHandler(this.recentToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemFavorites
            // 
            this.ToolStripMenuItemFavorites.Image = global::Dictionary.Properties.Resources.marked;
            this.ToolStripMenuItemFavorites.Name = "ToolStripMenuItemFavorites";
            this.ToolStripMenuItemFavorites.Size = new System.Drawing.Size(141, 22);
            this.ToolStripMenuItemFavorites.Text = "Favorites";
            this.ToolStripMenuItemFavorites.Click += new System.EventHandler(this.ToolStripMenuItemFavorites_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Image = global::Dictionary.Properties.Resources.games4;
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.gamesToolStripMenuItem.Text = "Word games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // ButtonMarkWord
            // 
            this.ButtonMarkWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonMarkWord.BackgroundImage = global::Dictionary.Properties.Resources.unmarked;
            this.ButtonMarkWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMarkWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMarkWord.ForeColor = System.Drawing.Color.White;
            this.ButtonMarkWord.Location = new System.Drawing.Point(716, 24);
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
            this.ButtonSpeak.Location = new System.Drawing.Point(337, 66);
            this.ButtonSpeak.Name = "ButtonSpeak";
            this.ButtonSpeak.Size = new System.Drawing.Size(25, 25);
            this.ButtonSpeak.TabIndex = 8;
            this.ButtonSpeak.UseVisualStyleBackColor = true;
            this.ButtonSpeak.Click += new System.EventHandler(this.ButtonSpeak_Click);
            this.ButtonSpeak.MouseHover += new System.EventHandler(this.ButtonSpeak_MouseHover);
            // 
            // LabelMore
            // 
            this.LabelMore.AutoSize = true;
            this.LabelMore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMore.Location = new System.Drawing.Point(31, 602);
            this.LabelMore.Name = "LabelMore";
            this.LabelMore.Size = new System.Drawing.Size(55, 18);
            this.LabelMore.TabIndex = 11;
            this.LabelMore.Text = "MORE";
            // 
            // LinkLabelSeeAlso1
            // 
            this.LinkLabelSeeAlso1.AutoSize = true;
            this.LinkLabelSeeAlso1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSeeAlso1.Location = new System.Drawing.Point(30, 635);
            this.LinkLabelSeeAlso1.Name = "LinkLabelSeeAlso1";
            this.LinkLabelSeeAlso1.Size = new System.Drawing.Size(72, 19);
            this.LinkLabelSeeAlso1.TabIndex = 12;
            this.LinkLabelSeeAlso1.TabStop = true;
            this.LinkLabelSeeAlso1.Text = "linkLabel1";
            this.LinkLabelSeeAlso1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSeeAlso1_LinkClicked);
            // 
            // LinkLabelSeeAlso2
            // 
            this.LinkLabelSeeAlso2.AutoSize = true;
            this.LinkLabelSeeAlso2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSeeAlso2.Location = new System.Drawing.Point(30, 669);
            this.LinkLabelSeeAlso2.Name = "LinkLabelSeeAlso2";
            this.LinkLabelSeeAlso2.Size = new System.Drawing.Size(72, 19);
            this.LinkLabelSeeAlso2.TabIndex = 12;
            this.LinkLabelSeeAlso2.TabStop = true;
            this.LinkLabelSeeAlso2.Text = "linkLabel1";
            this.LinkLabelSeeAlso2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSeeAlso2_LinkClicked);
            // 
            // LinkLabelSeeAlso3
            // 
            this.LinkLabelSeeAlso3.AutoSize = true;
            this.LinkLabelSeeAlso3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelSeeAlso3.Location = new System.Drawing.Point(30, 700);
            this.LinkLabelSeeAlso3.Name = "LinkLabelSeeAlso3";
            this.LinkLabelSeeAlso3.Size = new System.Drawing.Size(72, 19);
            this.LinkLabelSeeAlso3.TabIndex = 12;
            this.LinkLabelSeeAlso3.TabStop = true;
            this.LinkLabelSeeAlso3.Text = "linkLabel1";
            this.LinkLabelSeeAlso3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSeeAlso3_LinkClicked);
            // 
            // WordMeaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 749);
            this.Controls.Add(this.LinkLabelSeeAlso3);
            this.Controls.Add(this.LinkLabelSeeAlso2);
            this.Controls.Add(this.LinkLabelSeeAlso1);
            this.Controls.Add(this.LabelMore);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ButtonMarkWord);
            this.Controls.Add(this.ButtonSpeak);
            this.Controls.Add(this.RichTextBoxWordInfo);
            this.Controls.Add(this.LabelSpelling);
            this.Controls.Add(this.LabelWord);
            this.Name = "WordMeaning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordMeaning_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WordMeaning_FormClosed);
            this.Load += new System.EventHandler(this.WordMeaning_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelWord;
        private System.Windows.Forms.Label LabelSpelling;
        private System.Windows.Forms.RichTextBox RichTextBoxWordInfo;
        private System.Windows.Forms.Button ButtonSpeak;
        private System.Windows.Forms.ToolTip ToolTipWordMeaning;
        private System.Windows.Forms.Button ButtonMarkWord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFavorites;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.Label LabelMore;
        private System.Windows.Forms.LinkLabel LinkLabelSeeAlso1;
        private System.Windows.Forms.LinkLabel LinkLabelSeeAlso2;
        private System.Windows.Forms.LinkLabel LinkLabelSeeAlso3;
    }
}