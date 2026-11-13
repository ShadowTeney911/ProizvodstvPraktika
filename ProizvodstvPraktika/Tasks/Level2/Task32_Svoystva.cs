using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    /*
     * Задание 32. 
Что сделать: .
Требования:

Готово, если: корректное значение принимается, некорректное бросает исключение, Fahrenheit пересчитывается",
     * */
    internal class Task32_Svoystva : ITask
    {
        /* 
        * Название
        * Описание
        * Требования (Массивом, кажется так будет проще
        * Запуск
        */

        public string Title => "Свойства с валидацией (Temperature)";

        public string Description => "класс Temperature с валидацией в set";

        public string[] Requirements => new[]
        {
           "Свойство Celsius с проверкой в set: не ниже −273.15.",
"При некорректном значении — бросать ArgumentOutOfRangeException.",
"Вычисляемое свойство Fahrenheit (только get).",
"Продемонстрировать корректное и некорректное присваивание.",

        };
        class Temperature
        {
            private double _celsius;

            // Свойство с валидацией
            public double Celsius
            {
                get { return _celsius; }
                set
                {
                    if (value < -273.15)
                        throw new ArgumentOutOfRangeException(nameof(value),
                            "Температура не может быть ниже абсолютного нуля (-273.15 °C)");

                    _celsius = value;
                }
            }

            // Вычисляемое свойство (только для чтения)
            public double Fahrenheit => _celsius * 9 / 5 + 32;
        }

        public void Run()
        {
            var temp = new Temperature();

            // 1. Корректное присваивание
            Console.WriteLine("=== Корректные значения ===");
            temp.Celsius = 100;
            Console.WriteLine($"Celsius: {temp.Celsius}, Fahrenheit: {temp.Fahrenheit}");

            temp.Celsius = -40;
            Console.WriteLine($"Celsius: {temp.Celsius}, Fahrenheit: {temp.Fahrenheit}");

            // 2. Некорректное присваивание
            Console.WriteLine("\n=== Некорректное значение ===");
            try
            {
                Console.WriteLine("Пытаемся установить -300...");
                temp.Celsius = -300;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // Проверяем, что значение не изменилось
            Console.WriteLine($"\nЗначение после ошибки: {temp.Celsius}");
        }
    }
}
