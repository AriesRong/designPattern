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
        PizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();
        public override Pizza createPizza(string type)
        {
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "California Style Cheese Pizza";
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "California Style Veggie Pizza";
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "California Style Clam Pizza";
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "California Style Pepperoni Pizza";
            }
            return pizza;
        }
    }
}
