using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck num1 = new MallardDuck();
            num1.display();
            num1.performFly();
            num1.performQuack();
            num1.Swim();

            Duck num2 = new RedheadDuck();
            num2.display();
            num2.performFly();
            num2.performQuack();
            num2.Swim();

            Duck num3 = new DecoyDuck();
            num3.display();
            num3.performFly();
            num3.performQuack();
            num3.Swim();
            num3.setFlyBehavior(new FlyWithWings());
            num3.performFly();

            Console.Read();
        }
    }
}
