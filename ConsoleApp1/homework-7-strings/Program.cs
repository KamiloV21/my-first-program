using System;
using System.Text;

namespace homework_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(Compare(str, str2));
            Console.WriteLine($"Буквы которые вы ввели: {Analyze1(str)}");
            Console.WriteLine($"Цифры которые вы ввели: {Analyze2(str)}");
            Console.WriteLine($"Символы которые вы ввели: {Analyze3(str)}");
            Console.WriteLine(Sort("Hello"));
            Console.WriteLine(Duplicate("Hello and hi"));
        }

        static bool Compare(string str, string str2)
        {
            if(str.Length != str2.Length)
            {
                return false;
            }
            else
            {
                for (int i=0; i<str.Length; i++)
                {
                    if(str[i] != str2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static string Analyze1(string str)
        {
            StringBuilder alpha = new StringBuilder();
            StringBuilder num = new StringBuilder();
            StringBuilder special = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    num.Append(str[i]);
                else if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' &&str[i] <= 'z'))
                    alpha.Append(str[i]);
                else
                    special.Append(str[i]);
            }

            return alpha.ToString();
        }

        static string Analyze2(string str)
        {
            StringBuilder alpha = new StringBuilder();
            StringBuilder num = new StringBuilder();
            StringBuilder special = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    num.Append(str[i]);
                else if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                    alpha.Append(str[i]);
                else
                    special.Append(str[i]);
            }

            return num.ToString();
        }
        static string Analyze3(string str)
        {
            StringBuilder alpha = new StringBuilder();
            StringBuilder num = new StringBuilder();
            StringBuilder special = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                    num.Append(str[i]);
                else if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
                    alpha.Append(str[i]);
                else
                    special.Append(str[i]);
            }

            return special.ToString();
        }

        static string Sort(string str)
        {
            StringBuilder sumbl = new StringBuilder();
            sumbl.Append(str);

            for(int i=0; i<sumbl.Length - 1; i++)
            {
                for(int j=0; j<sumbl.Length - i - 1; j++)
                {
                    if (String.Compare(sumbl[j].ToString(), sumbl[j + 1].ToString()) == 1)
                    {
                        char c = sumbl[j];
                        sumbl[j] = str[j + 1];
                        sumbl[j + 1] = c;
                    }
                }
            }

            return sumbl.ToString();
        }

        static char[] Duplicate(string str)
        {
            string strLow = str.ToLower();

            string empty = string.Empty;
            for(int i = 0; i < strLow.Length; i++)
            {
                char c = str[i];
                int numberInString = strLow.Length - strLow.Replace(str[i].ToString(), "").Length;
                if(numberInString == 2 && !empty.Contains(str[i]))
                {
                    empty += c;
                }
            }

            return empty.ToCharArray();
        }
    }
}
