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

        public void Run(object sender,CatShoutEventArgs args)
        {
            Console.WriteLine("Cat {0} is coming,{1} run", args.Name, name);
        }
    }
}
