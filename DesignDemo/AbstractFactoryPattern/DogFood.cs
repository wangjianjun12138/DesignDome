using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class DogFood : IFood
    {

        public void ShowFood()
        {
            Console.WriteLine("{0}：骨头，谷物", this.GetType().Name);
        }
    }
}
