using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourNumber = new Random().Next(1, 21);
            int guessNumber = 0;

            for (int n = 5; n > 0; n--)
            {
                guessNumber = getGuess();

                if (guessNumber == ourNumber)
                {
                    Console.WriteLine("Correct! Well Done!");
                    break;
                }
                else if (guessNumber != ourNumber && n > 1)
                {
                    Console.WriteLine("Oops, sorry you only have {0} guesses left.", n-1);
                }
                else
                {
                    Console.WriteLine("Sorry, the correct number is {0}!", ourNumber);
                }
            }

            //while (ourNumber != guessNumber)
            //{
            //    guessNumber = getGuess();

            //    if (guessNumber == ourNumber)
            //    {
            //        Console.WriteLine("Correct! Well Done!");
            //    }
            //    else if (guessNumber > ourNumber)
            //    {
            //        Console.WriteLine("Opps, sorry your number was too high");
            //    }
            //    else if (guessNumber < ourNumber)
            //    {
            //        Console.WriteLine("Opps, sorry your number was too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, that is wrong!");
            //    }
            //}

            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }

        static int getGuess()
        {
            int result = 0;

            Console.WriteLine("Please guess a number between 1 and 20.");
            String answer = Console.ReadLine();
            Int32.TryParse(answer, out result);
            return result;
        }
    }
}
