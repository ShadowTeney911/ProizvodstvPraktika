using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task05_Tablica10x10 : ITask
    {
        public string Title => "Таблица умножения 10 х 10";

        public string Description => "Вывод таблицы умножения 10×1";

        public string[] Requirements => new[]
        {
            " - Использовать вложенные циклы for.",
            " - Выровнять столбцы.",
            " - Заголовки строк/столбцов — не обязательны, но приветствуются."
        };

        public void Run()
        {
            //параметры форматирования в {0,2} и {0,4}. Синтаксис: {индекс, ширина} Нужно чтобы все стояло +- ровно независимо 1 или 101
            // Заголовки столбцов
            Console.Write("    ");
            for (int j = 1; j <= 10; j++)
                Console.Write("{0,4}", j);
            Console.WriteLine();

            // Строки таблицы
            for (int i = 1; i <= 10; i++)
            {
                // Заголовок строки
                Console.Write("{0,2} |", i);

                // Значения в строке
                for (int j = 1; j <= 10; j++)
                    Console.Write("{0,4}", i * j);

                Console.WriteLine();
            }
        }
    }
}
