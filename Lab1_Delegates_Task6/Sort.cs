using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates_Task6
{


    internal class Sort
    {

        public static void ShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                // Прохід зліва направо
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    }
                }
                right--;

                // Прохід справа наліво
                for (int i = right; i > left; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    }
                }
                left++;

            }
        }
       public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (array[i], array[minIndex]) = (array[minIndex], array[i]);
                }

            }
        }


        public static void BadShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                // Помилка: перевірка знака навпаки
                for (int i = left; i < right; i++)
                {
                    if (array[i] < array[i + 1]) // повинно бути ">"
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    }
                }
                right--;

                // Прохід справа наліво, помилка: неправильно індексування
                for (int i = right; i > left; i--)
                {
                    if (array[i] > array[i - 1]) // повинно бути "<"
                    {
                        (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    }
                }
                left++;
            }
        }

        public static void BadSelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[minIndex]) // повинно бути "<"
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    (array[i], array[minIndex]) = (array[minIndex], array[i]);
                }
            }
        }

    }
}
    
