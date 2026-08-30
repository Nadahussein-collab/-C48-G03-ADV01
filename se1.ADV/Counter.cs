using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal static class Counter<T>
    {
        public static int count = 0;
        public static void Increment() => count++;
        public static void Decrement() => count--;
    }
}
