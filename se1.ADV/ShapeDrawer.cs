using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class ShapeDrawer : IShapeDrawer<Shape>
    {
        public void Draw(Shape item)
        {
            Console.WriteLine($"Drawing shape: {item.Name}");
        }
    }
}
