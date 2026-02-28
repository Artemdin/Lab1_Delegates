using System;
using System.Drawing;
using System.Text;

namespace Lab1_Delegates_Task6
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Tester tester = new Tester();

            Console.WriteLine("1 - Сортування вибором.");
            Console.WriteLine("2 - Шейкерне сортування.");
            Console.Write("\nВаш вибір: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[] array = InputeArray();
                    Console.WriteLine("=== ТЕСТУВАННЯ СОРТУВАННЯ ВИБОРОМ ===");
                    tester.Verify(Sort.SelectionSort, Sort.BadSelectionSort, array);

                    break;
                case 2:
                    int[] array1 = InputeArray();
                    Console.WriteLine("\n=== ТЕСТУВАННЯ ШЕЙКЕРНОГО СОРТУВАННЯ ===");
                    tester.Verify(Sort.ShakerSort, Sort.BadShakerSort,array1);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Використовується випадковий масив за замовчуванням.");
                    break;
            }

                Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
                Console.ReadKey();
         }



      static int[] InputeArray()
        {
            Console.WriteLine("""
                Яким способом заповняти масив
                1 => Вручну
                2 => Випадковими числами
                """);
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Вводь:");
                    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    return array;
                case 2:
                    Console.Write("Введіть кількість елементів: ");
                    int size = int.Parse(Console.ReadLine());
                    Random rnd = new Random();
                    int[] arr = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = rnd.Next(-100, 100);
                    }
                    return arr;

                default:
                    Console.WriteLine("Зробіть вибір 1 або 2.");
                   return InputeArray();

            }

        }




    } 
}
