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
            RunClockymcClockface();
        }
       public static void CukooClock()
        {
           Console.WriteLine("final " + CuckooClockSolution.CuckooClock("12:59", 10));
        }

        public static void RunClockymcClockface()
        {
            Console.WriteLine("Final " + ClockymcClockface.WhatTimeIsIt(2));
        }
    }
}
