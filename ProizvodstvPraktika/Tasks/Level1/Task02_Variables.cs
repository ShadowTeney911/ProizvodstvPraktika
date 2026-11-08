using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task02_Variables : ITask
    {
        /* 
        * Название
        * Описание
        * Требования (Массивом, кажется так будет проще
        * Запуск
        * 
      

        */

        public string Title => "Переменные примитивных типов";

        public string Description => "Объявить переменные всех примитивных типов и вывести их значения и типы";

        public string[] Requirements => new[]
        {
            " - Объявить минимум: int, long, double, float, decimal, bool, char, string.",
            " - Для каждой переменной вывести значение и GetType().Name.",
            " - decimal — с суффиксом m, float — с f.",
            " - Готово, если: по каждой переменной в консоли есть строка «имя = значение (тип)»."
        };

        public void Run()
        {
            int nt = 2027;
            long lng = 9223372036854775807;
            double dbl = 13.09;
            float flt = 3.14f; // float нужно указать f в конце для компилятора
            decimal dcml = 123.4m;
            bool bl = true;
            char chr = 'A';
            string strng = "Abcdefg";

            Console.WriteLine($" {nt} - тип {nt.GetType().Name} \n {lng} - тип {lng.GetType().Name} \n {dbl} - тип {dbl.GetType().Name} \n {flt} - тип {flt.GetType().Name} \n {dcml} - тип {dcml.GetType().Name} \n {bl} - тип {bl.GetType().Name} \n {chr} - тип {chr.GetType().Name} \n {strng} - тип {strng.GetType().Name}");
        }
    }
}
