using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore one = new PizzaStore();
            one.orederPizza("clam");
            one.orederPizza("veggie");
            one.orederPizza("pepperoni");
            one.orederPizza("cheese");
            Console.Read();
        }
    }
}
