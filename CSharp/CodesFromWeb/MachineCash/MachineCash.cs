using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.CodesFromWeb.MachineCash
{
    class MachineCash
    {
        static void Main(string[] args)
        {
            //This is a new Line From Stacy PC
            Console.WriteLine("Insert the amount to change:");
            int amount = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            List<int> numbers = new List<int>() { 1, 2, 5, 10, 20 };
            numbers.Reverse();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
                if (amount % i != 0)
                {
                    amount -= i;
                    count++;
                }


            }
            Console.WriteLine("The number of coins are: " + count);
            Console.ReadLine();
        }
    }
}
