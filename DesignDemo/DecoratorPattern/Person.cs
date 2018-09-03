using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Person
    {
        private String m_name;

        public Person()
        { 
        
        }
        public Person(String name)
        {
            m_name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",m_name);
        }
    }
}
