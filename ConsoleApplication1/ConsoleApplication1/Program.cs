using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name? ");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your last name? ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}, how's it going? {0}", firstname, lastname);
        }
    }
}
