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
            int i;

            string[] Lines1 = File.ReadAllLines("USB_Legacy_Disabled.txt");
            string[] Lines2 = File.ReadAllLines("USB_UEFI_Disabled.txt");

            Console.WriteLine(Lines1[22]);

            if (Lines1[22].Contains("Administrator Only"))
            {
                Console.WriteLine("Administrator Only was found");
            }
            //for(i=0; i <= 22; i++)
            //{
            //    Console.WriteLine(Lines1[i]);
            //}

            //foreach (string s in Lines1)
            //{
            //    Console.WriteLine(s);
            //}

            //for (int line = 0; line < Lines1.Length; line++)
            //{
            //    if (line < Lines2.Length)
            //    {
            //        if (Lines1[line].Equals(Lines2[line]))
            //        {
            //            // lines from both the file are same
            //            Console.WriteLine("lines from both the file are same");
            //        }
            //        else
            //        {
            //            // Lines are not same
            //            Console.WriteLine("Lines are not same");
            //        }
            //    }
            //    else
            //    {
            //        // Doesnt exits in second file
            //        Console.WriteLine("Doesnt exits in second file");
            //    }                
            //}
            Console.ReadLine();
        }
    }
}
