using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task41_TaskWhenAll : ITask
    {
        /* 
        * Задание 41. 
Что сделать: 
Требования:

Готово, если: параллельный вариант заметно быстрее, результаты одинаковые.
        */

        public string Title => "Task.WhenAll — параллельно 10 задач";

        public string Description => "запустить 10 задач параллельно и сравнить с последовательным выполнением.";

        public string[] Requirements => new[]
        {
            "Метод Task<int> WorkAsync(int id) — Task.Delay(500), возвращает id.",
"Последовательный запуск 10 задач в цикле с await.",
"Параллельный запуск через Task.WhenAll.",
"Замерить время обоих вариантов через Stopwatch.",
"Вывести оба времени и объяснить разницу.",

        };


        // Имитация долгой работы (500 мс)
        static async Task<int> WorkAsync(int id)
        {
            await Task.Delay(500);
            return id;
        }

        static async Task RunAsync()
        {
            int count = 10;

            // 1. Последовательное выполнение
            Console.WriteLine("=== Последовательное выполнение ===");
            Stopwatch swSeq = Stopwatch.StartNew();

            List<int> seqResults = new List<int>();
            for (int i = 0; i < count; i++)
            {
                int result = await WorkAsync(i);
                seqResults.Add(result);
            }

            swSeq.Stop();
            Console.WriteLine($"Время: {swSeq.ElapsedMilliseconds} мс");

            // 2. Параллельное выполнение
            Console.WriteLine("\n=== Параллельное выполнение (Task.WhenAll) ===");
            Stopwatch swPar = Stopwatch.StartNew();

            // Создаем все задачи сразу
            Task<int>[] tasks = new Task<int>[count];
            for (int i = 0; i < count; i++)
            {
                tasks[i] = WorkAsync(i);
            }

            // Ждем завершения ВСЕХ задач одновременно
            int[] parResults = await Task.WhenAll(tasks);

            swPar.Stop();
            Console.WriteLine($"Время: {swPar.ElapsedMilliseconds} мс");

            // Проверка, что результаты одинаковые
            Console.WriteLine($"\nРезультаты совпадают: {seqResults.SequenceEqual(parResults)}");
        }

        public void Run()
        {

            RunAsync().GetAwaiter().GetResult();


        }
    }
}
