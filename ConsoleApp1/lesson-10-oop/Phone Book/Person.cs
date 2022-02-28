using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10_oop.Phone_Book
{
    internal class Person
    {
        public string Name;

        public Person(string name)
        {
            this.Name = name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
