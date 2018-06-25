using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Burger:IItem
    {
        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract Double Price();

        public abstract string Name();
    }

    public abstract class ColdDrink : IItem
    {
        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract Double Price();

        public abstract string Name();
        
    }
}
