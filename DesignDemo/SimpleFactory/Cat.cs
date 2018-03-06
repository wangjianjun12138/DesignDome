using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Cat : IAnimal
    {
        public void Declare()
        {
            Console.WriteLine("我是猫{0}，喵喵喵！",this.GetType().Name);
        }
    }
}
