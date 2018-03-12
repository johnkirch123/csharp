using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    class Program
    {
        // int, float, double, bool, string, byte, char
        double pi = Math.PI;

        static void Main(string[] args)
        {
            NewUser user1 = new NewUser("Mitch", "Metz", 23);
            NewUser user2 = new NewUser("John", "Kirch", 37);
            NewUser user3 = new NewUser();

            Console.WriteLine(user1.ToString());
            Console.WriteLine(user2.ToString());
            Console.WriteLine(user3.ToString());

            NewUser[] userArray = new NewUser[] { user1, user2, user3 };

            foreach (NewUser user in userArray)
                Console.WriteLine(user.ToString());
        }
        
    }
}
