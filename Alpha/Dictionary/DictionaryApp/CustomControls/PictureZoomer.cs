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
    public partial class PictureZoomer : UserControl
    {
        public PictureZoomer()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }
        public void Show(string link)
        {
            Image picture = DatabaseHandle.GetDataHandle().GetImageGivenLinkandSize(link, 600, 600);
            if (this.pictureBox1.Image != null)
                this.pictureBox1.Image.Dispose();
            if (picture != null)
            {
                this.pictureBox1.Image = picture;

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            (this.Parent as PicturesView).CloseZoomer();
        }
    }
}
