
using DictionaryApp.Database;
using System.Drawing;

namespace DictionaryApp.CustomControls
{
    partial class Topics
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

        private void InitializeComponent()
        {
            this.otherResultsPanel = new DictionaryApp.CustomControls.TopicsSelectionPanel();
            this.wordsPanel = new DictionaryApp.CustomControls.TopicWordsSelectionPanel();
            this.SuspendLayout();
            // 
            // otherResultsPanel
            // 
            this.otherResultsPanel.BackColor = System.Drawing.Color.White;
            this.otherResultsPanel.Location = new System.Drawing.Point(0, 3);
            this.otherResultsPanel.Name = "otherResultsPanel";
            this.otherResultsPanel.Size = new System.Drawing.Size(200, 500);
            this.otherResultsPanel.TabIndex = 0;
            // 
            // wordDefinition
            // 
            if (w != null)
            {
                this.wordDefinition = new DictionaryApp.CustomControls.WordDefinition(w);
                this.wordDefinition.AutoSize = true;
                this.wordDefinition.BackColor = System.Drawing.Color.White;
                this.wordDefinition.Location = new System.Drawing.Point(230, 0);
                this.wordDefinition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                this.wordDefinition.MaximumSize = new System.Drawing.Size(648, 0);
                this.wordDefinition.Name = "wordDefinition";
                this.wordDefinition.Size = new System.Drawing.Size(500, 1466);
                this.wordDefinition.MaximumSize = new System.Drawing.Size(500, 0);
                this.wordDefinition.TabIndex = 11;
                this.Controls.Add(this.wordDefinition);

            }
            else
            {
                this.text = new System.Windows.Forms.TextBox();
                this.text.BackColor = System.Drawing.Color.White;
                this.text.Location = new System.Drawing.Point(230, 80);
                this.text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
                this.text.Name = "wordDefinition";
                this.text.Size = new System.Drawing.Size(500, 200);
                this.text.AutoSize = false;
                this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.text.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.text.TabIndex = 11;
                this.text.Text = "Please, select word";
                this.text.ForeColor = Color.FromArgb(150, 150, 150);
                this.Controls.Add(this.text);
            }
            this.wordsPanel.BackColor = System.Drawing.Color.White;
            this.wordsPanel.Location = new System.Drawing.Point(730, 3);
            this.wordsPanel.Name = "otherResultsPanel";
            this.wordsPanel.Size = new System.Drawing.Size(200, 500);
            this.wordsPanel.TabIndex = 0;
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
            this.Controls.Add(this.wordsPanel);
            this.Name = "WordResultPanel";
            this.Size = new System.Drawing.Size(931, 1469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TopicsSelectionPanel otherResultsPanel;
        private TopicWordsSelectionPanel wordsPanel;
        private WordDefinition wordDefinition;
        private System.Windows.Forms.TextBox text;
    }
}
