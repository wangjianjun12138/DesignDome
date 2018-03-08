using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern;

namespace AbstractFactoryPattern
{
   /// <summary>
   /// 抽象工厂
   /// 倾斜的可扩展性设计
   /// 
   /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IFactoryAbstract factory=null;
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
                {
                    factory = new FactoryCat();
                    factory.CreateInstance().Declare();
                    factory.CreateFoodInstance().ShowFood();
                }

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
                {
                    factory = new FactoryDog();
                    factory.CreateInstance().Declare();
                    factory.CreateFoodInstance().ShowFood();
                }

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
                {
                    factory = new FactoryPanda();
                    factory.CreateInstance().Declare();
                    factory.CreateFoodInstance().ShowFood();
                }
                

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
