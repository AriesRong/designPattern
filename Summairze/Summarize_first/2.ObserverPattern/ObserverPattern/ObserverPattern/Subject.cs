using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    interface Subject
    {
        void resignMember(Observer o);
        void removerMember(Observer o);
        void notifyMember();
        void getBossState(string bossState);
    }
}
