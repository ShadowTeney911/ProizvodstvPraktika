using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task06_SummaChisla : ITask
    {
        public string Title => " Сумма цифр числа (строка + арифметика)";

        public string Description => "найти сумму цифр введённого числа (например, 1234 → 10).";

        public string[] Requirements => new[]
        {
            " - Способ 1 (строка): число → ToString() → пройти по символам → int.Parse каждой цифры",
            " - Способ 2 (арифметика): цикл while (n > 0) { sum += n % 10; n /= 10; }",
            " - Оба способа оформить отдельными методами",
            " - Отрицательные числа — брать модуль"
        };

        public void Run()
        {
            // Способ 1: через строку
             int MetodSTROK(int n)
            {
                n = Math.Abs(n);
                string s = n.ToString();
                int sum = 0;
                foreach (char c in s)
                    sum += int.Parse(c.ToString());
                return sum;
            }

            // Способ 2: через арифметику
            int MetodARIFMETIC(int n)
            {
                n = Math.Abs(n);
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                return sum;
            }

            
            int[] tests = { 123, 0, -1234};

            foreach (int num in tests)
            {
                int sum1 = MetodSTROK(num);
                int sum2 = MetodARIFMETIC(num);
                Console.WriteLine($"Число: {num,5} | Строчный метод: {sum1,2} | Арифмет метод: {sum2,2} | Совпадение методов: {sum1 == sum2}");
            }
            
        }
    }
}
