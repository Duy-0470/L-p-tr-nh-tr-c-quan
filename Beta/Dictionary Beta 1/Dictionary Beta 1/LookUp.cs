using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Dictionary_Beta_1
{
    public partial class LookUp : Form
    {
        public static LookUp instance;
        public static IEnumerable<string> EnumerateLines(TextReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }

        public static string[] ReadAllResourceLines(string resourceText)
        {
            using (StringReader reader = new StringReader(resourceText))
            {
                return EnumerateLines(reader).ToArray();
            }
        }

        readonly string[] words = ReadAllResourceLines(Properties.Resources.CSDL);
        readonly string[] images = ReadAllResourceLines(Properties.Resources.images);
        readonly string[] sound = ReadAllResourceLines(Properties.Resources.british);
        private readonly WordDatabase WordDB = WordDatabase.Instance;

        public LookUp()
        {
            InitializeComponent();
            instance = this;
            pictureBox_Image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox_Image.Image = null;
            if (textBox1.Text == "")
            {
                richTextBox1.Text = "Please input a word";
                return;
            }

            string result = WordDB.FindWordMeaning(textBox1.Text, words);            
            if (result == "")
            {
                richTextBox1.Text = "Word not found\n- Your spelling might have been wrong\n- The word might has not been supported";
                return;
            }
            richTextBox1.Text = textBox1.Text + "\n" + result;
            string url = WordDB.FindUrl(textBox1.Text, images);
            if (url != "") pictureBox_Image.Load(url);
        }

        private void button_Sound_Click(object sender, EventArgs e)
        {
            string url = WordDB.FindUrl(textBox1.Text, sound);
            if (url == "") return;
            else
            {
                WindowsMediaPlayer spell = new WindowsMediaPlayer
                {
                    URL = url
                };
                spell.controls.play(); 
            }
        }
    }
}
