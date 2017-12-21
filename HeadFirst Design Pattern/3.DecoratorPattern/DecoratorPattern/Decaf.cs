using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Decaf:Beverage
    {
        public override string getDesciption()
        {
            return "Decaf";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
