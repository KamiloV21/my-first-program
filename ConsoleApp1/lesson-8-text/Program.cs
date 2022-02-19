using System;
using System.IO;
using System.Text.RegularExpressions;

namespace lesson_8_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "PhoneBookEmpty.csv";
            string content = GetBookText(filePath);

            string[] names = content.Split("\n");

            Regex regex = new Regex(@"^(\w+);(\d+)$");

            var book = new (string name, int number)[names.Length];
            for (var index = 0; index < names.Length; index++)
            {
                var item = names[index];
                var match = regex.Match(item);

                if (match.Success)
                {
                    book[index].name = match.Groups[1].Value;
                    book[index].number = int.Parse(match.Groups[2].Value);
                }
            }

            foreach (var item in book)
            {
                Console.WriteLine($"{item.name} which phone number is {item.number}");
            }

            var random = new Random();
            book[0].number = random.Next();

            ToFile(book, filePath);
        }

        static string GetBookText(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        static void ToFile((string name, int number)[] content, string filePath)
        {
            string toFile = string.Empty;
            foreach (var item in content)
            {
                toFile += $"{item.name};{item.number}\n";
            }

            File.WriteAllText(filePath, toFile);
        }
    }
}