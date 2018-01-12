﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{


    public static class publicMthod
    {
        public static double getSizePrice(string size)
        {
            switch (size)
            {
                case "tall":
                    return 0.1;
                case "grande":
                    return 0.15;
                default:
                    return 0.2;
            }
        }
    }

}
