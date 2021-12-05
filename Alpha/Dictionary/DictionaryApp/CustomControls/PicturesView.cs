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
    public partial class PicturesView : UserControl
    {
        public PicturesView()
        {
            InitializeComponent();
        }
        public void CloseZoomer()
        {
            this.pictureZoomer.Visible = false;

        }
        public void DisplayImage(string link)
        {
            this.pictureZoomer.Visible = true;
            this.pictureZoomer.Show(link);
        }
        public void ChangeCatalogueWithLetter(string letter)
        {

            this.pictureCatalog.PopulateWithPicture(DatabaseHandle.GetDataHandle().GetImageGivenLetter(letter));
        }
        public void ChangeCatalogueWithTopic(string topic)
        {

            this.pictureCatalog.PopulateWithPicture(DatabaseHandle.GetDataHandle().GetImageGivenTopic(topic));
        }
    }
}
