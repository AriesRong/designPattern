using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Subject
    {
        void resignNumber(Observer o);
        void removeNumber(Observer o);
        void notifyNumber();
        void setBossState(string bossState);
        void bossStateChanged();
    }
}
