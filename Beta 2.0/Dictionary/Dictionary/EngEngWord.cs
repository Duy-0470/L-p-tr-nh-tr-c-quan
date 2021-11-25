using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class EngEngWord
    {
        private string name, spelling, meaning, seealso;
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
        public string SeeAlso
        {
            get => seealso;
            set => seealso = value;
        }
        public EngEngWord(string n = "", string sp = "", string m = "", string sa = "")
        {
            Name = n; Spelling = sp; Meaning = m; SeeAlso = sa;
        }
    }
}
