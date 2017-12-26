using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class ClamPizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking ClamPizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing ClamPizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting ClamPizzaa...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing ClamPizza...");
        }
    }
}
