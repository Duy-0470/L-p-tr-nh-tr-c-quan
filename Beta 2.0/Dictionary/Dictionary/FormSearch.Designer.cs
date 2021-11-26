namespace Dictionary
{
    partial class FormSearch
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
            this.PanelSearchBar = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.TextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFavorites = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.wordGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewHint = new System.Windows.Forms.ListView();
            this.ColumnHint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelSearchBar.SuspendLayout();
            this.SearchBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSearchBar
            // 
            this.PanelSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(69)))), ((int)(((byte)(144)))));
            this.PanelSearchBar.Controls.Add(this.SearchBar);
            this.PanelSearchBar.Controls.Add(this.ButtonGo);
            this.PanelSearchBar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PanelSearchBar.Location = new System.Drawing.Point(1, 27);
            this.PanelSearchBar.Name = "PanelSearchBar";
            this.PanelSearchBar.Size = new System.Drawing.Size(602, 77);
            this.PanelSearchBar.TabIndex = 4;
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.BackColor = System.Drawing.Color.White;
            this.SearchBar.Controls.Add(this.TextBoxSearchInput);
            this.SearchBar.Location = new System.Drawing.Point(29, 15);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(500, 48);
            this.SearchBar.TabIndex = 2;
            // 
            // TextBoxSearchInput
            // 
            this.TextBoxSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearchInput.BackColor = System.Drawing.Color.White;
            this.TextBoxSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSearchInput.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearchInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxSearchInput.Location = new System.Drawing.Point(25, 15);
            this.TextBoxSearchInput.Name = "TextBoxSearchInput";
            this.TextBoxSearchInput.Size = new System.Drawing.Size(465, 20);
            this.TextBoxSearchInput.TabIndex = 1;
            this.TextBoxSearchInput.TabStop = false;
            this.TextBoxSearchInput.TextChanged += new System.EventHandler(this.TextBoxSearchInput_TextChanged);
            // 
            // ButtonGo
            // 
            this.ButtonGo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.ButtonGo.Enabled = false;
            this.ButtonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonGo.Location = new System.Drawing.Point(525, 15);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(48, 48);
            this.ButtonGo.TabIndex = 2;
            this.ButtonGo.TabStop = false;
            this.ButtonGo.Text = "Go";
            this.ButtonGo.UseVisualStyleBackColor = false;
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.browseToolStripMenuItem,
            this.toolStripSeparator2,
            this.wordGamesToolStripMenuItem});
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
            this.recentToolStripMenuItem.Image = global::Dictionary.Properties.Resources.history;
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recentToolStripMenuItem.Text = "Recent";
            this.recentToolStripMenuItem.Click += new System.EventHandler(this.recentToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemFavorites
            // 
            this.ToolStripMenuItemFavorites.Image = global::Dictionary.Properties.Resources.marked2;
            this.ToolStripMenuItemFavorites.Name = "ToolStripMenuItemFavorites";
            this.ToolStripMenuItemFavorites.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemFavorites.Text = "Favorites";
            this.ToolStripMenuItemFavorites.Click += new System.EventHandler(this.ToolStripMenuItemFavorites_Click);
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
            this.wordGamesToolStripMenuItem.Text = "Word Games";
            this.wordGamesToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ListViewHint
            // 
            this.ListViewHint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewHint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHint});
            this.ListViewHint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewHint.FullRowSelect = true;
            this.ListViewHint.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListViewHint.HideSelection = false;
            this.ListViewHint.Location = new System.Drawing.Point(30, 110);
            this.ListViewHint.MultiSelect = false;
            this.ListViewHint.Name = "ListViewHint";
            this.ListViewHint.Size = new System.Drawing.Size(500, 524);
            this.ListViewHint.TabIndex = 11;
            this.ListViewHint.UseCompatibleStateImageBehavior = false;
            this.ListViewHint.View = System.Windows.Forms.View.Details;
            this.ListViewHint.SelectedIndexChanged += new System.EventHandler(this.ListViewHint_SelectedIndexChanged);
            // 
            // ColumnHint
            // 
            this.ColumnHint.Text = "";
            this.ColumnHint.Width = 350;
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Image = global::Dictionary.Properties.Resources.BrowseDefinition_16x;
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 646);
            this.Controls.Add(this.ListViewHint);
            this.Controls.Add(this.PanelSearchBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearch_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSearch_FormClosed);
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.PanelSearchBar.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            this.SearchBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSearchBar;
        private System.Windows.Forms.Panel SearchBar;
        private System.Windows.Forms.TextBox TextBoxSearchInput;
        private System.Windows.Forms.Button ButtonGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFavorites;
        private System.Windows.Forms.ToolStripMenuItem wordGamesToolStripMenuItem;
        private System.Windows.Forms.ListView ListViewHint;
        private System.Windows.Forms.ColumnHeader ColumnHint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
    }
}