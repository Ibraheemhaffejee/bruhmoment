using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectAccess
{
     class PrtctTest : ProtectAcc
    {
        static void Main(string[] args)
        {
            PrtctTest p = new PrtctTest();

            Console.WriteLine("Enter your Birth year: ");
            p.bYear = int.Parse(Console.ReadLine());

            p.print();
        }
    }
}
