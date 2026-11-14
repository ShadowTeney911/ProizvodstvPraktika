using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task38_Benchmark : ITask
    {
        /* 
        * Задание 38. List<T> vs LinkedList<T> (бенчмарк)
Что сделать: сравнить вставку в середину List<T> и LinkedList<T>.
Требования:

Готово, если: времена выведены, есть вывод о разнице (LinkedList быстрее на вставке, но медленнее на поиске по индексу).
        */

        public string Title => "List<T> vs LinkedList<T> (бенчмарк)";

        public string Description => "сравнить вставку в середину List<T> и LinkedList<T>.-";

        public string[] Requirements => new[]
        {
            "Создать List<int> и LinkedList<int> по 100 000 элементов.",
"Вставить 1000 элементов в середину каждой коллекции.",
"Замерить время через Stopwatch.",
"Вывести оба времени и объяснить результат в комментарии.",

        };

        public void Run()
        {
            int size = 100000;
            int insertions = 1000;

            // Создаем List и заполняем
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
                list.Add(i);

            // Создаем LinkedList и заполняем
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < size; i++)
                linkedList.AddLast(i);

            // Замер для List: вставка в середину по индексу
            Stopwatch sw1 = Stopwatch.StartNew();
            for (int i = 0; i < insertions; i++)
            {
                int middleIndex = list.Count / 2;
                list.Insert(middleIndex, 999);
            }
            sw1.Stop();

            // Замер для LinkedList: поиск середины + вставка
            Stopwatch sw2 = Stopwatch.StartNew();
            for (int i = 0; i < insertions; i++)
            {
                // Находим середину (обход узлов)
                LinkedListNode<int> middle = linkedList.First;
                for (int j = 0; j < linkedList.Count / 2; j++)
                    middle = middle.Next;

                // Вставка перед найденным узлом
                linkedList.AddBefore(middle, 999);
            }
            sw2.Stop();

            Console.WriteLine($"Вставка {insertions} элементов в середину коллекции из {size} элементов:\n");
            Console.WriteLine($"List<T>:        {sw1.ElapsedMilliseconds} мс");
            Console.WriteLine($"LinkedList<T>:  {sw2.ElapsedMilliseconds} мс");
            Console.WriteLine($"Разница:        {sw2.ElapsedMilliseconds - sw1.ElapsedMilliseconds} мс");

        }
    }
}
