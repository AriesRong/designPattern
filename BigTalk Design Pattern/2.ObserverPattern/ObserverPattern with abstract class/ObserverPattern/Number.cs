using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Number : Observer
    {
        private string bossState="";
        private Subject subject;
        private string name;
        public Number(string name,Subject subject) : base(name)
        {
            this.name = name;
            this.subject = subject;
            subject.resignNumber(this);
        }

        public override void displayInEntertainment()
        {
            Console.WriteLine(" {0} receive the message and take a break.",name);
        }

        public override void displayInWork()
        {
            Console.WriteLine(" {0} receive the message and continue to work.", name);
        }

        public override void update(string bossState)
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
