using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class PepperoniPizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking PepperoniPizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing PepperoniPizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting PepperoniPizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing PepperoniPizza...");
        }
    }
}
