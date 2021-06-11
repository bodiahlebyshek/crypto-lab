using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class Functions
    {
        public static List<double> CountLetters(string text, string alphabet)
        {
            List<double> p = new List<double>();
            foreach(var x in alphabet)
                p.Add((double)text.ToString().Count(s => s.Equals(x)) / (double)text.Length);
            return p;
        }

        public static char[,] GenerateMatrix(string text, int s)
        {
            int k = ((text.Length - 1) / s) + 1;
            char[,] matrix = new char[s, k];

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                    if (i * k + j >= text.Length)
                        matrix[i, j] = ' ';
                    else
                        matrix[i, j] = text[i * k + j];
            }
            return matrix;
        }

        public static char[,] GenerateMatrix(string text, int s, int k)
        {
            char[,] matrix = new char[s, k];

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                    if (i * k + j >= text.Length)
                        matrix[i, j] = ' ';
                    else
                        matrix[i, j] = text[i * k + j];
            }
            return matrix;
        }

        public static char[,] Encode(string text, int s)
        {
            int k = ((text.Length - 1) / s) + 1;
            char[,] matrix = new char[s, k];

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                    if (j * s + i >= text.Length)
                        matrix[i, j] = ' ';
                    else
                        matrix[i, j] = text[j * s + i];
            }
            return matrix;
        }

        public static string MatrixToString(char[,] matrix, int s)
        {
            StringBuilder str = new StringBuilder();
            int k = ((matrix.Length - 1) / s) + 1;

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                    str.Append(matrix[i, j]);
                str.Append("\r\n");
            }

            return str.ToString();
        }

        public static string MatrixToString(char[,] matrix, int s, int k)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < k; j++)
                    str.Append(matrix[i, j]);
                str.Append("\r\n");
            }

            return str.ToString();
        }

        public static string MatrixToStringSecond(char[,] matrix, int s, int k)
        {
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < s; j++)
                    str.Append(matrix[i, j]);
                str.Append("\r\n");
            }

            return str.ToString();
        }

        public static char[,] SecondTask(string stringUser, string firstKey, string secondKey)
        {
            int countSymbols = 0;

            char[,] matrix;

            // Переводим строки в массивы типа char
            char[] charsFirstKey = firstKey.ToCharArray();
            char[] charsSecondKey = secondKey.ToCharArray();
            char[] charStringUser = stringUser.ToCharArray();

            // Создаем списки в которых будут храниться символы и порядковы номера символов
            List<CharNum> listCharNumFirst =
                new List<CharNum>(firstKey.Length);

            List<CharNum> listCharNumSecond =
                new List<CharNum>(secondKey.Length);

            // Заполняем символами из ключей
            listCharNumFirst = FillListKey(charsFirstKey);
            listCharNumSecond = FillListKey(charsSecondKey);

            // Заполняем порядковыми номерами
            listCharNumFirst = FillingSerialsNumber(listCharNumFirst);
            listCharNumSecond = FillingSerialsNumber(listCharNumSecond);

            matrix = GenerateMatrix(stringUser, listCharNumSecond.Count, listCharNumFirst.Count);

            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    if (countSymbols >= charStringUser.Length)
                        matrix[listCharNumSecond[i].NumberInWord,
                            listCharNumFirst[j].NumberInWord] = ' ';
                    else
                        matrix[listCharNumSecond[i].NumberInWord,
                           listCharNumFirst[j].NumberInWord] = charStringUser[countSymbols++];
                }
            }

            return matrix;
        }

        public static List<CharNum> FillingSerialsNumber(List<CharNum> listCharNum)
        {
            int count = 0;

            var result = listCharNum.OrderBy(a =>
                a.NumberInWord);

            foreach (var i in result)
            {
                i.NumberInWord = count++;
            }

            return listCharNum;
        }

        public static List<CharNum> FillListKey(char[] chars)
        {
            List<CharNum> listKey = new List<CharNum>(chars.Length);

            for (int i = 0; i < chars.Length; i++)
            {
                CharNum charNum = new CharNum()
                {
                    Ch = chars[i],
                    NumberInWord = GetNumberInThealphabet(chars[i])
                };

                listKey.Add(charNum);
            }
            return listKey;
        }

        public static int GetNumberInThealphabet(char s)
        {
            string str = @"абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            return str.IndexOf(s);
        }
    }
}
