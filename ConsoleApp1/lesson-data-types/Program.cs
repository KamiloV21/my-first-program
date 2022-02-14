using System;
using System.Timers;

namespace lesson_data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            short s = 300;
            int us = -23532;

            int i = 5;
            int result = ++i + i++;
            Console.WriteLine(-i);
            Console.WriteLine(result);

            bool isTrue = true;
            Console.WriteLine(!isTrue);

            Console.WriteLine(a * b);
            Console.WriteLine(6 / 4);
            Console.WriteLine(6 % 4);

            short biiigInt = 32000;
            short biiigInt1 = 32000;
            short result1 = (short)(biiigInt + short.Parse("32000"));

            Console.WriteLine("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int a1 = Convert.ToInt32(Math.Pow(x,3));
            int a2 = Convert.ToInt32(Math.Pow(x, 2));
            Console.WriteLine(-6*a1+5*a2-10*x+15);

            var hours = TimeSpan.FromHours(6);
            Console.WriteLine(TimeSpan.FromHours(6));

            char b1 = (char)Math.Abs(x);
            char b2 = (char)Math.Sin(x);
            Console.WriteLine(b1 * b2);

            double PI= (double)Math.PI;
            Console.WriteLine(2 * PI * x);

            Console.WriteLine("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z= (int)Math.Max(x,y);
            Console.WriteLine(z);

            var now= DateTime.Now;
            Console.WriteLine(now);
            var NewYear = new DateTime(now.Year + 0, 12, 31);
            var LastNewYear = new DateTime(now.Year - 0, 2, 7);
            var XDays = NewYear - now;
            var YDays = now - LastNewYear;
            Console.WriteLine($"До Нового года осталось: {XDays.Days}");
            Console.WriteLine(YDays.Days);

            var timer = new Timer();
            timer.Interval = TimeSpan.FromSeconds(5).TotalMilliseconds;
            timer.Elapsed += (a, e) => Console.WriteLine("Some");
            timer.Start();
            Console.ReadKey();
        }
    }
}
