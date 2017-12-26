using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class SimpleFactory
    {
        Operation operation;
        public Operation createOperation(string algorithm)
        {
            if (algorithm == "+")
            {
                operation = new OperationAdd();
            }
            else if (algorithm == "-")
            {
                operation = new OperationSub();
            }
            else if (algorithm=="*")
            {
                operation = new OperationMul();
            }
            else if(algorithm=="/")
            {
                operation = new OperationDiv();
            }
            else
            {
                operation = null;
            }
            return operation;
        }
    }
}
