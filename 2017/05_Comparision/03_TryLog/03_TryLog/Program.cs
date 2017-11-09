using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_TryLog
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Comparison_Result.txt";
            //string sourcePath = @"C:\C_MyCode\Scrapmetal\2017\05_Comparision\03_TryLog\03_TryLog\bin\Debug";
            string targetPath = @"C:\C_MyCode";
            string path = Directory.GetCurrentDirectory();

            Console.WriteLine("The current directory is {0}", path);

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(path, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            StreamWriter sw = new StreamWriter("Comparison_Result.txt");
            //FileStream sw = new FileStream("C:\\Comparison_Result.txt", FileMode.Append, FileAccess.Write); 


            string[] Lines1 = File.ReadAllLines("USB Legacy Disabled.log");
            string[] Lines2 = File.ReadAllLines("USB UEFI Disabled.log");

            Console.WriteLine(Lines1[22]);

            if (Lines1[22].Contains("Administrator Only") == Lines2[22].Contains("Administrator Only"))
            {
                Console.WriteLine("Result = Equal");
                sw.WriteLine("Result = Equal");

                //System.IO.File.WriteAllLines(@"C:\WriteLines.txt", Lines1);
            }
            else
            {
                Console.WriteLine("Result = Not Equal");
                //sw.WriteLine("Result = Not Equal");
            }

            sw.Flush();
            sw.Close();
            //FileStream sw = new FileStream("C:\\Comparison_Result.txt", FileMode.Append, FileAccess.Write); 

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
            //File.SetAttributes(destFile, FileAttributes.Normal);
            //file.SaveAs(Path.Combine(targetPath, file.destFile));

        }
    }
}
