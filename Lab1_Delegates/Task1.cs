using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates
{
    internal class Task1
    {
        
        static void PrintTick(int t)
        {
            Console.WriteLine($":::: Пройшло {t} секунди");
        }

        //static void PrintTack()
        //{
        //    Console.WriteLine("---> Так! :::: Пройшло 3 секунди");
        //}
        public static void Task_1()
        {
            Console.WriteLine("Введіть секунду першого таймера");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть секунду другого таймера");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Запускаємо наші паралельні таймери...");

            Timer timer1 = new Timer(() => PrintTick(t), t);
           Timer timer2 = new Timer(() => PrintTick(s),s);
            //  Timer timer2 = new Timer(PrintTack,t);

            CancellationTokenSource cts = new CancellationTokenSource();
            Task task1 = timer1.Start(cts.Token);
            Task task2 = timer2.Start(cts.Token);

            Console.WriteLine("Таймери працюють. Натисни Enter, щоб вийти з програми.");
            Console.ReadLine();
            cts.Cancel();
            System.Threading.Thread.Sleep(100); Console.WriteLine("Stop timer");
        }
    }
}
