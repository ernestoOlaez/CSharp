using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Chapter1.ProgramOne
{
    class Person
    {
        // Name of person
        public String Name;

        // Year of Birth
        public int BornYear;

        // Place of Birth
        public String PlaceOfBirth;

        // This Constructor has 3 parameters. 
        // The aim to initialize the value for fields of Person.
        // Specify the name, year of birth, place of birth.
        public Person(String Name, int BornYear, String PlaceOfBirth)
        {
            this.Name = Name;
            this.BornYear = BornYear;
            this.PlaceOfBirth = PlaceOfBirth;
        }

        // This Constructor have 2 parameters. 
        // Purpose initialize for two fields (name & Born year) of Person.
        // PlaceOfBirth not be initialized.
        public Person(String Name, int BornYear)
        {
            this.Name = Name;
            this.BornYear = BornYear;
        }

    }
}
