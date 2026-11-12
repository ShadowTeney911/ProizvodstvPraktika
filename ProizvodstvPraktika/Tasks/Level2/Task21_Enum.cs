using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task21_Enum : ITask
    {
        public string Title => "enum дни недели";

        public string Description => "описать дни недели через enum и определить тип дня";

        public string[] Requirements => new[]
        {
            "enum DayOfWeek { Monday, ..., Sunday }",
            "Метод IsWeekend(DayOfWeek day) — true для субботы и воскресенья.",
            "Метод GetRussianName(DayOfWeek day) — возвращает название на русском.",
            "Продемонстрировать на всех 7 днях."
        };
        enum DayOfWeek //Enum (перечисление) в C# — пользовательский тип данных,фиксированный набор именованных целочисленных констант
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public void Run()
        {
            bool IsWeekend(DayOfWeek day) // проверка на выходные
            {
                return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
            }

            string GetRussianName(DayOfWeek day)
            {
                switch (day)
                {
                    case DayOfWeek.Monday: return "Понедельник";
                    case DayOfWeek.Tuesday: return "Вторник";
                    case DayOfWeek.Wednesday: return "Среда";
                    case DayOfWeek.Thursday: return "Четверг";
                    case DayOfWeek.Friday: return "Пятница";
                    case DayOfWeek.Saturday: return "Суббота";
                    case DayOfWeek.Sunday: return "Воскресенье";
                    default: return "Неизвестно";
                }
            }
            Console.WriteLine("Дни недели:\n");

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                string name = GetRussianName(day);
                string type = IsWeekend(day) ? "Выходной" : "Рабочий";
                Console.WriteLine($"{name,-12} → {type}");
            }

        }

    }

}
