using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task25_Figures : ITask
    {
        public string Title => "Интерфейс IShape + сортировка фигур";

        public string Description => "реализовать интерфейс фигур и отсортировать их.";

        public string[] Requirements => new[]
        {
             "IShape с методами Area() и Perimeter().", "Классы Circle, Rectangle, Triangle — реализуют IShape.", "Создать List<IShape> из 5+ фигур.", "Отсортировать по площади (через List.Sort с лямбдой или OrderBy).", "Вывести фигуры с площадями до и после сортировки"
        };
        interface IShape
        {
            double Area();
            double Perimeter();
        }

        class Circle : IShape
        {
            public double R { get; set; }
            public Circle(double r) { R = r; }
            public double Area() => Math.PI * R * R;
            public double Perimeter() => 2 * Math.PI * R;
            public override string ToString() => $"Круг(r={R})";
        }

        class Rectangle : IShape
        {
            public double W, H;
            public Rectangle(double w, double h) { W = w; H = h; }
            public double Area() => W * H;
            public double Perimeter() => 2 * (W + H);
            public override string ToString() => $"Прямоугольник({W}x{H})";
        }

        class Triangle : IShape
        {
            public double A, B, C;
            public Triangle(double a, double b, double c) { A = a; B = b; C = c; }
            public double Area()
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
            public double Perimeter() => A + B + C;
            public override string ToString() => $"Треугольник({A},{B},{C})";
        }
        public void Run()
        {
            List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(3, 4),
            new Triangle(3, 4, 5),
            new Circle(2),
            new Rectangle(10, 2)
        };

            Console.WriteLine("=== До сортировки ===");
            foreach (var s in shapes)
                Console.WriteLine($"{s} → Площадь: {s.Area():F2}");

            shapes.Sort((a, b) => a.Area().CompareTo(b.Area()));

            Console.WriteLine("\n=== После сортировки ===");
            foreach (var s in shapes)
                Console.WriteLine($"{s} → Площадь: {s.Area():F2}");
        }
    }
}
