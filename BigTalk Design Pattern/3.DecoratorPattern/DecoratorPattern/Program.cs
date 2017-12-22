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
            Person one = new Student("A");
            one = new Tshirt(one);
            one = new BigTrouser(one);
            one = new LeatherShoes(one);
            one.show();

            Console.Read();
        }
    }
}
