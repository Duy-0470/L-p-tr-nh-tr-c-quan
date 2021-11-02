
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topBar = new System.Windows.Forms.Panel();
            this.rightTopBarPanel = new System.Windows.Forms.Panel();
            this.avatarButton = new Dictionary.CustomControls.RoundButton();
            this.helpButton = new Dictionary.CustomControls.RoundButton();
            this.signOutButton = new Dictionary.CustomControls.RoundButton();
            this.appNamePanel = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.topBar.SuspendLayout();
            this.rightTopBarPanel.SuspendLayout();
            this.appNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar.BackColor = System.Drawing.Color.White;
            this.topBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.rightTopBarPanel.Location = new System.Drawing.Point(536, 0);
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
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.signOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.appName.Font = new System.Drawing.Font("Verdana", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(118)))), ((int)(((byte)(174)))));
            this.appName.Location = new System.Drawing.Point(0, 11);
            this.appName.Margin = new System.Windows.Forms.Padding(0);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(207, 25);
            this.appName.TabIndex = 0;
            this.appName.Text = "Your Dictionaries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
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
    }
}

