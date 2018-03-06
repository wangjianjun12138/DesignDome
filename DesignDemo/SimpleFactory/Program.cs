using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        /// <summary>
        /// 上端屏蔽细节
        /// 可扩展
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                //IAnimal animal = AnimalFactory.CreateInstance(AnimalFactory.AnimalType.cat);
                //animal.Declare();
                //animal = AnimalFactory.CreateInstance(AnimalFactory.AnimalType.dog);
                //animal.Declare();
                //animal = AnimalFactory.CreateInstance(AnimalFactory.AnimalType.panda);
                //animal.Declare();

                IAnimal animal = AnimalFactory.CreateInstanceByReflect();

                animal.Declare();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally 
            {
                Console.ReadLine();
            }
        }
    }
}
