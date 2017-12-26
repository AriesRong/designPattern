using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department department = new Department();

            IFactory factory = new AccessFactory();

            IUser iu = factory.createUser();
            user.Name = "nameA";
            iu.Insert(user);
            iu.getUser(5);

            IDepartment id = factory.createDepartment();
            department.Name = "nameB";
            id.Insert(department);
            id.getDepartment(7);

            Console.Read();
        }
    }
}
