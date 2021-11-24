using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class EngEngWord
    {
        private string name, spelling, wordclass, wordforms, shortcuts, senses, examples, extras, see_also;
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
        public string WordClass
        {
            get => wordclass;
            set => wordclass = value;
        }
        public string WordForms
        {
            get => wordforms;
            set => wordforms = value;
        }
        public string Shortcuts
        {
            get => shortcuts;
            set => shortcuts = value;
        }
        public string Senses
        {
            get => senses;
            set => senses = value;
        }
        public string Examples
        {
            get => examples;
            set => examples = value;
        }
        public string Extras
        {
            get => extras;
            set => extras = value;
        }
        public string SeeAlso
        {
            get => see_also;
            set => see_also = value;
        }
        public EngEngWord(string n = "", string wf = "", string sh = "", string se = "", string exa = "", string ext = "", string sa = "")
        {
            Name = n; WordForms = wf; Shortcuts = sh; Shortcuts = se; Examples = exa; Extras = ext; SeeAlso = sa;
        }
    }
}
