using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class NYPizzaStore : PizzaStore
    {
        Pizza pizza;
        public override Pizza createPizza(string type)
        {
            if (type.Contains("cheese"))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NYStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new NYStylePepperoniPizza();
            }
            return pizza;
        }
    }
}
