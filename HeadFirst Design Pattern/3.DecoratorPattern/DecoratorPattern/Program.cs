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
            Beverage one = new DarkRoast();
            one.setSize("tall");
            one = new Mocha(one);
            one = new Mocha(one);
            Console.WriteLine(one.getDesciption().ToString() + ": ${0}", one.cost().ToString());

            Beverage two = new Espresso();
            two.setSize("grande");
            Console.WriteLine(two.getDesciption().ToString() + ": ${0}", two.cost().ToString());

            Beverage three = new HouseBlend();
            three.setSize("venti");
            three = new Soy(three);
            three = new Mocha(three);
            three = new Whip(three);
            Console.WriteLine(three.getDesciption() + ": ${0}", three.cost());

            Console.Read();
        }
    }
}
