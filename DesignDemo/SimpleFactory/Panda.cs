using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Panda:IAnimal
    {
        public void Declare()
        {
            Console.WriteLine("我是大熊猫{0}，piupiupiu！", this.GetType().Name);
        }
    }
}
