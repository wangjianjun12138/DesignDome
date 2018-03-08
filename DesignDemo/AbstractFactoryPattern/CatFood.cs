using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CatFood:IFood
    {

        public void ShowFood()
        {
            Console.WriteLine("{0}：老鼠，小鱼干",this.GetType().Name);
        }
    }
}
