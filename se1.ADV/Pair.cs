using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class Pair<TKey , Tvalue>
    {
        public TKey key { get; set; }
        public Tvalue value { get; set; }

        public Pair(TKey key, Tvalue value)
        {
            key = key;
            value = value;
        }
        public void PrintPair()
        {
            Console.WriteLine($"Key: {key}, Value: {value}");
        }
    }
}
