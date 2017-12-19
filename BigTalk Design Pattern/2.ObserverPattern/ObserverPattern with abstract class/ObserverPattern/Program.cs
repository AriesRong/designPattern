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

            Number one = new Number("A",boss);
            Number two = new Number("B",boss);
            boss.setBossState("I'm back");
            boss.removeNumber(one);
            boss.removeNumber(two);

            Secretary lady = new Secretary();
            lady.resignNumber(one);
            lady.resignNumber(two);
            lady.setBossState("Boss is gone!");

            boss.setBossState("I'm back again!");

            Console.Read();
        }
    }
}
