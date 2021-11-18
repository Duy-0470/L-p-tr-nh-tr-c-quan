
using Dictionary.Classes;
using System.Drawing;

namespace Dictionary.CustomControls
{
    partial class DefintionHeader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label NAPron;
        private System.Windows.Forms.Label BEPron;
        private System.Windows.Forms.Button NAButton;
        private System.Windows.Forms.Button BEButton;
        private CustomControls.RoundButton WordLevel;
        private System.Windows.Forms.Label WordType;
        private System.Windows.Forms.Label Word;
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
            this.WordLevel = new Dictionary.CustomControls.RoundButton();
            this.WordType = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();

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
            this.Word.Text = header.word;
            this.Word.AutoSize = true;
            // 
            // WordType
            // 
            this.WordType.AutoSize = true;
            this.WordType.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.WordType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.WordType.Location = new System.Drawing.Point(this.Word.Size.Width, 11);
            this.WordType.Name = "WordType";
            this.WordType.Size = new System.Drawing.Size(300, 26);
            this.WordType.TabIndex = 1;
            this.WordType.Text = header.type;
            this.WordType.AutoSize = true;


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
                this.WordLevel.Location = new System.Drawing.Point(0, this.Word.Size.Height+8);
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
                       this.Word.Size.Height + this.Word.Location.Y + 8);
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
                this.NAPron.Text =header.na;
                
            }

            this.Controls.Add(this.Word);
            this.Controls.Add(this.WordLevel);
            this.Controls.Add(this.WordType);
            this.Controls.Add(this.BEButton);
            this.Controls.Add(this.BEPron);
            this.Controls.Add(this.NAButton);
            this.Controls.Add(this.NAPron);
            this.BackColor = Color.White;
            if (header.wordForms.Count != 0) 
            { 
            }
            else
            {
                this.Size = new System.Drawing.Size(648, this.NAButton.Location.Y + this.NAButton.Size.Height + 8);

            }


        }

        #endregion
    }
}
