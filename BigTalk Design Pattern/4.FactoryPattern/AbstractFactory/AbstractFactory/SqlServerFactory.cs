using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlServerFactory : IFactory
    {
        public IDepartment createDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser createUser()
        {
            return new SqlServerUser();
        }
    }
}
