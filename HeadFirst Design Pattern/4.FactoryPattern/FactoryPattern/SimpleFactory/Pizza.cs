using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Pizza
    {
        //string name;//名称
        //string dough;
        //string sauce;
        ArrayList toppings = new ArrayList();

        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public ArrayList Toppings
        {
            get { return toppings; }
            set { this.toppings = value; }
        }

        public virtual void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing douugh...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            for (int i = 0; i < Toppings.Count; i++)
            {
                Console.WriteLine("  " + Toppings[i]);
            }
        }
        //public abstract void prepare();
        public abstract void bake();
        public abstract void cut();
        public abstract void box();
    }
}
