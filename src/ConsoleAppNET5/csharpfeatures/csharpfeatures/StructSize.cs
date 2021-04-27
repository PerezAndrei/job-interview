using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace csharpfeatures
{
    class StructSize
    {
        public static void Test() {
            Console.WriteLine(Marshal.SizeOf<Address>());
        }
    }

    public struct Address
    {
        int streetNummber { get; set; }
        int flatNumber { get; set; }
        int houseNumber { get; set; }
    }
}
