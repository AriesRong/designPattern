using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AccessDepartment : IDepartment
    {
        public Department getDepartment(int id)
        {
            Console.WriteLine("in Access, get the information of {0} from Department", id);
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("in Access, insert {0} to the Department", department.Name);
        }
    }
}
