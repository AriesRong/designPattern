using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class VeggiePizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking VeggiePizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing VeggiePizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting VeggiePizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing VeggiePizza...");
        }
    }
}
