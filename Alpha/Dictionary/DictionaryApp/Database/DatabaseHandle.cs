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
        static DatabaseHandle handle=null;
        public SqlConnection connection;
        public string DataDirectories = "";
        static public DatabaseHandle GetDataHandle()
        {
            if (handle == null)
            {
                handle = new DatabaseHandle();
            }
            return handle;
        }
        public List<String> FindWordsMatchingSearch(string search)
        {
            SqlCommand command = new SqlCommand();
            List<String> matches = new List<String>();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id LIKE '%' + @id + '%'";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = search;
            connection.Open();
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
        public Word FindWord(string wid)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Vocabulary where id= @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = wid;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string id = reader.GetString(1);
                WordHeader wordHeader = new WordHeader(reader.GetString(1), reader.GetString(2), "a1", 
                    reader.GetString(3), reader.GetString(5), reader.GetString(4), reader.GetString(6));

                connection.Close();
                
                List<Sense> senses = this.GetSenses(wid);
                List<WordForm> wordForms = this.GetWordForms(wid);
                List<Shortcut> shortcuts = this.GetShortcuts(wid);
                wordHeader.AddWordForms(wordForms);
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
        public List<SeeAlso> GetSeeAlsos(string sid)
        {
            List<SeeAlso> seeAlsos = new List<SeeAlso>();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from SeeAlso where sense_hash=@sense_hash";
            command.Parameters.AddWithValue("@sense_hash", sid);
            
            connection.Open();

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
            connection.Open();
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
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    senses.Add(new Sense(reader.GetString(2), reader.GetString(3), reader.GetString(4),
                        reader.GetString(5), reader.GetString(6), reader.GetString(7), null, null));
                }
                connection.Close();
                foreach(Sense s in senses)
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
            connection.Open();
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
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    shortcuts.Add(new Shortcut(reader.GetString(2)));
                }


            }
            connection.Close();
            return shortcuts;
        }
        public DatabaseHandle()
        {
            connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Hoc_Ki_3\Lap_Trinh_Truc_Quan\Github2\Visual-Progamming\Alpha\Dictionary\DictionaryApp\DictionaryDB.mdf;Integrated Security=True;Connect Timeout=30;" +
                "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            string pa = Directory.GetCurrentDirectory();
            DataDirectories =  pa.Substring(0, pa.Length - 9) + "Database\\Files\\";
            Debug.WriteLine(DataDirectories);
            // AddVocabulary();

            connection.Open();
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

            connection.Open();
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

            connection.Open();
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

            connection.Open();
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

            connection.Open();
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

            connection.Open();
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
            connection.Open();
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT COUNT(*) FROM Images";
            numRows = (Int32)command.ExecuteScalar();
            connection.Close();
            if (numRows <= 1000)
            {
                Debug.WriteLine("Add words into Images table");
                AddImages();
            }
            connection.Open();
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
            connection.Open();
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
            connection.Open();
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
            connection.Open();
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
            List<String> w = FindWordsMatchingSearch("account");
        }
        private void AddIdioms()
        {
            connection.Open();

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
            connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"idioms\meanings.txt"))
            {

                tokens = line.Split('|');

                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Idiom_Meanings (idiom, type1, word, level, type2, hash) VALUES (@idiom, @type1, @word, @level, @type2, @hash)";
                Debug.WriteLine(tokens[0]);
                command.Parameters.Add("@idiom", SqlDbType.NVarChar).Value = tokens[0];
                command.Parameters.Add("@type1", SqlDbType.NVarChar).Value = tokens[1];
                command.Parameters.Add("@word", SqlDbType.NVarChar).Value = tokens[2];
                command.Parameters.Add("@level", SqlDbType.NVarChar).Value = tokens[3];
                command.Parameters.Add("@type2", SqlDbType.NVarChar).Value = tokens[4];
                command.Parameters.Add("@hash", SqlDbType.NVarChar).Value = tokens[5];
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        private void AddIdiom_Examples()
        {
            connection.Open();

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
            connection.Open();

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
            connection.Open();

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
        private void AddSenses()
        {
            connection.Open();

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
            connection.Open();

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
            connection.Open();

            string[] tokens;
            SqlCommand command;

            foreach (string line in System.IO.File.ReadLines(DataDirectories + @"images\images.txt"))
            {

                tokens = line.Split('|');

                string imagePath = DataDirectories + @"images\images\"+ tokens[1].Substring(56).Replace('/','_');


                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Images (image, word_id) VALUES (@image, @word_id)";
                Debug.WriteLine(tokens[0]);
                Debug.WriteLine(imagePath);
                byte[] content = ImageToStream(imagePath);
                command.Parameters.Add("@image", content);
                command.Parameters.Add("@word_id", SqlDbType.NVarChar).Value = tokens[0];
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
            connection.Open();

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
            connection.Open();

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
            connection.Open();

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
