using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessFactory : IFactory
    {
        public IDepartment createDepartment()
        {
            return new AccessDepartment();
        }

        public IUser createUser()
        {
            return new AccessUser();
        }
    }
}
