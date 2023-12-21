using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public static class BusinessController
    {

        public static void Run()
        {
            CukooClock();
        }
       public static void CukooClock()
        {
           Console.WriteLine("final " + CuckooClockSolution.CuckooClock("10:00", 10));
        }
    }
}
