using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task04_ChetnostChisla : ITask
    {
        public string Title => "Чётность числа (два способа)";

        public string Description => "Определение, чётное ли введённое число";

        public string[] Requirements => new[]
        {
            " - Способ 1: через % 2 == 0.",
            " - Способ 2: через тернарный оператор ? :n",
            " - Вывести результат обоих способов."
        };

        public void Run()
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            // Способ 1: через % 2 == 0
            bool IsEven1 = n % 2 == 0;

            // Способ 2: через тернарный оператор --- Тернарный оператор ? : — это сокращённая запись if-else. 
            /*
             * Сначала проверяется условие n % 2 == 0 (остаток от деления на 2 равен нулю?)
             * Если да (условие истинно) → возвращается true
             * Если нет (условие ложно) → возвращается false
            */
            bool IsEven2 = n % 2 == 0 ? true : false;
            
            Console.WriteLine($"Способ 1: {(IsEven1 ? "чётное" : "нечётное")}");
            Console.WriteLine($"Способ 2: {(IsEven2 ? "чётное" : "нечётное")}");
        }
    }
}


 
   