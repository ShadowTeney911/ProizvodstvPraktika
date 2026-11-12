using ProizvodstvPraktika.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Tasks.Level1
{
    internal class Task15_WorkFilesandGit : ITask
    {
        public string Title => "Git: репозиторий → ветка → merge → разрешение конфликта";

        public string Description => "пройти базовый git-сценарий";

        public string[] Requirements => new[]
        {
            "git init — создать локальный репозиторий.", 
            "Сделать 2–3 коммита с осмысленными сообщениями.", 
            "Создать ветку feature/git-basics, внести изменение, закоммитить.", 
            "Вернуться в main, влить ветку: git merge feature/git-basics.", 
            "Смоделировать конфликт: в двух ветках изменить одну и ту же строку README.md, сделать merge, вручную разрешить конфликт (убрать маркеры <<<<<<<).",
            "Сохранить вывод git log --graph --oneline --all в git-notes.md."

        };
        public void Run()
        {
            Console.WriteLine("Тут ничего не выполняется, просто инструкция к действиям");

        }

    }

}
