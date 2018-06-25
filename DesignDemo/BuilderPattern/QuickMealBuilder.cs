using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class QuickMealBuilder
    {
        public QuickMeal PrepareVegMeal()
        {
            QuickMeal meal = new QuickMeal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public QuickMeal PrepareChickenMeal()
        {
            QuickMeal meal = new QuickMeal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
