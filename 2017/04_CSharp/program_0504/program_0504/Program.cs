using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace program_0504
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a StreamWriter variable.
            StreamWriter outputFile;

            // Create a file and get a StreamWriter object
            outputFile = File.CreateText("Numbers.txt");

            // Write the numbers 1 through 10; count++
            for (int count = 1; count <= 10; count++)
            {
                outputFile.WriteLine(count);
            }

            // Close the file.
            outputFile.Close();



        }
    }
}
