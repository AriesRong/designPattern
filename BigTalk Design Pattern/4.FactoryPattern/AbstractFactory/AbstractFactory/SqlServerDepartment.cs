using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SqlServerDepartment : IDepartment
    {
        public Department getDepartment(int id)
        {
            Console.WriteLine("in sqlServer, get the information of {0} from Department", id);
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("in sqlServer, insert {0} to the Department", department.Name);
        }
    }
}
