using ProizvodstvPraktika.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task14_Vozrast : ITask
    {
        public string Title => "Возраст по дате рождения";

        public string Description => "по дате рождения вычислить точный возраст в годах, месяцах и днях";

        public string[] Requirements => new[]
        {
            " - Ввод даты через DateTime.TryParse (или TryParseExact)",
            " - Учесть, что день рождения в этом году мог ещё не наступить",
            " - Вывести «X лет, Y месяцев, Z дней»",
            " - Некорректная дата — сообщение об ошибке, не падать"
        };

        public void Run()
        {
            Console.Write("Введите дату рождения (дд.мм.гггг): ");

            if (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null,
                System.Globalization.DateTimeStyles.None, out DateTime birth))
            {
                Console.WriteLine("Ошибка: некорректная дата");
                return;
            }

            if (birth > DateTime.Today)
            {
                Console.WriteLine("Ошибка: дата в будущем");
                return;
            }

            DateTime today = DateTime.Today;

            int years = today.Year - birth.Year;
            int months = today.Month - birth.Month;
            int days = today.Day - birth.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(today.Year, today.Month == 1 ? 12 : today.Month - 1);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Возраст: {years} лет, {months} месяцев, {days} дней");
        }
    }
}
