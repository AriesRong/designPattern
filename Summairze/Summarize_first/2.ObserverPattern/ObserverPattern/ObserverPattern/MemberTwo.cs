using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class MemberTwo:Observer
    {
        private Subject subject;
        public MemberTwo(Subject subject)
        {
            this.subject = subject;
            subject.resignMember(this);
        }
        public void displayInEntainment()
        {
            Console.WriteLine("bossState is: back,MemberTwo take a break.");
        }

        

        public void displayInWork()
        {
            Console.WriteLine("bossState is: gone,MemberTwo continue to work.");
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
