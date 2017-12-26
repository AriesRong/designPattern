using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattren
{
    class CashReturn : CashSuper
    {
        private double monCondition;
        private double monReturn;

        public CashReturn(double monCondition,double monReturn)
        {
            this.monCondition = monCondition;
            this.monReturn = monReturn;
        }

        public override double accaptCash(double money)
        {
            if (money >= monCondition)
            {
                money = money - monReturn;
            }
            return money;
        }
    }
}
