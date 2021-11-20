using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Classes
{
    class Quizz
    {
        public string question, topic, A, B, C, D;
        public int rightAnswer;
        public Quizz(string q, string t, string a, string b, string c, string d, int ra)
        {
            this.question = q;
            this.topic = t;
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.rightAnswer = ra;
        }
    }
}
