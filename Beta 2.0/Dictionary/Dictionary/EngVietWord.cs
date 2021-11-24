using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class EngVietWord
    {
        private string name, spelling, meaning;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Spelling
        {
            get => spelling;
            set => spelling = value;
        }
        public string Meaning
        {
            get => meaning;
            set => meaning = value;
        }
        public EngVietWord(string n = "", string s = "", string m = "", string an = "", string asp = "")
        {
            Name = n; Spelling = s; Meaning = m;
        }
    }
}
