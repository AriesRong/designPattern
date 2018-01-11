using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Seretary : Subject
    {
        List<Observer> observers = new List<Observer>();
        string bossState;
        public void getBossState(string bossState)
        {
            this.bossState = bossState;
            notifyMember();
        }

        public void notifyMember()
        {
            foreach (Observer o in observers)
                o.upadateState(bossState);
        }

        public void removerMember(Observer o)
        {
            observers.Remove(o);
        }

        public void resignMember(Observer o)
        {
            observers.Add(o);
        }
    }
}
