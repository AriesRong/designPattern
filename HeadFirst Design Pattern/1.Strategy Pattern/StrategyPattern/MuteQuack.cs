﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("I can't quack.");
        }
    }
}