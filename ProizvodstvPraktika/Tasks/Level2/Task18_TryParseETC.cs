using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task18_TryParseETC : ITask
    {
        public string Title => "TryParse vs try/catch";

        public string Description => "сравнить два способа обработки некорректного ввода числа.";

        public string[] Requirements => new[]
        {
            "Способ 1: int.TryParse — вернуть bool + значение через out.",
            "Способ 2: int.Parse внутри try/catch — ловить FormatException.",
            "Оба оформить отдельными методами.",
            "Продемонстрировать на корректном и некорректном вводе."

        };
        static bool TryParseMethod(string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        // Способ 2: через try/catch
        static bool TryCatchMethod(string input, out int result)
        {
            result = 0;
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public void Run()
        {
            string[] tests = { "123", "abc", "456", "hello" };

            foreach (string input in tests)
            {
                Console.WriteLine($"Ввод: \"{input}\"");

                // Способ 1
                if (TryParseMethod(input, out int val1))
                    Console.WriteLine($"  TryParse:    успех, значение = {val1}");
                else
                    Console.WriteLine($"  TryParse:    ошибка");

                // Способ 2
                if (TryCatchMethod(input, out int val2))
                    Console.WriteLine($"  Try/Catch:   успех, значение = {val2}");
                else
                    Console.WriteLine($"  Try/Catch:   ошибка");

                Console.WriteLine();
            }
        }
        /*


Продемонстрировать на корректном и некорректном вводе.
         * */
    }
}
