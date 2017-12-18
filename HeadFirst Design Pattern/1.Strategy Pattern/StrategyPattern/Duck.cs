using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public void Swim()
        {
            Console.WriteLine("All duck can swim.");
        }

        public abstract void display();

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void setFlyBehavior(FlyBehavior fb)
        {
            this.flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            this.quackBehavior = qb;
        }
    }
}
