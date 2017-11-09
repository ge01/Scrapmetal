using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteOut
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            String myOutLine;
            Console.Write("Enter your first name:");
            firstName = Convert.ToString(Console.ReadLine());
            string path = @"file.txt";
            myOutLine = firstName;

            if (!File.Exists (path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(myOutLine);
                }
                Console.ReadKey();
            }
        }
    }
}
