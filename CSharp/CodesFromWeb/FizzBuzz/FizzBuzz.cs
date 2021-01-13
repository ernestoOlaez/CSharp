using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.CodesFromWeb.FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz");
            Console.WriteLine("Inser the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                //Console.WriteLine(+i);
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(+i);
                }
            }
        }
    }
}
