
using System.Drawing;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    partial class PicturePanel
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
            components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();

            // 
            // button2
            // 

            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.FlatAppearance.BorderSize = 0;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(0, 180);
            this.title.Name = "button2";
            this.title.Size = new System.Drawing.Size(180, 50);
            this.title.TabIndex = 1;
            this.title.Text = "Hello";
            this.title.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.BackColor = Color.Black;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "pictureBox2";
            this.picture.Size = new System.Drawing.Size(172, 172);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;

            this.panel.BackColor = Color.White;
            this.panel.Location = new System.Drawing.Point(4, 4);
            this.panel.Controls.Add(this.picture);
            this.panel.Size = new System.Drawing.Size(172, 174);

            this.BackColor = Color.FromArgb(236, 236, 236);
            this.title.BackColor = Color.FromArgb(236, 236, 236);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel);
            this.Name = "panel7";
            this.Size = new System.Drawing.Size(180, 230);
            this.MaximumSize = new System.Drawing.Size(180, 230);
            this.TabIndex = 12;
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();

        }

        #endregion
        private Button title;
        private Panel panel;
        private PictureBox picture;
    }
}
