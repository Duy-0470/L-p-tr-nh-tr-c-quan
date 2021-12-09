
using DictionaryApp.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class IdiomHeaderPanel : Panel

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private DictionaryApp.CustomControls.RoundButton WordLevel;
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
        private void InitializeComponent(IdiomHeader header)
        {
            components = new System.ComponentModel.Container();

            this.WordLevel = new DictionaryApp.CustomControls.RoundButton();
            this.WordType = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();

            // 
            // Word
            // 
            this.Word.AutoSize = true;
            
            this.Word.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
            this.Word.Location = new System.Drawing.Point(0, 4);
            this.Word.Name = "Word";
            this.Word.TabIndex = 0;
            this.Word.Text = header.phrase;
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
            if (header.type != "NA")
            {
                this.WordType.Text = header.type;

            }
            this.WordType.AutoSize = true;
            if (header.type == "")
            {
                this.WordType.Size = new System.Drawing.Size(0, 0);

            }

            this.Controls.Add(this.Word);
/*            this.Controls.Add(this.WordLevel);
*/            this.Controls.Add(this.WordType);


            /*foreach(Panel wf in forms)
            {
                this.Controls.Add(wf);
            }*/
            this.BackColor = Color.White;
            
            this.AutoSize = true;
            this.MaximumSize = new System.Drawing.Size(460, 0);

        }

        #endregion
    }
}
