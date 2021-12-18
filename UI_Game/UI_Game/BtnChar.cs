using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Game
{
    internal class BtnChar : Button
    {
        int ID;
        int x;
        int y;
        int selected;

        public int ID1 { get => ID; set => ID = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Selected { get => selected; set => selected = value; }
    }
}
