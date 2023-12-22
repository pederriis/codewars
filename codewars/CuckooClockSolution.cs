using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public class CuckooClockSolution
    {
        public static string CuckooClock(string inputTime, int chimes)
        {
            var parsedTime = DateTime.Parse(inputTime);

            while (chimes >0)
            {

                {
                    int currentMinuts = short.Parse(parsedTime.ToString("mm"));

                    if (currentMinuts % 15 == 0 && currentMinuts != 0)
                    {
                        chimes--;
                     
                    }

                    else if (currentMinuts == 0)
                    {
                        chimes = chimes - short.Parse(parsedTime.ToString("hh"));

                        if (chimes>0)
                        {
                        parsedTime = parsedTime.AddMinutes(15);

                        }

                    }
                    if (chimes > 0 && currentMinuts != 0)
                    {
                        parsedTime = parsedTime.AddMinutes(1);

                    }

                }
            }
            return parsedTime.ToString("hh:mm");
        }

    }
}
