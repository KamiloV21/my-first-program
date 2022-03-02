using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_opp.Library
{
    internal class Book
    {
        public string Title;
        public string Autor;
        public string Genre;
        private string Text;

        public void SetParams(string autor, string title, string genre, string text)
        {
            Autor = autor;
            Title = title;
            Genre = genre;
            Text = text;
        }

        public Book WriteBook()
        {
            Book book1 = new Book();
            Console.WriteLine("Какое хотите название вашей книги ?");
            string bookTitle = Console.ReadLine();
            Console.WriteLine($"Кто автор этой книги {bookTitle} ?");
            string bookAutor = Console.ReadLine();
            Console.WriteLine($"Какой жанр вашей книги {bookTitle} ?");
            string bookGenre = Console.ReadLine();
            Console.WriteLine($"Что вы хотите написать в книге {bookTitle} ?");
            string Text = Console.ReadLine();
            book1.SetParams(bookTitle, bookAutor, bookGenre, Text);
            Console.WriteLine($"Ваша книга написана!");
            Console.WriteLine($"Ваша книга: {bookTitle} {bookAutor} {bookGenre}. Написано в ней {Text}");
            return book1;
        }

        public Book Findbook()
        {
            Book book = new Book();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            bool parseAnswer;
            string userInput;

            book1.Title = "Мастер и Маргарита";
            book1.Genre = "Роман";
            book1.Autor = "Михаил Булгаков";
            book2.Title = "Маленький принц";
            book2.Genre = "Философская сказка";
            book2.Autor = "Антуан де Сент-Экзюпери";
            book3.Title = "Гарри Поттер и философский камень";
            book3.Genre = "Фэнтези";
            book3.Autor = "Джоан Роулинг";

            Console.WriteLine("Выберите книгу от 1 до 3:");
            userInput = Console.ReadLine();
            parseAnswer = int.TryParse(userInput, out int a);
            if (parseAnswer == false)
            {
                Console.WriteLine("Вы ввели не число введите число! ");
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine($"Название: {book1.Title}, Автор: {book1.Autor}, Жанр: {book1.Genre}");
                    break;
                case 2:
                    Console.WriteLine($"Название:{book2.Title}, Автор: {book2.Autor}, Жанр: {book2.Genre}");
                    break;
                case 3:
                    Console.WriteLine($"Название:{book3.Title}, Автор: {book3.Autor}, Жанр: {book3.Genre}");
                    break;
                default:
                    Console.WriteLine("Выберете номер от 1..2");
                    break;
            }
            return book;
        }
    }
}
