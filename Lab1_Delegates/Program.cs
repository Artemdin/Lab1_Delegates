using System;
using System.Text;

namespace Lab1_Delegates
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\nОберіть завдання (1-4), або 0 для виходу:");
                Console.Write("Ваш вибір: ");

                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Помилка: введіть ціле число!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Task1.Task_1();
                        break;

                    case 2:
                        Task2.Run();
                        break;

                    case 3:
                        Task3.Run();
                        break;

                    case 4:
                        Task4.Run();
                        break;

                    case 0:
                        Console.WriteLine("Вихід з програми. До зустрічі!");
                        return;

                    default:
                        Console.WriteLine("Помилка: завдання з таким номером не існує.");
                        break;
                }

            }
        }
    }
}