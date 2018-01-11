using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Tom");
            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");

            cat.catShout += new Cat.CatShoutEventHandler(mouse1.Run); //实例化一个委托
            cat.catShout += new Cat.CatShoutEventHandler(mouse2.Run);

            cat.Shout();
            Console.Read();
        }
    }
}
