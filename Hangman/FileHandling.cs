using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    class FileHandling
    {
        public static List<string> words = new List<string>();
        public static void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.Filter = "Text files (*.txt)| *.txt";
            ofd.ShowDialog();
            string filename = ofd.FileName;
            words.Clear();
            try
            {
                StreamReader reader = new StreamReader(filename);

                while (reader.EndOfStream != true)
                {
                    words.Add(reader.ReadLine());
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
