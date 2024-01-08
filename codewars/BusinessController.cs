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
            runReadableDuration();
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
            List<int> pancakes = new List<int> { 4, 1, 3, 2, 4, 6, 3, 9, 1 };

            Console.WriteLine("Flips: " + PancakeFlip.FlipPancakes(pancakes));
        }
    
        public static void runFizHex()
        {
            Console.WriteLine(Howmuchisthefish.FisHex("f"));
        }

        public static void runTriangle()
        {
            Console.WriteLine(IsThisATriangle.IsTriangle(1, 2, 2));
        }

        public static void runReadableDuration()
        {
            Console.WriteLine(ReadableDuration.formatDuration(120));
        }

    }
}
