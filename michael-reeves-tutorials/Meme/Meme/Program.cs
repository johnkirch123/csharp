using System;

namespace Meme
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {

            // Console.WriteLine("Hello World");
            String x = "Hello World";
            Console.WriteLine(x);
            int y = 500;
            Console.WriteLine(y);

            bool intersects = false;

            Console.WriteLine("Do the circles intersect? ");
            Console.WriteLine(intersects);

            SimpleMethod();
            Console.WriteLine("");
            IfStatementTest();

        }

        private static void SimpleMethod()
        {
            Console.Write("Your name: ");
            string input = Console.ReadLine();
            Console.Write("What is your age: ");
            string age = Console.ReadLine();
            x = Int32.Parse(age);
            Console.WriteLine("My name is: " + input + " and I am " + age);
        }

        private static void IfStatementTest()
        {
            if (x == 10)
            {
                Console.WriteLine("Age is equal to 10");
            }
            else
            {
                Console.WriteLine(x + " does not equal 10");
            }
        }
    }
}
