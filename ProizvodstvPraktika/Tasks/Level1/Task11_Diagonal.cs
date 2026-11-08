using ProizvodstvPraktika.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task11_Diagonal : ITask
    {
        public string Title => "Диагональ матрицы N×N";

        public string Description => " найти сумму элементов главной диагонали матрицы N×N.";

        public string[] Requirements => new[]
        {
    " - Размер N вводится пользователем (минимум 2)",
    " - Матрица заполняется случайными числами",
    " - Вывести саму матрицу и сумму"
};

        public void Run()
        {
            // Ввод N с проверкой
            int n;
            do
            {
                Console.Write("Введите размер матрицы N (минимум 2): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 2);

            // Создание и заполнение матрицы
            Random rnd = new Random();
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(1, 100);

            // Вывод матрицы
            Console.WriteLine("\nМатрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0,4}", matrix[i, j]);
                Console.WriteLine();
            }

            // Сумма главной диагонали в одном цикле
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += matrix[i, i];

            Console.WriteLine($"\nСумма главной диагонали: {sum}");
        }
    }
}
