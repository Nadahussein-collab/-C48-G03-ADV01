using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal class Document : IPrint
    {
        public int X { get; set; }
        public Document(int x)
        {
            X = x;
        }
        public Document()
        {

        }
        public void Print()
        {
            Console.WriteLine("Print Document");
        }
    }
}
