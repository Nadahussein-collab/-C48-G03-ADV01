using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal interface IRepository<T>
    {
        void Add(T item);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
