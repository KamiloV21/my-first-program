using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_10_opp.Library
{
    internal class Start
    {
        Book book =new Book();

        public void StartProg()
        {
            bool parseAnswer;
            string userInput;
            Console.WriteLine("Что вы хотите сделать?(выберите от 1 до 2, 1 - это написать книгу, 2 - инфрмация о книги)");
            userInput = Console.ReadLine();
            parseAnswer = int.TryParse(userInput, out int a);
            if (parseAnswer == false)
            {
                Console.WriteLine("Вы ввели не число введите число: ");
                return;
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine(book.WriteBook());
                    break;
                case 2:
                    Console.WriteLine(book.Findbook());
                    break;
                default:
                    Console.WriteLine("Выберете номер от 1..2");
                    break;
            }
        }
    }
}
