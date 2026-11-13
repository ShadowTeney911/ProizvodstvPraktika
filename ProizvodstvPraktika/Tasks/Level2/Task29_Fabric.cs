using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level2
{
    internal class Task29_Fabric : ITask
    {
        public string Title => "Паттерн «Фабрика» (уведомления)";

        public string Description => "реализовать фабрику уведомлений.";

        public string[] Requirements => new[]
        {
            "Интерфейс INotification с методом Send(string message).",
            "Реализации: EmailNotification, SmsNotification, PushNotification.",
            "NotificationFactory.Create(NotificationType type) — возвращает нужную реализацию.",
            "enum NotificationType { Email, Sms, Push }.",
            "Продемонстрировать создание и отправку через фабрику.",
        };

        // 1. Перечисление типов уведомлений
        enum NotificationType
        {
            Email,
            Sms,
            Push
        }

        // 2. Интерфейс уведомления
        interface INotification
        {
            void Send(string message);
        }

        // 3. Реализации
        class EmailNotification : INotification
        {
            public void Send(string message) => Console.WriteLine($"[Email] Отправлено: {message}");
        }

        class SmsNotification : INotification
        {
            public void Send(string message) => Console.WriteLine($"[SMS] Отправлено: {message}");
        }

        class PushNotification : INotification
        {
            public void Send(string message) => Console.WriteLine($"[Push] Отправлено: {message}");
        }

        // 4. Фабрика
        class NotificationFactory
        {
            public static INotification Create(NotificationType type)
            {
                switch (type)
                {
                    case NotificationType.Email: return new EmailNotification();
                    case NotificationType.Sms: return new SmsNotification();
                    case NotificationType.Push: return new PushNotification();
                    default: throw new ArgumentException("Неизвестный тип уведомления");
                }
            }
        }
        public void Run()
        {
            string message = "Ваш код подтверждения: 1234";

            // Создаем и отправляем через фабрику
            INotification email = NotificationFactory.Create(NotificationType.Email);
            email.Send(message);

            INotification sms = NotificationFactory.Create(NotificationType.Sms);
            sms.Send(message);

            INotification push = NotificationFactory.Create(NotificationType.Push);
            push.Send(message);
        }
    }
}
