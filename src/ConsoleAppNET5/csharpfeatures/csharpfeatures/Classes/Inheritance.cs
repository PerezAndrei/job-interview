using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfeatures.Classes
{
    class Inheritance
    {
        public static void Test()
        {
            Employee employee = new()
            {
                Id = "Id1",
                FirstName = "FirstName1",
                LastName = "LastName1",
                Job = "Job1",
                CompanyName = "Company1"
            };
            employee.WriteToConsole();
        }
    }
}
