using System;

namespace lesson_4_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(4, 5);
            Console.WriteLine(sum);
            Console.WriteLine(Sum(10,20));          // 30
            Console.WriteLine(Sum(10, 20, true));   // 30
            Console.WriteLine(Sum(10, 20, false));  // -10
            Console.WriteLine(SumNubers(10,20));    // 145

            int i = 10;             //0x0001
            Increment(ref i);
            Console.WriteLine(i);   // 11

            if(TryDivideByTree(i,out int result))
            {
                Console.WriteLine(result);
            }

            Concat(10,20);
        }

        static void Concat(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Concat(string a, string b)
        {
            Console.WriteLine($"{a},{b}");
        }

        static void Concat(string a, string b, string c)
        {
            Console.WriteLine($"{a},{b},{c}");
        }

        static void Concat(params string[] strings)
        {
            Console.WriteLine(strings.Length);
        }

        static int Factorial(int value)
        {
            if (value == 1) return value;
            return value * Factorial(value - 1);
        }

        static bool TryDivideByTree(int a, out int result)
        {
            result = a / 3;
            return a % 3 == 0;
        }

        static int Sum(int a,int b, bool r = true) 
        {
            if (r) return a + b;
            else return a - b;
        }

        static int SumNubers(int a,int b)
        {
            int sum = 0;
            for (int i = a; i<=b; i++)
            {
                sum += i;
            }

            return sum;
        }

        static int Increment(ref int i)
        {
            i++;
            return i;
        }
    }
}
