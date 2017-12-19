using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterAValidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Program is valid if the number is between
             * 1 and 10, if not it is invalid
             */
            Console.WriteLine("Please enter a number between 1 and 10");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            /* Program takes 2 numbers as inpuits and displays 
             * the max
             */
            Console.WriteLine("Enter 2 numbers, I will display the max:");
            Console.WriteLine("Number 1: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2: ");
            var number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The max number is: " + Math.Max(number1, number2));

            /* Program takes 2 numbers as inputs and
             * tells the user if the numbers (height and 
             * width) make an image that is a portrait, 
             * landscape, or a square.
             */
            Console.WriteLine("Enter width and height and I will tell you if the image" +
                " is landscape or portrait");
            Console.WriteLine("Height: ");
            var height = int.Parse(Console.ReadLine());
            Console.WriteLine("Width: ");
            var width = int.Parse(Console.ReadLine());
            if (height > width)
                Console.WriteLine("Image is portrait");
            else if (width > height)
                Console.WriteLine("Image is landscape");
            else
                Console.WriteLine("Image is square");

            /* Program asks user to enter speed limit, then 
             * ask the user the speed of the car, display OK 
             * if the speed is below the speed limit and demerit
             * points are incurred if for every 5km/hr above the 
             * speed limit, after 12, license suspended.
             */
            const int DemeritSpeed = 5;
            Console.WriteLine("What is the speed limit?");
            var speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the speed of the vehicle?");
            var speedOfVehicle = int.Parse(Console.ReadLine());
            if (speedOfVehicle > speedLimit)
            {
                int demeritPoints = (speedOfVehicle - speedLimit) / DemeritSpeed;
                if (demeritPoints > 12)
                    Console.WriteLine("You license is suspended");
                else
                    Console.WriteLine("You are docked " + demeritPoints + " points");
            }
            else
            {
                Console.WriteLine("Your speed is OK!");
            }

        }
    }
}
