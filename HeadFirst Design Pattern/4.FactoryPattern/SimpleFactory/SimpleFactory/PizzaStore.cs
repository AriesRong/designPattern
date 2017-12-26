using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class PizzaStore
    {
        SimplePizzaFactory factory = new SimplePizzaFactory();
        Pizza pizza;

        public Pizza orederPizza(string type)
        {
            pizza = factory.createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
