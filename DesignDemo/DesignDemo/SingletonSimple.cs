using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDemo
{
    public class SingletonSimple
    {
        private static SingletonSimple m_singletonSimple = null;
        private static SingletonSimple m_singletonStatic = new SingletonSimple();
        static SingletonSimple()
        {
            m_singletonSimple = new SingletonSimple();
        }

        public static SingletonSimple CreateInstance()
        {
            return m_singletonSimple;
        }

        public static SingletonSimple GetInstance()
        {
            return m_singletonStatic;
        }

        public void Show()
        {
            Console.WriteLine("这里调用了{0}.Show", this.GetType().Name);
        }
    }
}
