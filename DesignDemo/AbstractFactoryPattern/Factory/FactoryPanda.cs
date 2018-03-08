using FactoryMethodPattern;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FactoryPanda:IFactoryAbstract
    {

        public IFood CreateFoodInstance()
        {
            return new PandaFood();
        }

        public IAnimal CreateInstance()
        {
            return new Panda();
        }
    }
}
