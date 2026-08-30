using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal class Inventory<T> where T : class // Class => Allow Reference Types ONLY
    {
        public T Value { get; set; }
        public Inventory(T value)
        {
            Value = value;
        }
    }
}
