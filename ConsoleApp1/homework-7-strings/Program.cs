using System;
using System.Text;

namespace homework_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            Console.WriteLine(Analyze(str));
        }

        

        static string Analyze(string str)
        {
            StringBuilder alpha = new StringBuilder();
            StringBuilder num = new StringBuilder();
            StringBuilder special = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    num.Append(str[i]);
                else if ((str[i] >= 'A' &&
                         str[i] <= 'Z') ||
                         (str[i] >= 'a' &&
                          str[i] <= 'z'))
                    alpha.Append(str[i]);
                else
                    special.Append(str[i]);
            }

            return alpha.ToString();
            return num.ToString();
            return special.ToString();
        }
    }
}
