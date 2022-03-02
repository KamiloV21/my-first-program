using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_oop.Library
{
    internal class Person
    {
        public string Name;
        public string SerName;
        public int Age;

        public static Person NewPerson()
        {
            Person person = new Person();
            person.Name = "Max";
            person.Age = 18;
            person.SerName = "Kalin";
        }
    }
}
