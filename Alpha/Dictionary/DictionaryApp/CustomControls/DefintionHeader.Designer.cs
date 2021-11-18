
using DictionaryApp.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class DefintionHeader : Panel

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label NAPron;
        private System.Windows.Forms.Label BEPron;
        private System.Windows.Forms.Button NAButton;
        private System.Windows.Forms.Button BEButton;
        private DictionaryApp.CustomControls.RoundButton WordLevel;
        private System.Windows.Forms.Label WordType;
        private System.Windows.Forms.Label Word;

        private System.Windows.Forms.Panel WordFormBar;
        private System.Windows.Forms.Label WordForm;
        private System.Windows.Forms.Label WordFormSign;
        private System.Windows.Forms.Panel WordFormPanel;

        private List<Panel> forms;
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(WordHeader header)
        {
            components = new System.ComponentModel.Container();

            this.NAPron = new System.Windows.Forms.Label();
            this.BEPron = new System.Windows.Forms.Label();
            this.NAButton = new System.Windows.Forms.Button();
            this.BEButton = new System.Windows.Forms.Button();
            this.WordLevel = new DictionaryApp.CustomControls.RoundButton();
            this.WordType = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();

            this.WordFormBar = new System.Windows.Forms.Panel();
            this.WordForm = new System.Windows.Forms.Label();
            this.WordFormSign = new System.Windows.Forms.Label();
            this.WordFormPanel = new System.Windows.Forms.Panel();
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            
            this.Word.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.Word.Location = new System.Drawing.Point(0, 4);
            this.Word.Name = "Word";
            this.Word.TabIndex = 0;
            this.Word.Text = header.word;
            this.Word.AutoSize = true;
            
            // 
            // WordType
            // 
            
            this.WordType.AutoSize = true;
            this.WordType.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WordType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.WordType.Location = new System.Drawing.Point(TextRenderer.MeasureText(this.Word.Text,
                new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)).Width, 12);
           
            this.WordType.Name = "WordType";
            this.WordType.Size = new System.Drawing.Size(300, 26);
            this.WordType.TabIndex = 1;
            this.WordType.Text = header.type;
            this.WordType.AutoSize = true;
            if (header.type == "")
            {
                this.WordType.Size = new System.Drawing.Size(0, 0);

            }

            if (header.level != "")
            {
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
                this.WordLevel.Location = new System.Drawing.Point(0, this.WordType.Size.Height + this.WordType.Location.Y+8);
                this.WordLevel.Name = "WordLevel";
                this.WordLevel.Size = new System.Drawing.Size(53, 30);
                this.WordLevel.TabIndex = 2;
                this.WordLevel.Text = header.level;
                this.WordLevel.TextColor = System.Drawing.Color.White;
                this.WordLevel.UseVisualStyleBackColor = false;
            }

            // 
            // BEPron
            // 
            if (header.br != "")
            {// 
                // BEButton
                // 
                this.BEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                this.BEButton.FlatAppearance.BorderSize = 0;
                this.BEButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.BEButton.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.BEButton.ForeColor = System.Drawing.Color.White;
                if (header.level != "")
                {
                    this.BEButton.Location = new System.Drawing.Point(0,
                       this.WordLevel.Size.Height + this.WordLevel.Location.Y + 14);
                }
                else
                {
                    this.BEButton.Location = new System.Drawing.Point(0,
                       this.Word.Size.Height + this.Word.Location.Y + 18);
                }
                this.BEButton.Name = "BEButton";
                this.BEButton.Size = new System.Drawing.Size(30, 30);
                this.BEButton.TabIndex = 3;
                this.BEButton.Text = "BrE";
                this.BEButton.UseVisualStyleBackColor = false;

                this.BEPron.AutoSize = true;
                this.BEPron.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                this.BEPron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                this.BEPron.Location = new System.Drawing.Point(36, this.BEButton.Location.Y + 2);
                this.BEPron.Name = "BEPron";
                this.BEPron.Size = new System.Drawing.Size(61, 25);
                this.BEPron.TabIndex = 5;
                this.BEPron.Text = header.br;

            }

            if (header.na != "")
            {// 
                // NAButton
                // 
                this.NAButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
                this.NAButton.FlatAppearance.BorderSize = 0;
                this.NAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.NAButton.Font = new System.Drawing.Font("Times New Roman", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                this.NAButton.ForeColor = System.Drawing.Color.White;
                this.NAButton.Location = new System.Drawing.Point(0,
                        this.BEButton.Size.Height + this.BEButton.Location.Y + 6);
                this.NAButton.Name = "NAButton";
                this.NAButton.Size = new System.Drawing.Size(30, 30);
                this.NAButton.TabIndex = 4;
                this.NAButton.Text = "NAE";
                this.NAButton.UseVisualStyleBackColor = false;

                this.NAPron.AutoSize = true;
                this.NAPron.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
                this.NAPron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                this.NAPron.Location = new System.Drawing.Point(36, this.NAButton.Location.Y + 2);
                this.NAPron.Name = "NAPron";
                this.NAPron.Size = new System.Drawing.Size(61, 25);
                this.NAPron.TabIndex = 6;
                this.NAPron.Text = header.na;

            }
            if (header.wordForms.Count != 0)
            {
                // 
                // WordFormBar
                // 
                this.WordFormBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(185)))), ((int)(((byte)(164)))));
                this.WordFormBar.Controls.Add(this.WordForm);
                this.WordFormBar.Controls.Add(this.WordFormSign);
                this.WordFormBar.Location = new System.Drawing.Point(0, this.NAButton.Location.Y + this.NAButton.Height+15);
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
                this.WordForm.Text = "Word forms";
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
                this.WordFormSign.Click += new System.EventHandler(this.ToggleWordFormPanel);
                // 
                // WordFormPanel
                // 
                List<Panel> fs = new List<Panel>();
                foreach(WordForm fms in header.wordForms)
                {
                    Panel formPanel = new System.Windows.Forms.Panel();
                    int ind = header.wordForms.IndexOf(fms);



                    System.Windows.Forms.Label nAPronSmall = new Label();
                    System.Windows.Forms.Button nAButtonSmall = new Button();
                    System.Windows.Forms.Label bEPronSmall= new Label();
                    System.Windows.Forms.Label formedWord= new Label();
                    System.Windows.Forms.Button bEButtonSmall = new Button();
                    System.Windows.Forms.Label subjectOfForm= new Label();
                    System.Windows.Forms.Button form = new Button();


                    // 
                    // NAPronSmall
                    // 
                    nAPronSmall.AutoSize = true;
                    nAPronSmall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
                    nAPronSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                    nAPronSmall.Location = new System.Drawing.Point(304, 42);
                    nAPronSmall.Name = "NAPronSmall";
                    nAPronSmall.Size = new System.Drawing.Size(56, 19);
                    nAPronSmall.TabIndex = 11;
                    nAPronSmall.Text = fms.na;
                    // 
                    // NAButtonSmall
                    // 
                    nAButtonSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
                    nAButtonSmall.FlatAppearance.BorderSize = 0;
                    nAButtonSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    nAButtonSmall.Font = new System.Drawing.Font("Times New Roman", 5F, System.Drawing.FontStyle.Bold);
                    nAButtonSmall.ForeColor = System.Drawing.Color.White;
                    nAButtonSmall.Location = new System.Drawing.Point(277, 38);
                    nAButtonSmall.Name = "NAButtonSmall";
                    nAButtonSmall.Size = new System.Drawing.Size(25, 25);
                    nAButtonSmall.TabIndex = 10;
                    nAButtonSmall.Text = "BrE";
                    nAButtonSmall.UseVisualStyleBackColor = false;
                    // 
                    // BEPronSmall
                    // 
                    bEPronSmall.AutoSize = true;
                    bEPronSmall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
                    bEPronSmall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                    bEPronSmall.Location = new System.Drawing.Point(162, 42);
                    bEPronSmall.Name = "BEPronSmall";
                    bEPronSmall.Size = new System.Drawing.Size(48, 19);
                    bEPronSmall.TabIndex = 9;
                    bEPronSmall.Text = fms.br;
                    // 
                    // FormedWord
                    // 
                    formedWord.AutoSize = true;
                    formedWord.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
                    formedWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                    formedWord.Location = new System.Drawing.Point(265, 5);
                    formedWord.Name = "FormedWord";
                    formedWord.Size = new System.Drawing.Size(37, 20);
                    formedWord.TabIndex = 2;
                    formedWord.Text = fms.form;
                    // 
                    // BEButtonSmall
                    // 
                    bEButtonSmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                    bEButtonSmall.FlatAppearance.BorderSize = 0;
                    bEButtonSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    bEButtonSmall.Font = new System.Drawing.Font("Times New Roman", 5F, System.Drawing.FontStyle.Bold);
                    bEButtonSmall.ForeColor = System.Drawing.Color.White;
                    bEButtonSmall.Location = new System.Drawing.Point(135, 38);
                    bEButtonSmall.Name = "BEButtonSmall";
                    bEButtonSmall.Size = new System.Drawing.Size(25, 25);
                    bEButtonSmall.TabIndex = 8;
                    bEButtonSmall.Text = "BrE";
                    bEButtonSmall.UseVisualStyleBackColor = false;
                    // 
                    // SubjectOfForm
                    // 
                    subjectOfForm.AutoSize = true;
                    subjectOfForm.Font = new System.Drawing.Font("Times New Roman", 12.75F);
                    subjectOfForm.Location = new System.Drawing.Point(135, 6);
                    subjectOfForm.Name = "SubjectOfForm";
                    subjectOfForm.Size = new System.Drawing.Size(130, 19);
                    subjectOfForm.TabIndex = 1;
                    subjectOfForm.Text = fms.sub;
                    // 
                    // Form
                    // 
                    form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(91)))), ((int)(((byte)(81)))));
                    form.FlatAppearance.BorderSize = 0;
                    form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    form.Font = new System.Drawing.Font("Times New Roman", 10F);
                    form.ForeColor = System.Drawing.Color.White;
                    form.Location = new System.Drawing.Point(0, 0);
                    form.Name = "Form";
                    form.Size = new System.Drawing.Size(120, 25);
                    form.TabIndex = 0;
                    form.Text = fms.tense;
                    form.UseVisualStyleBackColor = false;

                    formPanel.Controls.Add(formedWord);
                    formPanel.Controls.Add(nAPronSmall);
                    formPanel.Controls.Add(form);
                    formPanel.Controls.Add(nAButtonSmall);
                    formPanel.Controls.Add(subjectOfForm);
                    formPanel.Controls.Add(bEPronSmall);
                    formPanel.Controls.Add(bEButtonSmall);
                    formPanel.Location = new System.Drawing.Point(0, 15 + ind*72);
                    formPanel.Name = "FormPanel"+ind;
                    formPanel.Size = new System.Drawing.Size(648, 67);
                    formPanel.TabIndex = 12;
                    this.WordFormPanel.Controls.Add(formPanel);
                }
                this.WordFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
                this.WordFormPanel.ForeColor = System.Drawing.Color.Black;
                this.WordFormPanel.Location = new System.Drawing.Point(0, this.WordFormBar.Height+this.WordFormBar.Location.Y);
                this.WordFormPanel.Name = "WordFormPanel";
                this.WordFormPanel.Size = new System.Drawing.Size(648, 100);
                this.WordFormPanel.TabIndex = 7;
                this.WordFormPanel.AutoSize = true;
                this.WordFormPanel.MaximumSize = new Size(648, 0);

            }


            this.Controls.Add(this.Word);
/*            this.Controls.Add(this.WordLevel);
*/            this.Controls.Add(this.WordType);
            this.Controls.Add(this.BEButton);
            this.Controls.Add(this.BEPron);
            this.Controls.Add(this.NAButton);
            this.Controls.Add(this.NAPron);
            this.Controls.Add(this.WordFormBar);
            this.Controls.Add(this.WordFormPanel);
            /*foreach(Panel wf in forms)
            {
                this.Controls.Add(wf);
            }*/
            this.BackColor = Color.White;
            if (header.wordForms.Count != 0)
            {
                this.Size = new System.Drawing.Size(648, this.WordFormPanel.Location.Y + this.WordFormPanel.Size.Height + 100);
            }
            else
            {
                this.Size = new System.Drawing.Size(648, this.NAButton.Location.Y + this.NAButton.Size.Height + 8);

            }
            this.AutoSize = true;
            this.MaximumSize = new System.Drawing.Size(460, 0);

        }

        #endregion
    }
}
