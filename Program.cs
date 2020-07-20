using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int option, number = 0, guess, tries, tip;
            char right;

            do
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("*           Number Guessing Game         *");
                Console.WriteLine("*  1- Player tries to guess the number   *");
                Console.WriteLine("*  2- Computer tries to guess the number *");
                Console.WriteLine("*  3- History                            *");
                Console.WriteLine("*  0- Quit                               *");
                Console.WriteLine("******************************************");
                option = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"{option}");

                Console.ReadKey();

            } while (option != 0);


        }
    }
}
