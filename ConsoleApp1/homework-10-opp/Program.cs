using homework_10_opp.Library;
using System;

namespace homework_10_opp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Start start = new Start();

            start.StartProg();
            Console.WriteLine();

            firstPerson.Name = "Max";
            firstPerson.Age = 18;
            firstPerson.SerName = "Kalin";

            firstPerson.Print();
        }
    }
}
