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

            else
                Console.WriteLine("You Are Young");

            }
        }
    }
