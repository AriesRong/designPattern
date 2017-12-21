using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        private string size;
        public Whip(Beverage beverage)
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
            return beverage.getDesciption() + ".Whip";
        }
        
        public override double cost()
        { 
            return beverage.cost() + 0.1+publicMthod.getSizePrice(size);
        }
    }
}
