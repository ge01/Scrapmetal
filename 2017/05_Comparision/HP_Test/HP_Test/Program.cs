using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HP_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to hold file name and paths
            string fileName = "Comparison_Result.txt";
            string sourcePath = Directory.GetCurrentDirectory();
            string targetPath = @"C:\Result";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // Write string to file "Comparison_Result.txt"
            StreamWriter sw = new StreamWriter("Comparison_Result.txt");

            // Open the file to read from.
            string[] Lines1 = File.ReadAllLines("USB Legacy Disabled.log");
            string[] Lines2 = File.ReadAllLines("USB UEFI Disabled.log");

            // Comparison - Result
            // Look for phrase "Administrator Only" in both log files.
            if (Lines1[22].Contains("Administrator Only") == Lines2[22].Contains("Administrator Only"))
            {
                sw.WriteLine("Result = Equal");
            }
            else
            {
                sw.WriteLine("Result = Not Equal");
            }

            // Clear buffer for stream and cause any buffered
            // data to be written to file.
            sw.Flush();
            sw.Close();

            // Copy folder's contents to a new location and
            // create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            // Copy file to another location and overwrite 
            // the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }
    }
}
