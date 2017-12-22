using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class LeatherShoes : Finery
    {
        Person person;
        public LeatherShoes(Person person)
        {
            this.person = person;
        }
        public override void show()
        {
            person.show();
            Console.WriteLine(" LeatherShoes ");
        }
    }
}
