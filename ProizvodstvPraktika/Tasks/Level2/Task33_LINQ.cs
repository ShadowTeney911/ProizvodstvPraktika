using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task33_LINQ : ITask
    {

        public string Title => "LINQ: сотрудники (top-3, avg по отделу, фильтр)";

        public string Description => "LINQ-запросы по списку сотрудников.";

        public string[] Requirements => new[]
        {
            "Класс Employee: Name, Age, Salary, Department.",
            "Список из 10+ сотрудников.",
            "Запросы через LINQ:",
            "топ-3 по зарплате (убывание);",
            "средняя зарплата по каждому отделу (GroupBy + Average);",
            "сотрудники старше 30 (Where).",
        };

        class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }

            public override string ToString() => $"{Name} ({Age} лет, {Department}) — {Salary:C}";
        }

        public void Run()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Иванов", Age = 25, Salary = 50000, Department = "IT" },
            new Employee { Name = "Петров", Age = 35, Salary = 80000, Department = "IT" },
            new Employee { Name = "Сидоров", Age = 42, Salary = 120000, Department = "IT" },
            new Employee { Name = "Козлов", Age = 28, Salary = 45000, Department = "HR" },
            new Employee { Name = "Новиков", Age = 31, Salary = 60000, Department = "HR" },
            new Employee { Name = "Морозов", Age = 45, Salary = 150000, Department = "Sales" },
            new Employee { Name = "Волков", Age = 33, Salary = 90000, Department = "Sales" },
            new Employee { Name = "Зайцев", Age = 29, Salary = 55000, Department = "Sales" },
            new Employee { Name = "Соловьев", Age = 38, Salary = 110000, Department = "IT" },
            new Employee { Name = "Лебедев", Age = 27, Salary = 48000, Department = "HR" },
            new Employee { Name = "Кузнецов", Age = 50, Salary = 200000, Department = "Sales" }
        };

            // 1. Топ-3 по зарплате (убывание)
            Console.WriteLine("=== Топ-3 по зарплате ===");
            var top3 = employees
                .OrderByDescending(e => e.Salary)
                .Take(3);

            foreach (var emp in top3)
                Console.WriteLine(emp);

            // 2. Средняя зарплата по отделам
            Console.WriteLine("\n=== Средняя зарплата по отделам ===");
            var avgByDept = employees
                .GroupBy(e => e.Department)
                .Select(g => new { Department = g.Key, Average = g.Average(e => e.Salary) });

            foreach (var dept in avgByDept)
                Console.WriteLine($"{dept.Department}: {dept.Average:C}");

            // 3. Сотрудники старше 30
            Console.WriteLine("\n=== Сотрудники старше 30 лет ===");
            var olderThan30 = employees.Where(e => e.Age > 30);

            foreach (var emp in olderThan30)
                Console.WriteLine(emp);
        }
    }
}
