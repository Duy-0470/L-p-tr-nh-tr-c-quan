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
        public static readonly string DataDirectories = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 9) + "Database\\";
        
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

        public bool IsInEEData(string word)
        {
            string[] line = File.ReadAllLines(DataDirectories + "words\\EnglishEnglish\\list\\EE" + word[0] + ".txt");
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == word)
                {
                    return true;
                }
            }
            return false;
        }

        public EngEngWord FindEEWordMeaning(string word, string[] data)
        {
            EngEngWord result = new EngEngWord();
            bool flag = false;

            for (int i = 0; i < data.Length; i++)
            {
                if (IsInEEData(word))
                {
                    result.Name = word;
                    for (int j = 0; j < MainMenu.randomizer.Length; j++)
                    {
                        if (word == MainMenu.randomizer[j].Substring(0, MainMenu.randomizer[j].IndexOf('|')))
                        {
                            result.Spelling = MainMenu.randomizer[j].Substring(MainMenu.randomizer[j].IndexOf('|') + 1);
                            break;
                        }
                    }

                    foreach (string line in File.ReadLines(DataDirectories + "words\\EnglishEnglish\\words.txt"))
                    {
                        if (line.Substring(0, line.IndexOf('|') - 2) == word)
                        { 
                            flag = true;
                            string[] tokens_w = line.Split('|');
                            if (result.Meaning.Contains(tokens_w[2]))
                                continue;
                            result.Meaning = result.Meaning + tokens_w[2] + ": " + tokens_w[1] + " " + tokens_w[3] + "\n";
                        }
                        if (flag && line.Substring(0, line.IndexOf('|') - 2) != word)
                            break;
                    }
                    result.Meaning += "\n";

                    flag = false;
                    foreach (string line in File.ReadLines(DataDirectories + "words\\EnglishEnglish\\word_forms.txt"))
                    {
                        if (line.Substring(0, line.IndexOf('|') - 2) == word)
                        {
                            flag = true;
                            string[] tokens_wf = line.Split('|');
                            if (result.Spelling == "")
                                result.Spelling += tokens_wf[3];
                            result.Meaning = result.Meaning + "- " + tokens_wf[1] + " " + tokens_wf[2] + "\n";                     
                        }
                        if (flag && line.Substring(0, line.IndexOf('|') - 2) != word)
                            break;
                    }
                    result.Meaning += "\n";

                    flag = false;
                    foreach (string line in File.ReadAllLines(DataDirectories + "words\\EnglishEnglish\\shortcuts.txt"))
                    {
                        if (line.Substring(0, line.IndexOf('|') - 2) == word)
                        {
                            flag = true;
                            string[] tokens_sc = line.Split('|');
                            result.Meaning = result.Meaning + "- " + tokens_sc[1] + "\n";                           
                        }
                        if (flag && line.Substring(0, line.IndexOf('|') - 2) != word)
                            break;
                    }
                    result.Meaning += "\n";

                    flag = false;
                    foreach (string line in File.ReadAllLines(DataDirectories + "words\\EnglishEnglish\\senses.txt"))
                    {                       
                        if (line.Substring(0, line.IndexOf('|') - 2) == word)
                        {
                            flag = true;
                            string[] tokens_sc = line.Split('|');
                            result.Meaning = result.Meaning + "- " + (tokens_sc[1] != "NA" ? tokens_sc[1] + " " : "") + tokens_sc[2] + " " + (tokens_sc[4] != "NA" ? tokens_sc[4] : "")
                                + " " + (tokens_sc[5] != "NA" ? tokens_sc[5] : "") + "\n";
                        }
                        if (flag && line.Substring(0, line.IndexOf('|') - 2) != word)
                            break;
                    }
                    result.Meaning += "\n";

                    flag = false;
                    foreach (string line in File.ReadAllLines(DataDirectories + "words\\EnglishEnglish\\extra_list.txt"))
                    {
                        if (line.Substring(0, line.IndexOf('|') - 2) == word)
                        {
                            flag = true;
                            string[] tokens_el = line.Split('|');
                            result.Meaning = result.Meaning + "- " + tokens_el[1] + "\n";                           
                        }
                        if (flag && line.Substring(0, line.IndexOf('|') - 2) != word)
                            break;
                    }
                    result.Meaning += "\n";

                    flag = false;
                    foreach (string line in File.ReadAllLines(DataDirectories + "words\\EnglishEnglish\\examples.txt"))
                    {
                        if (line.Substring(0, line.IndexOf('|') - 2) == word)
                        {
                            flag = true;
                            string[] tokens_ex = line.Split('|');
                            result.Meaning = result.Meaning + tokens_ex[4] + "\n";
                        }
                        if (flag && line.Substring(0, line.IndexOf('|') - 2) != word)
                            break;
                    }
                    result.Meaning += "\n";

                    flag = false;
                    foreach (string line in File.ReadAllLines(DataDirectories + "words\\EnglishEnglish\\see_also.txt"))
                    {
                        if (line.Substring(0, line.IndexOf('|') - 2) == word)
                        {
                            string[] tokens_sa = line.Split('|');
                            result.SeeAlso += tokens_sa[3] + "|";
                        }
                        if (flag && line.Substring(0, line.IndexOf('|') - 2) != word)
                            break;
                    }
                    result.Meaning += "\n";

                    break;
                }
            }
            return result;
        }
    }
}
