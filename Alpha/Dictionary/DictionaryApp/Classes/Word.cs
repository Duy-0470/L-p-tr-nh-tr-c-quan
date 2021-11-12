using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    public class Word
    {
        public WordHeader wordHeader;
        public string id;
        public List<Sense> senses;
        public List<WordForm> wordForms;
        public List<Shortcut> shortcuts;
        public Word(WordHeader h, string id, List<Sense> sn, List<WordForm> wf, List<Shortcut> sc)
        {
            this.wordHeader = h;
            this.id = id;
            this.senses = sn;
            this.wordForms = wf;
            this.shortcuts = sc;
        }
    }
}
