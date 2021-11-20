using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    public class Sense
    {
        public string meaning;
        public string topic;
        public string level;
        public string type1;
        public string type2;
        public string hash;
        public List<Example> examples;
        public List<SeeAlso> seeAlsos;
        public Sense(string t, string m, string l, string t1, string t2, string ha, List<Example> exs, List<SeeAlso> s)
        {
            this.topic = t;
            this.meaning = m;
            this.level = l;
            this.type1 = t1;
            this.type2 = t2;
            this.hash = ha;
            this.examples = exs;
            this.seeAlsos = s;
            if (topic == "NA") topic = "";
            if (level == "NA") level = "";
            if (type1 == "NA") type1 = "";
            if (type2 == "NA") type2 = "";
        }
    }
}
