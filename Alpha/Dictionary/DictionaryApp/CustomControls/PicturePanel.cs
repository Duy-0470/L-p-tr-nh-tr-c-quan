using DictionaryApp.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp.CustomControls
{
    public partial class PicturePanel : Panel
    {
        public PicturePanel()
        {
            InitializeComponent();
            this.title.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.title.MouseLeave += new System.EventHandler(this.MouseLeave);

        }
        public void SetPicture(string link)
        {
            Image picture = DatabaseHandle.GetDataHandle().GetImageGivenLinkandSize(link, 140, 140);
            if(this.picture.Image!=null)
                this.picture.Image.Dispose();
            if(picture!=null)
                this.picture.Image = picture;
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
            this.title.ForeColor = Color.Black;
            this.BackColor = Color.FromArgb(236, 236, 236);

        }
    }
}
