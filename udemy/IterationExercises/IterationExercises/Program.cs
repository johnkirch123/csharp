using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* count how many times 3 is divisible in 100 */
            var counter = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    counter++;
            }
            Console.WriteLine("There are " + counter + " counts where" +
                " 3 is divisible by 100 with no remainder");

            /* Prgoram asks user for inputs and type "ok" to exit, 
             * sum all numbers.
             */
            Console.WriteLine("Enter numbers to sum (type ok to exit)");
            var sum = 0;
            do
            {
                var word = Console.ReadLine();
                if (word.Equals("ok"))
                    break;
                else
                    sum += int.Parse(word);
            } while (true);
            Console.WriteLine("The sum of the numbers is " + sum);

            /* Program computes the factorial that the user enters */
            Console.WriteLine("Enter a number to compute it's factorial");
            var factorial = int.Parse(Console.ReadLine());
            var answer = 1;
            for (var i = factorial; i > 0; i--)
                answer *= i;
            Console.WriteLine(factorial + "! = " + answer);

            /* Program gives the user 4 attempts to guess the correct random 
             * number between 1 and 10
             */
            var random = new Random();
            var randomNumber = random.Next(1, 11);
            Console.WriteLine(randomNumber);
            for (var i = 4; i > 0; i--)
            {
                Console.WriteLine("Guess the correct number between 1 and 10(" +
                i + " attempts left)");
                var guess = int.Parse(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (i == 1)
                {
                    Console.WriteLine("You lost!");
                    break;
                }
            }

            /* Prompt user to enter comma separated numbers and display max */
            Console.WriteLine("Enter a series of comma separated numbers to see the max ");
            string numbers = Console.ReadLine();
            List<int> numList = numbers.Split(',').Select(int.Parse).ToList();
            var maxNum = 0;
            foreach (var num in numList)
            {
                if (num > maxNum)
                    maxNum = num;
            }
            Console.WriteLine("The maximum number you entered is " + maxNum);
        }
    }
}
