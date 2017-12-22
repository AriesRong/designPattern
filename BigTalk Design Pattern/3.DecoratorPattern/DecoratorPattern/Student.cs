using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Student : Person
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
        }
        public override void show()
        {
            Console.WriteLine("装扮的{0}:",name);
        }
    }
}
