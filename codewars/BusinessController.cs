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
            runPancakeFlip();
        }
       public static void CukooClock()
        {
           Console.WriteLine("final " + CuckooClockSolution.CuckooClock("12:59", 10));
        }

        public static void RunClockymcClockface()
        {
            Console.WriteLine("Final " + ClockymcClockface.WhatTimeIsIt(2));
        }

        public static void runPancakeFlip()
        {
            List<int> pancakes = new List<int> { 1, 5, 8, 3 };

            Console.WriteLine("Flips: " + PancakeFlip.FlipPancakes(pancakes));
        }
    }
}
