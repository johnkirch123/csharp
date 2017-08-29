using System;

namespace Meme
{
    class Program
    {
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

        }

        private static void SimpleMethod()
        {
            Console.Write("Your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Name: " + input);
        }
    }
}
