using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var doubles = new GenericList<double>();
            doubles.Add(23.5);

            var dictionary = new GenericDictionary<string, GenericList<int>>();

            var num = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + num.HasValue);
            Console.WriteLine("Value: " + num.GetValueOrDefault());
        }
    }
}
