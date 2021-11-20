using DictionaryApp.Classes;
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
    public partial class PictureCatalog : UserControl
    {
        public PictureCatalog()
        {
            InitializeComponent();
            PopulateWithPicture(DatabaseHandle.GetDataHandle().GetImageContaining("l"));
        }
        public void PopulateWithPicture(List<MyImage> images)
        {
            this.Controls.Clear();
            int row = 0;
            int col = 0;
            foreach(MyImage image in images)
            {
                row++;
                PicturePanel picturePanel = new PicturePanel();
                picturePanel.Location = new Point(row * (picturePanel.Width + 15), col * (picturePanel.Height + 15)+15);
                picturePanel.SetPicture(image.link);
                this.Controls.Add(picturePanel);
                if (row == 3)
                {
                    row = 0;
                    col++;
                }
            }
        }
    }
}
