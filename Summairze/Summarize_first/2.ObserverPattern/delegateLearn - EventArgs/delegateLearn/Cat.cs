using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateLearn
{
    class Cat
    {
        private string name;
        public Cat(string name)
        {
            this.name = name;
        }
        public delegate void CatShoutEventHandler(object sender,CatShoutEventArgs args);//委托
        public event CatShoutEventHandler catShout;

        public void Shout()
        {
            Console.WriteLine("miao,I'm {0}", name);
            if (catShout != null)
            {
                CatShoutEventArgs e = new CatShoutEventArgs();
                e.Name = this.name;
                catShout(this,e);
            }
        }
    }
}
