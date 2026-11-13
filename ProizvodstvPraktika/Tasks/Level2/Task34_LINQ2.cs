using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task34_LINQ2 : ITask
    {
        
        public string Title => "LINQ: группировка слов по первой букве";

        public string Description => "сгруппировать слова по первой букве.";

        public string[] Requirements => new[]
        {
            "Взять список слов (10+).",
            "Сгруппировать через LINQ GroupBy(w => w[0]).",
            "Отсортировать группы по первой букве.",
            "Внутри группы — отсортировать слова.",
            "Вывести «Буква: слово1, слово2, ...».",
            "Готово, если: группы по буквам, внутри — алфавитный порядок.",
        };

        public void Run()
        {
            var words = new List<string>
        {
            "banana", "apple", "avocado", "blueberry", "cherry",
            "apricot", "blackberry", "cranberry", "almond", "coconut",
            "date", "elderberry"
        };

            // Группировка и сортировка
            var grouped = words
                .GroupBy(w => w[0])                 // 1. Группируем по первой букве
                .OrderBy(g => g.Key)                // 2. Сортируем сами группы по букве
                .Select(g => new                    // 3. Создаем анонимный объект
                {
                    Letter = g.Key,
                    SortedWords = g.OrderBy(w => w) // Сортируем слова внутри группы
                });

            // Вывод результата
            foreach (var group in grouped)
            {
                // string.Join склеивает коллекцию слов через запятую
                Console.WriteLine($"{group.Letter}: {string.Join(", ", group.SortedWords)}");
            }
        }
    }
}
