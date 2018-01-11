using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class MemberOne : Observer
    {
        private Subject subject;
        public MemberOne(Subject subject)
        {
            this.subject = subject;
            subject.resignMember(this);
        }
        public void displayInEntainment()
        {
            Console.WriteLine("bossState is: back,MemberOne take a break.");
        }

        public void displayInWork()
        {
            Console.WriteLine("bossState is: gone,MemberOne continue to work.");
        }

        public void upadateState(string bossState)
        {
            if (bossState.Contains("back"))
                displayInWork();
            else
                displayInEntainment();
        }
    }
}
