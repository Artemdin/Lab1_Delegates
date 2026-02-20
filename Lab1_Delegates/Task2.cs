using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates
{
    // можна було б public delegate bool MyFilterDelegate(int number) але є Func;
    internal class Task2
    {
        static int[] CustomFilter(int[] array, Func<int,bool> filterDelegate)
        {
           
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (filterDelegate(array[i])) count++;
            }

            int[] result = new int[count];
            int index = 0;
           
            for (int i = 0; i < array.Length; i++)
            {
                if (filterDelegate(array[i]))
                {
                    result[index] = array[i]; 
                    index++;
                }
            }

            return result;

            /*
            int index = 0;
            int[] temp = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (filterDelegate(array[i]))
                    temp[index++] = array[i];
            }

            Array.Resize(ref temp, index);
            return temp;
            */
        }

        public static void Run()
        {
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 15, 20, 24 };
            // int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
            Console.WriteLine("Початковий масив: " + string.Join(", ", numbers));

            
            Console.Write("Введіть число k: ");
            int k = int.Parse(Console.ReadLine());

            Func<int, bool> dis = x => x % k == 0;
 
            int[] resultA = numbers.Where(dis).ToArray();
            Console.WriteLine("\nСпосіб А (через Where):    " + string.Join(", ", resultA));

            int[] resultB = CustomFilter(numbers, dis);
            Console.WriteLine("Спосіб Б (власний метод): " + string.Join(", ", resultB));

            Console.WriteLine("\nНатисни Enter для повернення в меню...");
            Console.ReadLine();
        }




    }
}
