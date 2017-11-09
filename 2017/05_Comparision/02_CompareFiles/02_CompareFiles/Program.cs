using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _02_CompareFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("USB_Legacy_Disabled.txt");

            string line = "";
            int counter = 0;

            while ((line = sr.ReadLine()) != null)
            {
                counter++;

                Console.WriteLine("{0}:{1}", counter, line);
            }

            Console.WriteLine("we have {0} names in the txt file", counter);
            Console.ReadLine();

        }
    }
}
