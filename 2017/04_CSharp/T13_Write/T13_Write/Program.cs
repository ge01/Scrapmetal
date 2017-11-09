using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T13_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            int frequency;
            int duration;

            StreamWriter sw = new StreamWriter("song.txt");

            do
            {
                Console.Write("Please enter a frequency:");
                frequency = Int32.Parse(Console.ReadLine());
                if (frequency == -1) break;
                Console.Write("Please enter the duration in milliseconds: ");
                duration = Int32.Parse(Console.ReadLine());
                Console.Beep(frequency, duration);
                sw.WriteLine(frequency + "," + duration);
            } while (frequency != -1);
            sw.Flush();
            sw.Close();
        }
    }
}
