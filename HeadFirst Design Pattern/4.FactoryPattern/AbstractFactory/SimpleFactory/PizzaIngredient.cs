using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleFactory
{
    public class Dough { }

    public class Sauce { }

    public class Cheese { }

    public class Veggies { }

    public class Pepperoni { }

    public class Clams { }

    //NY
    public class ThinCrustDough : Dough
    {
        public ThinCrustDough()
        {
            Console.WriteLine(" ThinCrustDough ");
        }
    }
    public class MarinaraSauce : Sauce
    {
        public MarinaraSauce()
        {
            Console.WriteLine(" MarinaraSauce ");
        }
    }
    public class ReggianoCheese : Cheese
    {
        public ReggianoCheese()
        {
            Console.WriteLine(" ReggianoCheese ");
        }
    }
    public class Garlic : Veggies
    {
        public Garlic()
        {
            Console.WriteLine(" Garlic ");
        }
    }
    public class Onion : Veggies
    {
        public Onion()
        {
            Console.WriteLine(" Onion ");
        }
    }
    public class Mushroom : Veggies
    {
        public Mushroom()
        {
            Console.WriteLine(" Mushroom ");
        }
    }
    public class RedPepper : Veggies
    {
        public RedPepper()
        {
            Console.WriteLine(" RedPepper ");
        }
    }
    public class SlicedPepperoni : Pepperoni
    {
        public SlicedPepperoni()
        {
            Console.WriteLine(" SlicedPepperoni ");
        }
    }
    public class FreshClams : Clams
    {
        public FreshClams()
        {
            Console.WriteLine(" FreshClams ");
        }
    }


    //Chicago
    public class FrozenClams : Clams
    {
        public FrozenClams()
        {
            Console.WriteLine(" FrozenClams ");
        }
    }
    public class PlumTomatoSauce : Sauce
    {
        public PlumTomatoSauce()
        {
            Console.WriteLine(" PlumTomatoSauce ");
        }
    }
    public class Mozzarella : Cheese
    {
        public Mozzarella()
        {
            Console.WriteLine(" Mozzarellae ");
        }
    }
    public class EggPlant : Veggies
    {
        public EggPlant()
        {
            Console.WriteLine(" EggPlant ");
        }
    }
    public class BlackOlives : Veggies
    {
        public BlackOlives()
        {
            Console.WriteLine(" BlackOlives ");
        }
    }
    public class Spinach : Veggies
    {
        public Spinach()
        {
            Console.WriteLine(" Spinach ");
        }
    }

}
