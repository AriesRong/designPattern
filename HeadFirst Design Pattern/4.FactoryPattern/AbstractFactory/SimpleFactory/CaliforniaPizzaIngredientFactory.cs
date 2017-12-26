using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class CaliforniaPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            Console.WriteLine("Cheese:");
            return new ReggianoCheese();
        }

        public Clams createClam()
        {
            Console.WriteLine("Clam:");
            return new FreshClams();
        }

        public Dough createDough()
        {
            Console.WriteLine("Dough:");
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            Console.WriteLine("Pepperoni:");
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            Console.WriteLine("Sauce:");
            return new MarinaraSauce();
        }

        public Veggies[] createVeggies()
        {
            Console.WriteLine("Veggies:");
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
