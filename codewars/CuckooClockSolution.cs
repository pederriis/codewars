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


            for (int i = chimes-1; i > 0; i--)
            {
                int currentMinuts = short.Parse(parsedTime.ToString("mm"));

                if (currentMinuts % 15 == 0 && currentMinuts != 0)
                {
                    chimes--;
                    Console.WriteLine(parsedTime.ToString("HH:mm"));
                    Console.WriteLine("Current chimes " + chimes);

                }
                else if (currentMinuts == 0)
                {
                    chimes = chimes - short.Parse(parsedTime.ToString("HH"));
                    Console.WriteLine(parsedTime.ToString("HH:mm"));
                    Console.WriteLine("Current chimes " + chimes);
                }
                parsedTime = parsedTime.AddMinutes(1);

            }
            
            return parsedTime.ToString("HH:mm");
        }

    }
}
