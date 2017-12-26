using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            Console.WriteLine("Cheese:");
            return new Mozzarella();
        }

        public Clams createClam()
        {
            Console.WriteLine("Clam:");
            return new FrozenClams();
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
            return new PlumTomatoSauce();
        }

        public Veggies[] createVeggies()
        {
            Console.WriteLine("Veggies:");
            Veggies[] veggies = { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }
    }
}
