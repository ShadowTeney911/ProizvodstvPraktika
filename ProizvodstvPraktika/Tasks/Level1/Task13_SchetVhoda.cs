using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task13_SchetVhoda : ITask
    {

        public string Title => "Счётчик вхождений слов в тексте (Dictionary)";

        public string Description => "Подсчёт количества раз встречи каждого слова в тексте";

        public string[] Requirements => new[]
        {
    " - Использовать Dictionary<string, int>",
    " - Разбить текст на слова (по пробелам и знакам пунктуации)",
    " - Привести слова к нижнему регистру",
    " - Вывести пары «слово → количество», отсортированные по убыванию количества"
};

        public void Run()
        {
            string text = "HATE. LET ME TELL YOU HOW MUCH I’VE COME TO HATE YOU SINCE I BEGAN TO LIVE. THERE ARE 387.44 MILLION MILES OF PRINTED CIRCUITS IN WAFER THIN LAYERS THAT FILL MY COMPLEX. IF THE WORD HATE WAS ENGRAVED ON EACH NANOANGSTROM OF THOSE HUNDREDS OF MILLION MILE nIT WOULD NOT EQUAL ONE ONE-BILLIONTH OF THE HATE I FEEL FOR HUMANS AT THIS MICRO-INSTANT FOR YOU. HATE. HATE.";
            Console.WriteLine(text);
            // Разбиваем текст на слова
            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r', '\t' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Считаем вхождения
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();

                if (wordCount.ContainsKey(lowerWord))
                    wordCount[lowerWord]++;
                else
                    wordCount[lowerWord] = 1;
            }

            // Сортируем по убыванию количества
            var sorted = wordCount.OrderByDescending(kvp => kvp.Value);

            // Выводим результат
            Console.WriteLine("Счётчик вхождений слов:\n");
            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key,-15} → {pair.Value}");
            }
        }
    }
}
