using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mocha : CondimentDecorator
    {
        private Beverage beverage;
        private string size;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            if (beverage != null)
            {
                size = beverage.getSize();
                base.setSize(size);
            }
        }

        public override string getDescription()
        {
            return  beverage.getDescription()+".Mocha";
        }

        public override double cost()
        {
            return beverage.cost() + 0.15 + publicMthod.getSizePrice(size);
        }
    }
}
