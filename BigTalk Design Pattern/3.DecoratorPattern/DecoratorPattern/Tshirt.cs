using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Tshirt : Finery
    {
        Person person;
        
        public Tshirt(Person person)
        {
            this.person = person;
        }

        public override void show()
        {
            person.show();
            Console.Write(" Tshirts ");
        }
    }
}
