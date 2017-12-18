using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattren
{
    class CashRebate : CashSuper
    {
        private double rebate;

        public CashRebate(double rebate)
        {
            this.rebate = rebate;
        }
        public override double accaptCash(double money)
        {
            return money * rebate;
        }
    }
}
