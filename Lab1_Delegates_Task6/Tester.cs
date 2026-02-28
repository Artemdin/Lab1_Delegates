using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Delegates_Task6
{

    delegate void TestSortMethod(int[] arr);
    internal class Tester
    {
        public long MeasureTime(TestSortMethod sort, int[] array)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sort(array); 
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        public bool CompareArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length) return false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }


        public void Verify(TestSortMethod ideal, TestSortMethod student, int[] sourceData)
        {
        
            int[] idealArr = sourceData.ToArray();
            int[] studentArr = sourceData.ToArray();

            long t = MeasureTime(ideal, idealArr);
            long tStud = MeasureTime(student, studentArr);

            bool isCorrect = true;
            for (int i = 0; i < idealArr.Length; i++)
            {
                if (idealArr[i] != studentArr[i])
                {
                    isCorrect = false;
                    break; 
                }
            }

            Console.WriteLine(isCorrect ? "РЕЗУЛЬТАТ: МОЛОДЕЦЬ" : "РЕЗУЛЬТАТ: СТУДЕНТ ПРОВАЛИВСЯ (масиви різні)");

            if(idealArr.Length >= 100)
                Console.WriteLine("Масив сильно великий,Більше 100 елементів,тому вірте на слово!");
            else
                Console.WriteLine("Правильний масив" + string.Join(' ',idealArr));
                Console.WriteLine("Не правильний масив" + string.Join(' ',studentArr));
          
            Console.WriteLine($"Час розробника: {t} мс, Час студента: {tStud} мс");
            Console.WriteLine("---------------------------------------------");
        }





    }
}
