using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject boss = new Boss();

            Number1 one = new Number1(boss);
            Number2 two = new Number2(boss);

            boss.setState("I'm back!");
            boss.removeNumber(one);
            boss.removeNumber(two);

            Subject lady = new Secretary();
            lady.resignNumber(one);
            lady.resignNumber(two);
            lady.setState("Boss has gone!");

            boss.setState("I'm back again!");

            Console.Read();
        }
    }
}
