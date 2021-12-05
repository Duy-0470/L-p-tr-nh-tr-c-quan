
namespace DictionaryApp.CustomControls
{
    partial class PicturesView
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
            this.pictureZoomer = new DictionaryApp.CustomControls.PictureZoomer();
            this.pictureCatalog = new DictionaryApp.CustomControls.PictureCatalog();
            this.imageSelectionPanel = new DictionaryApp.CustomControls.ImageSelectionPanel();
            this.SuspendLayout();
            // 
            // pictureZoomer
            // 
            this.pictureZoomer.BackColor = System.Drawing.Color.White;
            this.pictureZoomer.Location = new System.Drawing.Point(285, 0);
            this.pictureZoomer.Name = "pictureZoomer";
            this.pictureZoomer.Size = new System.Drawing.Size(600, 550);
            this.pictureZoomer.TabIndex = 0;
            this.pictureZoomer.Visible = false;
            // 
            // pictureCatalog
            // 
            this.pictureCatalog.AutoSize = true;
            this.pictureCatalog.BackColor = System.Drawing.Color.White;
            this.pictureCatalog.Location = new System.Drawing.Point(272, 0);
            this.pictureCatalog.Name = "pictureCatalog";
            this.pictureCatalog.Size = new System.Drawing.Size(828, 503);
            this.pictureCatalog.TabIndex = 0;
            // 
            // imageSelectionPanel
            // 
            this.imageSelectionPanel.BackColor = System.Drawing.Color.White;
            this.imageSelectionPanel.Location = new System.Drawing.Point(0, 0);
            this.imageSelectionPanel.Name = "imageSelectionPanel";
            this.imageSelectionPanel.Size = new System.Drawing.Size(400, 500);
            this.imageSelectionPanel.TabIndex = 1;
            // 
            // PicturesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureZoomer);
            this.Controls.Add(this.pictureCatalog);
            this.Controls.Add(this.imageSelectionPanel);
            this.Name = "PicturesView";
            this.Size = new System.Drawing.Size(1200, 600);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ImageSelectionPanel imageSelectionPanel;
        private PictureCatalog pictureCatalog;
        private PictureZoomer pictureZoomer;
    }
}
