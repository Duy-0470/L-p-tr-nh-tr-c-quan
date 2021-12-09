
using DictionaryApp.Classes;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class IdiomDefinition
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
        private void InitializeComponent(Idiom word)
        {
            this.components = new System.ComponentModel.Container();
            this.defintionHeader1 = new IdiomHeaderPanel(this.components, word.wordHeader);
            this.sensePanel = new Panel();
            this.SuspendLayout();
            // 
            // defintionHeader1
            // 
            this.defintionHeader1.BackColor = System.Drawing.Color.White;
            this.defintionHeader1.Location = new System.Drawing.Point(0, 0);
            this.defintionHeader1.Name = "defintionHeader1";
            this.defintionHeader1.TabIndex = 0;
            this.defintionHeader1.MaximumSize = new System.Drawing.Size(648, 0);

            this.sensePanel.BackColor = System.Drawing.Color.White;
            this.sensePanel.Location = new System.Drawing.Point(0, defintionHeader1.Location.Y+defintionHeader1.PreferredSize.Height+10);
            List<Control> c = new List<Control>();
            Debug.WriteLine(word.senses.Count);
            foreach(Sense sense in word.senses)
            {
                SensePanel s = new SensePanel(word.senses.IndexOf(sense) + 1, sense);
                s.Location = new System.Drawing.Point(0,
                                c.Count == 0 ? 0 :(
                                c[word.senses.IndexOf(sense) - 1].Location.Y +
                                c[word.senses.IndexOf(sense) - 1].PreferredSize.Height -30));
                /*                s.MaximumSize = new System.Drawing.Size(648, 600);
                */
                // s.BackColor = Color.Green;

                s.AutoSize = true;
                c.Add(s);
            }
            for(int i = c.Count - 1; i > -1; i--)
            {
                this.sensePanel.Controls.Add(c[i]);

            }
            this.sensePanel.Name = "rightTopBarPanel";
            this.sensePanel.Size = new System.Drawing.Size(648, 48);
            this.sensePanel.TabIndex = 1;
            this.sensePanel.AutoSize = true;
            // this.sensePanel.BackColor = Color.Pink;
            this.sensePanel.MaximumSize = new System.Drawing.Size(648, 0);
            // 
            // UserControl1
            // 
            this.BackColor = Color.White;
            this.AutoScroll = false;
            this.HorizontalScroll.Enabled = false;
            this.HorizontalScroll.Visible = false;
            this.HorizontalScroll.Maximum = 0;
            this.AutoScroll = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sensePanel);
            this.Controls.Add(this.defintionHeader1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(649, 299);
            this.ResumeLayout(false);

        }

        #endregion

        private IdiomHeaderPanel defintionHeader1;
        private Panel sensePanel;
    }
}
