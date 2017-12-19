using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Boss : Subject
    {
        private ArrayList observers;
        private string bossState;
        public Boss()
        {
            observers = new ArrayList();
        }
        public void notifyNumber()
        {
           foreach(Observer o in observers)
            {
                o.update(bossState);
            }
        }

        public void removeNumber(Observer o)
        {
            if (observers.Count >= 0)
            {
                observers.Remove(o);
            }
        }

        public void resignNumber(Observer o)
        {
            observers.Add(o);
        }

        public void bossStateChanged()
        {
            notifyNumber();
        }
        public void setBossState(string bossState)
        {
            this.bossState = bossState;
            Console.WriteLine("bossState is: " + bossState.ToString());
            bossStateChanged();
        }
    }
}
