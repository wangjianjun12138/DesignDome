using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Human:IAnimal
    {
        private String m_name;
        private Int32 m_age;
        private String[] m_remarks;

        public Human(String name,Int32 age,params String[] remarks)
        {
            m_name = name;
            m_age = age;
            m_remarks = remarks;
        }



        public void Declare()
        {
            Console.WriteLine("嗨，大家好，我是{0}，今年{1}岁了。",m_name,m_age);
            for (int i = 0; i < m_remarks.Length; i++)
            {
                Console.WriteLine(m_remarks[i]);
            }
        }
    }
}
