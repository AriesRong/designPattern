using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateLearn
{
    class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Console.WriteLine("Cat is coming,{0} run", name);
        }
    }
}
