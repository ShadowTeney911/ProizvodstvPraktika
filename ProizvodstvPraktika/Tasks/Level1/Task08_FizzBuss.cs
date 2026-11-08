using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task08_FizzBuss : ITask
    {
        public string Title => " FizzBuzz 1–100";

        public string Description => "вывести числа от 1 до 100 с заменами определенных элементов";

        public string[] Requirements => new[]
        {
        " - Кратно 5 → Buzz.",
        " - Кратно 3 → Fizz.",
        " - Кратно 15 → FizzBuzz.",
        " - Иначе - само число",
        " - Порядок проверок - 15 > 3 > 5"
        };

        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
