using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    // Properties
    public class Person
    {
        public string _firstName;
        public DateTime Birthdate { get; private set; }
        //public string _lastName { get => _lastName; set => _lastName = value; }
        public string _lastName { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            }
        }

        public void Introduce()
        {
            Console.WriteLine("My name is " + _firstName);
        }
    }
}
