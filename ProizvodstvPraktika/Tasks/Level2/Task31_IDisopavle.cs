using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task31_IDisopavle : ITask
    {
        /* 

        */

        public string Title => "IDisposable + using";

        public string Description => "реализовать IDisposable для класса, работающего с файлом.";

        public string[] Requirements => new[]
        {
            "Реализовать Dispose() (закрыть StreamWriter).",
"Продемонстрировать использование через using.",
"Дополнительно: продемонстрировать using-декларацию (C# 8+, using var).",
"Готово, если: файл закрывается после выхода из using, повторная запись не падает.",

        };
        class FileWriter : IDisposable
        {
            private StreamWriter writer;
            private bool disposed = false;

            public FileWriter(string path)
            {
                writer = new StreamWriter(path, append: true);
            }

            public void Write(string text)
            {
                if (disposed)
                {
                    Console.WriteLine("Объект уже удалён, запись невозможна");
                    return;
                }
                writer.WriteLine(text);
                writer.Flush();
            }

            public void Dispose()
            {
                if (!disposed)
                {
                    writer?.Close();
                    writer?.Dispose();
                    disposed = true;
                    Console.WriteLine("Файл закрыт и ресурсы освобождены");
                }
            }
        }

        public void Run()
        {
            Console.WriteLine("-=Я сделал без обновления СиШарп v8. Нашёл альтернативный способ в интернете=-");
            string path = "test.txt";

            // Классический using — работает в C# 7.3 и ниже
            using (var fw = new FileWriter(path))
            {
                fw.Write("Строка 1");
                fw.Write("Строка 2");
            } // Dispose вызывается автоматически

            // Ещё один using
            using (var fw2 = new FileWriter(path))
            {
                fw2.Write("Строка 3");
            }

            // Ручной Dispose
            var fw3 = new FileWriter(path);
            fw3.Write("Строка 4");
            fw3.Dispose();
            fw3.Write("Строка 5"); // не упадёт

            Console.WriteLine("\n=== Содержимое файла ===");
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
