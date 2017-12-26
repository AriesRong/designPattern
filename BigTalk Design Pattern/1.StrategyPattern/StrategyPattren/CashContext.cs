using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattren
{
    class CashContext
    {
        CashSuper cs = null;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300减50":
                    cs = new CashReturn(300, 50);
                    break;
                case "满400减70":
                    cs = new CashReturn(400, 70);
                    break;
                case "满500减100":
                    cs = new CashReturn(500, 100);
                    break;
                case "满900减200":
                    cs = new CashReturn(900, 200);
                    break;
                case "九折优惠":
                    cs = new CashRebate(0.9);
                    break;
                case "八折优惠":
                    cs = new CashRebate(0.8);
                    break;
                case "七折优惠":
                    cs = new CashRebate(0.7);
                    break;
            }
        }

        public double getTotalPrice(double money)
        {
            return cs.accaptCash(money);
        }
    }
}
