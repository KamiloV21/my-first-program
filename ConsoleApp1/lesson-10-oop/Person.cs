using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10_oop
{
    internal class Person
    {
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName;
        public string LastName;
        public int Age;

        public void Print()
        {
            Console.WriteLine($"{this.FirstName} {LastName}, {this.Age}");
        }

        public string GetInfo()
        {
            return $"{this.FirstName} {LastName}, {this.Age}";
        }

        public static Person Create(string firstName, string lastName)
        {
            return new Person
            {
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}
