﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class OperationMul : Operation
    {
        public override double getResult(double numA, double numB)
        {
            return numA * numB;
        }
    }
}
