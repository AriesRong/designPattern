using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Number1 : Observer
    {
        private string bossState;
        private Subject subject;
        public Number1(Subject subject)
        {
            this.subject = subject;
            subject.resignNumber(this);
        }

        public void displayInEntertainment()
        {
            Console.WriteLine("bossState is: "+bossState.ToString()+ ",Number1 take a break.");
        }

        public void displayInWork()
        {
            Console.WriteLine("bossState is: " + bossState.ToString() + ",Number1 continue to work.");
        }

        public void update(string bossState)
        {
            this.bossState = bossState;
            if (bossState.Contains("back"))
            {
                displayInWork();
            }
            else
            {
                displayInEntertainment();
            }
        }
    }
}
