using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;
using System.IO;

namespace CSharp.CodesFromWeb.FileAppendText
{
    class WorkingWithFile
    {
        static void Main(string[] args)
        {
           /* string fileName = "SampleFile.txt";
            String myPath;
            myPath = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(myPath);
            Console.ReadLine();*/

            string path = @"C:\\Users\\Azuce\\source\\repos\\ernestoOlaez\\CSharp\\CSharp\\CodesFromWeb\\FileAppendText\\MyTest.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

                //This text is always added
                using(StreamWriter sw= File.AppendText(path))
                {
                    
                    sw.WriteLine("This is a Extra Line");
                    sw.WriteLine("Ernesto Gonzalez Olaez");
                    sw.WriteLine("One.");
                }

                // Open the file to read from.
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.ReadLine();

            }
        
    }
}
