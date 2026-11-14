using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task39_YieldReturn : ITask
    {
        /* 
        * НЗадание 39. yield return — генератор чётных чисел
Что сделать: реализовать генератор чётных чисел через yield return.
Требования:

"Готово, если: генератор возвращает чётные числа, ленивое выполнение видно по выводу.",
        */

        public string Title => "yield return — генератор чётных чисел";

        public string Description => " реализовать генератор чётных чисел через yield return.";

        public string[] Requirements => new[]
        {
            "Метод IEnumerable<int> GetEvenNumbers(int max) — возвращает чётные числа до max.",
"Реализовать именно через yield return, без промежуточного списка.",
"Продемонстрировать работу в foreach.",
"Дополнительно: показать ленивость — вывести сообщение внутри генератора и убедиться, что оно печатается по одному.",

        };

        // Генератор чётных чисел через yield return
        static IEnumerable<int> GetEvenNumbers(int max)
        {
            for (int i = 0; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"  [Генератор] Вычисляю и выдаю: {i}");
                    yield return i;
                }
            }
        }
        public void Run()
        {
            // 1. Создание генератора — код внутри НЕ выполняется
            Console.WriteLine("=== Создание генератора ===");
            var evens = GetEvenNumbers(10);
            Console.WriteLine("Генератор создан, но числа ещё не считались.\n");

            // 2. Использование в foreach — код выполняется по одному элементу
            Console.WriteLine("=== Перебор через foreach ===");
            foreach (int num in evens)
            {
                Console.WriteLine($"Получено число: {num}\n");
            }

            // 3. Демонстрация ленивости через Take
            Console.WriteLine("=== Ленивость: берём только 3 числа из 100 ===");
            var firstThree = GetEvenNumbers(100).Take(3);
            foreach (int num in firstThree)
            {
                Console.WriteLine($"Получено число: {num}");
            }
        }
    }
}
