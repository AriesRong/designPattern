using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class CheesePizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking CheesePizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing CheesePizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting CheesePizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing CheesePizza...");
        }
    }
}
