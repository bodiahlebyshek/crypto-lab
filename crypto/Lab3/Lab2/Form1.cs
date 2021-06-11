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

namespace Lab2
{
    public partial class Form1 : Form
    {
        private string path = "";
        private StringBuilder text = new StringBuilder("");
        private string encryptedText = "";
        public static string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private string keyWord = "ильинов";
        private string keyString = "";
        private int k = 5;
        private int s = 10;
        public static List<double> textP = new List<double>();
        public static List<double> encryptedTextP = new List<double>();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = alphabet;
            textBox2.Text = s.ToString();
            textBox.Text = text.ToString();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            PathTextBox.Text = path;

            textP.Clear();

            using (StreamReader sr = new StreamReader(path))
            {
                text = new StringBuilder(sr.ReadToEnd().ToLower());
            }
            textBox.Text = text.ToString();
            textP = Functions.CountLetters(text.ToString(), alphabet);
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text.ToString()))
            {
                if (firstTask.Checked)
                {
                    MatrixBox.Text = Functions.MatrixToString(Functions.GenerateMatrix(text.ToString(), s), s);
                    EncryptedMatrixBox.Text = Functions.MatrixToString(Functions.Encode(text.ToString(), s), s);
                }

                if (secondTask.Checked)
                {
                    MatrixBox.Text = Functions.MatrixToString(Functions.GenerateMatrix(text.ToString(), FirstKeyBox.Text.Length, SecondKeyBox.Text.Length), FirstKeyBox.Text.Length, SecondKeyBox.Text.Length);
                    EncryptedMatrixBox.Text = Functions.MatrixToStringSecond(Functions.SecondTask(text.ToString(), FirstKeyBox.Text, SecondKeyBox.Text), FirstKeyBox.Text.Length, SecondKeyBox.Text.Length);
                }

                textP = Functions.CountLetters(MatrixBox.Text, alphabet);
                encryptedTextP = Functions.CountLetters(EncryptedMatrixBox.Text, alphabet);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphs graphs = new Graphs();
            graphs.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            alphabet = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
                s = Convert.ToInt32(textBox2.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            text = new StringBuilder(textBox.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FirstKeyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondTask_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
