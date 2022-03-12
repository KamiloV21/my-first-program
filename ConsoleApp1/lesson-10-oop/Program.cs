using lesson_10_oop.Phone_Book;
using System;

namespace lesson_10_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Max";
            person.LastName = "Kalin";
            person.Age = 18;

            Person otherPerson = new Person("Alex", "Smit");
            otherPerson.Age = 15;

            person.Print();
            Console.WriteLine(otherPerson.GetInfo());

            var secondPersin = Person.Create("Nick", "qwerty");
            secondPersin.Print();

            var record = new Phone_Book.PhoneBookRecord(new Phone_Book.Person("Serhii"), 0987654321);
            var otherRecord = new Phone_Book.PhoneBookRecord(new Phone_Book.Person("Max"), 0987654321);

            PhoneBook book = new PhoneBook(new PhoneBookRecord[]
            {
                record,
                otherRecord
            });

            record.Person.SetName("Alex");
            book.Print();
            //record.Print();
        }
    }
}
