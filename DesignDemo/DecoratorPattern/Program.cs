using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("hanchen");
            Console.WriteLine("第一种装扮");
            Sneaker sneaker = new Sneaker();
            BigTrouser bigTrouser = new BigTrouser();
            TShirts tShirts = new TShirts();

            sneaker.Decorate(person);
            bigTrouser.Decorate(sneaker);
            tShirts.Decorate(bigTrouser);
            tShirts.Show();

            Console.ReadLine() ;
        }
    }
}
