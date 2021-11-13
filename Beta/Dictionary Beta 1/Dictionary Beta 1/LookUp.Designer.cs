
namespace Dictionary_Beta_1
{
    partial class LookUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.button_Sound = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Look Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(811, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(414, 677);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_Image.Location = new System.Drawing.Point(12, 125);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(793, 540);
            this.pictureBox_Image.TabIndex = 10;
            this.pictureBox_Image.TabStop = false;
            // 
            // button_Sound
            // 
            this.button_Sound.BackgroundImage = global::Dictionary_Beta_1.Properties.Resources._1024px_Speaker_Icon_svg;
            this.button_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Sound.ForeColor = System.Drawing.Color.White;
            this.button_Sound.Location = new System.Drawing.Point(659, 38);
            this.button_Sound.Name = "button_Sound";
            this.button_Sound.Size = new System.Drawing.Size(29, 23);
            this.button_Sound.TabIndex = 11;
            this.button_Sound.UseVisualStyleBackColor = true;
            this.button_Sound.Click += new System.EventHandler(this.button_Sound_Click);
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 12;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // LookUp
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 677);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Sound);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "LookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Button button_Sound;
        private System.Windows.Forms.Button button_Back;
    }
}

