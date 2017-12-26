using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class CaliforniaCheesePizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        public override void box()
        {
            Console.WriteLine("Place the pizza in official PizzaStore box.");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
        }

        public override void prepare()
        {
            Name = "California Cheese Pizza";
            Dough = "=========";
            Sauce = "=========";

            Toppings.Add("==========");
            base.prepare();
        }
    }
}
