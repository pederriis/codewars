using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public static class FirstNoneRepeating
    {
        public static string FirstNonRepeatingLetter(string s)
        {

            var singleChar = s.ToLower().GroupBy(x => x).Where(g => g.Count() == 1).ToList().FirstOrDefault()?.Key.ToString();

           return singleChar == null?"": s[s.IndexOf(singleChar, StringComparison.OrdinalIgnoreCase)].ToString();

           

        }
    }
}
