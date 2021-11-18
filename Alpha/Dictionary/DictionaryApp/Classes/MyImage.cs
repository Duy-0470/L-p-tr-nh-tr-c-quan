using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    public class MyImage
    {
        public string name, link;
        public Image image;
        public MyImage(string name, string link)
        {
            this.name = name;
            this.link = link;
        }
        public MyImage()
        { }
        
    }
}
