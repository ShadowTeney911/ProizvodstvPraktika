using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task09_MinMaxETC : ITask
    {
        public string Title => "Массивы: min/max/sum/avg";

        public string Description => "Нахождение минимума, максимума, суммы и среднего арифметического числа для массива элементов.";

        public string[] Requirements => new[]
        {
            " - Заполнить массив (например, случайными числами 1–100, размер 20).",
            " - Реализовать без LINQ (Min/Max/Sum/Average запрещены).",
            " - Оформить 4 отдельных метода.",
            " - Пустой массив — обработать (вернуть ошибку или 0, но не падать)."
};

        public void Run()
        {
            int FindMin(int[] arr)
            {
                if (arr.Length == 0) return 0;
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                    if (arr[i] < min) min = arr[i];
                return min;
            }

            int FindMax(int[] arr)
            {
                if (arr.Length == 0) return 0;
                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                    if (arr[i] > max) max = arr[i];
                return max;
            }

            int FindSum(int[] arr)
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                    sum += arr[i];
                return sum;
            }

            double FindAvg(int[] arr)
            {
                if (arr.Length == 0) return 0;
                return (double)FindSum(arr) / arr.Length;
            }

            
                Random rnd = new Random();
                int[] numbers = new int[20];

                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] = rnd.Next(1, 101);

                Console.WriteLine("Массив: " + string.Join(" ", numbers));
                Console.WriteLine($"Минимум: {FindMin(numbers)}");
                Console.WriteLine($"Максимум: {FindMax(numbers)}");
                Console.WriteLine($"Сумма:   {FindSum(numbers)}");
                Console.WriteLine($"Среднее: {FindAvg(numbers):F2}");
            
        }
    }
}
