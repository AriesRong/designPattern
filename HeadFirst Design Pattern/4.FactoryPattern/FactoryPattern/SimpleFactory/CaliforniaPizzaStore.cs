using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class CaliforniaPizzaStore : PizzaStore
    {
        Pizza pizza;
        public override Pizza createPizza(string type)
        {
            if (type.Equals("cheese"))
            {
                pizza = new CaliforniaCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new CaliforniaVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new CaliforniaClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new CaliforniaPepperoniPizza();
            }
            return pizza;
        }
    }
}
