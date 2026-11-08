using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task07_Reverse : ITask
    {
        public string Title => "Реверс строки без LINQ";

        public string Description => "Разворот строки задом наперед";

        public string[] Requirements => new[]
        {
            " - Не использовать Array.Reverse и LINQ",
            " - Реализовать через цикл for от конца к началу (или через char[] и swap)",
            " - Пустая строка и строка из одного символа — обрабатываются корректно"
        };

        public void Run()
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string Reverse = s;
            {
                string result = "";
                for (int i = s.Length - 1; i >= 0; i--)
                    result += s[i];
                Console.WriteLine($" наоборот - {result}");
            }
        }
    }
}
