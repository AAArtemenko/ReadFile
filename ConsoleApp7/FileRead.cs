using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class FileRead
    {
        private string DirName { get; set; }

        public FileRead(string DirName)
        {
            this.DirName = DirName;
        }

        public void GetFiles()
        {
            if (Directory.Exists(DirName))
            {
                Console.WriteLine("Files:");
                string[] files = Directory.GetFiles(DirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            else
                Console.WriteLine("Directory not found");
        }
    }
}
