using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class NAZVANIE : ITask
    {
        /* 
        * Название
        * Описание
        * Требования (Массивом, кажется так будет проще
        * Запуск
        */

        public string Title => "------";

        public string Description => "--------";

        public string[] Requirements => new[]
        {
            " - ",
            " - ",
            " -"
        };

        public void Run()
        {
           
            Console.WriteLine("Hello World");
      
        }
    }
}
