using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public Veggies[] Veggies { get; set; }
        
        
        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        public void box()
        {
            Console.WriteLine("Place the pizza in official PizzaStore box.");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
        }
    }
}
