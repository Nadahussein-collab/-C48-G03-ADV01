using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal class MyList<T>
    {
        protected List<T> Values = new();

        public void Add(T item) => Values.Add(item);
    }
}
