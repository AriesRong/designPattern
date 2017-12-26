using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduteFactory();
            LeiFeng student = factory.createLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();

            Console.Read();
        }
    }
}
