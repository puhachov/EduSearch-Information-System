using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRead
{
    class FileRead
    {
        public static string ReadFile(string path)
        {          

            // SOLUTION 1
            System.IO.TextReader reader = new System.IO.StreamReader(path);
            string text = reader.ReadToEnd();            
            reader.Close();
            return text;
        }
    }
}
