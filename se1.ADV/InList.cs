using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    internal class InList : MyList<int>
    {
        public void Sum()
        {
            int sum = 0; 
            foreach (int item in Values) 
            {
                sum += item;
            }
        }
    }
}
