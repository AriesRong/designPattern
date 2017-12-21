using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{


    public static class publicMthod
    {
        private static double sizePrice;

        public static double getSizePrice(string size)
        {
            if (size == "tall")
            {
                sizePrice = 0.1;
            }
            else if (size == "grande")
            {
                sizePrice = 0.15;
            }
            else if(size==null)
            {
                sizePrice = 0;
            }
            else
            {
                sizePrice = 0.2;
            }
            return sizePrice;
        }
    }

}
