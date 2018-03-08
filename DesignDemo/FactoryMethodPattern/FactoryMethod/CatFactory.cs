using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class CatFactory : IFactory
    {
        public IAnimal CreateInstance()
        {
            IAnimal animal = new Cat();
            return animal;
        }
    }
}
