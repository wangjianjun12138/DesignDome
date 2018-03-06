using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Cow:IAnimal
    {
        public void Declare()
        {
            Console.WriteLine("我是奶牛{0}，哞哞哞！", this.GetType().Name);
        }
    }
}
