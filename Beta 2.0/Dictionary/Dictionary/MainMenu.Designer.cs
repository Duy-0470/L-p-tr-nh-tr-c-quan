namespace Dictionary
{
    partial class MainMenu
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
            this.TextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.PanelSearchBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelRandomWord = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LabelRWSpelling = new System.Windows.Forms.Label();
            this.LabelRandomizedWord = new System.Windows.Forms.Label();
            this.LabelRandom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolTipMainMenu = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.ButtonGames = new System.Windows.Forms.Button();
            this.ButtonRandom = new System.Windows.Forms.Button();
            this.ButtonRMSpeak = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.wordGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBar.SuspendLayout();
            this.PanelSearchBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelRandomWord.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSearchInput
            // 
            this.TextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearchInput.BackColor = System.Drawing.Color.White;
            this.TextBoxSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearchInput.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearchInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.TextBoxSearchInput.Location = new System.Drawing.Point(25, 15);
            this.TextBoxSearchInput.Name = "TextBoxSearchInput";
            this.TextBoxSearchInput.Size = new System.Drawing.Size(394, 20);
            this.TextBoxSearchInput.TabIndex = 1;
            this.TextBoxSearchInput.TabStop = false;
            this.TextBoxSearchInput.Text = "Let\'s find your word";
            this.TextBoxSearchInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TextBoxSearchInput.Enter += new System.EventHandler(this.TextBoxSearchInput_Enter);
            this.TextBoxSearchInput.Leave += new System.EventHandler(this.TextBoxSearchInput_Leave);
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.BackColor = System.Drawing.Color.White;
            this.SearchBar.Controls.Add(this.TextBoxSearchInput);
            this.SearchBar.Location = new System.Drawing.Point(223, 15);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(429, 48);
            this.SearchBar.TabIndex = 2;
            // 
            // PanelSearchBar
            // 
            this.PanelSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(69)))), ((int)(((byte)(144)))));
            this.PanelSearchBar.Controls.Add(this.panel1);
            this.PanelSearchBar.Controls.Add(this.SearchBar);
            this.PanelSearchBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PanelSearchBar.Location = new System.Drawing.Point(-6, 68);
            this.PanelSearchBar.Name = "PanelSearchBar";
            this.PanelSearchBar.Size = new System.Drawing.Size(663, 77);
            this.PanelSearchBar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.ComboBoxLanguage);
            this.panel1.Location = new System.Drawing.Point(26, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 48);
            this.panel1.TabIndex = 4;
            // 
            // ComboBoxLanguage
            // 
            this.ComboBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.ComboBoxLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxLanguage.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxLanguage.FormattingEnabled = true;
            this.ComboBoxLanguage.Items.AddRange(new object[] {
            "English - Vietnamese",
            "English - English"});
            this.ComboBoxLanguage.Location = new System.Drawing.Point(7, 12);
            this.ComboBoxLanguage.Name = "ComboBoxLanguage";
            this.ComboBoxLanguage.Size = new System.Drawing.Size(184, 27);
            this.ComboBoxLanguage.TabIndex = 0;
            this.ComboBoxLanguage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictionary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelRandomWord
            // 
            this.PanelRandomWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRandomWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelRandomWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRandomWord.Controls.Add(this.linkLabel1);
            this.PanelRandomWord.Controls.Add(this.ButtonRMSpeak);
            this.PanelRandomWord.Controls.Add(this.LabelRWSpelling);
            this.PanelRandomWord.Controls.Add(this.LabelRandomizedWord);
            this.PanelRandomWord.Controls.Add(this.LabelRandom);
            this.PanelRandomWord.Location = new System.Drawing.Point(1, 169);
            this.PanelRandomWord.Name = "PanelRandomWord";
            this.PanelRandomWord.Size = new System.Drawing.Size(657, 229);
            this.PanelRandomWord.TabIndex = 4;
            this.PanelRandomWord.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRandomWord_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(22, 160);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(212, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SEE DEFINITION AND EXAMPLES";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LabelRWSpelling
            // 
            this.LabelRWSpelling.AutoSize = true;
            this.LabelRWSpelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRWSpelling.Location = new System.Drawing.Point(53, 106);
            this.LabelRWSpelling.Name = "LabelRWSpelling";
            this.LabelRWSpelling.Size = new System.Drawing.Size(92, 16);
            this.LabelRWSpelling.TabIndex = 2;
            this.LabelRWSpelling.Text = "/spelling here/";
            // 
            // LabelRandomizedWord
            // 
            this.LabelRandomizedWord.AutoSize = true;
            this.LabelRandomizedWord.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRandomizedWord.Location = new System.Drawing.Point(50, 55);
            this.LabelRandomizedWord.Name = "LabelRandomizedWord";
            this.LabelRandomizedWord.Size = new System.Drawing.Size(153, 36);
            this.LabelRandomizedWord.TabIndex = 1;
            this.LabelRandomizedWord.Text = "word here";
            // 
            // LabelRandom
            // 
            this.LabelRandom.AutoSize = true;
            this.LabelRandom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRandom.Location = new System.Drawing.Point(22, 14);
            this.LabelRandom.Name = "LabelRandom";
            this.LabelRandom.Size = new System.Drawing.Size(175, 16);
            this.LabelRandom.TabIndex = 0;
            this.LabelRandom.Text = "YOU MAY WANT TO KNOW";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.ButtonInfo.BackgroundImage = global::Dictionary.Properties.Resources.info2;
            this.ButtonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo.ForeColor = System.Drawing.Color.White;
            this.ButtonInfo.Location = new System.Drawing.Point(596, 513);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(50, 50);
            this.ButtonInfo.TabIndex = 7;
            this.ButtonInfo.UseVisualStyleBackColor = false;
            // 
            // ButtonGames
            // 
            this.ButtonGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.ButtonGames.BackgroundImage = global::Dictionary.Properties.Resources.games4;
            this.ButtonGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGames.ForeColor = System.Drawing.Color.White;
            this.ButtonGames.Location = new System.Drawing.Point(353, 447);
            this.ButtonGames.Name = "ButtonGames";
            this.ButtonGames.Size = new System.Drawing.Size(50, 50);
            this.ButtonGames.TabIndex = 6;
            this.ButtonGames.UseVisualStyleBackColor = false;
            this.ButtonGames.Click += new System.EventHandler(this.ButtonGames_Click);
            this.ButtonGames.MouseHover += new System.EventHandler(this.ButtonGames_MouseHover);
            // 
            // ButtonRandom
            // 
            this.ButtonRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.ButtonRandom.BackgroundImage = global::Dictionary.Properties.Resources.randomize;
            this.ButtonRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRandom.ForeColor = System.Drawing.Color.White;
            this.ButtonRandom.Location = new System.Drawing.Point(242, 447);
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Size = new System.Drawing.Size(50, 50);
            this.ButtonRandom.TabIndex = 6;
            this.ButtonRandom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonRandom.UseVisualStyleBackColor = false;
            this.ButtonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            this.ButtonRandom.MouseHover += new System.EventHandler(this.ButtonRandom_MouseHover);
            // 
            // ButtonRMSpeak
            // 
            this.ButtonRMSpeak.BackgroundImage = global::Dictionary.Properties.Resources.speaker;
            this.ButtonRMSpeak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRMSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRMSpeak.ForeColor = System.Drawing.Color.White;
            this.ButtonRMSpeak.Location = new System.Drawing.Point(164, 103);
            this.ButtonRMSpeak.Name = "ButtonRMSpeak";
            this.ButtonRMSpeak.Size = new System.Drawing.Size(24, 23);
            this.ButtonRMSpeak.TabIndex = 3;
            this.ButtonRMSpeak.UseVisualStyleBackColor = true;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripSeparator1,
            this.recentToolStripMenuItem,
            this.favoritesToolStripMenuItem,
            this.toolStripSeparator2,
            this.wordGamesToolStripMenuItem});
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recentToolStripMenuItem.Image = global::Dictionary.Properties.Resources.history;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.Image = global::Dictionary.Properties.Resources.marked;
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.favoritesToolStripMenuItem.Text = "Favorites";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // wordGamesToolStripMenuItem
            // 
            this.wordGamesToolStripMenuItem.Image = global::Dictionary.Properties.Resources.games4;
            this.wordGamesToolStripMenuItem.Name = "wordGamesToolStripMenuItem";
            this.wordGamesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordGamesToolStripMenuItem.Text = "Word games";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 575);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.ButtonGames);
            this.Controls.Add(this.ButtonRandom);
            this.Controls.Add(this.PanelRandomWord);
            this.Controls.Add(this.PanelSearchBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Click += new System.EventHandler(this.MainMenu_Click);
            this.SearchBar.ResumeLayout(false);
            this.SearchBar.PerformLayout();
            this.PanelSearchBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelRandomWord.ResumeLayout(false);
            this.PanelRandomWord.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxSearchInput;
        private System.Windows.Forms.Panel SearchBar;
        private System.Windows.Forms.Panel PanelSearchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelRandomWord;
        private System.Windows.Forms.Button ButtonRMSpeak;
        private System.Windows.Forms.Label LabelRWSpelling;
        private System.Windows.Forms.Label LabelRandomizedWord;
        private System.Windows.Forms.Label LabelRandom;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button ButtonRandom;
        private System.Windows.Forms.Button ButtonGames;
        private System.Windows.Forms.ToolTip ToolTipMainMenu;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxLanguage;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem wordGamesToolStripMenuItem;
    }
}

