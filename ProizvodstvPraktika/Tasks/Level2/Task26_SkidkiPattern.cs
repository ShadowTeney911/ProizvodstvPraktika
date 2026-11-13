using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task26_SkidkiPattern
         : ITask
    {
        /* 
        * Название
        * Описание
        * Требования (Массивом, кажется так будет проще
        * Запуск
        */

        public string Title => "Паттерн «Стратегия» (скидки)";

        public string Description => "Что сделать: реализовать калькулятор скидок через паттерн «Стратегия».\r\n";

        public string[] Requirements => new[]
        {
"Интерфейс IDiscountStrategy с методом Apply(decimal price).",
"Реализации: NoDiscount, VipDiscount (10%), PromoDiscount (20%).",
"Класс PriceCalculator, принимающий стратегию в конструкторе.",
"Продемонстрировать расчёт цены с каждой стратегией.",
        };
        // Интерфейс стратегии скидки
        interface IDiscountStrategy
        {
            decimal Apply(decimal price);
        }

        // Без скидки
        class NoDiscount : IDiscountStrategy
        {
            public decimal Apply(decimal price) => price;
        }

        // VIP скидка 10%
        class VipDiscount : IDiscountStrategy
        {
            public decimal Apply(decimal price) => price * 0.9m;
        }

        // Промо скидка 20%
        class PromoDiscount : IDiscountStrategy
        {
            public decimal Apply(decimal price) => price * 0.8m;
        }

        // Калькулятор цены
        class PriceCalculator
        {
            private IDiscountStrategy strategy;

            public PriceCalculator(IDiscountStrategy strategy)
            {
                this.strategy = strategy;
            }

            // Можно менять стратегию на лету
            public void SetStrategy(IDiscountStrategy strategy)
            {
                this.strategy = strategy;
            }

            public decimal Calculate(decimal price)
            {
                return strategy.Apply(price);
            }
        }


        public void Run()
        {
            decimal price = 1000m;
            var calculator = new PriceCalculator(new NoDiscount());

            Console.WriteLine($"Исходная цена: {price} руб.\n");

            // Стратегия 1: без скидки
            Console.WriteLine($"Без скидки:      {calculator.Calculate(price):F2} руб.");

            // Меняем стратегию на VIP
            calculator.SetStrategy(new VipDiscount());
            Console.WriteLine($"VIP скидка 10%:  {calculator.Calculate(price):F2} руб.");

            // Меняем стратегию на Промо
            calculator.SetStrategy(new PromoDiscount());
            Console.WriteLine($"Промо скидка 20%: {calculator.Calculate(price):F2} руб.");

            // Или создаём новый калькулятор со стратегией
            Console.WriteLine("\n=== Через конструктор ===");
            var calc2 = new PriceCalculator(new VipDiscount());
            Console.WriteLine($"VIP: {calc2.Calculate(price):F2} руб.");
        }
    }

}
