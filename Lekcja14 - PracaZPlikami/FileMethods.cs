using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja14___PracaZPlikami
{

    class FileMethods
    {
        public static void WriteFile(string path, string content)
        {
            using (StreamWriter fm = new StreamWriter(path))
            {
                fm.Write(content);
            }
        }

        public static void ReadFile(string path)
        {
            using (StreamReader fm = new StreamReader(path))
            {
                Console.WriteLine(fm.ReadToEnd());
            }
        }
    }
}
