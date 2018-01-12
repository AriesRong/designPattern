using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DarkRoast : Beverage
    {
        public override double cost()
        {
            return 0.99;
        }

        public override void setSize(string size)
        {
            base.setSize(size);
        }

        public override string getDescription()
        {
            return "DarkRoast";
        }
    }
}
