using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDemo
{
    /// <summary>
    /// 设计模式分三大类
    /// 1.创建型
    /// 2.结构型
    /// 3.行为模式型
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 保证进程中只有一个实例化对象
        /// 常驻内存 不被GC回收
        /// </summary>
        
        static void Main(string[] args)
        {
            try
            {
                List<IAsyncResult> resultList = new List<IAsyncResult>();
                for (int i = 0; i < 20; i++)
                {

                    resultList.Add(new Action(() =>
                    {
                        SingletonSimple singleton = SingletonSimple.GetInstance();
                        singleton.Show();
                    }).BeginInvoke(null, null));
                }

                while (resultList.Count(x => !x.IsCompleted) > 0)
                { 
                    
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
