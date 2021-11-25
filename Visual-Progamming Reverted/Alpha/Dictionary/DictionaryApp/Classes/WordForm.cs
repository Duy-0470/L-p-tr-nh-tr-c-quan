using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp.Classes
{
    public class WordForm
    {
        public string tense, sub, form, br, na, br_link, na_link;
        public WordForm(string t, string s, string w, string n, string b, string bl, string nl)
        {
            tense = t;
            if (s == "NA") s = "";
            sub = s;
            form = w;
            na = n;
            br = b;
            br_link = bl;
            na_link = nl;
        }
        public WordForm()
        {
            form = "word";
            tense = "type";
            sub = "A1";
            br = "BR";
            na = "NA";
            br_link = "bl";
            na_link = "nl";
        }

    }
}
