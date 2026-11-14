using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Menu
{
    internal class MenuRunner
    {
        public void Run()
        {
            var levelMenu = new LevelMenu();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--==  C# практикум. Выберите нужный вам вариант  ==--");
                Console.WriteLine("1) Базовый уровень ( задачи с 1 по 15 )");
                Console.WriteLine("2) Средний уровень ( задачи с 16 по 35 )");
                Console.WriteLine("3) Продвинутый уровень ( задачи с 36 по 50 )");
                Console.WriteLine("4) Выход из программы");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        levelMenu.ShowLevel1Menu();
                        break;
                    case "2":
                        levelMenu.ShowLevel2Menu();
                        Console.ReadKey();
                        break;
                    case "3":
                        levelMenu.ShowLevel3Menu();
                        Console.ReadKey();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("--==  Неверный выбор  ==--");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
