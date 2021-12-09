
using DictionaryApp.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class SensePanel
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
        private void InitializeComponent(int order, Sense sense)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sense));
            this.OrderLabel = new System.Windows.Forms.Label();
            this.TypeHeader = new System.Windows.Forms.Panel();
            this.SenseLevelLabel = new DictionaryApp.CustomControls.RoundButton();
            this.SenseTypeLabel = new System.Windows.Forms.Label();
            this.MeaningLabel = new System.Windows.Forms.Label();
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.TopicPanel = new System.Windows.Forms.Panel();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.Topic = new System.Windows.Forms.Label();
            this.TypeHeader.SuspendLayout();
            this.TopicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(10, 7);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(17, 19);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = Convert.ToString(order);

            if (sense.level != "" || sense.type1 != "" || sense.type2 != "")
            {
                // 
                // TypeHeader
                // 
                this.TypeHeader.Controls.Add(this.SenseTypeLabel);

                this.TypeHeader.Controls.Add(this.SenseLevelLabel);

                this.TypeHeader.Location = new System.Drawing.Point(30, 0);
                this.TypeHeader.Name = "TypeHeader";
                this.TypeHeader.Size = new System.Drawing.Size(429, 32);
                this.TypeHeader.TabIndex = 1;
                if (sense.level != "")
                {
                    // 
                    // SenseLevelLabel
                    // 

                    this.SenseLevelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                    this.SenseLevelLabel.BorderColor = System.Drawing.Color.Transparent;
                    this.SenseLevelLabel.BorderRadius = 20;
                    this.SenseLevelLabel.BorderSize = 0;
                    this.SenseLevelLabel.FlatAppearance.BorderSize = 0;
                    this.SenseLevelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    this.SenseLevelLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.SenseLevelLabel.ForeColor = System.Drawing.Color.White;
                    this.SenseLevelLabel.Location = new System.Drawing.Point(10, 3);
                    this.SenseLevelLabel.Name = "SenseLevelLabel";
                    this.SenseLevelLabel.Size = new System.Drawing.Size(40, 25);
                    this.SenseLevelLabel.TabIndex = 0;
                    this.SenseLevelLabel.Text = sense.level.ToUpper();
                    this.SenseLevelLabel.TextColor = System.Drawing.Color.White;
                    this.SenseLevelLabel.UseVisualStyleBackColor = false;
                }

               
                // 
                // SenseTypeLabel
                // 
                this.SenseTypeLabel.AutoSize = true;
                this.SenseTypeLabel.BackColor = System.Drawing.Color.White;
                this.SenseTypeLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.SenseTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
                if (sense.level != "")
                {
                    this.SenseTypeLabel.Location = new System.Drawing.Point(this.SenseLevelLabel.Width + 20, 7);
                }
                else
                {
                    this.SenseTypeLabel.Location = new System.Drawing.Point(10, 7);

                }
                this.SenseTypeLabel.Name = "SenseTypeLabel";
                this.SenseTypeLabel.Size = new System.Drawing.Size(48, 19);
                this.SenseTypeLabel.TabIndex = 1;
                this.SenseTypeLabel.Text = sense.type1 + " " + sense.type2;
                this.SenseTypeLabel.FlatStyle = FlatStyle.Flat;
            }
            else
            {
                // 
                // TypeHeader
                // 
                this.TypeHeader.Location = new System.Drawing.Point(30, 0);
                this.TypeHeader.Name = "TypeHeader";
                this.TypeHeader.Size = new System.Drawing.Size(0, 0);
                this.TypeHeader.TabIndex = 1;
            }
            
            // 
            // MeaningLabel
            // 
            this.MeaningLabel.AutoSize = true;
            this.MeaningLabel.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.MeaningLabel.Location = new System.Drawing.Point(40, TypeHeader.Height+TypeHeader.Location.Y);
            this.MeaningLabel.MaximumSize = new System.Drawing.Size(648, 0);
            this.MeaningLabel.Name = "MeaningLabel";
            this.MeaningLabel.Size = new System.Drawing.Size(597, 57);
            this.MeaningLabel.ForeColor = Color.Black;
            this.MeaningLabel.MaximumSize = new System.Drawing.Size(400, 50);

            this.MeaningLabel.TabIndex = 2;
            this.MeaningLabel.Text = sense.meaning;
