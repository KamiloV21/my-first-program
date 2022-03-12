using System;

namespace homework_12_inheritance_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoService service = new AutoService();
            AutoModel model = new AutoModel();
            AutoWell well = new AutoWell();
            AutoEngine engine = new AutoEngine();

            service.Car();
            model.Car();
            engine.Car();
            well.Car();
            
        }
        public enum Model
        {
            Audi,
            BMW,
            Ford
        }

        public class AutoService
        {
            public virtual void Car()
            {
                Console.WriteLine("Автосервис имеет несколько машин");
            }
        }

        public class AutoModel : AutoService
        {
            public override void Car()
            {
                bool parseAnswer;
                string userInput;
                Console.WriteLine("Выберите машину: Audi - 1, BMW - 2, Ford - 3");
                userInput = Console.ReadLine();
                parseAnswer = int.TryParse(userInput, out int a);
                if (parseAnswer == false)
                {
                    Console.WriteLine("Вы ввели не число!: ");
                    return;
                }
                switch (a)
                {
                    case 1:
                        Console.WriteLine($"{Model.Audi}");
                        break;
                    case 2:
                        Console.WriteLine($"{Model.BMW}");
                        break;
                    case 3:
                        Console.WriteLine($"{Model.Ford}");
                        break;
                    default:
                        Console.WriteLine("Выберите число от 1..3");
                        break;
                }
            }
        }

        public class AutoWell: AutoService
        {
            public override void Car()
            {
                bool parseAnswer;
                string userInput;
                Console.WriteLine("Выберите колеса: Зимние - 1, Летние - 2");
                userInput = Console.ReadLine();
                parseAnswer = int.TryParse(userInput, out int a);
                if (parseAnswer == false)
                {
                    Console.WriteLine("Вы ввели не число!: ");
                    return;
                }
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали зимнюю резину");
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали летнюю резину");
                        break;
                    default:
                        Console.WriteLine("Выберите число от 1..2");
                        break;
                }
            }
        }

        public class AutoEngine : AutoService
        {
            public override void Car()
            {
                bool parseAnswer;
                string userInput;
                Console.WriteLine("Выберите двигатель: Бензиновый - 1, Дизельный - 2");
                userInput = Console.ReadLine();
                parseAnswer = int.TryParse(userInput, out int a);
                if (parseAnswer == false)
                {
                    Console.WriteLine("Вы ввели не число!: ");
                    return;
                }
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали бензиновый двигатель");
                        break;
                    case 2:
                        Console.WriteLine("Вы выбрали дизельный двигатель");
                        break;
                    default:
                        Console.WriteLine("Выберите число от 1..2");
                        break;
                }
            }
        }
    }
}
