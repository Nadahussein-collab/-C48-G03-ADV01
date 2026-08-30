using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace se1.ADV
{
    public class PetHandler<T> where T : Animal
    {
        public void Handle(T pet)
        {
            pet.MakeSound();
        }
    }
}
