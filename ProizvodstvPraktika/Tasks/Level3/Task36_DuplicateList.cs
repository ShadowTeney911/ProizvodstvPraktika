using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{

    internal class Task36_DuplicateList : ITask
    {

        public string Title => "Дубликаты в List (HashSet + GroupBy)";

        public string Description => "найти дубликаты в списке чисел двумя способами";

        public string[] Requirements => new[]
        {
            "Способ 1: через HashSet<int> — при добавлении проверять Contains.",
            "Способ 2: через LINQ GroupBy(x => x).Where(g => g.Count() > 1).",
            "Оба способа оформить отдельными методами.",
            "Продемонстрировать на списке с повторяющимися значениями.",
        };

        // Способ 1: через HashSet и Contains
        static HashSet<int> FindDuplicatesByHashSet(List<int> numbers)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int num in numbers)
            {
                if (seen.Contains(num))
                {
                    duplicates.Add(num);
                }
                else
                {
                    seen.Add(num);
                }
            }
            return duplicates;
        }
        // Способ 2: через LINQ GroupBy
        static List<int> FindDuplicatesByLinq(List<int> numbers)
        {
            return numbers
                .GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();
        }
        public void Run()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6, 1, 7, 8, 8, 8 };

            Console.WriteLine("Исходный список: " + string.Join(", ", numbers));

            // Получаем результаты
            var dups1 = FindDuplicatesByHashSet(numbers);
            var dups2 = FindDuplicatesByLinq(numbers);

            // Сортируем для красивого вывода
            var sorted1 = dups1.OrderBy(x => x);
            var sorted2 = dups2.OrderBy(x => x);

            Console.WriteLine($"\nСпособ 1 (HashSet): {string.Join(", ", sorted1)}");
            Console.WriteLine($"Способ 2 (LINQ):    {string.Join(", ", sorted2)}");

            // Проверяем, что наборы одинаковые (игнорируя порядок)
            bool areEqual = dups1.SetEquals(dups2);
            Console.WriteLine($"\nНаборы дубликатов совпадают: {areEqual}");
        }
    }
}
