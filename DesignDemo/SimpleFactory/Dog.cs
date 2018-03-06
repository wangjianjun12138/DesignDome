using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Dog:IAnimal
    {
        public void Declare()
        {
            Console.WriteLine("我是狗{0}，汪汪汪！", this.GetType().Name);
        }
    }
}
