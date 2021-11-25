
using DictionaryApp.Classes;

namespace DictionaryApp.CustomControls
{
    partial class WordDefinition
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Word word)
        {
            this.components = new System.ComponentModel.Container();
            this.defintionHeader1 = new DictionaryApp.CustomControls.DefintionHeader(this.components, word.wordHeader);
            this.SuspendLayout();
            // 
            // defintionHeader1
            // 
            this.defintionHeader1.BackColor = System.Drawing.Color.White;
            this.defintionHeader1.Location = new System.Drawing.Point(0, 0);
            this.defintionHeader1.Name = "defintionHeader1";
            this.defintionHeader1.Size = new System.Drawing.Size(648, 164);
            this.defintionHeader1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.defintionHeader1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(649, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private DefintionHeader defintionHeader1;
    }
}
