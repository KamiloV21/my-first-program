using System;
using System.Text;

namespace lesson_7_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string placeholder = "Hello {0} and {1}";
            string name = "Serhii";
            string hisName = "Alex";
            Console.WriteLine("Hello " + name);                                     //Hello Serhii
            Console.WriteLine(string.Format("Hello {0}", name));                    //Hello Serhii
            Console.WriteLine(string.Format("Hello {0} and {1}",name,hisName));     //Hello Serhii and Alex
            Console.WriteLine($"Hello {name} and {hisName}");                       //Hello Serhii and Alex
            Console.WriteLine(string.Format(placeholder,name,hisName));             //Hello Serhii and Alex

            var hello = $"Hello, {name} and {hisName}";
            char symbol = hello[0];

            Console.WriteLine(symbol);                      //H
            Console.WriteLine(char.IsLetter(symbol));       //true
            Console.WriteLine(char.IsDigit(symbol));        //false
            Console.WriteLine(char.IsUpper(symbol));        //true

            Console.WriteLine(hello.Contains('q'));         //false
            Console.WriteLine(hello.Contains("hii"));       //true
            Console.WriteLine(hello.EndsWith("lex"));       //true
            Console.WriteLine(hello.StartsWith("lex"));     //false

            var helloPlaceholder = "Hello ";
            var index = helloPlaceholder.IndexOf(' ');      //5

            Console.WriteLine(helloPlaceholder.Insert(index + 1, name));
            Console.WriteLine($"Hello {name}".Replace(name, hisName));

            Console.WriteLine(hello.PadLeft(40));
            Console.WriteLine(hello.PadLeft(40).Trim());
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());

            Console.WriteLine(string.Compare("abc", "bcd"));
            Console.WriteLine(string.Equals("abc", "bcd"));
            Console.WriteLine("abc" == "bcd");
            Console.WriteLine("abc" != "bcd");

            Console.WriteLine("Hello" + name);

            var emptyString = string.Empty;
            const int N = 1000;
            int i = 0;
            for(i=0; i < N; i++)
            {
                emptyString += $" {i}";
            }

            var stringBuilder = new StringBuilder();
            for (i = 0; i < N; i++)
            {
                stringBuilder.AppendFormat(" {0}", i);
            }

            Console.WriteLine(emptyString);
            Console.WriteLine(stringBuilder.ToString());

            string input=Console.ReadLine();
            string output = string.Empty;
            foreach(var item in input)
            {
                output += char.IsLower(item)
                    ? char.ToUpper(item)
                    : char.ToLower(item);
            }
            Console.WriteLine(output);
        }
    }
}

