using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class HumanFactory : IFactory
    {
        public IAnimal CreateInstance()
        {
            IAnimal animal = new Human("王建君",24,"我很开心","你呢？") ;
            return animal;
        }
    }
}
