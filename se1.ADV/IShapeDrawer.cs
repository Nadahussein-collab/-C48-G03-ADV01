using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public interface IShapeDrawer<in T>
    {
        void Draw(T item); 
    }
}
