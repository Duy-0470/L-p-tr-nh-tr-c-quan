using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp.Classes
{
    public class WordHeader
    {
        public string word, type, level, br, na, br_link, na_link, id;
        public int starred;
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
            starred = 0;
            id = "";
        }

        public WordHeader(string id, string w, string l)
        {
            word = w;
            this.id = id;
            level =l;
        }

        public WordHeader(string w, string t, string l, string b, string n, string bl, string nl, int st, string id)
        {
            word = w;
            type = t;
            level = "";
            br = b;
            na = n;
            br_link = bl;
            na_link = nl;
            starred = st;
            this.id = id;
        }
        public void AddWordForms(List<WordForm> w)
        {
            wordForms = w;
        }
    }
}
