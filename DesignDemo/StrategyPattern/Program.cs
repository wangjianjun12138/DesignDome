using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 策略模式工程
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FormCashAccpet formCashAccpet = new FormCashAccpet();
            formCashAccpet.ShowDialog();
        }
    }
}
