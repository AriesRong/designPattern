using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class PepperoniPizza:Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = ingredientFactory.createDough();
            Sauce = ingredientFactory.createSauce();
            Cheese = ingredientFactory.createCheese();
            Veggies = ingredientFactory.createVeggies();
        }
    }
}
