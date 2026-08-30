using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class ValueWrapper<T> where T : struct
    {
        public T Data { get; set; }

        public ValueWrapper(T initialData)
        {
            Data = initialData;
        }

        public void PrintData()
        {
            Console.WriteLine($"Stored Value: {Data}");
        }
    }
}