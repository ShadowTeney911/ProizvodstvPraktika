using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    /*
     * Задание 24. ООП: Animal → Dog/Cat/Bird
Что сделать: построить иерархию животных.
Требования:

Абстрактный класс Animal: свойство Name, абстрактный метод MakeSound(), переопределённый ToString().
Классы Dog, Cat, Bird — наследники, реализуют MakeSound().
Bird дополнительно имеет метод Fly().
Готово, если: в цикле по List<Animal> каждый издаёт свой звук, ToString() информативен.
     * */
    internal class Task24_OOP : ITask
    {
        public string Title => " ООП: Animal → Dog/Cat/Bird";

        public string Description => "построить иерархию животных.";

        public string[] Requirements => new[]
        {
            "Абстрактный класс Animal: свойство Name, абстрактный метод MakeSound(), переопределённый ToString().",
            "Классы Dog, Cat, Bird — наследники, реализуют MakeSound().",
            "Bird дополнительно имеет метод Fly().",
            "Продемонстрировать полиморфизм: List<Animal> с разными животными, вызов MakeSound() в цикле."
        };

        // Абстрактный класс Animal
        abstract class Animal
        {
            public string Name { get; set; }
            public Animal(string name)
            {
                Name = name;
            }
            // Абстрактный метод — должен быть реализован в наследниках
            public abstract string MakeSound();
            // Переопределение ToString
            public override string ToString()
            {
                return $"Животное: {Name}";
            }
        }

        // Класс Dog
        class Dog : Animal
        {
            public Dog(string name) : base(name) { }
            public override string MakeSound()
            {
                return "Гав-гав!";
            }
            public override string ToString()
            {
                return $"Собака: {Name}";
            }
        }

        // Класс Cat
        class Cat : Animal
        {
            public Cat(string name) : base(name) { }
            public override string MakeSound()
            {
                return "Мяу!";
            }
            public override string ToString()
            {
                return $"Кошка: {Name}";
            }
        }

        // Класс Bird
        class Bird : Animal
        {
            public Bird(string name) : base(name) { }
            public override string MakeSound()
            {
                return "Чирик-чирик!";
            }
            // Дополнительный метод только для Bird
            public string Fly()
            {
                return $"{Name} летит!";
            }
            public override string ToString()
            {
                return $"Птица: {Name}";
            }
        }

        public void Run()
        {
            // Создаём список животных (полиморфизм)
            List<Animal> animals = new List<Animal>
        {
            new Dog("Собакен"),
            new Cat("Котакен"),
            new Bird("Птицен"),
            new Dog("Собакабакен"),
            new Cat("Котангенс")
        };

            // Демонстрация полиморфизма
            Console.WriteLine("=== Полиморфизм: вызов MakeSound() ===\n");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal} говорит: {animal.MakeSound()}");
            }

            // Демонстрация ToString()
            Console.WriteLine("\n=== ToString() ===\n");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

            // Демонстрация метода Fly() только для Bird
            Console.WriteLine("\n=== Метод Fly() для Bird ===\n");
            foreach (Animal animal in animals)
            {
                if (animal is Bird bird)
                {
                    Console.WriteLine(bird.Fly());
                }
            }
        }
    }
}
