using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.CodesFromWeb.SolveMeFirst
{
    class SolveMeFirst
    {
        //svm
        static void Main(string[] args)
        {
            Console.WriteLine("Solve me First:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
           sum= functionSolveMeFirst(val1, val2);
            Console.WriteLine("The sum =" + sum);


        }

        static int  functionSolveMeFirst(int val1, int val2)
        {
           
            return val1 + val2;
        }

    }
}
