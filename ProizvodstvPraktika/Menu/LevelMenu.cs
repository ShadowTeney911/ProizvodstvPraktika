using ProizvodstvPraktika.Common;
using ProizvodstvPraktika.Tasks.Level1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Menu
{
    internal class LevelMenu
    {
        public void ShowLevel1Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--==  Уровень 1: Базовый  ==--");
                Console.WriteLine("1) Hello, World + текущая дата");
                Console.WriteLine("2) Переменные примитивных типов");
                Console.WriteLine("3) Калькулятор с делением на ноль");
                Console.WriteLine("4) Чётность числа (два способа)");
                Console.WriteLine("5) Таблица умножения 10×10");
                Console.WriteLine("6) Сумма цифр числа (строка + арифметика)");
                Console.WriteLine("7) Реверс строки без LINQ");
                Console.WriteLine("8) FizzBuzz 1–100");
                Console.WriteLine("9) Массивы: min/max/sum/avg");
                Console.WriteLine("10) Сортировка пузырьком + вставками");
                Console.WriteLine("11) Диагональ матрицы N×N");
                Console.WriteLine("12) Палиндром (без учёта регистра/пробелов)");
                Console.WriteLine("13) Счётчик вхождений слов в тексте (Dictionary)");
                Console.WriteLine("14) Возраст по дате рождения");
                Console.WriteLine("15) Git: репозиторий → ветка → merge → разрешение конфликта");


                Console.WriteLine("0) Назад");
                Console.WriteLine("\n Выберите нужную вам задачу с помощью номеру");
                string UserChoice = Console.ReadLine();
                switch (UserChoice)
                {
                    default:
                        Console.WriteLine("Неверный выбор. Нажмите Enter");
                        Console.ReadKey();
                        break;
                    case "0": Console.Clear(); return;

                    case "1":
                        RunTask(new Task01_HelloWorld());
                        break;
                    case "2":
                        RunTask(new Task02_Variables());
                        break;
                    case "3":
                        RunTask(new Task03_Calculator());
                        break;
                    case "4":
                        RunTask(new Task04_ChetnostChisla());
                        break;
                    case "5":
                        RunTask(new Task05_Tablica10x10());
                        break;
                    case "6":
                        RunTask(new Task06_SummaChisla());
                        break;
                    case "7":
                        RunTask(new Task07_Reverse());
                    break;
                    case "8":
                        RunTask(new Task08_FizzBuss());
                        break;
                    case "9":
                        RunTask(new Task09_MinMaxETC());
                        break;
                    case "10":
                        RunTask(new Task10_SortBubble());
                        break;
                    case "11":
                        RunTask(new Task11_Diagonal());
                        break;
                    case "12":
                        RunTask(new Task12_Palindrom());
                        break;
                    case "13":
                        RunTask(new Task13_SchetVhoda());
                        break;
                    case "14":
                        RunTask(new Task14_Vozrast());
                        break;



                }

            }
        }
        private void RunTask(ITask task)
        {
            Console.Clear();
            Console.WriteLine($"Задание: {task.Title}");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Описание: {task.Description}");
            Console.WriteLine("-----------------------------------------");
            foreach (var requirements in task.Requirements)
            {
                Console.WriteLine($"- {requirements}");
            }
            Console.WriteLine("-----------------------------------------");
            task.Run();
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Нажмите любую клавишу для возврата в меню");
            Console.ReadKey();
        }
    }
}
