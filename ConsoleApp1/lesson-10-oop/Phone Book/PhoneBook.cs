using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10_oop.Phone_Book
{
    internal class PhoneBook
    {
        public PhoneBookRecord[] Persons;

        public PhoneBook(PhoneBookRecord[] persons)
        {
            this.Persons = persons;
        }

        public void Print()
        {
            foreach (var item in this.Persons)
            {
                item.Print();
            }
        }
    }
}
