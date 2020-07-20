using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int option, number , guess, tries, tip;
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

                switch (option)
                {
                    case 1:
                        Random randomNumber = new Random();
                        number = randomNumber.Next(0, 101);
                        tries = 0;
                        do
                        {
                            Console.WriteLine("Try to guess the number (0-100)");
                            guess = Convert.ToInt32(Console.ReadLine());
                            tries++;
                            if (guess > number)
                            {
                                Console.WriteLine($"The number is smaller than {guess}.\n");
                            }else if(guess < number )
                            {
                                Console.WriteLine($"The number is bigger than {guess}.\n");
                            }
                            else
                            {
                                Console.WriteLine($"Correct ! You guessed the number {number} in {tries} try/tries .\n ");
                            }
                        } while (number != guess);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Please insert a valid input!");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        break;
                        
                }
                

            } while (option != 0);


        }
    }
}
