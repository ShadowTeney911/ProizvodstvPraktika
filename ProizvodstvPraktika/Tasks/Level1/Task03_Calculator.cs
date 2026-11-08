using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task03_Calculator : ITask
    {
        /* 
        * Название
        * Описание
        * Требования (Массивом, кажется так будет проще
        * Запуск
        */

        public string Title => "--==  Калькулятор с обработкой деления на ноль ==--";

        public string Description => "принимает два числа и оператор (+ - * /), выводит результат";

        public string[] Requirements => new[]
        {
            " - Оператор обрабатывать через switch ",
            " - При делении на ноль — вывести сообщение об ошибке, не ронять приложение.",
            " - Некорректный оператор — вывести «Неизвестная операция».",
            " - Ввод чисел — через double.Parse или TryParse."
        };

        public void Run()
        {

            Console.WriteLine("Введите первое число - "); double FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число - "); double SecondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию -> + - * /"); char Operation = Convert.ToChar(Console.ReadLine());
            double Resultat = 0; Console.WriteLine("Результат операции");
            switch (Operation)
            {
                default:
                    Console.WriteLine("Неизвестный оператор");
                    break;
                case '+':
                    Resultat = FirstNumber + SecondNumber;
                    Console.WriteLine(Resultat);
                    break;
                case '-':
                    Resultat = FirstNumber - SecondNumber;
                    Console.WriteLine(Resultat);
                    break;
                case '*':
                    Resultat = FirstNumber * SecondNumber;
                    Console.WriteLine(Resultat);
                    break;
                case '/':
                    { switch (SecondNumber)
                        {
                            case '0':
                                Console.WriteLine("Делить на ноль нельзя. Операция прервана");
                                break;
                            default : 
                                Resultat = FirstNumber / SecondNumber;
                                Console.WriteLine(Resultat);
                                break;
                        }
                        
                    }
                    break;
            }
        }
        
    }
}