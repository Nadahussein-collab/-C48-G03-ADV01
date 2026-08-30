using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class Repository<T> where T : BaseEntity,IAuditable,new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
