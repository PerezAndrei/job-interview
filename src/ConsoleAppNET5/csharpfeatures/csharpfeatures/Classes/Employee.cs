using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfeatures.Classes
{
    class Employee: Person
    {
        public string Job { get; set; }
        public string CompanyName { get; set; }
        public override void WriteToConsole() {
            base.WriteToConsole();
            Console.WriteLine($"Job: {Job}, CompanyName: {CompanyName}");
        }
    }
}
