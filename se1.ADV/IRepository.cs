using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Remove(T entity);
    }
}
