using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace _01_ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("TextFile1.txt");

            string line = "";
            int counter = 0;

            while ((line = sr.ReadLine())!=null)
            {
                counter++;

                Console.WriteLine("{0}:{1}", counter, line);                
            }

            Console.WriteLine("we have {0} names in the txt file", counter);
            Console.ReadLine();
        }
    }
}
