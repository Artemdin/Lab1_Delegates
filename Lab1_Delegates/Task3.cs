using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates
{
    internal class Task3
    {

        static double CalculateSum(Func<int, double> Formula, double precision)
        {
            double sum = 0;
            int n = 1;

            double currentTerm = Formula(n);

            while (Math.Abs(currentTerm) >= precision)
            {
                sum += currentTerm;
                n++;
                currentTerm = Formula(n);
            }

            return sum;
        }

     
        static double Factorial(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Формула: 1 / 2^(n-1)
        static double Example1(int n)
        {
            return 1.0 / Math.Pow(2, n - 1);
        }

        // Формула: 1 / n!
        static double Example2(int n)
        {
            return 1.0 / Factorial(n);
        }

        // Формула: (-1)^n / 2^(n-1)
        static double Example3(int n)
        {
            return Math.Pow(-1, n) / Math.Pow(2, n - 1);
        }
        public static void Run()
        {
            Console.Write("Введіть точність (дріб від 0 до 1, наприклад 0,001 або 0,00001): ");

            double precision;

            string input = Console.ReadLine().Replace(',', '.');

            while (!double.TryParse(input, out precision) || precision <= 0 || precision >= 1)
            {
                Console.WriteLine("Помилка! Точність має бути маленьким дробом.\nСпробуй ще раз (наприклад 0.001 або 0,001):");
                input = Console.ReadLine().Replace(',', '.');
            }

            Console.WriteLine($"\nПочинаємо обчислення з точністю: {precision}\n");

            Func<int, double> series1 = Example1;
            double sum1 = CalculateSum(series1, precision);
            Console.WriteLine($"Ряд 1 (має прямувати до 2):       {sum1}");

            Func<int, double> series2 = Example2;
            double sum2 = CalculateSum(series2, precision);
            Console.WriteLine($"Ряд 2 (має прямувати до ~1,718):  {sum2}");

            Func<int, double> series3 = Example3;
            double sum3 = CalculateSum(series3, precision);
            Console.WriteLine($"Ряд 3 (має прямувати до ~-0,666): {sum3}");

            Console.WriteLine("\nНатисни Enter для повернення в меню...");
            Console.ReadLine();
        }

    }
}
