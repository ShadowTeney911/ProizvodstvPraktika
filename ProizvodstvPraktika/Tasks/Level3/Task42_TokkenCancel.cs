using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task42_TokkenCancel : ITask
    {
        /* 
        * Задание 42. CancellationToken — отмена через 2 сек
Что сделать: 
Требования:

Готово, если: операция отменяется через 2 сек, исключение обработано, приложение не падает.
        */

        public string Title => "CancellationToken — отмена через 2 сек";

        public string Description => "реализовать долгую операцию с поддержкой отмены.";

        public string[] Requirements => new[]
        {
"async Task LongOperationAsync(CancellationToken token) — цикл с Task.Delay(500, token) 10 раз.",
"В Main создать CancellationTokenSource, запустить операцию, отменить через 2 секунды.",
"Обработать OperationCanceledException.",
"Вывести «операция отменена».",
        };

        // Долгая операция с поддержкой отмены
        static async Task LongOperationAsync(CancellationToken token)
        {
            for (int i = 1; i <= 10; i++)
            {
                // Проверяем отмену перед каждой итерацией
                token.ThrowIfCancellationRequested();

                Console.WriteLine($"  Шаг {i}/10 выполнен");
                await Task.Delay(500, token); // ждём 500 мс, реагируем на отмену
            }

            Console.WriteLine("  Операция завершена успешно");
        }

        static async Task RunAsync()
        {
            using (var cts = new CancellationTokenSource())
            {
                CancellationToken token = cts.Token;

                // Запускаем долгую операцию
                Console.WriteLine("=== Запуск долгой операции ===");
                Task operation = LongOperationAsync(token);

                // Отменяем через 2 секунды
                Console.WriteLine("\nОтмена через 2 секунды...");
                await Task.Delay(2000);
                cts.Cancel();
                Console.WriteLine("Сигнал отмены отправлен\n");

                // Ждём завершения (или отмены) операции
                try
                {
                    await operation;
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Операция отменена");
                }
            }
        }




        public void Run()
        {
            RunAsync().GetAwaiter().GetResult();
        }
    }
}
