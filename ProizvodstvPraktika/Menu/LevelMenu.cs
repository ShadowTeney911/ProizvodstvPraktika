using ProizvodstvPraktika.Common;
using ProizvodstvPraktika.Tasks.Level1;
using ProizvodstvPraktika.Tasks.Level2;
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
                    case "15":
                        RunTask(new Task15_WorkFilesandGit());
                        break;



                }

            }
        }
        public void ShowLevel2Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--==  Уровень 2: Средний  ==--");
                Console.WriteLine("1) Методы расширения для string");
                Console.WriteLine("2) StringBuilder vs конкатенация (замер)");
                Console.WriteLine("3) TryParse vs TryCatch");
                Console.WriteLine("4) --- ");
                Console.WriteLine("5) --- ");
                Console.WriteLine("6) Enum дни недели ");
                Console.WriteLine("7) Params");
                Console.WriteLine("8) --- ");
                Console.WriteLine("9) ОбъОринтПрогрм");
                Console.WriteLine("10) Фигуры");
                Console.WriteLine("11) Скидки и паттерны");
                Console.WriteLine("12) ---");
                Console.WriteLine("13) ---");
                Console.WriteLine("14)Фабрика");
                Console.WriteLine("15) Банк аккаунт");
                Console.WriteLine("16) IDisposable");
                Console.WriteLine("17) Свойства");
                Console.WriteLine("18) LINQ");
                Console.WriteLine("19) LINQ 2");



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
                        RunTask(new Task16_StringExtension());
                        break;
                    case "2":
                        RunTask(new Task17_StringBuilder());
                        break;
                    case "3":
                        RunTask(new Task18_TryParseETC());
                        break;
                    case "4":
                        Console.WriteLine("-=Wip=-");
                        break;
                    case "5":
                        Console.WriteLine("-=Wip=-");
                        break;
                    case "6":
                        RunTask(new Task21_Enum());
                        break;
                    case "7":
                        RunTask(new Task22_Params());
                        break;
                    case "8":
                        Console.WriteLine("-=Wip=-");
                        break;
                    case "9":
                        RunTask(new Task24_OOP());
                        break;
                    case "10":
                        RunTask(new Task25_Figures());
                        break;
                    case "11":
                        RunTask(new Task26_SkidkiPattern());
                        break;
                    case "12":
                        break;
                    case "13":
                        break;
                    case "14":
                        RunTask(new Task29_Fabric());
                        break;
                    case "15":
                        RunTask(new Task30_BankAcc());
                        break;
                    case "16":
                        RunTask(new Task31_IDisopavle());
                        break;
                    case "17":
                        RunTask(new Task32_Svoystva());
                        break;
                    case "18":
                        RunTask(new Task33_LINQ());
                        break;
                    case "19":
                        RunTask(new Task34_LINQ2());
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
