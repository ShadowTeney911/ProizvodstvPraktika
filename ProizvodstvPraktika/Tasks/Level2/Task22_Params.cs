using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task22_Params : ITask
    {
        public string Title => "params-метод + перегрузка";

        public string Description => "написать метод суммы с params и его перегрузку.";

        public string[] Requirements => new[]
        {
            "Sum(params int[] numbers) — сумма произвольного числа чисел.",
            "Перегрузка Sum(int[] numbers) — та же логика для массива.",
            "Продемонстрировать: Sum(1, 2, 3), Sum(new[] {1, 2, 3}), Sum()."

        };

        public void Run()
        {
            // Способ 1: params — можно передать любое количество чисел
             int Sum(params int[] numbers)
            {
                int sum = 0;
                foreach (int n in numbers)
                    sum += n;
                return sum;
            }

            // Способ 2: перегрузка — принимает готовый массив
            int PeregrSum(int[] numbers)
            {
                int sum = 0;
                foreach (int n in numbers)
                    sum += n;
                return sum;
            }

             // Вызов 1: через params (несколько аргументов)
             Console.WriteLine($"Sum(1, 2, 3) = {Sum(1, 2, 3)}");

             // Вызов 2: через перегрузку (массив)
             Console.WriteLine($"Sum(new[] {{1, 2, 3}}) = {PeregrSum(new[] { 1, 2, 3 })}");

             // Вызов 3: пустой вызов
             Console.WriteLine($"Sum() = {Sum()}");
        }
    }
}