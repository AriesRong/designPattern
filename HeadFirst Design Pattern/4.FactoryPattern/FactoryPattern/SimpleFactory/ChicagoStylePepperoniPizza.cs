using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class ChicagoStylePepperoniPizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking ChicagoStylePepperoniPizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing ChicagoStylePepperoniPizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting ChicagoStylePepperoniPizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing ChicagoStylePepperoniPizza...");
        }
    }
}
