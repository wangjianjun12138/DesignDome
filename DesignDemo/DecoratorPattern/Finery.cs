using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Finery:Person
    {
        protected Person m_comonent;

        public void Decorate(Person comonent)
        {
            m_comonent = comonent;
        }

        public override void Show()
        {
            if (m_comonent != null)
            {
                m_comonent.Show();
            }
        }
    }

    class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }

    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }

    class Sneaker : Finery
    {
        public override void Show()
        {
            Console.WriteLine("运动鞋");
            base.Show();
        }
    }
}
