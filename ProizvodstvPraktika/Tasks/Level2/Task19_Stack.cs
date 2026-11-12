using ProizvodstvPraktika.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task19_Stack : ITask
    {
        public string Title => "Задание 19. Свой стек/очередь на массиве";

        public string Description => "реализовать MyStack<T> и MyQueue<T> на массив";

        public string[] Requirements => new[]
        {
            "Стек: Push, Pop, Peek, Count, IsEmpty.",
            "Очередь: Enqueue, Dequeue, Peek, Count, IsEmpty.",
            "При переполнении — расширять внутренний массив (удвоение).",
            "Pop/Dequeue на пустой коллекции — бросать InvalidOperationException."
        };
        public void Run()
        {

        }

    }
}
