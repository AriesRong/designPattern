using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class NYStyleVeggiePizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking NYStyleVeggiePizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing NYStyleVeggiePizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting NYStyleVeggiePizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing NYStyleVeggiePizza...");
        }
    }
}
