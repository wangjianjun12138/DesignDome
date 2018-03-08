using FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IFactoryAbstract:IFactory
    {
        IFood CreateFoodInstance();
    }
}
