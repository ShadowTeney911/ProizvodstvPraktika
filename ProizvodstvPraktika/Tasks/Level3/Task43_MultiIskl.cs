using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task43_MultiIskl : ITask
    {
        /* 
        * Задание 43. 
Что сделать: 
Требования:

"Метод, который может бросить FormatException, DivideByZeroException или свой CustomException.",
"Несколько catch-блоков в правильном порядке (от частного к общему).",
"Продемонстрировать все три сценария.",
"В конце — finally с выводом «завершено».",
"Объяснить в комментарии, почему порядок catch важен.",
Готово, если: каждое исключение ловится своим блоком, finally выполняется всегда.
        */

        public string Title => "Множественные типы исключений, порядок catch";

        public string Description => "продемонстрировать порядок обработки исключений.";

        public string[] Requirements => new[]
        {
            "Метод, который может бросить FormatException, DivideByZeroException или свой CustomException.",
"Несколько catch-блоков в правильном порядке (от частного к общему).",
"Продемонстрировать все три сценария.",
"В конце — finally с выводом «завершено».",
"Объяснить в комментарии, почему порядок catch важен.",

        };



        // Собственное исключение
        class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }



        // Метод, который может бросить три разных исключения
        static void RiskyMethod(int type)
        {
            switch (type)
            {
                case 1:
                    // Ошибка формата
                    int.Parse("не_число");
                    break;
                case 2:
                    // Деление на ноль
                    int x = 10;
                    int y = 0;
                    int result = x / y;
                    break;
                case 3:
                    // Собственное исключение
                    throw new CustomException("Произошла пользовательская ошибка");
                default:
                    Console.WriteLine("Никаких ошибок");
                    break;
            }
        }



        public void Run()
        {
            // Сценарий 1: FormatException
            Console.WriteLine("=== Сценарий 1: FormatException ===");
            try
            {
                RiskyMethod(1);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Поймали FormatException: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Поймали DivideByZeroException: {ex.Message}");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Поймали CustomException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Поймали общее Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершено\n");
            }

            // Сценарий 2: DivideByZeroException
            Console.WriteLine("=== Сценарий 2: DivideByZeroException ===");
            try
            {
                RiskyMethod(2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Поймали FormatException: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Поймали DivideByZeroException: {ex.Message}");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Поймали CustomException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Поймали общее Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершено\n");
            }

            // Сценарий 3: CustomException
            Console.WriteLine("=== Сценарий 3: CustomException ===");
            try
            {
                RiskyMethod(3);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Поймали FormatException: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Поймали DivideByZeroException: {ex.Message}");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Поймали CustomException: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Поймали общее Exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершено\n");
            }
        }
    }
}
