using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task37_Fibonachi : ITask
    {
        /* 
        * Задание 37. 
Что сделать: 
Требования:

Готово, если: мемоизированная версия заметно быстрее, результаты совпадают.",
        */

        public string Title => "Мемоизация Фибоначчи через Dictionary";

        public string Description => "реализовать мемоизированную функцию Фибоначчи.";

        public string[] Requirements => new[]
        {
"Обычная рекурсивная версия (для сравнения на маленьком N).",
"Мемоизированная версия с Dictionary<int, long>.",
"Замерить время обеих на N = 30–35 через Stopwatch.",
"Вывести оба времени и разницу.",
        };

        // 1. Обычная рекурсия (очень медленная)
        static long Fib(int n)
        {
            if (n <= 1) return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        // 2. Мемоизированная рекурсия (быстрая)
        static Dictionary<int, long> memo = new Dictionary<int, long>();

        static long FibMemo(int n)
        {
            if (n <= 1) return n;

            // Если уже считали, берем из кэша
            if (memo.ContainsKey(n))
                return memo[n];

            // Считаем и сохраняем в кэш
            long result = FibMemo(n - 1) + FibMemo(n - 2);
            memo[n] = result;
            return result;
        }
        public void Run()
        {
            int n = 35;

            // Замер обычной рекурсии
            Stopwatch sw1 = Stopwatch.StartNew();
            long result1 = Fib(n);
            sw1.Stop();

            // Замер мемоизированной рекурсии
            Stopwatch sw2 = Stopwatch.StartNew();
            long result2 = FibMemo(n);
            sw2.Stop();

            // Вывод результатов
            Console.WriteLine($"Вычисление Фибоначчи для N = {n}\n");

            Console.WriteLine($"Обычная рекурсия:");
            Console.WriteLine($"  Результат: {result1}");
            Console.WriteLine($"  Время:     {sw1.ElapsedMilliseconds} мс\n");

            Console.WriteLine($"Мемоизация:");
            Console.WriteLine($"  Результат: {result2}");
            Console.WriteLine($"  Время:     {sw2.ElapsedMilliseconds} мс\n");

            Console.WriteLine($"Разница: {sw1.ElapsedMilliseconds - sw2.ElapsedMilliseconds} мс");
            Console.WriteLine($"Результаты совпадают: {result1 == result2}");
        }
    }
}
