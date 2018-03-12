using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {


        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("Hour: " + now.Hour);
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd  HH:mm"));

            var timeSapn = new TimeSpan(1, 2, 3);

            int[] items = { 1, 2, 3 };
            double[] numArray = new double[5];
            var counter = 3;
            for (int i = 0; i < numArray.Length; i++)
            {
                counter++;
                numArray[i] = counter;
            }
            foreach (int number in numArray)
            {
                Console.WriteLine(number);
            }

            foreach (int item in items)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

        }
        
    }
}
