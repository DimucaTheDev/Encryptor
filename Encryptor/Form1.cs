using System;
using System.IO;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < textBox1.Lines.Length; i++)
                    File.Encrypt(textBox1.Lines[i]);
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form2.files)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.ShowDialog();
                foreach (string s in ofd.FileNames)
                    textBox1.Text += s + "\n";
            }
            else
            {
                FolderBrowserDialog ofd = new FolderBrowserDialog();
                ofd.ShowDialog();
                textBox1.Text = ofd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < textBox1.Lines.Length; i++)
                    File.Decrypt(textBox1.Lines[i]);
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
