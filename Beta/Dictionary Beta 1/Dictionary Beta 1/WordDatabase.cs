using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private bool IsWord(string line, string word)
        {
            if (line != "")
            {
                if (line[0] == '@')
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i] == '/')
                            if (line.Substring(1, i - 2) == word) return true;
                    }
                }
            }
            return false;
        }

        public string FindWordMeaning(string word, string[] lines)
        {
            string result = "";
            for (int i = 0; i < lines.Length; i++)
            {
                if (IsWord(lines[i], word))
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
            return result.Replace('+', ':');
        }

        public string FindUrl(string word, string[] url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                for (int j = 0; j < url[i].Length; j++)
                {
                    if (url[i].Substring(0, url[i].IndexOf("_")) == word)
                        return url[i].Substring(url[i].IndexOf(word) + word.Length + 3);
                }
            }
            return "";
        }


    }
 }
