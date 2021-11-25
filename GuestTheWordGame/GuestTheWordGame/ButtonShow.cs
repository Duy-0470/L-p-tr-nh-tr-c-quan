using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestTheWordGame
{
    class ButtonShow : Button
    {
        private int iD;

        public int ID { get => iD; set => iD = value; }
    }
}
