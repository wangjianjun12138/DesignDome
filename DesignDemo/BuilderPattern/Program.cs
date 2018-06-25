using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 建造者模式
    /// 创建型模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            QuickMealBuilder mealBuilder = new QuickMealBuilder();

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            QuickMeal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Price:"+vegMeal.GetPrice());

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-");
            QuickMeal chickenMeal = mealBuilder.PrepareChickenMeal();
            Console.WriteLine("Chicken Meal");
            chickenMeal.ShowItems();
            Console.WriteLine("Total Price:" + chickenMeal.GetPrice());
            
            Console.ReadLine();
   
        }
    }
}
