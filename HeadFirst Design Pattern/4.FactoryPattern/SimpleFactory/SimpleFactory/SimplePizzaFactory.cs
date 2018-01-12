using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new CheesePizza();
                case "veggie":
                    return new VeggiePizza();
                case "clam":
                    return new ClamPizza(); ;
                case "pepperoni":
                    return new PepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
