using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level3
{
    internal class Task44_ToDo : ITask
    {

        public string Title => "Мини-проект «Todo List» (классы + JSON)";

        public string Description => "консольное приложение для списка задач с сохранением в JSON.";

        public string[] Requirements => new[]
        {
            "Классы: TaskItem (Id, Title, IsDone), TaskRepository (CRUD), TaskService (бизнес-логика).",
"CRUD-операции: добавить, вывести все, отметить выполненной, удалить.",
"Сохранение/загрузка через System.Text.Json (файл tasks.json).",
"Меню с выбором действий.",
"Обработка ошибок (некорректный ввод, отсутствующий файл).",

        };



        public void Run()
        {
            
         
        }
    }
}
