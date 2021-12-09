using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    public class IdiomHeader
    {
        public string phrase;
        public string id;
        public string type, word_id;
        /*  public List<WordForm> wordForms;
          public List<Shortcut> shortcuts;*/
        public IdiomHeader( string id, string p, string t, string wid)
        {
            this.phrase = p;
            this.id = id;
            this.type = t;
            this.word_id = wid;

            /*this.wordForms = wf;
            this.shortcuts = sc;*/
        }
        public IdiomHeader() { }
    }
}
