using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task01_HelloWorld : ITask
    {
        /* 
        * Название
        * Описание
        * Требования (Массивом, кажется так будет проще
        * Запуск
        */

        public string Title => "Hello, World + текущая дата";

        public string Description => "Вывести приветствие и текущую дату";

        public string[] Requirements => new[] 
        {
            " - Использовать Console.WriteLine.",
            " - Дату получить через DateTime.Now, отформатировать как dd.MM.yyyy.",
            " - Вывести две строки: приветствие и дату"
        };

        public void Run()
        {
            DateTime NasheVremya = DateTime.Now;
            Console.WriteLine("Hello World");
            Console.WriteLine(NasheVremya.ToString("dd.MM.yyyy"));
        }
    }
}
