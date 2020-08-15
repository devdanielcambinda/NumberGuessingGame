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
            List<Jogada> history = new List<Jogada>();
            string difficulty = "Medium";
            do
            {
                Console.Clear();
                Console.WriteLine("******************************************");
                Console.WriteLine("*           Number Guessing Game         *");
                Console.WriteLine("*  1- Player tries to guess the number   *");
                Console.WriteLine("*  2- Computer tries to guess the number *");
                Console.WriteLine("*  3- History                            *");
                Console.WriteLine("*  4- Settings                           *");
                Console.WriteLine("*  0- Quit                               *");
                Console.WriteLine("******************************************");
                Console.Write("Option: ");
                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        if (difficulty.Equals("Low"))
                        {
                            Console.Clear();
                            Random randomNumber = new Random();
                            number = randomNumber.Next(0, 11);
                            tries = 0;
                            do
                            {
                                Console.WriteLine("Try to guess the number (0-10)");
                                Console.Write("Number: ");
                                guess = Convert.ToInt32(Console.ReadLine());
                                tries++;
                                if (guess > number)
                                {
                                    Console.WriteLine($"The number is smaller than {guess}.\n");
                                }
                                else if (guess < number)
                                {
                                    Console.WriteLine($"The number is bigger than {guess}.\n");
                                }
                                else
                                {
                                    Console.WriteLine($"Correct ! You guessed the number {number} in {tries} try/tries . ");
                                    Console.WriteLine("Press any key to continue ...");
                                    Console.ReadKey();
                                    history.Add(new Jogada("Player", number, tries,difficulty));
                                }
                            } while (number != guess);
                        }
                        else if (difficulty.Equals("Medium"))
                        {
                            Console.Clear();
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
                                }
                                else if (guess < number)
                                {
                                    Console.WriteLine($"The number is bigger than {guess}.\n");
                                }
                                else
                                {
                                    Console.WriteLine($"Correct ! You guessed the number {number} in {tries} try/tries . ");
                                    Console.WriteLine("Press any key to continue ...");
                                    Console.ReadKey();
                                    history.Add(new Jogada("Player", number, tries,difficulty));
                                }
                            } while (number != guess);
                        }else if (difficulty.Equals("Hard"))
                        {
                            Console.Clear();
                            Random randomNumber = new Random();
                            number = randomNumber.Next(0, 1001);
                            tries = 0;
                            do
                            {
                                Console.WriteLine("Try to guess the number (0-1000)");
                                Console.Write("Number: ");
                                guess = Convert.ToInt32(Console.ReadLine());
                                tries++;
                                if (guess > number)
                                {
                                    Console.WriteLine($"The number is smaller than {guess}.\n");
                                }
                                else if (guess < number)
                                {
                                    Console.WriteLine($"The number is bigger than {guess}.\n");
                                }
                                else
                                {
                                    Console.WriteLine($"Correct ! You guessed the number {number} in {tries} try/tries . ");
                                    Console.WriteLine("Press any key to continue ...");
                                    Console.ReadKey();
                                    history.Add(new Jogada("Player", number, tries,difficulty));
                                }
                            } while (number != guess);
                        }
                        break;
                    case 2:
                        
                        if (difficulty.Equals("Low"))
                        {
                            Console.Clear();
                            Console.WriteLine("Think in a number between 0 and 10");
                            tries = 0;
                            limSup = 11;
                            limInf = 0;
                            do
                            {
                                guess = (limInf + limSup) / 2;
                                tries++;
                                Console.Write($"Is the number you are thinking {guess} ?  (Y/N) ");
                                string input = Console.ReadLine();
                                right = input[0];
                                Char.ToLower(right);

                                if (right == 'n' || right =='N')
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
                                }
                                else if (right == 'y' || right =='Y' )
                                {
                                    Console.WriteLine($"I found the number {guess} within {tries} try/tries");
                                    Console.WriteLine("Press any key to continue ...");
                                    Console.ReadKey();
                                    history.Add(new Jogada("Computer", guess, tries,difficulty));
                                }
                            } while (right == 'n' || right =='N');
                        }
                        else if (difficulty.Equals("Medium"))
                        {
                            Console.Clear();
                            Console.WriteLine("Think in a number between 0 and 100");
                            tries = 0;
                            limSup = 101;
                            limInf = 0;
                            do
                            {
                                guess = (limInf + limSup) / 2;
                                tries++;
                                Console.Write($"Is the number you are thinking {guess} ?  (Y/N) ");
                                string input = Console.ReadLine();
                                right = input[0];
                                Char.ToLower(right);

                                if (right == 'n' || right == 'N')
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
                                }
                                else if (right == 'y' || right == 'Y' )
                                {
                                    Console.WriteLine($"I found the number {guess} within {tries} try/tries");
                                    Console.WriteLine("Press any key to continue ...");
                                    Console.ReadKey();
                                    history.Add(new Jogada("Computer", guess, tries,difficulty));
                                }
                            } while (right == 'n' || right == 'N');
                        }
                        else if (difficulty.Equals("Hard"))
                        {
                            Console.Clear();
                            Console.WriteLine("Think in a number between 0 and 1000");
                            tries = 0;
                            limSup = 1001;
                            limInf = 0;
                            do
                            {
                                guess = (limInf + limSup) / 2;
                                tries++;
                                Console.Write($"Is the number you are thinking {guess} ?  (Y/N) ");
                                string input = Console.ReadLine();
                                right = input[0];
                                Char.ToLower(right);

                                if (right == 'n' || right=='N')
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
                                }
                                else if ( right == 'y' || right == 'Y' )
                                {
                                    Console.WriteLine($"I found the number {guess} within {tries} try/tries");
                                    Console.WriteLine("Press any key to continue ...");
                                    Console.ReadKey();
                                    history.Add(new Jogada("Computer", guess, tries,difficulty));
                                }
                            } while (right == 'n' || right == 'N');
                        }
                        break;
                    case 3:
                        Console.Clear();
                        
                        if (history.Count == 0)
                        {
                            Console.WriteLine("No matches played yet ! ");
                        }
                        else
                        {
                            for (int i = 0; i < history.Count; i++)
                            {
                                Console.WriteLine($"Play #{i + 1}");
                                Console.WriteLine("Guesser: {0}" , history[i].Guesser);
                                Console.WriteLine("Number: {0}" , history[i].Number);
                                Console.WriteLine("Difficulty: {0}" , history[i].Difficulty);
                                Console.WriteLine("Try/tries: {0}" , history[i].Tries + "\n");
                            }
                        }
 
                        Console.WriteLine("Press any key to return to menu ...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($" Your Current difficulty is {difficulty}");
                        Console.WriteLine("Difficulty levels: ");
                        Console.WriteLine("1-Low");
                        Console.WriteLine("2-Medium");
                        Console.WriteLine("3-Hard");
                        Console.WriteLine("Do you want to switch difficulty ? Y/N ");
                        string difficulty_question = Console.ReadLine();
                        if (difficulty_question.Equals("Y"))
                        {
                            Console.WriteLine("Wich difficulty do you want ?");
                            Console.Write("Option: ");
                            switch (Int32.Parse(Console.ReadLine()))
                            {
                                case 1:
                                    difficulty = "Low";
                                    break;
                                case 2:
                                    difficulty = "Medium";
                                    break;
                                case 3:
                                    difficulty = "Hard";
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (difficulty_question.Equals("N"))
                        {
                            Console.WriteLine("You choose not to switch the game difficulty ");
                            Console.WriteLine("Press any key to return to the main menu ...");
                            Console.ReadKey();
                        }else
                        {
                            Console.WriteLine("Invalid Input ...");
                            Console.WriteLine("Press any key to return to the main menu ...");
                            Console.ReadKey();
                        }
                       
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
