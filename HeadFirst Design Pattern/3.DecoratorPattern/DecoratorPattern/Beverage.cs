using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        string description;
        private string size;
        public abstract double cost();
        public virtual string getDesciption()
        {
            return description = "Unknown Beverage.";
        }
        public virtual void setSize(string size)
        {
            this.size = size;
        }

        public virtual string getSize()
        {
            return size;
        }
        
    }
}
