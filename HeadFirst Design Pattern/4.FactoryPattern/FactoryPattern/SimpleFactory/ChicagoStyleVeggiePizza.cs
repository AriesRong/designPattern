using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class ChicagoStyleVeggiePizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking ChicagoStyleVeggiePizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing ChicagoStyleVeggiePizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting ChicagoStyleVeggiePizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing ChicagoStyleVeggiePizza...");
        }
    }
}
