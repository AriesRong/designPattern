using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class Beverage
    {
        string description;
        string size;

        public virtual string getDescription()
        {
            return description = "Unknown description";
        }

        public abstract double cost();

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
