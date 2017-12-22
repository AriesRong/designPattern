using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Suit : Finery
    {
        Person person;
        public Suit(Person person)
        {
            this.person = person;
        }
        public override void show()
        {
            person.show();
            Console.Write(" Suit ");
        }
    }
}
