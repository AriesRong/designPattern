using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }
        public override void display()
        {
            Console.WriteLine("===DecoyDuck===");
        }
    }
}
