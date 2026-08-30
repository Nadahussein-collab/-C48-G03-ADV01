using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class SafeList<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _items.Count)
                {
                    return default;
                }
                return _items[index];
            }
        }

        public int Count => _items.Count;
    }
}
