using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task10_SortBubble : ITask
    {

        public string Title => "Сортировка пузырьком + вставками";

        public string Description => "Сортировка массива двумя разными алгоритмами";

        public string[] Requirements => new[]
        {
            " - Реализовать BubbleSort и InsertionSort отдельными методами",
            " - Оба — без LINQ и Array.Sort.",
            " - Замерить время каждого через Stopwatch на массиве 10 000 элементов",
            " - Вывести оба времени"
        };

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public void Run()
        {
            Random rnd = new Random();
            int size = 10000;
            int[] original = new int[size];

            for (int i = 0; i < size; i++)
                original[i] = rnd.Next(1, 100001);

            int[] arr1 = (int[])original.Clone();
            int[] arr2 = (int[])original.Clone();

            // Замер BubbleSort
            Stopwatch sw1 = Stopwatch.StartNew();
            BubbleSort(arr1);
            sw1.Stop();

            // Замер InsertionSort
            Stopwatch sw2 = Stopwatch.StartNew();
            InsertionSort(arr2);
            sw2.Stop();

            // Проверка, что отсортировано одинаково
           
            Console.WriteLine($"Bubble Sort:    {sw1.ElapsedMilliseconds} мс");
            Console.WriteLine($"Insertion Sort: {sw2.ElapsedMilliseconds} мс");
        }
    }
}
