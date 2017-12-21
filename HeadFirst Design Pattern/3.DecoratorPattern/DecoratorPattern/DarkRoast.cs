using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DarkRoast : Beverage
    {
        public override void setSize(string size)
        {
            base.setSize(size);
        }

        public override string getDesciption()
        {
            return "DarkRoast";
        }
        public override double cost()
        {
            return 0.99;
        }
    }
}
