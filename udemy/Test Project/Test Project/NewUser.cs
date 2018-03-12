using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project
{
    public class NewUser
    {
        private string firstName;
        private string lastName;
        private int age;
        private string email;

        public NewUser()
        {
            this.firstName = "John";
            this.lastName = "Doe";
            this.age = 21;
        }

        public NewUser(string firstName)
        {
            this.firstName = firstName;
            this.lastName = "Doe";
            this.age = 21;
        }

        public NewUser(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = 21;
        }

        public NewUser(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public string ToString()
        {
            return "First name: " + firstName + ", Last name: " + lastName + ", Age: " + age;
        }
    }
}
