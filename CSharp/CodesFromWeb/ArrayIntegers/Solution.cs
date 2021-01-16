using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CSharp.CodesFromWeb.ArrayIntegers
{
    class Solution
    {
        /*
    * Complete the simpleArraySum function below.
    */
        private static int simpleArraySum(List<int> lst)
        {
            int sum = 0;
            for (int i = 0; i <= lst.Count - 1; i++)
            {
                sum += lst[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //System.IO.TextWriter textWriter = new StreamWriter("C:\\Users\\olaez\\Source\\Repos\\ernestoOlaez\\CSharp\\CSharp\\CodesFromWeb\\ArrayIntegers\\textwriter.txt");

            string path = @"C:\\Users\\olaez\\Source\\Repos\\ernestoOlaez\\CSharp\\CSharp\\CodesFromWeb\\ArrayIntegers\\textwriter.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("1");
                    sw.WriteLine("24");
                    sw.WriteLine("88");
                }
            }




            List<int> lst = new List<int>();
            int[] integerArray = new int[44];
            int contor = 0;
            string[] stringArray2 = System.IO.File.ReadAllLines(@"C:\\Users\\olaez\\Source\\Repos\\ernestoOlaez\\CSharp\\CSharp\\CodesFromWeb\\ArrayIntegers\\textwriter.txt");

            foreach (string example in stringArray2)
            {
                lst.Add(Convert.ToInt32(example.Trim()));
                integerArray[contor] = Convert.ToInt32(example.Trim());
                ++contor;
            }
            lst.ForEach(Console.WriteLine);
            int result = simpleArraySum(lst);


            // System.IO.TextWriter textWriter2 = new StreamWriter("C:\\Users\\olaez\\Source\\Repos\\ernestoOlaez\\CSharp\\CSharp\\CodesFromWeb\\ArrayIntegers\\OUTPUT.txt");
            //textWriter2.WriteLine(result);
            // textWriter2.Flush();
            //textWriter2.Close();

            using (StreamWriter sw = File.AppendText(path))
            {

                // sw.WriteLine(result);
            }
            Console.WriteLine("The output from the file is:");
            Console.WriteLine(result);
            Console.ReadLine();


            if (File.Exists(path))
            {
                File.Delete("C:\\Users\\olaez\\Source\\Repos\\ernestoOlaez\\CSharp\\CSharp\\CodesFromWeb\\ArrayIntegers\\textwriter.txt");
            }

        }

      
    }
    }

