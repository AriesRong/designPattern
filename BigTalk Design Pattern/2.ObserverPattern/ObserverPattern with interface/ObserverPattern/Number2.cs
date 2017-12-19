using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Number2 : Observer
    {
        private Subject subject;
        private string bossState;
        public Number2(Subject subject)
        {
            this.subject = subject;
            subject.resignNumber(this);
        }
        public void displayInEntertainment()
        {
            Console.WriteLine("bossState is: " + bossState.ToString() + ",Number2 take a break.");
        }

        public void displayInWork()
        {
            Console.WriteLine("bossState is: " + bossState.ToString() + ",Number2 continue to work.");
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
