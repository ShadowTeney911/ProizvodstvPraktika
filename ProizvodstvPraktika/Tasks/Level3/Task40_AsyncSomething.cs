using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task40_AsyncSomething : ITask
    {
        /* 
        * Задание 40. async/await + обработка исключений
Что сделать: асинхронный метод с эмуляцией «скачивания».
Требования:

"async Task<string> DownloadAsync(string url) — внутри Task.Delay(1000).",
"Имитировать ошибку: если url пустой — бросить ArgumentException.",
"В Main вызвать через await внутри try/catch.",
"Продемонстрировать успешный и ошибочный вызов.",
Готово, если: успешный вызов возвращает результат, ошибочный — ловится try/catch, приложение не падает.
        * Запуск
        */

        public string Title => "async/await + обработка исключений";

        public string Description => "асинхронный метод с эмуляцией «скачивания».";

        public string[] Requirements => new[]
        {
            "async Task<string> DownloadAsync(string url) — внутри Task.Delay(1000).",
"Имитировать ошибку: если url пустой — бросить ArgumentException.",
"В Main вызвать через await внутри try/catch.",
"Продемонстрировать успешный и ошибочный вызов.",

        };


        // Асинхронный метод "скачивания"
        static async Task<string> DownloadAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("URL не может быть пустым", nameof(url));

            Console.WriteLine($"  Начинаю скачивание: {url}");
            await Task.Delay(1000); // имитация долгой операции
            return $"Данные с {url} (размер: 1024 байт)";
        }
        // Асинхронный метод для Main (т.к. в C# 7.3 Main не может быть async)
        static async Task RunAsync()
        {
            // 1. Успешный вызов
            Console.WriteLine("=== Успешный вызов ===");
            try
            {
                string result = await DownloadAsync("https://example.com");
                Console.WriteLine($"Результат: {result}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}\n");
            }

            // 2. Ошибочный вызов (пустой URL)
            Console.WriteLine("=== Ошибочный вызов ===");
            try
            {
                string result = await DownloadAsync("");
                Console.WriteLine($"Результат: {result}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Поймали ArgumentException: {ex.Message}");
                Console.WriteLine($"Параметр: {ex.ParamName}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Другая ошибка: {ex.Message}\n");
            }

            Console.WriteLine("Программа завершилась корректно");
        }

        public void Run()
        {
            RunAsync().GetAwaiter().GetResult();
        }
    }
}
