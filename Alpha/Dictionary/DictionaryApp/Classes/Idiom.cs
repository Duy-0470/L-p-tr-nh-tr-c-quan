using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    public class Idiom
    {
        public IdiomHeader wordHeader;
        public string id;
        public List<Sense> senses;
      /*  public List<WordForm> wordForms;
        public List<Shortcut> shortcuts;*/
        public Idiom(IdiomHeader h, string id, List<Sense> sn)
        {
            this.wordHeader = h;
            this.id = id;
            this.senses = sn;
            /*this.wordForms = wf;
            this.shortcuts = sc;*/
        }
        public Idiom(IdiomHeader h, string id)
        {
            this.wordHeader = h;
            this.id = id;
            /*this.wordForms = wf;
            this.shortcuts = sc;*/
        }
        public void AddSenses(List<Sense> s)
        {
            this.senses = s;

        }
        public Idiom()
        {
            this.wordHeader = new IdiomHeader();
        }
    }
}
