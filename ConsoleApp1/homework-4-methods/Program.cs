using System;
using System.Linq;
//using System.Linq;

namespace homework_4_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool parse;
            string userInput;
            Console.WriteLine("Введите число a: ");
            userInput = Console.ReadLine();
            parse = int.TryParse(userInput, out int a);
            Console.WriteLine("Введите число b: ");
            userInput = Console.ReadLine();
            parse = int.TryParse(userInput, out int b);

            Console.WriteLine($"Максимальное число: {Max(a, b)}");
            Console.WriteLine($"Минимальное число: {Min(a, b)}");
            Console.WriteLine(TrySumIfOdd(a, b));

            Console.WriteLine("Введите строку которую хотите повторить: ");
            string x = Console.ReadLine();
            Console.WriteLine("Введите количество повторений: ");
            string n = Console.ReadLine();
            parse = int.TryParse(n, out int N);
            Console.WriteLine("Ваше сообщение много раз: ");
            Console.WriteLine(Repeat(x, N));
        }

        static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }


        static int Min(int a, int b)
        {
            return Math.Min(a, b);
        }

        static bool TrySumIfOdd(int a, int b)
        {
            int sum = 0;
            for (; a <= b; a++)
            {
                sum += a;
                if (a > b)
                {
                    continue;
                }
            }

            for (; b < a; b++)
            {
                sum += b;
            }

            if (sum % 2 == 0) return false;
            else return true;
        }

        static void Increment(ref int val)
        {
            val++;
        }
        static void Increment(int val)
        {
            val++;
        }

        static string Repeat(string x,int N)
        {
            string output = x;
            for (uint i = 0; i < N; i++)
            {
                output += x;
            }
            return output;
        }
    }
}
