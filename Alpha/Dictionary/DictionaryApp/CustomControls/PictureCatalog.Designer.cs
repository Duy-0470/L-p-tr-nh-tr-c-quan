
using System.Drawing;

namespace DictionaryApp.CustomControls
{
    partial class PictureCatalog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(margin*2, height);
            this.panel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Size = new System.Drawing.Size(margin * (n_columns + 3) + 180 * n_columns, margin);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(margin * (n_columns + 1) + 180 * n_columns, 0);
            this.panel3.Size = new System.Drawing.Size(margin * 2, height);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, height-margin);
            this.panel4.Size = new System.Drawing.Size(margin * (n_columns + 3) + 180 * n_columns, margin);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.list.BackColor = System.Drawing.Color.White;
            this.list.Location = new System.Drawing.Point(margin * 2, margin);
            this.list.Size = new System.Drawing.Size(margin * (n_columns + 0) + 180 * n_columns, height-margin*2);
            this.list.TabIndex = 0;
            this.list.HorizontalScroll.Maximum = 0;
            this.list.HorizontalScroll.Visible = false;
            this.list.HorizontalScroll.Enabled = false;
            this.list.AutoScroll = true;
            // 
            // PictureCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.list);

            this.Name = "PictureCatalog";
            this.AutoSize = true;
            this.Size = new System.Drawing.Size(margin*((n_columns - 1) +10)+180*n_columns, height);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel list;
    }
}
