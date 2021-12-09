using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    public class Example
    {
        public string topic;
        public string sentence;
        public Example(string t, string s)
        {
            this.topic = t;
            this.sentence = s;
        }
        public Example(string s)
        {
            this.sentence = s;
        }
    }
}
