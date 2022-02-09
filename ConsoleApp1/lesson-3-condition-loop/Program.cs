using System;

namespace lesson_3_condition_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            if (a <= b)
            {
                Console.WriteLine($"{a} is lees than {b}");
            }
            else
            {
                Console.WriteLine($"{a} is more than {b}");
            }

            string s = a <= 5
                ? $"{a} is lees than {b}"
                : $"{a} is more than {b}";

            int c = a <= b
                ? a + b
                : a - b;

            switch (a)
            {
                case 5:
                    Console.WriteLine("a is 5");
                    break;
                case 6:
                    Console.WriteLine("a is 6");
                    break;
                case 7:
                    Console.WriteLine("a is 7");
                    break;
                default:
                    Console.WriteLine("a is something");
                    break;
            }

            const int N = 10;
            int sum = 0;
            int i = 0;
            for(; i < N; i++)
            {
                sum+=i;
            }
            Console.WriteLine(sum);

            sum = 0;
            i = 0;
            while(i < N)
            {
                sum += i++;
            }
            Console.WriteLine(sum);

            sum = 0;
            i = 0;
            do
            {
                sum += i;
                i++;
            } while (i < N);
            Console.WriteLine(sum);

            i = 0;
            sum = 0;
            for(; i < N; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            i = 0;
            sum = 0;
            for(; i < N; i++)
            {
                sum = (i % 2 == 0)
                    ? i
                    : 0;
            }

            i = 0;
            sum = 0;
            for (; i < N; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                sum += i;
            }

            i = 0;
            sum = 0;
            while (true)
            {
                sum += i++;
                if (i == N)
                {
                    break;
                }
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
