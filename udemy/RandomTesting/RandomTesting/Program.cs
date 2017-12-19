using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            const int PasswordLength = 10;
            var buffer = new char[PasswordLength];
            for (var i = 0; i < PasswordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            var password = new string(buffer);

            Console.WriteLine(password);
        }

    }
}
