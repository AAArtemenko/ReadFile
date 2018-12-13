using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter directiry: ");
            FileRead txt = new FileRead(Console.ReadLine());           
            txt.GetFiles();
            Console.WriteLine("Enter path to the file: ");
            try
            {
                using (StreamReader streamWriter = File.OpenText(Console.ReadLine()))
                {
                    Console.WriteLine(streamWriter.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
