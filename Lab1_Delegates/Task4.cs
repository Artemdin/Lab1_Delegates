using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates
{
    internal class Task4
    {
        public static void Run()
        {
            Func<double, double>[] operations = new Func<double, double>[]
            {
                x => Math.Sqrt(Math.Abs(x)),
                x => Math.Pow(x, 3),
                x => x + 3.5,

            };

            Console.WriteLine("""
             Вводьте рядки послідовно один за одним.
             Поки вони матимуть вигляд: [номер_функції] [число]
             0 -- sqrt(abs(x))
             1 -- x^3     
             2 -- x + 3.5
             
             """);

            while (true)
            {
                try
                {
                    Console.Write("> ");
                    string input = Console.ReadLine();

                    string[] parts = input.Split(' ');

                    int funcIndex = int.Parse(parts[0]);
                    double x = double.Parse(parts[1].Replace(',', '.'));

                    double result = operations[funcIndex](x);

                    Console.WriteLine($"Результат: {result}\n");
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("Такої функції не існує.");
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("\n[Система]: Формат не дотримано або отримано команду виходу.");
                    Console.WriteLine("Спробуйте знову!");
                    break;
                }
            }

            Console.WriteLine("\nНатисніть Enter, щоб повернутися в головне меню...");
            Console.ReadLine();
        }
    }
}
