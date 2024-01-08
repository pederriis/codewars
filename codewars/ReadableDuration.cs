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
            if (seconds == 1)
            {
                return "1 second";
            }
            int years = seconds / 31536000;
            int days = seconds % 31536000 / 86400;

            int spillseconds = seconds % 31536000 % 86400;
            int hours = spillseconds / 60 / 60;
            int minutes = spillseconds / 60 % 60;
            int finalseconds = spillseconds % 60 % 60;

            string yearString = years > 1 ? "years" : "year";
            string daysString = days > 1 ? "days" : "day";
            string hoursString = hours > 1 ? "hours" : "hour";
            string minutesString = minutes > 1 ? "minutes" : "minute";
            string secondsString = finalseconds > 1 ? "seconds" : "second";

            string output = "";

            if (years > 0)

            {
                seconds = seconds - years * 31536000;
                output = $"{years} {yearString}";
            }
            if (days > 0)

            {
                seconds = seconds - days * 86400;

                if (seconds == 0 && output != "")
                {
                    output = output + $" and ";

                }
                else if (output != "")
                {
                    output = output + $", ";

                }

                output = output + $"{days} {daysString}";
            }
            if (hours > 0)

            {
                seconds = seconds - hours * 3600;


                if (seconds == 0 && output != "")
                {
                    output = output + $" and ";

                }

                else if (output != "")
                {
                    output = output + $", ";

                }

                output = output + $"{hours} {hoursString}";
            }
            if (minutes > 0)

            {
                seconds = seconds - minutes * 60;

                if (seconds == 0&&output!="")
                {
                    output = output + $" and ";

                }
               
                else if (output!="")
                {
                    output = output + $", ";

                }

                output = output + $"{minutes} {minutesString}";
            }
            if (finalseconds > 0)

            {
                output = output + $" and { finalseconds} { secondsString}";
            }
            return output;
        }
    }

}