using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlServerUser : IUser
    {
        public User getUser(int id)
        {
            Console.WriteLine("in sqlServer, get the information of {0} from User", id);
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("in sqlServer, insert {0} to the User", user.Name);
        }
    }
}
