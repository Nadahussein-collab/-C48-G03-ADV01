using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class Order : BaseEntity, IAuditable
    {
        public void Audit()
        {
            Console.WriteLine("Order audited");
        }
        public Order()
        {

        }
    }
}
