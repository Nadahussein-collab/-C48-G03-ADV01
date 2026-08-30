using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class CircleFactory : IShapeFactory<Circle>
    {
        public Circle Create() => new Circle { Name = "Circle", Radius = 10.0 };
    }
}
