using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Observer
    {
        string name;
        public Observer(string name)
        {
            this.name = name;
        }
        public abstract void update(string bossState);
        public abstract void displayInWork();

        public abstract void displayInEntertainment();
    }
}
