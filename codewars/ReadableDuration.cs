using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public static class ReadableDuration
    {
        public static string formatDuration(int seconds)
        {
            if (seconds <= 0) 
            {
                return "now";
            }
            //Enter Code here
            int years= seconds/31536000; 
            int days = seconds%31536000/86400; 

            int spillseconds = seconds % 31536000 % 86400; 
            int hours = spillseconds / 60/60;
            int minuts=spillseconds/ 60%60;
            int finalseconds= spillseconds % 60 % 60;

            string yearString = years > 1 ? "years" : "year";
            string daysString = days > 1 ? "days" : "day";
            string hoursString = hours > 1 ? "hours" : "hour";
            string minutsString = minuts > 1 ? "minuts": "minut";
            string secondsString = finalseconds > 1 ? "seconds" : "second";

            string output = "";

            if (years > 0) 
            
            {
                output = years.ToString() + ", "+yearString;
            }
            if (days > 0)

            {
                output = output +", "+days.ToString() + " " + daysString;
            }
            if (hours > 0)

            {
                output = output + ", " + hours.ToString() + " " + hoursString;
            }
            if (minuts > 0)

            {
                output = seconds>0?output + " and " + minuts.ToString() + " " + minutsString:
                    output + ", " + minuts.ToString() + " " + minutsString;
            }
            if (finalseconds > 0)

            {
                output = output + "and" + finalseconds.ToString();
            }

            return output;
        }

    }
}

