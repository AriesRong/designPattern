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
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orederPizza("cheese");
            Console.WriteLine("Ehan ordered a " + pizza.Name + "\n");

            pizza = chicagoStore.orederPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.Name + "\n");

            Console.Read();
        }
    }
}
