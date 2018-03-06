using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignDemo
{
    /// <summary>
    /// 1.私有化构造函数
    /// 2.返回静态对象
    /// </summary>
     public class Singleton
    {
         private static Singleton m_singleton = null;

         private Singleton()
         {
             Thread.Sleep(1000);
             String bigSize = "占用10M内存";
             String resoure = "占用多个线程和数据库链接资源";
             Console.WriteLine("{0}被构造，线程ID={1}",this.GetType().Name,Thread.CurrentThread.ManagedThreadId);
         }

         static Object lockObj = new Object();
         public static Singleton GetSingleton()
         {
             if (m_singleton == null)
             {
                 lock (lockObj)
                 {
                     if (m_singleton == null)
                     {
                         m_singleton = new Singleton();
                     }
                 }
             }
             return m_singleton;
         }

         public void Show()
         {
             Console.WriteLine("这里调用了{0}.Show",this.GetType().Name);
         }
    }
}
