using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattren
{
    class CashNormal : CashSuper
    {
        public override double accaptCash(double money)
        {
            return money;
        }
    }
}
