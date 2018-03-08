using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 对扩展开放 对修改封闭
    /// 创建型设计模式关心对象创建
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IFactory factory = new CatFactory();
                IAnimal animal = factory.CreateInstance();
                animal.Declare();

                factory = new HumanFactory();
                animal = factory.CreateInstance();
                animal.Declare();
                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
