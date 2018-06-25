using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class QuickMeal
    {
        private List<IItem> m_mealItems = new List<IItem>();

        public void AddItem(IItem item)
        {
            m_mealItems.Add(item);
        }

        public Double GetPrice()
        {
            Double price = 0;

            foreach (var item in m_mealItems)
            {
                price += item.Price();
            }

            return price;
        }

        public void ShowItems()
        {
            foreach (var item in m_mealItems)
            {
                Console.Write("Items:"+item.Name());
                Console.Write(" Packing:" + item.Packing());
                Console.Write(" price:" + item.Price());
                Console.WriteLine();
            }
        }
    }
}
