using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class NYStylePepperoniPizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking NYStylePepperoniPizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing NYStylePepperoniPizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting NYStylePepperoniPizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing NYStylePepperoniPizza...");
        }
    }
}
