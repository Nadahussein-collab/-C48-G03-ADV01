using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal class Printer<T> where T : IPrint, new()
    {
        public void PrintItem(T item)
        {
            item.Print();
        }
    }
}
