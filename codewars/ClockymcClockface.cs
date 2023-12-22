using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public static class ClockymcClockface
    {

        public static string WhatTimeIsIt(double angle)
        {

            TimeSpan time = TimeSpan.FromMinutes(angle * 2);
            
            if (time.Hours ==0)
            {
                time = TimeSpan.FromMinutes(720+angle*2);
            }

            return time.ToString(@"hh\:mm");
        }
    }
}

