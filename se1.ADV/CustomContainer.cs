using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class CustomContainer<T>
    {
        private T _data;
        public void Reset()
        {
            _data = default(T); 
        }

        public T GetDefaultIfNull(T input)
        {
            if (input == null)
            {
                return default(T);
            }
            return input;
        }
    }
}
