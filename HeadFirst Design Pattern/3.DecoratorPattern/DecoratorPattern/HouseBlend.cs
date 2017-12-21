using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class HouseBlend:Beverage
    {
        public override string getDesciption()
        {
            return "HouseBlend";
        }
        public override double cost()
        {
            return 1.05;
        }
    }
}
