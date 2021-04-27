using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfeatures.Classes
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void WriteToConsole() {
            Console.WriteLine($"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}");
        }

        ~Person()
        {

        }
    }
}
