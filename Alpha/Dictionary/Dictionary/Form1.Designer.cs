
using System;
using System.Drawing;

namespace Dictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topBar = new System.Windows.Forms.Panel();
            this.rightTopBarPanel = new System.Windows.Forms.Panel();
            this.avatarButton = new Dictionary.CustomControls.RoundButton();
            this.helpButton = new Dictionary.CustomControls.RoundButton();
            this.signOutButton = new Dictionary.CustomControls.RoundButton();
            this.appNamePanel = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicturesButton = new System.Windows.Forms.Button();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RightBorderOfDictionaries = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DictionariesButton = new System.Windows.Forms.Button();
            this.dictionariesOptions = new System.Windows.Forms.Panel();
            this.engVietButton = new System.Windows.Forms.Button();
            this.DictionariesHomeButton = new System.Windows.Forms.Button();
            this.engengButton = new System.Windows.Forms.Button();
            this.dictionariesOptionBorder = new System.Windows.Forms.Panel();
            this.ButtonBarBorder = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.Panel();
            this.GoButton = new System.Windows.Forms.Button();
            this.SearchInputBorder = new System.Windows.Forms.Panel();
            this.SearchInputArea = new System.Windows.Forms.Panel();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.TypeSelectionButton = new System.Windows.Forms.Button();
            this.TypePanel = new System.Windows.Forms.Panel();
            this.engVietTypeButton = new System.Windows.Forms.Button();
            this.engEngTypeButton = new System.Windows.Forms.Button();
            this.TypePanelBorder = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.WordHeader = new System.Windows.Forms.Panel();
            this.WordFormBar = new System.Windows.Forms.Panel();
            this.WordForm = new System.Windows.Forms.Label();
            this.WordFormSign = new System.Windows.Forms.Label();
            this.WordFormPanel = new System.Windows.Forms.Panel();
            this.NAPronSmall = new System.Windows.Forms.Label();
            this.NAButtonSmall = new System.Windows.Forms.Button();
            this.BEPronSmall = new System.Windows.Forms.Label();
            this.FormedWord = new System.Windows.Forms.Label();
            this.BEButtonSmall = new System.Windows.Forms.Button();
            this.SubjectOfForm = new System.Windows.Forms.Label();
            this.Form = new System.Windows.Forms.Button();
            this.NAPron = new System.Windows.Forms.Label();
            this.BEPron = new System.Windows.Forms.Label();
            this.NAButton = new System.Windows.Forms.Button();
            this.BEButton = new System.Windows.Forms.Button();
            this.WordLevel = new Dictionary.CustomControls.RoundButton();
            this.WordType = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();
            this.defintionHeader1 = new Dictionary.CustomControls.DefintionHeader(this.components);
            this.topBar.SuspendLayout();
            this.rightTopBarPanel.SuspendLayout();
            this.appNamePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.RightBorderOfDictionaries.SuspendLayout();
            this.dictionariesOptions.SuspendLayout();
            this.dictionariesOptionBorder.SuspendLayout();
            this.ButtonBarBorder.SuspendLayout();
            this.SearchBar.SuspendLayout();
            this.SearchInputBorder.SuspendLayout();
            this.SearchInputArea.SuspendLayout();
            this.TypePanel.SuspendLayout();
            this.TypePanelBorder.SuspendLayout();
            this.panel6.SuspendLayout();
            this.WordHeader.SuspendLayout();
            this.WordFormBar.SuspendLayout();
            this.WordFormPanel.SuspendLayout();
            this.SuspendLayout();

            this.defintionHeader1.Location = new System.Drawing.Point(0, 0);
            this.defintionHeader1.AutoSize = true;
            this.defintionHeader1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            // 
            // topBar
            // 
            this.topBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar.BackColor = System.Drawing.Color.White;
            this.topBar.Controls.Add(this.rightTopBarPanel);
            this.topBar.Controls.Add(this.appNamePanel);
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(904, 48);
            this.topBar.TabIndex = 0;
            // 
            // rightTopBarPanel
            // 
            this.rightTopBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightTopBarPanel.BackColor = System.Drawing.Color.White;
            this.rightTopBarPanel.Controls.Add(this.avatarButton);
            this.rightTopBarPanel.Controls.Add(this.helpButton);
            this.rightTopBarPanel.Controls.Add(this.signOutButton);
            this.rightTopBarPanel.Location = new System.Drawing.Point(1209, 0);
            this.rightTopBarPanel.Name = "rightTopBarPanel";
            this.rightTopBarPanel.Size = new System.Drawing.Size(245, 48);
            this.rightTopBarPanel.TabIndex = 1;
            // 
            // avatarButton
            // 
            this.avatarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.avatarButton.BackColor = System.Drawing.Color.Transparent;
            this.avatarButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.avatarButton.BorderRadius = 20;
            this.avatarButton.BorderSize = 0;
            this.avatarButton.FlatAppearance.BorderSize = 0;
            this.avatarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatarButton.ForeColor = System.Drawing.Color.White;
            this.avatarButton.Image = ((System.Drawing.Image)(resources.GetObject("avatarButton.Image")));
            this.avatarButton.Location = new System.Drawing.Point(208, 9);
            this.avatarButton.Name = "avatarButton";
            this.avatarButton.Size = new System.Drawing.Size(30, 30);
            this.avatarButton.TabIndex = 1;
            this.avatarButton.TextColor = System.Drawing.Color.White;
            this.avatarButton.UseVisualStyleBackColor = false;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.helpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.helpButton.BorderRadius = 30;
            this.helpButton.BorderSize = 2;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(1, 9);
            this.helpButton.Margin = new System.Windows.Forms.Padding(6, 14, 6, 14);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(80, 30);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Help";
            this.helpButton.TextColor = System.Drawing.Color.White;
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // signOutButton
            // 
            this.signOutButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.signOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.signOutButton.BorderColor = System.Drawing.Color.Transparent;
            this.signOutButton.BorderRadius = 0;
            this.signOutButton.BorderSize = 0;
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signOutButton.ForeColor = System.Drawing.Color.White;
            this.signOutButton.Location = new System.Drawing.Point(89, 9);
            this.signOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(109, 30);
            this.signOutButton.TabIndex = 2;
            this.signOutButton.Text = "Sign out";
            this.signOutButton.TextColor = System.Drawing.Color.White;
            this.signOutButton.UseVisualStyleBackColor = false;
            // 
            // appNamePanel
            // 
            this.appNamePanel.AutoSize = true;
            this.appNamePanel.BackColor = System.Drawing.Color.Transparent;
            this.appNamePanel.Controls.Add(this.appName);
            this.appNamePanel.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.appNamePanel.Location = new System.Drawing.Point(11, 0);
            this.appNamePanel.Name = "appNamePanel";
            this.appNamePanel.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.appNamePanel.Size = new System.Drawing.Size(237, 48);
            this.appNamePanel.TabIndex = 0;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.appName.Location = new System.Drawing.Point(0, 11);
            this.appName.Margin = new System.Windows.Forms.Padding(0);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(186, 28);
            this.appName.TabIndex = 0;
            this.appName.Text = "Your Dictionaries";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PicturesButton);
            this.panel1.Controls.Add(this.ReviewButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.RightBorderOfDictionaries);
            this.panel1.Controls.Add(this.DictionariesButton);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1575, 48);
            this.panel1.TabIndex = 1;
            // 
            // PicturesButton
            // 
            this.PicturesButton.BackColor = System.Drawing.Color.White;
            this.PicturesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PicturesButton.FlatAppearance.BorderSize = 0;
            this.PicturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PicturesButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PicturesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PicturesButton.Location = new System.Drawing.Point(146, 0);
            this.PicturesButton.Name = "PicturesButton";
            this.PicturesButton.Size = new System.Drawing.Size(88, 48);
            this.PicturesButton.TabIndex = 6;
            this.PicturesButton.Text = "Pictures";
            this.PicturesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PicturesButton.UseVisualStyleBackColor = false;
            this.PicturesButton.MouseEnter += new System.EventHandler(this.TopBarButtonGetsFocus);
            this.PicturesButton.MouseLeave += new System.EventHandler(this.TopBarButtonLosesFocus);
            // 
            // ReviewButton
            // 
            this.ReviewButton.BackColor = System.Drawing.Color.White;
            this.ReviewButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ReviewButton.FlatAppearance.BorderSize = 0;
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ReviewButton.Location = new System.Drawing.Point(235, 0);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(85, 48);
            this.ReviewButton.TabIndex = 5;
            this.ReviewButton.Text = "Review";
            this.ReviewButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReviewButton.UseVisualStyleBackColor = false;
            this.ReviewButton.MouseEnter += new System.EventHandler(this.TopBarButtonGetsFocus);
            this.ReviewButton.MouseLeave += new System.EventHandler(this.TopBarButtonLosesFocus);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(234, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 48);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 48);
            this.panel4.TabIndex = 6;
            // 
            // RightBorderOfDictionaries
            // 
            this.RightBorderOfDictionaries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.RightBorderOfDictionaries.Controls.Add(this.panel2);
            this.RightBorderOfDictionaries.Location = new System.Drawing.Point(145, 0);
            this.RightBorderOfDictionaries.Name = "RightBorderOfDictionaries";
            this.RightBorderOfDictionaries.Size = new System.Drawing.Size(1, 48);
            this.RightBorderOfDictionaries.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 48);
            this.panel2.TabIndex = 6;
            // 
            // DictionariesButton
            // 
            this.DictionariesButton.BackColor = System.Drawing.Color.White;
            this.DictionariesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DictionariesButton.FlatAppearance.BorderSize = 0;
            this.DictionariesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DictionariesButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DictionariesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DictionariesButton.Location = new System.Drawing.Point(12, 0);
            this.DictionariesButton.Name = "DictionariesButton";
            this.DictionariesButton.Size = new System.Drawing.Size(133, 48);
            this.DictionariesButton.TabIndex = 3;
            this.DictionariesButton.Text = "Dictionaries ...";
            this.DictionariesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DictionariesButton.UseVisualStyleBackColor = false;
            this.DictionariesButton.Click += new System.EventHandler(this.ClickAtDictionaries);
            this.DictionariesButton.MouseEnter += new System.EventHandler(this.TopBarButtonGetsFocus);
            this.DictionariesButton.MouseLeave += new System.EventHandler(this.TopBarButtonLosesFocus);
            // 
            // dictionariesOptions
            // 
            this.dictionariesOptions.BackColor = System.Drawing.Color.White;
            this.dictionariesOptions.Controls.Add(this.engVietButton);
            this.dictionariesOptions.Controls.Add(this.DictionariesHomeButton);
            this.dictionariesOptions.Controls.Add(this.engengButton);
            this.dictionariesOptions.Location = new System.Drawing.Point(1, 0);
            this.dictionariesOptions.Name = "dictionariesOptions";
            this.dictionariesOptions.Size = new System.Drawing.Size(250, 150);
            this.dictionariesOptions.TabIndex = 2;
            // 
            // engVietButton
            // 
            this.engVietButton.BackColor = System.Drawing.Color.White;
            this.engVietButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.engVietButton.FlatAppearance.BorderSize = 0;
            this.engVietButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engVietButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.engVietButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.engVietButton.Location = new System.Drawing.Point(15, 95);
            this.engVietButton.Name = "engVietButton";
            this.engVietButton.Size = new System.Drawing.Size(220, 40);
            this.engVietButton.TabIndex = 6;
            this.engVietButton.Text = "   English - Vietnamese";
            this.engVietButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.engVietButton.UseVisualStyleBackColor = false;
            this.engVietButton.MouseEnter += new System.EventHandler(this.OptionLabelGetsFocused);
            this.engVietButton.MouseLeave += new System.EventHandler(this.OptionLabelLosesFocused);
            // 
            // DictionariesHomeButton
            // 
            this.DictionariesHomeButton.BackColor = System.Drawing.Color.White;
            this.DictionariesHomeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DictionariesHomeButton.FlatAppearance.BorderSize = 0;
            this.DictionariesHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DictionariesHomeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DictionariesHomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.DictionariesHomeButton.Location = new System.Drawing.Point(15, 15);
            this.DictionariesHomeButton.Name = "DictionariesHomeButton";
            this.DictionariesHomeButton.Size = new System.Drawing.Size(220, 40);
            this.DictionariesHomeButton.TabIndex = 4;
            this.DictionariesHomeButton.Text = "   Dictionaries Home";
            this.DictionariesHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DictionariesHomeButton.UseVisualStyleBackColor = false;
            this.DictionariesHomeButton.MouseEnter += new System.EventHandler(this.OptionLabelGetsFocused);
            this.DictionariesHomeButton.MouseLeave += new System.EventHandler(this.OptionLabelLosesFocused);
            // 
            // engengButton
            // 
            this.engengButton.BackColor = System.Drawing.Color.White;
            this.engengButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.engengButton.FlatAppearance.BorderSize = 0;
            this.engengButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engengButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.engengButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(172)))));
            this.engengButton.Location = new System.Drawing.Point(15, 55);
            this.engengButton.Name = "engengButton";
            this.engengButton.Size = new System.Drawing.Size(220, 40);
            this.engengButton.TabIndex = 5;
            this.engengButton.Text = "   English - English";
            this.engengButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.engengButton.UseVisualStyleBackColor = false;
            this.engengButton.MouseEnter += new System.EventHandler(this.OptionLabelGetsFocused);
            this.engengButton.MouseLeave += new System.EventHandler(this.OptionLabelLosesFocused);
            // 
            // dictionariesOptionBorder
            // 
            this.dictionariesOptionBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.dictionariesOptionBorder.Controls.Add(this.dictionariesOptions);
            this.dictionariesOptionBorder.Location = new System.Drawing.Point(12, 94);
            this.dictionariesOptionBorder.Name = "dictionariesOptionBorder";
            this.dictionariesOptionBorder.Size = new System.Drawing.Size(252, 151);
            this.dictionariesOptionBorder.TabIndex = 3;
            this.dictionariesOptionBorder.Visible = false;
            this.dictionariesOptionBorder.MouseLeave += new System.EventHandler(this.LeaveOptionPanel);
            // 
            // ButtonBarBorder
            // 
            this.ButtonBarBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBarBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ButtonBarBorder.Controls.Add(this.panel1);
            this.ButtonBarBorder.Location = new System.Drawing.Point(0, 48);
            this.ButtonBarBorder.Name = "ButtonBarBorder";
            this.ButtonBarBorder.Size = new System.Drawing.Size(904, 50);
            this.ButtonBarBorder.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel5.Location = new System.Drawing.Point(775, 169);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 48);
            this.panel5.TabIndex = 7;
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(69)))), ((int)(((byte)(144)))));
            this.SearchBar.Controls.Add(this.GoButton);
            this.SearchBar.Controls.Add(this.SearchInputBorder);
            this.SearchBar.Controls.Add(this.TypeSelectionButton);
            this.SearchBar.Location = new System.Drawing.Point(0, 99);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(904, 68);
            this.SearchBar.TabIndex = 8;
            // 
            // GoButton
            // 
            this.GoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.GoButton.FlatAppearance.BorderSize = 0;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoButton.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GoButton.Location = new System.Drawing.Point(663, 10);
            this.GoButton.Name = "GoButton";
            this.GoButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.GoButton.Size = new System.Drawing.Size(48, 48);
            this.GoButton.TabIndex = 11;
            this.GoButton.Text = "Go";
            this.GoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Click += new System.EventHandler(this.ClickAtGoButton);
            // 
            // SearchInputBorder
            // 
            this.SearchInputBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SearchInputBorder.Controls.Add(this.SearchInputArea);
            this.SearchInputBorder.Location = new System.Drawing.Point(275, 10);
            this.SearchInputBorder.Name = "SearchInputBorder";
            this.SearchInputBorder.Size = new System.Drawing.Size(390, 48);
            this.SearchInputBorder.TabIndex = 10;
            // 
            // SearchInputArea
            // 
            this.SearchInputArea.BackColor = System.Drawing.Color.White;
            this.SearchInputArea.Controls.Add(this.SearchInput);
            this.SearchInputArea.Location = new System.Drawing.Point(1, 1);
            this.SearchInputArea.Name = "SearchInputArea";
            this.SearchInputArea.Size = new System.Drawing.Size(388, 46);
            this.SearchInputArea.TabIndex = 11;
            this.SearchInputArea.Click += new System.EventHandler(this.ClickAtSearchArea);
            // 
            // SearchInput
            // 
            this.SearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchInput.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SearchInput.Location = new System.Drawing.Point(18, 14);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(327, 20);
            this.SearchInput.TabIndex = 10;
            this.SearchInput.Text = "Search";
            this.SearchInput.Click += new System.EventHandler(this.ClickAtSearchArea);
            // 
            // TypeSelectionButton
            // 
            this.TypeSelectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.TypeSelectionButton.FlatAppearance.BorderSize = 0;
            this.TypeSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeSelectionButton.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeSelectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TypeSelectionButton.Location = new System.Drawing.Point(55, 10);
            this.TypeSelectionButton.Name = "TypeSelectionButton";
            this.TypeSelectionButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.TypeSelectionButton.Size = new System.Drawing.Size(220, 48);
            this.TypeSelectionButton.TabIndex = 9;
            this.TypeSelectionButton.Text = "English - English ...";
            this.TypeSelectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TypeSelectionButton.UseVisualStyleBackColor = false;
            this.TypeSelectionButton.Click += new System.EventHandler(this.OpenTypePanel);
            this.TypeSelectionButton.MouseLeave += new System.EventHandler(this.LeaveTypeSelectionButton);
            // 
            // TypePanel
            // 
            this.TypePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(159)))));
            this.TypePanel.Controls.Add(this.engVietTypeButton);
            this.TypePanel.Controls.Add(this.engEngTypeButton);
            this.TypePanel.Location = new System.Drawing.Point(2, 0);
            this.TypePanel.Name = "TypePanel";
            this.TypePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.TypePanel.Size = new System.Drawing.Size(216, 120);
            this.TypePanel.TabIndex = 9;
            // 
            // engVietTypeButton
            // 
            this.engVietTypeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(159)))));
            this.engVietTypeButton.FlatAppearance.BorderSize = 0;
            this.engVietTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engVietTypeButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.engVietTypeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.engVietTypeButton.Location = new System.Drawing.Point(10, 59);
            this.engVietTypeButton.Name = "engVietTypeButton";
            this.engVietTypeButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.engVietTypeButton.Size = new System.Drawing.Size(204, 48);
            this.engVietTypeButton.TabIndex = 1;
            this.engVietTypeButton.Text = "English - Vietnamese";
            this.engVietTypeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.engVietTypeButton.UseVisualStyleBackColor = false;
            this.engVietTypeButton.Click += new System.EventHandler(this.ChooseType);
            // 
            // engEngTypeButton
            // 
            this.engEngTypeButton.FlatAppearance.BorderSize = 0;
            this.engEngTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engEngTypeButton.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.engEngTypeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.engEngTypeButton.Location = new System.Drawing.Point(10, 10);
            this.engEngTypeButton.Name = "engEngTypeButton";
            this.engEngTypeButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.engEngTypeButton.Size = new System.Drawing.Size(204, 48);
            this.engEngTypeButton.TabIndex = 0;
            this.engEngTypeButton.Text = "English - English";
            this.engEngTypeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.engEngTypeButton.UseVisualStyleBackColor = true;
            this.engEngTypeButton.Click += new System.EventHandler(this.ChooseType);
            // 
            // TypePanelBorder
            // 
            this.TypePanelBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(234)))), ((int)(((byte)(118)))));
            this.TypePanelBorder.Controls.Add(this.TypePanel);
            this.TypePanelBorder.Location = new System.Drawing.Point(572, 173);
            this.TypePanelBorder.Name = "TypePanelBorder";
            this.TypePanelBorder.Size = new System.Drawing.Size(220, 122);
            this.TypePanelBorder.TabIndex = 10;
            this.TypePanelBorder.Visible = false;
            this.TypePanelBorder.MouseLeave += new System.EventHandler(this.LeaveTypePanel);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.WordHeader);
            this.panel6.Location = new System.Drawing.Point(11, 251);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(648, 353);
            this.panel6.TabIndex = 11;
            // 
            // WordHeader
            // 
            this.WordHeader.Controls.Add(this.WordFormBar);
            this.WordHeader.Controls.Add(this.WordFormPanel);
            this.WordHeader.Controls.Add(this.NAPron);
            this.WordHeader.Controls.Add(this.BEPron);
            this.WordHeader.Controls.Add(this.NAButton);
            this.WordHeader.Controls.Add(this.BEButton);
            this.WordHeader.Controls.Add(this.WordLevel);
            this.WordHeader.Controls.Add(this.WordType);
            this.WordHeader.Controls.Add(this.Word);
            this.WordHeader.Location = new System.Drawing.Point(0, 16);
            this.WordHeader.Name = "WordHeader";
            this.WordHeader.Size = new System.Drawing.Size(648, 337);
            this.WordHeader.TabIndex = 0;
            // 
            // WordFormBar
            // 
            this.WordFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(164)))));
            this.WordFormBar.Controls.Add(this.WordForm);
            this.WordFormBar.Controls.Add(this.WordFormSign);
            this.WordFormBar.Location = new System.Drawing.Point(0, 177);
            this.WordFormBar.Name = "WordFormBar";
            this.WordFormBar.Size = new System.Drawing.Size(648, 41);
            this.WordFormBar.TabIndex = 7;
            // 
            // WordForm
            // 
            this.WordForm.AutoSize = true;
            this.WordForm.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordForm.ForeColor = System.Drawing.Color.Black;
            this.WordForm.Location = new System.Drawing.Point(49, 12);
            this.WordForm.Name = "WordForm";
            this.WordForm.Size = new System.Drawing.Size(85, 19);
            this.WordForm.TabIndex = 1;
            this.WordForm.Text = "Verb forms";
            // 
            // WordFormSign
            // 
            this.WordFormSign.AutoSize = true;
            this.WordFormSign.Cursor = System.Windows.Forms.Cursors.Default;
            this.WordFormSign.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WordFormSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(81)))));
            this.WordFormSign.Location = new System.Drawing.Point(16, 7);
            this.WordFormSign.Name = "WordFormSign";
            this.WordFormSign.Size = new System.Drawing.Size(27, 24);
            this.WordFormSign.TabIndex = 0;
            this.WordFormSign.Text = "+";
            // 
            // WordFormPanel
            // 
            this.WordFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.WordFormPanel.Controls.Add(this.NAPronSmall);
            this.WordFormPanel.Controls.Add(this.NAButtonSmall);
            this.WordFormPanel.Controls.Add(this.BEPronSmall);
            this.WordFormPanel.Controls.Add(this.FormedWord);
            this.WordFormPanel.Controls.Add(this.BEButtonSmall);
            this.WordFormPanel.Controls.Add(this.SubjectOfForm);
            this.WordFormPanel.Controls.Add(this.Form);
            this.WordFormPanel.ForeColor = System.Drawing.Color.Black;
            this.WordFormPanel.Location = new System.Drawing.Point(0, 224);
            this.WordFormPanel.Name = "WordFormPanel";
            this.WordFormPanel.Size = new System.Drawing.Size(648, 100);
            this.WordFormPanel.TabIndex = 7;
            // 
            // NAPronSmall
            // 
            this.NAPronSmall.AutoSize = true;
            this.NAPronSmall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NAPronSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.NAPronSmall.Location = new System.Drawing.Point(304, 61);
            this.NAPronSmall.Name = "NAPronSmall";
            this.NAPronSmall.Size = new System.Drawing.Size(56, 19);
            this.NAPronSmall.TabIndex = 11;
            this.NAPronSmall.Text = "label10";
            // 
            // NAButtonSmall
            // 
            this.NAButtonSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.NAButtonSmall.FlatAppearance.BorderSize = 0;
            this.NAButtonSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAButtonSmall.Font = new System.Drawing.Font("Times New Roman", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NAButtonSmall.ForeColor = System.Drawing.Color.White;
            this.NAButtonSmall.Location = new System.Drawing.Point(277, 57);
            this.NAButtonSmall.Name = "NAButtonSmall";
            this.NAButtonSmall.Size = new System.Drawing.Size(25, 25);
            this.NAButtonSmall.TabIndex = 10;
            this.NAButtonSmall.Text = "BrE";
            this.NAButtonSmall.UseVisualStyleBackColor = false;
            // 
            // BEPronSmall
            // 
            this.BEPronSmall.AutoSize = true;
            this.BEPronSmall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BEPronSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.BEPronSmall.Location = new System.Drawing.Point(162, 57);
            this.BEPronSmall.Name = "BEPronSmall";
            this.BEPronSmall.Size = new System.Drawing.Size(48, 19);
            this.BEPronSmall.TabIndex = 9;
            this.BEPronSmall.Text = "label9";
            // 
            // FormedWord
            // 
            this.FormedWord.AutoSize = true;
            this.FormedWord.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormedWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.FormedWord.Location = new System.Drawing.Point(265, 20);
            this.FormedWord.Name = "FormedWord";
            this.FormedWord.Size = new System.Drawing.Size(37, 20);
            this.FormedWord.TabIndex = 2;
            this.FormedWord.Text = "like";
            // 
            // BEButtonSmall
            // 
            this.BEButtonSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.BEButtonSmall.FlatAppearance.BorderSize = 0;
            this.BEButtonSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEButtonSmall.Font = new System.Drawing.Font("Times New Roman", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BEButtonSmall.ForeColor = System.Drawing.Color.White;
            this.BEButtonSmall.Location = new System.Drawing.Point(135, 53);
            this.BEButtonSmall.Name = "BEButtonSmall";
            this.BEButtonSmall.Size = new System.Drawing.Size(25, 25);
            this.BEButtonSmall.TabIndex = 8;
            this.BEButtonSmall.Text = "BrE";
            this.BEButtonSmall.UseVisualStyleBackColor = false;
            // 
            // SubjectOfForm
            // 
            this.SubjectOfForm.AutoSize = true;
            this.SubjectOfForm.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubjectOfForm.Location = new System.Drawing.Point(135, 21);
            this.SubjectOfForm.Name = "SubjectOfForm";
            this.SubjectOfForm.Size = new System.Drawing.Size(130, 19);
            this.SubjectOfForm.TabIndex = 1;
            this.SubjectOfForm.Text = " I / you / we / they";
            // 
            // Form
            // 
            this.Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(81)))));
            this.Form.FlatAppearance.BorderSize = 0;
            this.Form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Form.ForeColor = System.Drawing.Color.White;
            this.Form.Location = new System.Drawing.Point(0, 15);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(120, 25);
            this.Form.TabIndex = 0;
            this.Form.Text = "past participle";
            this.Form.UseVisualStyleBackColor = false;
            // 
            // NAPron
            // 
            this.NAPron.AutoSize = true;
            this.NAPron.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NAPron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.NAPron.Location = new System.Drawing.Point(36, 127);
            this.NAPron.Name = "NAPron";
            this.NAPron.Size = new System.Drawing.Size(61, 25);
            this.NAPron.TabIndex = 6;
            this.NAPron.Text = "label4";
            // 
            // BEPron
            // 
            this.BEPron.AutoSize = true;
            this.BEPron.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BEPron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.BEPron.Location = new System.Drawing.Point(36, 92);
            this.BEPron.Name = "BEPron";
            this.BEPron.Size = new System.Drawing.Size(61, 25);
            this.BEPron.TabIndex = 5;
            this.BEPron.Text = "label3";
            // 
            // NAButton
            // 
            this.NAButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.NAButton.FlatAppearance.BorderSize = 0;
            this.NAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAButton.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NAButton.ForeColor = System.Drawing.Color.White;
            this.NAButton.Location = new System.Drawing.Point(0, 126);
            this.NAButton.Name = "NAButton";
            this.NAButton.Size = new System.Drawing.Size(30, 30);
            this.NAButton.TabIndex = 4;
            this.NAButton.Text = "NAE";
            this.NAButton.UseVisualStyleBackColor = false;
            // 
            // BEButton
            // 
            this.BEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.BEButton.FlatAppearance.BorderSize = 0;
            this.BEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEButton.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BEButton.ForeColor = System.Drawing.Color.White;
            this.BEButton.Location = new System.Drawing.Point(0, 90);
            this.BEButton.Name = "BEButton";
            this.BEButton.Size = new System.Drawing.Size(30, 30);
            this.BEButton.TabIndex = 3;
            this.BEButton.Text = "BrE";
            this.BEButton.UseVisualStyleBackColor = false;
            // 
            // WordLevel
            // 
            this.WordLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.WordLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WordLevel.BorderColor = System.Drawing.Color.Transparent;
            this.WordLevel.BorderRadius = 20;
            this.WordLevel.BorderSize = 0;
            this.WordLevel.FlatAppearance.BorderSize = 0;
            this.WordLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WordLevel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WordLevel.ForeColor = System.Drawing.Color.White;
            this.WordLevel.Location = new System.Drawing.Point(0, 46);
            this.WordLevel.Name = "WordLevel";
            this.WordLevel.Size = new System.Drawing.Size(53, 30);
            this.WordLevel.TabIndex = 2;
            this.WordLevel.Text = "A1";
            this.WordLevel.TextColor = System.Drawing.Color.White;
            this.WordLevel.UseVisualStyleBackColor = false;
            // 
            // WordType
            // 
            this.WordType.AutoSize = true;
            this.WordType.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WordType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.WordType.Location = new System.Drawing.Point(106, 11);
            this.WordType.Name = "WordType";
            this.WordType.Size = new System.Drawing.Size(72, 26);
            this.WordType.TabIndex = 1;
            this.WordType.Text = "label2";
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.Word.Location = new System.Drawing.Point(0, 0);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(103, 38);
            this.Word.TabIndex = 0;
            this.Word.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 749);
            this.Controls.Add(this.defintionHeader1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TypePanelBorder);
            this.Controls.Add(this.dictionariesOptionBorder);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ButtonBarBorder);
            this.Controls.Add(this.topBar);
            this.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.rightTopBarPanel.ResumeLayout(false);
            this.appNamePanel.ResumeLayout(false);
            this.appNamePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.RightBorderOfDictionaries.ResumeLayout(false);
            this.dictionariesOptions.ResumeLayout(false);
            this.dictionariesOptionBorder.ResumeLayout(false);
            this.ButtonBarBorder.ResumeLayout(false);
            this.SearchBar.ResumeLayout(false);
            this.SearchInputBorder.ResumeLayout(false);
            this.SearchInputArea.ResumeLayout(false);
            this.SearchInputArea.PerformLayout();
            this.TypePanel.ResumeLayout(false);
            this.TypePanelBorder.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.WordHeader.ResumeLayout(false);
            this.WordHeader.PerformLayout();
            this.WordFormBar.ResumeLayout(false);
            this.WordFormBar.PerformLayout();
            this.WordFormPanel.ResumeLayout(false);
            this.WordFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Panel appNamePanel;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Panel rightTopBarPanel;
        private CustomControls.RoundButton signOutButton;
        private CustomControls.RoundButton helpButton;
        private CustomControls.RoundButton avatarButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dictionariesOptions;
        private System.Windows.Forms.Button DictionariesButton;
        private System.Windows.Forms.Button engVietButton;
        private System.Windows.Forms.Button DictionariesHomeButton;
        private System.Windows.Forms.Button engengButton;
        private System.Windows.Forms.Panel dictionariesOptionBorder;
        private System.Windows.Forms.Panel ButtonBarBorder;
        private System.Windows.Forms.Panel RightBorderOfDictionaries;
        private System.Windows.Forms.Button PicturesButton;
        private System.Windows.Forms.Button ReviewButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel SearchBar;
        private System.Windows.Forms.Button TypeSelectionButton;
        private System.Windows.Forms.Panel TypePanel;
        private System.Windows.Forms.Button engVietTypeButton;
        private System.Windows.Forms.Button engEngTypeButton;
        private System.Windows.Forms.Panel TypePanelBorder;
        private System.Windows.Forms.Panel SearchInputBorder;
        private System.Windows.Forms.Panel SearchInputArea;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel WordHeader;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Panel WordFormPanel;
        private System.Windows.Forms.Button Form;
        private System.Windows.Forms.Label NAPron;
        private System.Windows.Forms.Label BEPron;
        private System.Windows.Forms.Button NAButton;
        private System.Windows.Forms.Button BEButton;
        private CustomControls.RoundButton WordLevel;
        private System.Windows.Forms.Label WordType;
        private System.Windows.Forms.Panel WordFormBar;
        private System.Windows.Forms.Label WordForm;
        private System.Windows.Forms.Label WordFormSign;
        private System.Windows.Forms.Label NAPronSmall;
        private System.Windows.Forms.Button NAButtonSmall;
        private System.Windows.Forms.Label BEPronSmall;
        private System.Windows.Forms.Label FormedWord;
        private System.Windows.Forms.Button BEButtonSmall;
        private System.Windows.Forms.Label SubjectOfForm;
        private CustomControls.DefintionHeader defintionHeader1;
    }
}

