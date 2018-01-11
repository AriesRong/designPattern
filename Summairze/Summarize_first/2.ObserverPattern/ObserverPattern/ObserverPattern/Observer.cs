using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface Observer
    {
        void upadateState(string bossState);
        void displayInEntainment();
        void displayInWork();
    }
}
