using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Soy : CondimentDecorator
    {
        private Beverage beverage;
        private string size;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            if (beverage != null)
            {
                size = beverage.getSize();
                base.setSize(size);
            }
        }

        public override string getDesciption()
        {
            return beverage.getDesciption() + ".Soy";
        }
        public override double cost()
        {
            return beverage.cost() + 0.15 + publicMthod.getSizePrice(size);
        }
    }
}
