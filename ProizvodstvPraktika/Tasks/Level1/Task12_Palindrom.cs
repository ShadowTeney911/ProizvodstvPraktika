using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task12_Palindrom : ITask
    {
        public string Title => "Палиндром (без учёта регистра/пробелов)";

        public string Description => "проверить, является ли строка палиндромом";

        public string[] Requirements => new[]
        {
            " - Игнорировать регистр (ToLower/ToUpper)",
            " - Игнорировать пробелы и знаки пунктуации (или хотя бы пробелы)",
            " - Не использовать LINQ Reverse",
            " - Пустая строка и строка из одного символа — палиндром "
        };
        static bool IsPalindrome(string s)
        {
            // Собираем только буквы и цифры в нижнем регистре
            string cleaned = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                    cleaned += char.ToLower(c);
            }

            // Проверяем двумя указателями
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }

        public void Run()
        {
            string[] tests = 
            {
                "А роза упала на лапу Азора",
                "Hello",
                "Бомбастер",
                "Потоп",
                "",
                "a"
            };

            foreach (string test in tests)
            {
                bool result = IsPalindrome(test);
                Console.WriteLine($"\"{test}\" → {result}");
            }
        }
        
    }
}
