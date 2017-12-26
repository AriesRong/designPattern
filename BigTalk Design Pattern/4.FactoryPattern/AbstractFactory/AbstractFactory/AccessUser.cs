using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessUser : IUser
    {
        public User getUser(int id)
        {
            Console.WriteLine("in Access, get the information of {0} from User", id);
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("in Access, insert {0} to the User", user.Name);
        }
    }
}
