
using System.Drawing;

namespace DictionaryApp.CustomControls
{
    partial class WordResultPanel
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
        private void InitializeComponent()
        {
            this.otherResultsPanel = new DictionaryApp.CustomControls.OtherResultsPanel();
            this.wordDefinition = new DictionaryApp.CustomControls.WordDefinition();
            this.SuspendLayout();
            // 
            // otherResultsPanel
            // 
            this.otherResultsPanel.BackColor = System.Drawing.Color.White;
            this.otherResultsPanel.Location = new System.Drawing.Point(510, 3);
            this.otherResultsPanel.Name = "otherResultsPanel";
            this.otherResultsPanel.Size = new System.Drawing.Size(270, 500);
            this.otherResultsPanel.TabIndex = 0;
            // 
            // wordDefinition
            // 
            this.wordDefinition.AutoSize = true;
            this.wordDefinition.BackColor = System.Drawing.Color.White;
            this.wordDefinition.Location = new System.Drawing.Point(0, 0);
            this.wordDefinition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wordDefinition.MaximumSize = new System.Drawing.Size(648, 0);
            this.wordDefinition.Name = "wordDefinition";
            this.wordDefinition.Size = new System.Drawing.Size(500, 1466);
            this.wordDefinition.MaximumSize = new System.Drawing.Size(500, 0);
            this.wordDefinition.TabIndex = 11;
            // 
            // WordResultPanel
            // 
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Maximum = 0;
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ScrollPanel);
            this.BackColor = Color.White;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.otherResultsPanel);
            this.Controls.Add(this.wordDefinition);
            this.Name = "WordResultPanel";
            this.Size = new System.Drawing.Size(931, 1469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OtherResultsPanel otherResultsPanel;
        private WordDefinition wordDefinition;

    }
}
