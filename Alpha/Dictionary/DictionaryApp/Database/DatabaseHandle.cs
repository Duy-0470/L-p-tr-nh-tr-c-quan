using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using DictionaryApp.Classes;
using System.Data;

namespace DictionaryApp.Database
{
    class DatabaseHandle
    {
        static DatabaseHandle handle = null;
        static Dictionary<string, List<string>> imageTopics = new Dictionary<string, List<string>>();
        public SqlConnection connection;
        public string DataDirectories = "";
        public Dictionary<string, Image> images = new Dictionary<string, Image>();
        public List<string> otherTopics = new List<string>();
        public List<string> words = new List<string>();
        static public DatabaseHandle GetDataHandle()
        {
            if (handle == null)
            {
                handle = new DatabaseHandle();
            }
            /*Word i = handle.RandomWord();
            Debug.WriteLine(i.wordHeader.word);
            Debug.WriteLine(i.senses[0].meaning);
*/
            return handle;
        }
        public List<String> FindWordsMatchingSearch(string search)
        {
            SqlCommand command = new SqlCommand();

            List<String> matches = new List<String>();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id LIKE '%@id%'";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = search;
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    matches.Add(reader.GetString(0));
                }
            }
            connection.Close();
            return matches;
        }
        public MyImage RandomImage()
        {
            SqlCommand command = new SqlCommand();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select distinct word from Image_Word";
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string> ids = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ids.Add(reader.GetString(0));
                }
            }
            int r = new Random().Next() % ids.Count;
            MyImage theW = null;
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Image_Word where word = @word";
            command.Parameters.Add("@word", System.Data.SqlDbType.NVarChar).Value = ids[r];
            connection.Close(); connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                theW = new MyImage(reader.GetString(2), reader.GetString(1));
                connection.Close();

            }
            connection.Close();
            return theW;
        }
        
        public Word GetWordGivenId(string id)
        {
            Word theW = null;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string wid = reader.GetString(0);
                WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                    reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));

                connection.Close();
                Debug.WriteLine(wid);

                List<Sense> senses = this.GetSenses(wid);
                /*List<WordForm> wordForms = this.GetWordForms(wid);
                List<Shortcut> shortcuts = this.GetShortcuts(wid);*/
                // wordHeader.AddWordForms(wordForms);
                connection.Close();
                theW = new Word(wordHeader,
                                wid,
                                senses,
                                null,
                                null);
            }
            connection.Close();
            return theW;
        }
        public Word RandomWord() {
            SqlCommand command;
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select id from Vocabulary";
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string> ids = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ids.Add(reader.GetString(0));
                }
            }
            int r = new Random().Next() % ids.Count;
            Word theW = null;
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = ids[r];
            connection.Close(); connection.Open();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string wid = reader.GetString(0);
                WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                    reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));

                connection.Close();
                Debug.WriteLine(wid);

                List<Sense> senses = this.GetSenses(wid);
                /*List<WordForm> wordForms = this.GetWordForms(wid);
                List<Shortcut> shortcuts = this.GetShortcuts(wid);*/
                // wordHeader.AddWordForms(wordForms);
                connection.Close();
                theW = new Word(wordHeader,
                                wid,
                                senses,
                                null,
                                null);
            }
            connection.Close();
            return theW;
        }

        public Word FindGivenId(string search, ref List<Word> mw, ref List<string> mm, ref List<string> saw)
        {
            SqlCommand command = new SqlCommand();
            Debug.WriteLine(search.ToLower().Replace(" ", "_"));

            Word theW = null;
            mm.Clear();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = search.ToLower().Replace(" ", "_");
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Debug.WriteLine(search.ToLower().Replace(" ", "_") + "_");
            if (reader.HasRows)
            {
                reader.Read();
                string wid = reader.GetString(0);
                WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                    reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));

                connection.Close();
                Debug.WriteLine(wid);

                List<Sense> senses = this.GetSenses(wid);
                List<WordForm> wordForms = this.GetWordForms(wid);
                List<Shortcut> shortcuts = this.GetShortcuts(wid);
                wordHeader.AddWordForms(wordForms);
                connection.Close();
                mm = shortcuts.Select(s => s.shortcut).ToList();
                theW = new Word(wordHeader,
                                wid,
                                senses,
                                wordForms,
                                shortcuts);
                this.AddToHistory(wordHeader.id, wordHeader.word, wordHeader.type, DateTime.Now.ToString());
            }
            else
            {
                connection.Close();
                theW = null;

            }
            /* foreach(string s in mm)
             {
                 Debug.WriteLine(s);
             }*/
            saw.Clear();
            // Debug.WriteLine("find seealso");

            if (theW != null)
            {
                mw.Clear();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from Vocabulary where id LIKE @id + '%'";
                command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = theW.wordHeader.word.ToLower();
                connection.Close(); connection.Open();
                reader = command.ExecuteReader();
                Debug.WriteLine("find also matching");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string wid = reader.GetString(0);
                        WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                            reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));


                        mw.Add(new Word(wordHeader,
                                        wid,
                                        null,
                                        null,
                                        null));
                    }
                }
                connection.Close();

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select word from SeeAlso where word_id = @id";
                command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = theW.id;
                connection.Close(); connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        saw.Add(reader.GetString(0));
                        Debug.WriteLine(reader.GetString(0));

                    }
                }
            }
            connection.Close();
            return theW;

        }
        public bool MarkWord(string id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Vocabulary SET starred = 1 WHERE id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value =id;
            connection.Close(); connection.Open();
            command.ExecuteNonQuery();
            return true;
        }
        public bool UnmarkWord(string id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Vocabulary SET starred = 0 WHERE id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            connection.Close(); connection.Open();
            command.ExecuteNonQuery();
            return true;
        }
        public void AddToHistory(string id, string w, string t, string ti)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Close(); connection.Open();

            command.CommandText = @"INSERT INTO History (word_id, word, word_type, time) VALUES (@word_id, @word, @word_type, @time)";
            command.Parameters.Add("@word_type", SqlDbType.NVarChar).Value = t;
            command.Parameters.Add("@word", SqlDbType.NVarChar).Value = w;
            command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = id;
            command.Parameters.Add("@time", SqlDbType.NVarChar).Value = ti;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public List<FoundWord> LoadHistory()
        {
            List<FoundWord> mw = new List<FoundWord>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from History";

            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mw.Add(new FoundWord(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                }
            }
            Debug.WriteLine(mw.Count);
            return mw;
        }
        public void ClearHistory()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "DELETE from History";

            connection.Close(); connection.Open();
            command.ExecuteNonQuery();
        }
        public List<WordHeader> GetMarkedWord()
        {
            List<WordHeader> mw = new List<WordHeader>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where starred = 1";

            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string wid = reader.GetString(0);
                    WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                        reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));


                    mw.Add(wordHeader);
                }
            }
            connection.Close();
            return mw;

        }
        /*public Word GetWordGivenId(string id)
        {
            Word theW = null;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id = @id ";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string wid = reader.GetString(0);
                WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                    reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));

                connection.Close();
                Debug.WriteLine(wid);

                List<Sense> senses = this.GetSenses(wid);
                List<WordForm> wordForms = this.GetWordForms(wid);
                List<Shortcut> shortcuts = this.GetShortcuts(wid);
                wordHeader.AddWordForms(wordForms);
                connection.Close();
                theW = new Word(wordHeader,
                                wid,
                                senses,
                                wordForms,
                                shortcuts);

            }
            else
            {
                connection.Close();
                theW = null;

            }
            return theW;
        }*/
        public Word Find(string search, ref List<Word> mw, ref List<string> mm, ref List<string> saw)
        {
            Debug.WriteLine(search.ToLower().Replace(" ", "-"));
            mw.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Vocabulary";
            connection.Close(); connection.Open();

            int numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            Debug.WriteLine(numRows);

            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id LIKE '@id%'";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = search.ToLower().Replace(" ", "-");
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Debug.WriteLine("find also matching");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string wid = reader.GetString(0);
                    WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                        reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));


                    mw.Add(new Word(wordHeader,
                                    wid,
                                    null,
                                    null,
                                    null));
                }
            }
            connection.Close();

            Word theW=null;
            mm.Clear();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id LIKE @id+'%' ESCAPE '/' OR id LIKE @id1+'%' ESCAPE '/' ";
            Debug.WriteLine(search.ToLower().Replace(" ", "/_") + "/_");
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = search.ToLower().Replace(" ", "/_") + "/_";
            command.Parameters.Add("@id1", System.Data.SqlDbType.NVarChar).Value = search.ToLower().Replace(" ", "/_");
            connection.Close(); connection.Open();
            reader = command.ExecuteReader();
            // Debug.WriteLine(search.ToLower().Replace(" ", "_") + "_");
            if (reader.HasRows)
            {
                reader.Read();
                string wid = reader.GetString(0);
                WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                    reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));

                connection.Close();
                Debug.WriteLine(wid);

                List<Sense> senses = this.GetSenses(wid);
                List<WordForm> wordForms = this.GetWordForms(wid);
                List<Shortcut> shortcuts = this.GetShortcuts(wid);
                wordHeader.AddWordForms(wordForms);
                connection.Close();
                mm = shortcuts.Select(s => s.shortcut).ToList();
                theW= new Word(wordHeader,
                                wid,
                                senses,
                                wordForms,
                                shortcuts);
                this.AddToHistory(wordHeader.id, wordHeader.word, wordHeader.type, DateTime.Now.ToString());

            }
            else
            {
                connection.Close();
                theW= null;

            }
           /* foreach(string s in mm)
            {
                Debug.WriteLine(s);
            }*/
            saw.Clear();
            // Debug.WriteLine("find seealso");

            if (theW != null)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select word from SeeAlso where word_id = @id";
                command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = theW.id;
                connection.Close(); connection.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        saw.Add(reader.GetString(0));
                        Debug.WriteLine(reader.GetString(0));

                    }
                }
            }
            connection.Close();
            return theW;
            
        }

        public Word FindWord(string wid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id= @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = wid;
            connection.Close();connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string id = reader.GetString(1);
                WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1",
                    reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6), reader.GetInt32(7), reader.GetString(0));

                connection.Close();

                List<Sense> senses = this.GetSenses(wid);
                List<WordForm> wordForms = this.GetWordForms(wid);
                List<Shortcut> shortcuts = this.GetShortcuts(wid);
                wordHeader.AddWordForms(wordForms);
                connection.Close();
                this.AddToHistory(wordHeader.id, wordHeader.word, wordHeader.type, DateTime.Now.ToString());
                return new Word(wordHeader,
                                wid,
                                senses,
                                wordForms,
                                shortcuts);               
            }
            else {
                connection.Close();
                return null;

            }

        }
        public Image GetImageGivenLinkandSize(string link, int width, int height)
        {
            Image im = GetImageGivenLink(link);
            if (im == null) return null;
            float iwth = (float)im.Width / im.Height;
            float rwth = (float)width / height;
            if (iwth > rwth)
            {
                im = new Bitmap(im, new Size(width, Convert.ToInt32(width / iwth)));
            }
            else
            {
                im = new Bitmap(im, new Size(Convert.ToInt32(height * iwth), height));

            }
            if (im.Width != width && im.Height != height)
            {
                im = im;
            }
            return im;
        }
        public Image GetImageGivenLink(string link)
        {
            Image image = null;

            if (images.TryGetValue(link, out image))
            {
                return image;
            }
            string query = "SELECT image, link FROM Images WHERE " +
                "link = '" + link + "'";// where Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Close();
            connection.Close();connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                byte[] bytes = (byte[])reader["image"];
                using (MemoryStream memstr = new MemoryStream(bytes))
                {
                    image = Image.FromStream(memstr);
                    if (image != null)
                        images.Add(link, image);
                }
            }
            return image;
        }
        public List<MyImage> GetImageGivenLetter(string letter)
        {
            List<MyImage> images = new List<MyImage>();
            string query = "SELECT image_link, word FROM Image_Word WHERE " +
                "word LIKE '" + letter + "%'";// where Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Close();
            connection.Close(); connection.Open();
            List<string> added = new List<string>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MyImage myImage = new MyImage();
                myImage.name = reader.GetString(1).Substring(0, reader.GetString(1).Length - 2).Replace('_', ' ');
                myImage.link = reader.GetString(0);
                if (!added.Contains(myImage.name))
                {
                    images.Add(myImage);
                    added.Add(myImage.name);
                }
            }
            Debug.WriteLine(images.Count);
            connection.Close();
            images.Distinct();
            return images;
        }
        public List<string> GetAllImageWords()
        {
            if (words.Count == 0)
            {
                /* string query = "SELECT word FROM Image_Word";
                 SqlCommand command = new SqlCommand(query, connection);
                 connection.Close();
                 connection.Close();connection.Open();
                 List<string> added = new List<string>();
                 SqlDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     words.Add(reader.GetString(0).Replace("_", " "));
                 }
                 connection.Close();*/
                for (int i = 0; i < 26; i++)
                {
                    words.Add(Convert.ToChar(i + 65).ToString());
                }
                words.Distinct();
            }
           
            return words;
        }
        public List<MyImage> GetImageContaining(string name = "l")
        {
            List<MyImage> images = new List<MyImage>();
            string query = "SELECT image_link, word FROM Image_Word WHERE " +
                "word LIKE '%" + name + "%'";// where Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Close();
            connection.Close();connection.Open();
            List<string> added = new List<string>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MyImage myImage = new MyImage();
                myImage.name = reader.GetString(1).Substring(0, reader.GetString(1).Length - 2).Replace('_', ' ');
                myImage.link = reader.GetString(0);
                if (!added.Contains(myImage.name))
                {
                    images.Add(myImage);
                    added.Add(myImage.name);
                }
            }
            Debug.WriteLine(images.Count);
            connection.Close();
            images.Distinct();
            return images;
        }

        public List<SeeAlso> GetSeeAlsos(string sid)
        {
            List<SeeAlso> seeAlsos = new List<SeeAlso>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from SeeAlso where sense_hash=@sense_hash";
            command.Parameters.AddWithValue("@sense_hash", sid);

            connection.Close();connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    seeAlsos.Add(new SeeAlso(reader.GetString(3)));
                }
            }
            else
            {

            }
            connection.Close();
            return seeAlsos;

        }
        public List<Example> GetExamples(string sid)
        {
            List<Example> examples = new List<Example>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Examples where sense_hash=@sense_hash";
            command.Parameters.AddWithValue("@sense_hash", sid);
            connection.Close();connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    examples.Add(new Example(reader.GetString(2), (reader.GetString(4))));
                }
            }
            else
            {

            }
            connection.Close();
            return examples;

        }
        public List<Sense> GetSenses(string wid)
        {
            List<Sense> senses = new List<Sense>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Senses where word_id=@word_id";
            command.Parameters.AddWithValue("@word_id", wid);
            connection.Close();connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    senses.Add(new Sense(reader.GetString(2), reader.GetString(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7), null, null));
                }
                connection.Close();
                foreach (Sense s in senses)
                {
                    s.seeAlsos = this.GetSeeAlsos(s.hash);
                    s.examples = this.GetExamples(s.hash);
                }

            }
            else
            {

            }
            connection.Close();

            return senses;
        }
        public List<WordForm> GetWordForms(string wid)
        {
            List<WordForm> wordForms = new List<WordForm>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from WordForms where word_id=@word_id";
            command.Parameters.AddWithValue("@word_id", wid);
            connection.Close();connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    wordForms.Add(new WordForm(reader.GetString(2), reader.GetString(3), reader.GetString(4),
                                reader.GetString(5), reader.GetString(7), reader.GetString(6), reader.GetString(8)));
                }


            }
            connection.Close();
            return wordForms;
        }
        public List<Shortcut> GetShortcuts(string wid)
        {
            List<Shortcut> shortcuts = new List<Shortcut>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Shortcuts where word_id=@word_id";
            command.Parameters.AddWithValue("@word_id", wid);
            connection.Close();connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    shortcuts.Add(new Shortcut(reader.GetString(2)));
                }


            }

            return shortcuts;
        }
        public void AddImageTopics()
        {
            try
            {
                imageTopics.Add("Vehicles (2)", new List<string>() { "car", "airliner" });
                imageTopics.Add("Vehicles (1)", new List<string>(){ "trucks", "trains", "taxis", "cycles", "construction", "cars",
                                "caravan_camper", "buses", "boats_ships_1", "boats_ships_2" , "aircraft"});
                imageTopics.Add("Vegetables", new List<string>() { "squash", "salad", "root", "beans", "vegetables_misc" });
                imageTopics.Add("Trees", new List<string>() { "evergreen", "deciduous", "_tree" });
                imageTopics.Add("Tools", new List<string>() { "diy_1", "diy_2", "diy_3", "toolbox" });
                imageTopics.Add("Sports", new List<string>() { "winter", "water", "track", "team", "racket", "sports_misc",
                                "field", "extreme", "equestrian" });
                imageTopics.Add("Cooking", new List<string>() { "spices", "cooking", "food_preparation" });
                imageTopics.Add("Office", new List<string>() { "office", "stationery", "classroom", "laboratory" });
                imageTopics.Add("Music", new List<string>() { "musicalnotation", "woodwind_instruments", "string_instruments", "pianos",
                                "percussion_instruments", "groups_playing", "brass_instruments", "other_string_instruments" });
                imageTopics.Add("Mammals", new List<string>() { "rodents", "primates", "marsupials", "cetaceans" });
                imageTopics.Add("Animal (1)", new List<string>() { "insects", "amphibians", "arachnids", "reptiles", "shellfish" });
                imageTopics.Add("Animal (2)", new List<string>() { "_mammals", "arachnids", "_fish", });
                imageTopics.Add("Rooms", new List<string>() { "livingroom", "diningroom", "bedroom", "bathroom", "kitchen" });
                imageTopics.Add("Kitchen", new List<string>() { "utensils_misc", "opening", "measuring", "drinks", "cutting",
                                "crushing_grating_squeezing", "baking", "appliances", "kitchen" });
                imageTopics.Add("Jewellery", new List<string>() { "rings", "necklaces", "earrings", "bracelets", "jewellery" });
                imageTopics.Add("House", new List<string>() { "house_1", "house_2" });
                imageTopics.Add("Buildings", new List<string>() { "homes", "buildings", "architecture", "bridges" });
                imageTopics.Add("Hobbies", new List<string>() { "running", "skating", "orienteering_caving", "diving_snorkelling",
                                "darts_pool", "creative", "crafts", "bowling" });
                imageTopics.Add("Plants", new List<string>() { "herbs", "flowers", "cereals", "plants" });
                imageTopics.Add("Fruit", new List<string>() { "tropical", "fruit_misc", "citrus", "berries" });
                imageTopics.Add("Excercise", new List<string>() { "fitness", "equipment" });
                imageTopics.Add("Garden", new List<string>() { "tools", "garden_misc", "chairs" });
                imageTopics.Add("Environment", new List<string>() { "environment_1", "environment_2" });
                imageTopics.Add("Sights", new List<string>() { "countryside", "coast", "city", "mountains" });
                imageTopics.Add("Clothes", new List<string>() { "sweaters", "sports_casual", "shoes", "scarves", "nightclothes", "clothes_misc",
                                "hats", "gloves", "fasteners", "dresses_skirts", "coats", "bags", "clothes" });
                imageTopics.Add("Cleaning", new List<string>() { "cleaning_1", "cleaning_2" });
                imageTopics.Add("Body", new List<string>() { "skeleton", "hand", "face", "eye", "body", "internal_organs" });
                imageTopics.Add("Birds", new List<string>() { "seabirds", "prey", "poultry", "birds" });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + "at DatabaseHandle.AddImageTopics");
            }
            
        }
        public List<string> GetImageTopics()
        {
            return imageTopics.Keys.ToList();
        }
        public List<MyImage> GetImageGivenTopic(string topic){
            List<string> names = new List<string>();
            imageTopics.TryGetValue(topic, out names);
            Debug.WriteLine(topic);
            Debug.WriteLine(names);

            List<MyImage> images = new List<MyImage>();
            foreach (string name in names)
            {
                connection.Close();connection.Open();
                SqlCommand command;
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT DISTINCT link FROM Images WHERE link LIKE '%" + "_" + name + "%'";

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string l = reader.GetString(0);
                    MyImage myImage = new MyImage();
                    myImage.name = l.Substring(l.IndexOf('_') + 10).Replace("_", " ").Replace(".png", " ").ToUpper();
                    string[] split = myImage.name.Split(' ');
                    //for (int i = 0; i < split.Length; i++)
                    //{
                    //    Debug.WriteLine(split[i]);
                    //}
                    myImage.name = split[split.Length - 2];
                    myImage.link = l;
                    images.Add(myImage);
                }
            }
            return images;
        }
        public List<MyImage> GetAllTopicImages()
        {
            List<string> names = imageTopics.Values.ToList().SelectMany(x => x).ToList();
            List<MyImage> images = new List<MyImage>();
            foreach (string name in names)
            {
                connection.Close();
                connection.Close();connection.Open();
                SqlCommand command;
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT DISTINCT link FROM Images WHERE link LIKE '%" + "_" + name + "%'";

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string l = reader.GetString(0);
                    MyImage myImage = new MyImage();
                    myImage.name = l.Substring(l.IndexOf('_') + 10).Replace("_", " ").Replace(".png", " ").ToUpper();
                    myImage.link = l;
                    images.Add(myImage);
                }
            }
            connection.Close();

            return images;

        }
        public List<MyImage> GetOtherImages()
        {
            List<MyImage> images = GetAllImages();
            List<string> t_images = GetAllTopicImages().Select(i => i.link).ToList();
            images = images.Where(i => !t_images.Contains(i.link)).ToList();
            return images;
        }
        public List<Idiom> GetIdiomsGivenWord(string word)
        {
            string w = word.Trim().Replace(" ", "-");
            List<Idiom> idioms = new List<Idiom>();
            foreach(string id in new List<string> { "_1", "_2", "_3", "_4", "_5" })
            {
                idioms = GetIdiomsGivenWordId(w + id);
                if (idioms.Count != 0)
                    return idioms;
            }
            return idioms;
        }
        public List<string> GetAlspMatchingIdioms(string w)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select DISTINCT word_id from Idioms where word_id like '"+w.Trim().Replace(" ","-")+"%'";
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string> headers = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    headers.Add(reader.GetString(0));
                }
            }
            connection.Close();
            return headers;

        }
        public List<Idiom> GetIdiomsGivenWordId(string wid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Idioms where word_id= @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = wid;
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<IdiomHeader> headers = new List<IdiomHeader>();
            List<Idiom> idioms = new List<Idiom>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    headers.Add(new IdiomHeader(
                        Convert.ToString( reader.GetInt32(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3)
                        ));
                }
                foreach(IdiomHeader header in headers)
                {
                    SqlCommand scommand = new SqlCommand();
                    scommand.Connection = connection;
                    scommand.CommandText = "select * from Idiom_Meanings where idiom= @id";
                    scommand.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = header.phrase;

                    connection.Close(); connection.Open();
                    SqlDataReader sreader = scommand.ExecuteReader();
                    List<Sense> s = new List<Sense>();
                    List<string> m = new List<string>();
                    if (sreader.HasRows)
                    {
                        while (sreader.Read())
                        {
                            if (!m.Contains(sreader.GetString(6)))
                            {

                                s.Add(new Sense(
                                        "", sreader.GetString(6), sreader.GetString(4), sreader.GetString(2), sreader.GetString(5), sreader.GetString(7), null));
                                m.Add(sreader.GetString(6));
                            }
                           
                        }
                    }
                    // Debug.WriteLine(headers.Count);

                    foreach (Sense sense in s)
                    {
/*                        Debug.WriteLine(sense.meaning);
*/                        SqlCommand xcommand = new SqlCommand();
                        xcommand.Connection = connection;
                        xcommand.CommandText = "select sentence from Idiom_Examples where hash= @id";
                        xcommand.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = sense.hash;

                        connection.Close(); connection.Open();
                        SqlDataReader xreader = xcommand.ExecuteReader();
                        List<Example> examples = new List<Example>();
                        List<string> x = new List<string>();
                        if (xreader.HasRows)
                        {
                            while (xreader.Read())
                            {
                                if (!x.Contains(xreader.GetString(0))){
                                    examples.Add(new Example(xreader.GetString(0)));
                                    x.Add(xreader.GetString(0));
                                }
                               
                            }
                        }
                        sense.examples = examples;
                    }

                    idioms.Add(new Idiom(header, header.id, s));
                }
                connection.Close();

            }
            else
            {
                connection.Close();

            }
            return idioms;

        }
        public List<MyImage> GetOtherTopics()
        {
            return GetOtherImages().Distinct().ToList();
        }
        public List<MyImage> GetAllImages()
        {
            connection.Close();connection.Open();
            SqlCommand command;
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT DISTINCT link FROM Images";
            SqlDataReader reader = command.ExecuteReader();
            // List<string> topics = new List<string>();
            List<MyImage> images = new List<MyImage>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                
                    string l = reader.GetString(0);
                    Debug.WriteLine(l.Substring(l.IndexOf('_') + 10));

                    MyImage myImage = new MyImage();
                    myImage.name = l.Substring(l.IndexOf('_') + 10).Replace("_", " ").Replace(".png", " ").ToUpper();
                    myImage.link = l;
                    images.Add(myImage);
                    // topics.Add(l);
                

                }

            }

            connection.Close();

            return images;
        }
        public DatabaseHandle()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DictionaryDB.mdf;Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            string pa = Directory.GetCurrentDirectory();
            DataDirectories = pa.Substring(0, pa.Length - 9) + "\\Database\\Files\\";
            //DataDirectories =  pa + "\\Database\\Files\\";


            // AddVocabulary();

            connection.Close();connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Vocabulary";
            int numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Vocabulary table");
                AddVocabulary();
            }

            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM WordForms";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into WordForms table");
                AddWordForms();
            }

            AddImageTopics();

            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Shortcuts";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Shortcuts table");
                AddShortcuts();
            }

            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Senses";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Senses table");
                AddSenses();
            }

            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM SeeAlso";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into SeeAlso table");
                AddSeealsos();
            }

            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Examples";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Examples table");
                AddExamples();
            }
            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Images";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows >= 400 || numRows == 0)
            {
                Debug.WriteLine("Add words into Images table");
                AddImages();
            }
            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Idiom_Topic";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Idiom_Topic table");
                AddIdiom_Topics();
            }
            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Idioms";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Idioms table");
                AddIdioms();
            }
            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Idiom_Meanings";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Idiom_Meanings table");
                AddIdiom_Meaning();
            }
            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Idiom_Examples";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Idiom_Examples table");
                AddIdiom_Examples();
            }
            connection.Close();connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Quizzes";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 500)
            {
                Debug.WriteLine("Add words into Quizzes table");
                AddQuizzes();
            }
            connection.Close(); connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Topics";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 500)
            {
                Debug.WriteLine("Add topics into Topics table");
                AddTopics();
            }


            List<String> w = FindWordsMatchingSearch("account");
            GetAllImageWords();
        }
        public List<string> GetTopics()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select DISTINCT topic from Topics";
            connection.Close(); connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<string> topic = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    topic.Add(reader.GetString(0));
                }
            }
            connection.Close();
            return topic;
        }
        public List<string> GetSubTopics(string t)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select DISTINCT subtopic from Topics WHERE topic = @topic";
            connection.Close(); connection.Open();
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = t;
            SqlDataReader reader = command.ExecuteReader();
            List<string> topic = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    topic.Add(reader.GetString(0));
                }
            }
            connection.Close();
            return topic;
        }
        public List<string> GetSubsubTopics(string t, string s)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select DISTINCT subsubtopic from Topics WHERE topic = @topic and subtopic = @subtopic";
            connection.Close(); connection.Open();
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = t;
            command.Parameters.Add("@subtopic", System.Data.SqlDbType.NVarChar).Value = s;
            SqlDataReader reader = command.ExecuteReader();
            List<string> topic = new List<string>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    topic.Add(reader.GetString(0));
                }
            }
            connection.Close();
            return topic;
        }
        public List<WordHeader> GetWordsGivenTopic(string t, string s, string ss)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select DISTINCT level, word, word_id from Topics WHERE topic = @topic and subtopic = @subtopic and subsubtopic = @subsubtopic";
            connection.Close(); connection.Open();
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = t;
            command.Parameters.Add("@subtopic", System.Data.SqlDbType.NVarChar).Value = s;
            command.Parameters.Add("@subsubtopic", System.Data.SqlDbType.NVarChar).Value = ss;
            SqlDataReader reader = command.ExecuteReader();
            List<WordHeader> words = new List<WordHeader>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    words.Add(new WordHeader(reader.GetString(2), reader.GetString(1), reader.GetString(0)));
                }
            }
            connection.Close();
            return words;
        } 
        public bool CheckTopicandSubtopic(string t, string s)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select COUNT(*) from Topics WHERE topic = @topic and subtopic = @subtopic";
            connection.Close(); connection.Open();

            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = t;
            command.Parameters.Add("@subtopic", System.Data.SqlDbType.NVarChar).Value = s;
            int numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows == 0) { return false; }
            return true;
            //connection.Close();
        }
        public List<Quizz> SelectNQuizzes(int number)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Quizzes";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Quizz> quizzs = new List<Quizz>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quizzs.Add(new Quizz(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7)));

                }
                connection.Close();
                var rnd = new Random();
                quizzs = (List<Quizz>)quizzs.OrderBy(item => rnd.Next());
            }
            else
            {
                connection.Close();
                return null;

            }
            if (number > quizzs.Count)
            {
                number = quizzs.Count;
            }
            return quizzs.GetRange(0, number);
        }
        public List<Quizz> SelectNIdiomQuizzes(int number)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Quizzes where topic= @topic";
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = "Idiom";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Quizz> quizzs = new List<Quizz>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quizzs.Add(new Quizz(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7)));

                }
                connection.Close();
                var rnd = new Random();
                quizzs = quizzs.OrderBy(item => rnd.Next()).ToList();
            }
            else
            {
                connection.Close();
                return null;

            }
            if (number > quizzs.Count)
            {
                number = quizzs.Count;
            }
            return quizzs.GetRange(0, number);
        }

        public List<Quizz> SelectNPhrasalVerbQuizzes(int number)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Quizzes where topic= @topic";
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = "Phrasal-Verbs";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Quizz> quizzs = new List<Quizz>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quizzs.Add(new Quizz(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7)));

                }
                connection.Close();
                var rnd = new Random();
                quizzs = quizzs.OrderBy(item => rnd.Next()).ToList();
            }
            else
            {
                connection.Close();
                return null;

            }
            if (number > quizzs.Count)
            {
                number = quizzs.Count;
            }
            return quizzs.GetRange(0, number);
        }

        public List<Quizz> SelectNCollocationQuizzes(int number)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Quizzes where topic= @topic";
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = "Collocation";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Quizz> quizzs = new List<Quizz>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quizzs.Add(new Quizz(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7)));

                }
                connection.Close();
                var rnd = new Random();
                quizzs = quizzs.OrderBy(item => rnd.Next()).ToList();
            }
            else
            {
                connection.Close();
                return null;

            }
            if (number > quizzs.Count)
            {
                number = quizzs.Count;
            }
            return quizzs.GetRange(0, number);
        }

        public List<Quizz> SelectNWordMeaningQuizzes(int number)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Quizzes where topic= @topic";
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = "Word-Meaning";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Quizz> quizzs = new List<Quizz>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quizzs.Add(new Quizz(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7)));

                }
                connection.Close();
                var rnd = new Random();
                quizzs = quizzs.OrderBy(item => rnd.Next()).ToList();
            }
            else
            {
                connection.Close();
                return null;

            }
            if (number > quizzs.Count)
            {
                number = quizzs.Count;
            }
            return quizzs.GetRange(0, number);
        }

        public List<Quizz> SelectNWordFormQuizzes(int number)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Quizzes where topic= @topic";
            command.Parameters.Add("@topic", System.Data.SqlDbType.NVarChar).Value = "Word-Form";
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Quizz> quizzs = new List<Quizz>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    quizzs.Add(new Quizz(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetInt32(7)));

                }
                connection.Close();
                var rnd = new Random();
                quizzs = quizzs.OrderBy(item => rnd.Next()).ToList();
            }
            else
            {
                connection.Close();
                return null;

            }
            if (number > quizzs.Count)
            {
                number = quizzs.Count;
            }
            return quizzs.GetRange(0, number);
        }
        private void AddQuizzes()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;
            List<string> topics = new List<string> { "Collocation", "Idiom", "Phrasal-Verbs", "Word-Meaning", "Word-Form" };
            Dictionary<string, List<string>> quizzDictionary = new Dictionary<string, List<string>>();

            foreach (string tp in topics)
            {
                Debug.WriteLine("Reading" + tp);
                // read files -Answers and -Quizzes
                string ansFile = DataDirectories + "quizzes\\" + tp + "-Answers.txt";
                Debug.WriteLine(DataDirectories + "quizzes\\" + tp + "-Answers.txt");
                string quzFile = DataDirectories + "quizzes\\" + tp + "-Quizzes.txt";
                Debug.WriteLine(DataDirectories + "quizzes\\" + tp + "-Quizzes.txt");


                // read -Answer file first
                foreach (string line in System.IO.File.ReadLines(ansFile))
                {
                    string qu = Convert.ToInt32(line.Substring(0, line.Length - 1))+tp;

                    int an = line.Substring(line.Length - 1, 1) == "A"?1:
                        line.Substring(line.Length - 1, 1) == "B"?2:
                        line.Substring(line.Length - 1, 1) == "C"?3:4;

                    quizzDictionary.Add(qu, new List<string> { Convert.ToString(an) });
                }
                
                foreach (string line in System.IO.File.ReadLines(quzFile))
                {
                    
                    tokens = line.Split('|');
                    if (tokens.Length != 5)
                    {
                        continue;
                    }
                           
                    string quNum = tokens[0].Substring(0, tokens[0].IndexOf(' ') -1) +tp;
                    string quSen = tokens[0].Substring(tokens[0].IndexOf(" ") + 1)/*.Replace('%', '_')*/;

                    string ansA = tokens[1].Substring(tokens[1].IndexOf(".")+1).Replace('\n', ' ');
                    string ansB = tokens[2].Substring(tokens[2].IndexOf(".")+1).Replace('\n', ' ');
                    string ansC = tokens[3].Substring(tokens[3].IndexOf(".")+1).Replace('\n', ' ');
                    string ansD = tokens[4].Substring(tokens[4].IndexOf(".")+1).Replace('\n', ' ');

                    quizzDictionary[quNum].AddRange(new List<string> {quSen, ansA, ansB, ansC, ansD});

                }
            }
            foreach (string tp in topics)
            {
                Debug.WriteLine("Adding" + tp);
                foreach (string key in quizzDictionary.Keys.ToList())
                {
                    if (quizzDictionary[key].Count != 6/* || key.Contains(tp)*/)
                    {
                        continue;
                    }
                    command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Quizzes (question, topic, ans1, ans2, ans3, ans4, rans) VALUES (@question, @topic, @ans1, @ans2, @ans3, @ans4, @rans)";
                    command.Parameters.Add("@question", SqlDbType.NVarChar).Value = quizzDictionary[key][1];
                    command.Parameters.Add("@topic", SqlDbType.NVarChar).Value = tp;
                    Debug.WriteLine(tp);
                    command.Parameters.Add("@ans1", SqlDbType.NVarChar).Value = quizzDictionary[key][2];
                    command.Parameters.Add("@ans2", SqlDbType.NVarChar).Value = quizzDictionary[key][3];
                    command.Parameters.Add("@ans3", SqlDbType.NVarChar).Value = quizzDictionary[key][4];
                    command.Parameters.Add("@ans4", SqlDbType.NVarChar).Value = quizzDictionary[key][5];
                    command.Parameters.Add("@rans", SqlDbType.Int).Value = Convert.ToInt32(quizzDictionary[key][0]);
                    command.ExecuteNonQuery();

                }

            }
            connection.Close();
        }
        private void AddIdioms()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"idioms\phrases.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Idioms (idiom, type, word_id) VALUES (@idiom, @type, @word_id)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@idiom", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = tokens[2];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddIdiom_Meaning()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"idioms\meanings.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Idiom_Meanings (idiom, type1, word, level, type2, meaning, hash) VALUES (@idiom, @type1, @word, @level, @type2, @meaning, @hash)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@idiom", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@type1", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@level", SqlDbType.NVarChar).Value = tokens[3];
                command.Parameters.Add("@type2", SqlDbType.NVarChar).Value = tokens[4];
                command.Parameters.Add("@meaning", SqlDbType.NVarChar).Value = tokens[5];
                command.Parameters.Add("@hash", SqlDbType.NVarChar).Value = tokens[6];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddIdiom_Examples()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"idioms\examples.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Idiom_Examples (idiom, type, word, sentence, hash) VALUES (@idiom, @type, @word, @sentence, @hash)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@idiom", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@sentence", SqlDbType.NVarChar).Value = tokens[3];
                command.Parameters.Add("@hash", SqlDbType.NVarChar).Value = tokens[4];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddIdiom_Topics()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"idioms\topics.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Idiom_Topic (idiom, type, word, topic, level, hash) VALUES (@idiom, @type, @word, @topic, @level, @hash)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@idiom", tokens[0]);
                command.Parameters.Add("@type", tokens[1]);
                command.Parameters.Add("@word", tokens[2]);
                command.Parameters.Add("@topic", tokens[3]);
                command.Parameters.Add("@level", tokens[4]);
                command.Parameters.Add("@hash", tokens[5]);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddVocabulary()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"words\words.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Vocabulary (id, word, type, bre, bre_file, nae, nae_file) VALUES (@id, @word, @type, @bre, @bre_file, @nae, @nae_file)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@id", SqlDbType.NVarChar).Value= tokens[0];
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@type", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@bre", SqlDbType.NVarChar).Value = tokens[3];
                command.Parameters.Add("@bre_file", SqlDbType.NVarChar).Value = tokens[4];
                command.Parameters.Add("@nae", SqlDbType.NVarChar).Value = tokens[5];
                command.Parameters.Add("@nae_file", SqlDbType.NVarChar).Value = tokens[6];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddTopics()
        {
            connection.Close(); connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"\topics.txt"))
            {
                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Topics (topic, subtopic, subsubtopic, level, word, word_id) VALUES (@topic, @subtopic, @subsubtopic, @level, @word, @word_id)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@topic", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@subtopic", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@subsubtopic", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@level", SqlDbType.NVarChar).Value = tokens[3];
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[4];
                command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = tokens[5];
                command.ExecuteNonQuery();
            }
            connection.Close();

        }
        private void AddSenses()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"words\senses.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Senses (word_id, topic, meaning, level, type1, type2, hash) VALUES (@word_id, @topic, @meaning, @level, @type1, @type2, @hash)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@topic", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@meaning", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@level", SqlDbType.NVarChar).Value = tokens[3];
                command.Parameters.Add("@type1", SqlDbType.NVarChar).Value = tokens[4];
                command.Parameters.Add("@type2", SqlDbType.NVarChar).Value = tokens[5];
                command.Parameters.Add("@hash", SqlDbType.NVarChar).Value = tokens[6];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddShortcuts()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"words\shortcuts.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Shortcuts (word_id, shortcut) VALUES (@word_id, @shortcut)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@shortcut", SqlDbType.NVarChar).Value = tokens[1];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddImages()
        {
            connection.Close();connection.Open();

            
            string[] tokens;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"DELETE FROM Images";
            command.ExecuteNonQuery();
            List<string> imagePaths = new List<string>();

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"images\images.txt"))
            {

                tokens = line.Split('|');

                string imagePath = DataDirectories + @"images\images\"+ tokens[1].Substring(56).Replace('/','_');
                imagePaths.Add(imagePath);

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Image_Word (image_link, word) VALUES (@image_link, @word)";
                command.Parameters.Add("@image_link", SqlDbType.NVarChar).Value = imagePath;
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[0];
                command.ExecuteNonQuery();
            }
            imagePaths= imagePaths.Distinct().ToList();
            foreach(string path in imagePaths)
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Images (image, link) VALUES (@image, @link)";
                byte[] content = ImageToStream(path);
                command.Parameters.Add("@image", content);
                command.Parameters.Add("@link", SqlDbType.NVarChar).Value = path;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
            tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void AddSeealsos()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"words\see_also.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO SeeAlso (word_id, sense_hash, word) VALUES (@word_id, @sense_hash, @word)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@sense_hash", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[3];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddExamples()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"words\examples.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Examples (word, topic, sense_hash, sentence) VALUES (@word, @topic, @sense_hash, @sentence)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@topic", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@sense_hash", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@sentence", SqlDbType.NVarChar).Value = tokens[4];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddWordForms()
        {
            connection.Close();connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"words\word_forms.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO WordForms (word_id, tense, subjects, form, bre, bre_file, nae, nae_file) VALUES (@word_id, @tense, @subjects, @form, @bre, @bre_file, @nae, @nae_file)";
                Debug.WriteLine(tokens[0]);
                string[] ts = tokens[1].Split();
                command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = tokens[0];
                if (ts.Length == 2)
                {
                    command.Parameters.Add("@tense", SqlDbType.NVarChar).Value = tokens[1];
                    command.Parameters.Add("@subjects", SqlDbType.NVarChar).Value = "";
                }
                else if (ts.Length == 4)
                {
                    command.Parameters.Add("@tense", SqlDbType.NVarChar).Value = "";
                    command.Parameters.Add("@subjects", SqlDbType.NVarChar).Value = tokens[1];
                }
                else
                {
                    command.Parameters.Add("@tense", SqlDbType.NVarChar).Value = ts[0] + " " + ts[1];
                    command.Parameters.Add("@subjects", SqlDbType.NVarChar).Value = tokens[1].Replace(ts[0] + " " + ts[1], "");
                }
                command.Parameters.Add("@form", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@bre", SqlDbType.NVarChar).Value = tokens[3];
                command.Parameters.Add("@bre_file", SqlDbType.NVarChar).Value = tokens[4];
                command.Parameters.Add("@nae", SqlDbType.NVarChar).Value = tokens[5];
                command.Parameters.Add("@nae_file", SqlDbType.NVarChar).Value = tokens[6];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
