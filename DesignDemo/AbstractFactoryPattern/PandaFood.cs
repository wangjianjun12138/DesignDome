using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PandaFood:IFood
    {

       public void ShowFood()
        {
            Console.WriteLine("{0}：竹子，水果", this.GetType().Name);
        }
    }
}
