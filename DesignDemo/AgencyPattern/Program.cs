using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------代理模式---------");
            {
                Image image = new ProxyImage("testImage.jpg");
                image.Display();
                Console.WriteLine();
                image.Display();
            }
            Console.ReadLine();
        }
    }
}
