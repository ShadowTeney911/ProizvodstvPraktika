using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodstvPraktika.Common
{
    internal interface ITask
    {
        /* 
         * Строчные значкния
         * Название, Описание, Требования
         * ВОзврат этих значений
        */ 
        string Title { get; }
        string Description { get; }
        string[] Requirements { get; }
        void Run();
    }
}
