using FactoryMethodPattern;
using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class FactoryDog:IFactoryAbstract
    {

        public IFood CreateFoodInstance()
        {
            return new DogFood();
        }

        public IAnimal CreateInstance()
        {
            return new Dog();
        }
    }
}
