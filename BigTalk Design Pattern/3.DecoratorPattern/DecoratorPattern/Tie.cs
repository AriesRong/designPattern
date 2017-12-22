using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Tie : Finery
    {
        Person person;
        public Tie(Person person)
        {
            this.person = person;
        }
        public override void show()
        {
            person.show();
            Console.Write(" Tie ");
        }
    }
}
