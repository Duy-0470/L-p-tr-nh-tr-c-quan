using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary_Beta_1
{
    public class WordDatabase
    {
        private static WordDatabase instance;
        internal static WordDatabase Instance
        {
            get => instance ?? (instance = new WordDatabase());
            set => instance = value;
        }

        public bool IsValid(string line, string user)
        {
            string t = "";
            if (line != "")
            {
                if (line[0] == '@')
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i] == '/')
                        {
                            t = line.Substring(1, i - 2);
                            break;
                        }
                    }
                    if (t == user) return true;
                }
            }
            return false;
        }

        public string Find(string user, string[] lines)
        {
            string result = "";
            for (int i = 0; i < lines.Length; i++)
            {
                if (IsValid(lines[i], user))
                {
                    int j = i + 1;
                    while (lines[j] != "")
                    {
                        result = result + lines[j] + "\n";                        
                        j++;
                    }
                    break;
                }
            }
            result = result.Replace('+', ':');
            return result;
        }
    }
}
