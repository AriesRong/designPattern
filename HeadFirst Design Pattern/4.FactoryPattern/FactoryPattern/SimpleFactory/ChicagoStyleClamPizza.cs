using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class ChicagoStyleClamPizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking ChicagoStyleClamPizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing ChicagoStyleClamPizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting ChicagoStyleClamPizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing ChicagoStyleClamPizza...");
        }
    }
}
