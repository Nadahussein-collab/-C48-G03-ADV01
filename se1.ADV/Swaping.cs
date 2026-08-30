using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal class Swaping
    {
        public static void swap<T>(ref T a,ref T b)
        {
            T Temp = a;
            a = b;
            b = Temp;
        }
        public static void Test()
        {

        }
    }
}
