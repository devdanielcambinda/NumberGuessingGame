using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int option, number, guess, tries, tip, limSup, limInf;
            char right;

            do
            {
                Console.Clear();
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
                            Console.Write("Number: ");
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
                                Console.WriteLine($"Correct ! You guessed the number {number} in {tries} try/tries . ");
                                Console.WriteLine("Press any key to continue ...");
                                Console.ReadKey();
                            }
                        } while (number != guess);
                        break;
                    case 2:
                        Console.WriteLine("Think in a number between 0 and 100");
                        tries = 0;
                        limSup = 101;
                        limInf = 0;
                        do
                        {
                            Console.Clear();
                            guess = (limInf + limSup) / 2;
                            tries++;
                            Console.Write($"Is the number you are thinking {guess} ?  (Y/N) ");
                            string input = Console.ReadLine();
                            right = input[0];
                            Char.ToLower(right);
                            
                            if ( right == 'n')
                            {
                                Console.WriteLine($"Is it higher or lower than {guess} ? (1 if higher 0 if lower)");
                                tip = Int32.Parse(Console.ReadLine());
                                switch (tip)
                                {
                                    case 1:
                                        limInf = guess;
                                        break;
                                    case 0:
                                        limSup = guess;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input");
                                        Console.WriteLine("Press any key to continue ...");
                                        Console.ReadKey();
                                        break;

                                }
                            }else if ( (right = 'y') != '\0' )
                            {
                                Console.WriteLine($"I found the number {guess} within {tries} try/tries");
                                Console.WriteLine("Press any key to continue ...");
                                Console.ReadKey();
                            }
                        } while (right == 'n' );
                        break;
                    case 3:
                        
                        break;
                    case 0:
                        Console.WriteLine("See you later! Have a good one! ");
                        Console.WriteLine("Press any key to leave ...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Please insert a valid input!");
                        Console.WriteLine("Press any key...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        
                }
                

            } while (option != 0);


        }
    }
}
