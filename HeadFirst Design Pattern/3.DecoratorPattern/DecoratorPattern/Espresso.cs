using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Espresso : Beverage
    {
        public override string getDesciption()
        {
            return "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
