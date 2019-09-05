using System;

namespace AgeAppClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Age App 1.0");

            Console.WriteLine("Please Enter Your Age When Ready: ");

            string personsAge = Console.ReadLine();
            double personsAgeEntered = Convert.ToDouble(personsAge);

            if (personsAgeEntered >= 100)
                Console.WriteLine("This program is for humans. Are You An Alien? ");

            else if (personsAgeEntered >= 66)
                Console.WriteLine("Golden Years ");

            else if (personsAgeEntered >= 23)
                Console.WriteLine("Working For The Man ");

            else if (personsAgeEntered >= 19)
                Console.WriteLine("College Age ");

            else if (personsAgeEntered >= 15)
                Console.WriteLine("HighSchool ");

            else if (personsAgeEntered >= 12)
                Console.WriteLine("Middle School ");

            else if (personsAgeEntered >= 5)
                Console.WriteLine("Elementary School ");

            else if (personsAgeEntered >= 3)
                Console.WriteLine("PreSchool ");

            else
                Console.WriteLine("You Are To Young To Use A Computer");

            }
        }
    }