/*            this.MeaningLabel.Text = resources.GetString("MeaningLabel.Text");
*/
            System.Windows.Forms.Label exampleLabel;
            foreach (Example example in sense.examples)
            {
                int index = sense.examples.IndexOf(example);
                exampleLabel = new System.Windows.Forms.Label();
                // 
                // ExampleLabel
                // 
                exampleLabel.Text = "~   " + example.sentence.Replace('\n', ' ');
                exampleLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                System.Drawing.Size textSize = TextRenderer.MeasureText(exampleLabel.Text, exampleLabel.Font);
                Debug.WriteLine(textSize);
                int extra_y = index == 0 ? MeaningLabel.Location.Y +  MeaningLabel.PreferredHeight/*25*/ : (examples[index - 1].Location.Y + examples[index - 1].PreferredHeight+5);
                exampleLabel.Location = new System.Drawing.Point(60,extra_y);
                exampleLabel.Name = "ExampleLabel"+index;
                exampleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
                exampleLabel.Size = new System.Drawing.Size(380, 50);
                
                exampleLabel.AutoSize = true;
                
                exampleLabel.MaximumSize = new System.Drawing.Size(400, 100);
                // exampleLabel.BackColor = Color.AliceBlue;

                examples.Add(exampleLabel);
            }
            if (sense.topic != "")
            {
                // 
                // TopicPanel
                // 
                this.TopicPanel.Controls.Add(this.Topic);
                this.TopicPanel.Controls.Add(this.TopicLabel);
                if (sense.examples.Count == 0)
                {
                    this.TopicPanel.Location = new System.Drawing.Point(34, 
                        this.MeaningLabel.Location.Y + this.MeaningLabel.Height + 5);
                }
                else
                {
                    this.TopicPanel.Location = new System.Drawing.Point(34,
                        this.examples[this.examples.Count-1].Location.Y + this.examples[this.examples.Count - 1].Height + 5);
                }
                
                this.TopicPanel.Name = "TopicPanel";
                this.TopicPanel.Size = new System.Drawing.Size(600, 32);
                this.TopicPanel.TabIndex = 4;
                // 
                // TopicLabel
                // 
                this.TopicLabel.AutoSize = true;
                this.TopicLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TopicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                this.TopicLabel.Location = new System.Drawing.Point(3, 6);
                this.TopicLabel.Name = "TopicLabel";
                this.TopicLabel.Size = new System.Drawing.Size(45, 19);
                this.TopicLabel.TabIndex = 0;
                this.TopicLabel.Text = "Topic";
                // 
                // Topic
                // 
                this.Topic.AutoSize = true;
                this.Topic.BackColor = System.Drawing.Color.White;
                this.Topic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Topic.ForeColor = System.Drawing.Color.Black;
                this.Topic.Location = new System.Drawing.Point(54, 7);
                this.Topic.Name = "Topic";
                this.Topic.Size = new System.Drawing.Size(58, 18);
                this.Topic.TabIndex = 2;
                this.Topic.Text = sense.topic;
            }
            else
            {
                if (sense.examples.Count == 0)
                {
                    this.TopicPanel.Location = new System.Drawing.Point(34,
                        this.MeaningLabel.Location.Y + this.MeaningLabel.Height + 5);
                }
                else
                {
                    this.TopicPanel.Location = new System.Drawing.Point(34,
                        this.examples[this.examples.Count - 1].Location.Y + this.examples[this.examples.Count - 1].Height + 5);
                }

                this.TopicPanel.Name = "TopicPanel";
                this.TopicPanel.Size = new System.Drawing.Size(600, 32);
                this.TopicPanel.TabIndex = 4;
                // 
                // TopicLabel
                // 
                this.TopicLabel.AutoSize = true;
                this.TopicLabel.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TopicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(53)))), ((int)(((byte)(97)))));
                this.TopicLabel.Location = new System.Drawing.Point(3, 6);
                this.TopicLabel.Name = "TopicLabel";
                this.TopicLabel.Size = new System.Drawing.Size(0, 0);
                this.TopicLabel.TabIndex = 0;
                this.TopicLabel.Text = "Topic";
            }
            
            // 
            // Sense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.OrderLabel);
            
            this.Controls.Add(this.TopicPanel);
            this.Controls.Add(this.MeaningLabel);
            this.Controls.Add(this.TypeHeader);
            foreach(var e in examples)
            {
                this.Controls.Add(e);
            }
            this.Name = "Sense";
            this.Size = new System.Drawing.Size(648, this.TopicPanel.Location.Y);
            this.TypeHeader.ResumeLayout(false);
            this.TypeHeader.PerformLayout();
            this.TopicPanel.ResumeLayout(false);
            this.TopicPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Panel TypeHeader;
        private RoundButton SenseLevelLabel;
        private System.Windows.Forms.Label SenseTypeLabel;
        private System.Windows.Forms.Label MeaningLabel;
        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Panel TopicPanel;
        private System.Windows.Forms.Label Topic;
        private System.Windows.Forms.Label TopicLabel;
        private List<System.Windows.Forms.Label> examples = new List<System.Windows.Forms.Label>();
    }
}
