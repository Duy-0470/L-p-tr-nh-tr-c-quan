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
        static int n_columns = 4;
        static int margin = 15;
        static int height = 500;
        public PictureCatalog()
        {
            InitializeComponent();
            // PopulateWithPicture(DatabaseHandle.GetDataHandle().GetImageContaining(""));
        }
        public void ShowPicture(string link)
        {
            (this.Parent as PicturesView).DisplayImage(link);
        }
        public void PopulateWithPicture(List<MyImage> images)
        {
            this.list.Controls.Clear();
            int row = 0;
            int col = 0;
            foreach(MyImage image in images)
            {
                PicturePanel picturePanel = new PicturePanel();
                picturePanel.Location = new Point(row * (picturePanel.Width + 15), col * (picturePanel.Height + 15)+15);
                picturePanel.SetPicture(image.link, char.ToUpper(image.name[0]) + image.name.Substring(1).ToLower());
                this.list.Controls.Add(picturePanel);
                row++;
                if (row == n_columns)
                {
                    row = 0;
                    col++;
                }
            }
        }
    }
}
