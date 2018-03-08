using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class DogFactory : IFactory
    {
        public IAnimal CreateInstance()
        {
            IAnimal animal = new Dog();
            return animal;
        }
    }
}
