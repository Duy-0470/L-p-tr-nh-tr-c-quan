using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    public class FoundWord
    {
        public string id, word, type, time;
        public FoundWord(string i, string w , string t, string ti)
        {
            this.id = i;
            this.word = w;
            this.type = t;
            this.time = ti;
        }
    }
}
