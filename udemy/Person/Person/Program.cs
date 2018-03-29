using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new DateTime(1980, 8, 2));
            john._firstName = "John";
            john._lastName = "Kirch";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var person = new Person(new DateTime(1980, 8, 2));
            Console.WriteLine(person.Age);
        }
    }
}
