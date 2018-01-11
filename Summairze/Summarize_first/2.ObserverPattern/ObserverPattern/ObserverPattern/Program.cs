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
            Boss boss = new Boss();
            MemberOne one = new MemberOne(boss);
            MemberTwo two = new MemberTwo(boss);

            boss.Update += new EventHandler(one.displayInEntainment);
            boss.Update += new EventHandler(two.displayInWork);


            boss.getBossState("I'm gone");

            Console.Read();

        }
    }
}
