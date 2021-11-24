using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Database
{
    public class DatabaseHandle
    {
        private string DataDirectories = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\";

        public DatabaseHandle()
        {
            
        }

        

        private bool IsInEVData(string line, string word)
        {
            if (line != "")
            {
                if (line[0] == '@')
                {
                    if (line.Contains('/'))
                    {
                        for (int i = 1; i < line.Length; i++)
                        {
                            if (line[i] == '/')
                            {
                                if (line.Substring(1, i - 2) == word)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (line.Substring(1).Equals(word))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public EngVietWord FindEVWordMeaning(string word, string[] data)
        {
            EngVietWord result = new EngVietWord();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != "" && data[i][0] == '@' && IsInEVData(data[i], word))
                {
                    if (data[i].Contains('/'))
                        result.Name = data[i].Substring(1, data[i].IndexOf('/') - 1);
                    else
                    {
                        Debug.WriteLine(data[i].Substring(1));
                        result.Name = data[i].Substring(1);
                    }

                    if (!data[i].Contains('(') && data[i].Contains('/'))
                    {
                        result.Spelling += data[i].Substring(data[i].IndexOf('/'));
                    }
                    else if (data[i].Contains('(') && data[i].Contains('/'))
                    {
                        result.Spelling += data[i].Substring(data[i].IndexOf('/'), data[i].IndexOf('/') + 1);
                        result.Meaning += "Gần giống: " + result.Meaning + data[i].Substring(data[i].IndexOf('(')) + "\n";
                    }

                    int j = i + 1;
                    if (data[j] == "???")
                        continue;
                    while (data[j] != "")
                    {
                        if (data[j][0] != '@')
                        {
                            result.Meaning = result.Meaning + data[j] + "\n";
                            j++;
                        }
                        else
                            break;
                    }
                }
            }
            result.Meaning = result.Meaning.Replace("=", "\t").Replace("+", ":").Replace("\n!", "\n").Replace("*", "\n*");
            return result;
        }

        public EngEngWord FindEEWordMeaning(string word, string[] data)
        {
            //EngEngWord result = new EngEngWord();
            //string[] tokens_words = word.Split('|');
            //result.Name = tokens_words[0];
            //result.Spelling = tokens_words[3];
            //result.WordClass = tokens_words[1];
        }

    }
}
