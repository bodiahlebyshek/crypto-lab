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
using System.Numerics;
using System.Windows;
using Microsoft.Win32;


namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text;
        private void LoadTextFromFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                text = File.ReadAllText(openFileDialog.FileName);
                TextToEncryptBox.Text = text;
            }
            if (String.IsNullOrEmpty(text)) MessageBox.Show("Файл пуст");

        }

        private void EncryptClick(object sender, EventArgs e)
        {
            if(task1Radio.Checked)
            {
                if (String.IsNullOrEmpty(aToEncrypt.Text) || String.IsNullOrEmpty(bToEncrypt.Text))
                    MessageBox.Show("Введите а и b");
                else
                    TextToDecryptBox.Text = EncryptAff(TextToEncryptBox.Text, Convert.ToInt32(aToEncrypt.Text), Convert.ToInt32(bToEncrypt.Text));
            }
            else
            {
                TextToDecryptBox.Text = EncryptVizh(TextToEncryptBox.Text, "ильинов");
            }
        }

        private string EncryptAff(string textToEncrypt, int a, int b)
        {
            textToEncrypt = textToEncrypt.ToLower();
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string encrypedText = "";
            int n = 33;
            if ( a == 0 || (b == 0 && a == 1) || b >= n || a >= n || calcNOD(a,n)!=1)
            {
                MessageBox.Show("Числа а и b не соответсвтуют необходимым условиям");
            }
            else
            {
                foreach (char x in textToEncrypt)
                {
                    if (alphabet.Contains(x))
                    {
                        char newSymbol;
                        int pos = alphabet.IndexOf(x);
                        int newpos = ((pos * a) + b) % n;
                        newSymbol = alphabet[newpos];
                        encrypedText += newSymbol;
                    }
                    else
                    {
                        encrypedText += x;
                    }
                }
                aToDecrypt.Text = aToEncrypt.Text;
                bToDecrypt.Text = bToEncrypt.Text;
            }
            return encrypedText;
        }

        private string EncryptVizh(string textToEncrypt, string key)
        {
            textToEncrypt = textToEncrypt.ToLower();
            key = key.ToLower();
            string encrypedText = "";
            char[] characters = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                                                'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
                                                'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь',
                                                'э', 'ю', 'я'
            };
            int n = characters.Length;
            int keyword_index = 0;


            foreach (char symbol in textToEncrypt)
            {
                if (characters.Contains(symbol))
                {
                    int c = (Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, key[keyword_index])) % n;

                    encrypedText += characters[c];

                    if ((keyword_index + 1) == key.Length)
                        keyword_index = 0;
                    else
                        keyword_index++;
                }
                else
                {
                    encrypedText += symbol;
                }

            }
            return encrypedText;
        }

        private void DecryptClick(object sender, EventArgs e)
        {
            if (task1Radio.Checked)
            {
                if (String.IsNullOrEmpty(aToDecrypt.Text) || String.IsNullOrEmpty(bToDecrypt.Text))
                    MessageBox.Show("Введите а и b");
                else
                    TextToEncryptBox.Text = DecryptAff(TextToDecryptBox.Text, Convert.ToInt32(aToDecrypt.Text), Convert.ToInt32(bToDecrypt.Text));
            }
            else
            {
                TextToEncryptBox.Text = DecryptVizh(TextToDecryptBox.Text, "ильинов");
            }
        }

        private string DecryptAff(string textToDecrypt, int a, int b)
        {
            textToDecrypt = textToDecrypt.ToLower();
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int n = 33;
            string decrypedText = "";
            if (a == 0 || (b == 0 && a == 1) || b >= n || a >= n || calcNOD(a, n) != 1)
            {
                MessageBox.Show("Числа а и b не соответсвтуют необходимым условиям");
            }
            else
            {
                foreach (char x in textToDecrypt)
                {
                    if (alphabet.Contains(x))
                    {
                        char newSymbol;
                        int pos = alphabet.IndexOf(x);
                        int newpos = ((int)InvMod(a, n) * (pos + n - b) % n);
                        newSymbol = alphabet[newpos];
                        decrypedText += newSymbol;
                    }
                    else
                    {
                        decrypedText += x;
                    }
                }
            }
            return decrypedText;
        }

        private string DecryptVizh(string textToDecrypt, string key)
        {
            textToDecrypt = textToDecrypt.ToLower();
            key = key.ToLower();
            string decrypedText = "";
            char[] characters = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                                                'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
                                                'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь',
                                                'э', 'ю', 'я'
            };
            int n = characters.Length;
            int keyword_index = 0;


            foreach (char symbol in textToDecrypt)
            {
                if (characters.Contains(symbol))
                {
                    int p = (Array.IndexOf(characters, symbol) + n -
                                        Array.IndexOf(characters, key[keyword_index])) % n;

                    decrypedText += characters[p];

                    if ((keyword_index + 1) == key.Length)
                        keyword_index = 0;
                    else
                        keyword_index++;
                }
                else
                {
                    decrypedText += symbol;
                }
                    
            }
            return decrypedText;
        }

        private BigInteger InvMod(int number, int mod)
        {
            return BigInteger.Pow(number, EulerFunc(mod) - 1) % mod;
        }

        private int EulerFunc(int number)
        {
            int res = number, en = Convert.ToInt32(Math.Sqrt(number) + 1);
            for (int i = 2; i <= en; i++)
            {
                if ((number % i) == 0)
                {
                    while ((number % i) == 0)
                        number /= i;
                    res -= (res / i);
                }
            }
            if (number > 1) res -= (res / number);
            return res;
        }

        private int calcNOD(int x, int y)
        {
            int max;
            int min;
            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
            return max % min == 0 ? min : calcNOD(min, max % min);
        }

        private void TextToEncryptBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aToEncrypt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
