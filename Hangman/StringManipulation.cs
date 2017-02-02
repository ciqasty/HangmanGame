using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    class StringManipulation
    {
        public static string word { get; set; }
        public static char[] wordAsChars { get; set; }
        public static char[] stringBuilder { get; set; }

        public static void NewWord()
        {
            Random rand = new Random();
            try
            {
                word = FileHandling.words[rand.Next(0, FileHandling.words.Count)];
                wordAsChars = word.ToCharArray();
            }
            catch (Exception)
            {

                MessageBox.Show("There were an error with the file, check if it is not empty", "Error", MessageBoxButtons.OK);
            }
            
        }

        public static List<int> CheckString(char ch, char[] w)
        {
            List<int> position = new List<int>();
            if (word!=null)
            {
                for (int i = 0; i < w.Length; i++)
                {
                    if (w[i] == Char.ToLower(ch)) position.Add(i);
                }
            }
            return position;

        }
        public static string BuildString(List<int> characterPositions, char c)
        {
            foreach (int position in characterPositions)
            {
                stringBuilder[position] = c;
            }
            string s = new string(stringBuilder);
            return s;
        }

    }
}
