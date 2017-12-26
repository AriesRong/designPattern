using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class NYStyleClamPizza:Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Baking NYStyleClamPizza...");
        }

        public override void box()
        {
            Console.WriteLine("Boxing NYStyleClamPizza...");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting NYStyleClamPizza...");
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing NYStyleClamPizza...");
        }
    }
}
