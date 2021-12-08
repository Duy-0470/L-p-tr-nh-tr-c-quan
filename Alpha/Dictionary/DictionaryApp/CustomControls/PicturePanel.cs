using DictionaryApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class PicturePanel : Panel
    {
        string link;
        public PicturePanel()
        {
            InitializeComponent();
            this.title.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.title.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.picture.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.picture.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.Click += PicturePanel_Click;
            this.picture.Click += PicturePanel_Click;
            this.title.Click += PicturePanel_Click;
        }

        private void PicturePanel_Click(object sender, EventArgs e)
        {
            (this.Parent.Parent as PictureCatalog).ShowPicture(this.link);
            Debug.WriteLine(this.link);
        }

        public void SetPicture(string link, string word)
        {
            Image picture = DatabaseHandle.GetDataHandle().GetImageGivenLinkandSize(link, 200, 200);
            if(this.picture.Image!=null)
                this.picture.Image.Dispose();
            if (picture != null)
            {
                int w = 175, h = 175;
                this.picture.Image = picture;
                this.title.Text = word;
                this.link = link;
            }
        }
        public void MouseEnter(object sender, EventArgs eventArgs)
        {
            this.title.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = Color.FromArgb(150, 150, 150);
            this.title.BackColor = Color.FromArgb(150, 150, 150); 
            this.title.ForeColor = Color.White;
            
        }
        public void MouseLeave(object sender, EventArgs eventArgs)
        {
            this.title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.BackColor = Color.FromArgb(236, 236, 236); 
            this.title.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(236, 236, 236);

        }
    }
}
