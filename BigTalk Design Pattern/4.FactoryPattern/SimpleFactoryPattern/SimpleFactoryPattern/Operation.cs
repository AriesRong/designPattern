using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    abstract class Operation
    {
        public abstract double getResult(double numA,double numB);
    }
}
