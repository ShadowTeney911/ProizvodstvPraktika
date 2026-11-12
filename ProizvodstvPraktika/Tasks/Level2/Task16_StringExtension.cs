using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task16_StringExtension : ITask
    {
        /* 
        * Название
        * Описание
        * Требования (Массивом, кажется так будет проще
        * Запуск
        */

        public string Title => " Методы расширения для string";

        public string Description => " написать extension-методы для string";

        public string[] Requirements => new[]
        {
            " - Реализовать в статическом классе StringExtensions.",
            " - Методы: IsPalindrome(), WordCount(), ReverseString().",
            " - Методы должны быть public static с this string первым параметром.",
            " - Продемонстрировать вызов на 2–3 строках"
        };
        public void Run()
        {
            string[] tests = {
            "А роза упала на лапу Азора",
            "Hello World",
            "12321"
        };

            foreach (string s in tests)
            {
                Console.WriteLine($"Строка: \"{s}\"");
                Console.WriteLine($"  Палиндром: {s.IsPalindrome()}");
                Console.WriteLine($"  Количество слов: {s.WordCount()}");
                Console.WriteLine($"  Реверс: \"{s.ReverseString()}\"");
                Console.WriteLine();
            }
        }
    }
}
