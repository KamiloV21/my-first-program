using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_opp.Library
{
    internal class Person
    {
        public string Name;
        public string SerName;
        public int Age;
        public string Book;

        public void Print()
        {
            Console.WriteLine($"Имя человека: {Name}");
            Console.WriteLine($"Фамилия человека: {SerName}");
            Console.WriteLine($"Возраст человека: {Age}");
        }
    }
}
