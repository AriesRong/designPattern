using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Secretary : Subject
    {
        //private ArrayList observers;
        private List<Observer> observers = new List<Observer>();
        private string bossState;
        
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

        public void setState(string bossState)
        {
            this.bossState = bossState;
            notifyNumber();
        }
    }
}
