using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class PandaFactory : IFactory
    {
        public IAnimal CreateInstance()
        {
            IAnimal animal = new Panda();
            return animal;
        }
    }
}
