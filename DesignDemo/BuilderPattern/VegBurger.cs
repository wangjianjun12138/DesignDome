using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class VegBurger:Burger
    {
        public override  Double Price() {
            return 25.0;
        }

        public override String Name()
        {
            return "Veg Burger";
        }
    }

    public class ChickenBurger : Burger
    {
        public override Double Price()
        {
            return 45.0;
        }

        public override String Name()
        {
            return "Chicken Burger";
        }
    }


    public class Coke : ColdDrink
    {
        public override Double Price()
        {
            return 12.0;
        }

        public override String Name()
        {
            return "Coke";
        }
    }
    public class Pepsi : ColdDrink
    {
        public override Double Price()
        {
            return 14.0;
        }

        public override String Name()
        {
            return "Pepsi";
        }
    }
}
