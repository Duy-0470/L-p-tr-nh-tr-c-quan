using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dictionary_Beta_1
{
    public partial class LookUp : Form
    {
        public static LookUp instance;


        public static string path = System.IO.Directory.GetCurrentDirectory() + @"\CSDL.txt";
        
        public static string[] lines = System.IO.File.ReadAllLines(path);
        public TextBox tb;
        private readonly WordDatabase WordDB = WordDatabase.Instance;
        public LookUp()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            if (WordDB.Find(user, lines) == "")
            {
                richTextBox1.Text = "Word not found\nIt either means nothing or hasn't been supported.";
            }
            else richTextBox1.Text = textBox1.Text + "\n" + WordDB.Find(user, lines);
        }
    }
}
