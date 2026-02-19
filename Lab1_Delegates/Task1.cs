using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates
{
    internal class Task1
    {
        static void PrintTick()
        {
            Console.WriteLine("----> Тік! :::: Пройшло 2 секунди");
        }

        static void PrintTack()
        {
            Console.WriteLine("---> Так! :::: Пройшло 3 секунди");
        }
        public static void Task_1()
        {
            Console.WriteLine("Запускаємо наші паралельні таймери...");

            Timer timer1 = new Timer(PrintTick, 2);
            Timer timer2 = new Timer(PrintTack,3);


            timer1.Start();
            timer2.Start();

            Console.WriteLine("Таймери працюють. Натисни Enter, щоб вийти з програми.");
            Console.ReadLine();
        }
    }
}
