using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task30_BankAcc : ITask
    {
        public string Title => "BankAccount + свой Exception";

        public string Description => "реализовать банковский счёт с собственным исключением.";

        public string[] Requirements => new[]
        {
            "Класс BankAccount с приватным балансом.",
            "Методы Deposit(decimal), Withdraw(decimal).",
            "Свой класс InsufficientFundsException : Exception.",
            "Withdraw бросает исключение, если сумма больше баланса.",
            "Продемонстрировать: успешное снятие и попытку снять больше баланса (с try/catch).",
            "Готово, если: исключение бросается и ловится, баланс не уходит в минус.",
        };

        // Собственное исключение
        class InsufficientFundsException : Exception
        {
            public decimal Balance { get; }
            public decimal Amount { get; }

            public InsufficientFundsException(decimal balance, decimal amount)
                : base($"Недостаточно средств. Баланс: {balance:F2}, требуется: {amount:F2}")
            {
                Balance = balance;
                Amount = amount;
            }
        }
        // Банковский счёт
        class BankAccount
        {
            private decimal balance;

            public BankAccount(decimal initialBalance)
            {
                balance = initialBalance;
            }

            public decimal Balance => balance;

            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Сумма пополнения должна быть положительной");

                balance += amount;
                Console.WriteLine($"Пополнение: +{amount:F2}. Баланс: {balance:F2}");
            }

            public void Withdraw(decimal amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Сумма снятия должна быть положительной");

                if (amount > balance)
                    throw new InsufficientFundsException(balance, amount);

                balance -= amount;
                Console.WriteLine($"Снятие: -{amount:F2}. Баланс: {balance:F2}");
            }
        }

        public void Run()
        {
            var account = new BankAccount(1000m);
            Console.WriteLine($"Начальный баланс: {account.Balance:F2}\n");

            // Успешное пополнение
            account.Deposit(500);

            // Успешное снятие
            account.Withdraw(300);

            // Попытка снять больше, чем есть на балансе
            Console.WriteLine("\nПопытка снять 1500:");
            try
            {
                account.Withdraw(1500);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine($"Не хватает: {ex.Amount - ex.Balance:F2}");
            }

            Console.WriteLine($"\nИтоговый баланс: {account.Balance:F2}");
        }
    }
}
