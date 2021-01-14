using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.Chapter1.ProgramOne
{
    class PersonDemo
    {

        static void Main(string[] args)
        {

            // Instance: Thomas Edison.
            // Created by Constructor has 2 parameters of the Person class.
            Person edison = new Person("Thomas Edison", 1847);

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + edison.Name);
            Console.WriteLine("Born Year: " + edison.BornYear);
            Console.WriteLine("Place Of Birth: " + edison.PlaceOfBirth);

            // Instance: Bill Gates.
            // Created by Constructor has 3 parameters of the Person class.
            Person billGates = new Person("Bill Gate", 1955, "Seattle, Washington");

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Info:");
            Console.WriteLine("Name: " + billGates.Name);
            Console.WriteLine("Born Year: " + billGates.BornYear);
            Console.WriteLine("Place Of Birth: " + billGates.PlaceOfBirth);

            Console.ReadLine();
        }
    }
}

