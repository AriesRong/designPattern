﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class UndergraduteFactory : IFactory
    {
        public LeiFeng createLeiFeng()
        {
            return new Undergradute();
        }
    }
}
