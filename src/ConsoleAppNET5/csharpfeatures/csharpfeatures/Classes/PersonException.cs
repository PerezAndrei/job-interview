using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpfeatures.Classes
{
    class PersonException: Exception
    {
        public PersonException() : base()
        {

        }

        public PersonException(string message): base(message)
        {

        }

        public PersonException(string message, Exception innerException) : base(message, innerException) { }
    }
}
