using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Classes
{
    class WordHeader
    {
        public string word, type, level, br, na, br_link, na_link;
        public List<WordForm> wordForms = new List<WordForm>();
        public WordHeader()
        {
            word = "word";
            type = "type";
            level = "A1";
            br = "BR";
            na = "NA";
            br_link = "bl";
            na_link = "nl";
        }

        public WordHeader(string w, string t, string l, string b, string n, string bl, string nl)
        {
            word = w;
            type = t;
            level = l;
            br = b;
            na = n;
            br_link = bl;
            na_link = nl;
        }
        public void AddWordForms(List<WordForm> w)
        {
            wordForms = w;
        }
    }
}
