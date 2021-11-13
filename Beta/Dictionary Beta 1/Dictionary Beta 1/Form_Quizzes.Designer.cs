namespace Dictionary_Beta_1
{
    partial class Form_Quizzes
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
            this.button_Collocation = new System.Windows.Forms.Button();
            this.button_Idioms = new System.Windows.Forms.Button();
            this.button_PhrasalVerbs = new System.Windows.Forms.Button();
            this.label_ChooseTopic = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Collocation
            // 
            this.button_Collocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Collocation.Location = new System.Drawing.Point(202, 155);
            this.button_Collocation.Name = "button_Collocation";
            this.button_Collocation.Size = new System.Drawing.Size(103, 35);
            this.button_Collocation.TabIndex = 0;
            this.button_Collocation.Text = "Collocation";
            this.button_Collocation.UseVisualStyleBackColor = true;
            this.button_Collocation.Click += new System.EventHandler(this.button_Collocation_Click);
            // 
            // button_Idioms
            // 
            this.button_Idioms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Idioms.Location = new System.Drawing.Point(202, 210);
            this.button_Idioms.Name = "button_Idioms";
            this.button_Idioms.Size = new System.Drawing.Size(103, 37);
            this.button_Idioms.TabIndex = 1;
            this.button_Idioms.Text = "Idioms";
            this.button_Idioms.UseVisualStyleBackColor = true;
            this.button_Idioms.Click += new System.EventHandler(this.button_Idioms_Click);
            // 
            // button_PhrasalVerbs
            // 
            this.button_PhrasalVerbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PhrasalVerbs.Location = new System.Drawing.Point(202, 266);
            this.button_PhrasalVerbs.Name = "button_PhrasalVerbs";
            this.button_PhrasalVerbs.Size = new System.Drawing.Size(103, 35);
            this.button_PhrasalVerbs.TabIndex = 2;
            this.button_PhrasalVerbs.Text = "Phrasal Verbs";
            this.button_PhrasalVerbs.UseVisualStyleBackColor = true;
            this.button_PhrasalVerbs.Click += new System.EventHandler(this.button_PhrasalVerbs_Click);
            // 
            // label_ChooseTopic
            // 
            this.label_ChooseTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ChooseTopic.AutoSize = true;
            this.label_ChooseTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChooseTopic.Location = new System.Drawing.Point(329, 25);
            this.label_ChooseTopic.Name = "label_ChooseTopic";
            this.label_ChooseTopic.Size = new System.Drawing.Size(154, 20);
            this.label_ChooseTopic.TabIndex = 3;
            this.label_ChooseTopic.Text = "Chọn chủ đề câu hỏi";
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Back.Location = new System.Drawing.Point(706, 412);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(82, 26);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "Quay lại";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Form_Quizzes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dictionary_Beta_1.Properties.Resources.quiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_ChooseTopic);
            this.Controls.Add(this.button_PhrasalVerbs);
            this.Controls.Add(this.button_Idioms);
            this.Controls.Add(this.button_Collocation);
            this.Name = "Form_Quizzes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quizzes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Collocation;
        private System.Windows.Forms.Button button_Idioms;
        private System.Windows.Forms.Button button_PhrasalVerbs;
        private System.Windows.Forms.Label label_ChooseTopic;
        private System.Windows.Forms.Button button_Back;
    }
}