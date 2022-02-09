using System;

namespace homework_3_condition_loop
{
    //dhfjghdgjdf
    internal class Program
    {
        //fkdkjhkjdsfkjs
        static void Main(string[] args)
        {
            bool parse;
            string userInput;
            Console.WriteLine("Введите число X");
            userInput = Console.ReadLine();
            parse = int.TryParse(userInput, out int x);
            if (parse == false)
            {
                Console.WriteLine("Вы ввели не число!");
                return;
            }
            Console.WriteLine("Введите число Y");
            userInput = Console.ReadLine();
            parse = int.TryParse(userInput, out int y);
            if (parse == false)
            {
                Console.WriteLine("Вы ввели не число!");
                return;
            }
            int sum = 0;
            int z = (int)Math.Max(x, y);

            Console.WriteLine($"Максимальное число: {z}");

            for (; x <= z; x++)
            {
                sum += x;
                if (x > z)
                {
                    continue;
                }
            }

            for (; y < z; y++)
            {
                sum += y;
            }

            Console.WriteLine(sum);
        }
    }
}
