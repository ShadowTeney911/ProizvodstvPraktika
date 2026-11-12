using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task17_StringBuilder : ITask
    {
        public string Title => "StringBuilder vs конкатенация (замер)";

        public string Description => "сравнить производительность конкатенации через + и StringBuilder";

        public string[] Requirements => new[]
        {
            " - Собрать строку из 10 000 (или 100 000) чисел двумя способами.",
            " -Замерить время каждого через Stopwatch.",
            " - Вывести оба времени и разницу.  .",
            " - Объяснить в комментарии, почему StringBuilder быстрее"
        };
        public void Run()
        {
            // сто тысяч долго грузились. с 10 нагляднее и быстрее
            int count = 10000;

            // Способ 1: конкатенация через +
            Stopwatch sw1 = Stopwatch.StartNew();
            string result1 = "";
            for (int i = 0; i < count; i++)
                result1 += i;
            sw1.Stop();

            // Способ 2: через StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
                sb.Append(i);
            string result2 = sb.ToString();
            sw2.Stop();

            // Проверка, что результаты одинаковые

            Console.WriteLine($"Конкатенация (+):    {sw1.ElapsedMilliseconds} мс");
            Console.WriteLine($"StringBuilder:       {sw2.ElapsedMilliseconds} мс");
            Console.WriteLine($"Разница:             {sw1.ElapsedMilliseconds - sw2.ElapsedMilliseconds} мс");
            Console.WriteLine($"Длина строки: {result1.Length:N0} символов");
        }
    }
}
