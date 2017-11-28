using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "John";
            bool isWorking = true;
            var numbers = 4;
            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(numbers);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine(Pi);

            byte b = 1;
            int i = b;

            Console.WriteLine(i);
            
            try
            {
                string numberr = "1234";
                byte inn = Convert.ToByte(numberr);
                Console.WriteLine(inn);

                try
                {
                    string str = "true";
                    bool bo = Convert.ToBoolean(str);
                    Console.WriteLine(bo);
                }
                catch (Exception)
                {
                    Console.WriteLine("The string cannot be converted to a boolean");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Your number is too big!");
            }
        }
    }
}
