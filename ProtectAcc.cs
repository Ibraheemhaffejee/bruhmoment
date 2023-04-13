using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectAccess
{
    internal class ProtectAcc
    {
        protected int bYear;

        public void print()
        {
            Console.WriteLine("Your birth year {0}", bYear);
        }

    }
}
