using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace codewars
{
    public static class DecipherThisText
    {
        public static string DecipherThis(string s)
        {
            var wordsArray= s.Split(' ');

            var number = Convert.ToInt32( string.Join("", wordsArray[0].Where(x => char.IsDigit(x)).ToArray()));

            string stringAgain = Convert.ToChar(number).ToString();

            var ArrayOfStringNumbers = string.Join("",wordsArray.Select(x => x.Where(x => char.IsDigit(x)).ToArray()));

           string resultString = string.Concat(wordsArray[0].Where(Char.IsDigit));

            string[] someName = new string[] { "First", "MiddleName", "LastName" };

            var initials = string.Join(".", someName.Select(x => x.ToString().Concat(x.Where(char.IsDigit)).ToArray()));

            foreach (var item in wordsArray)
            {
                var tmpNumber= Convert.ToInt32(string.Join("", item.Where(x => char.IsDigit(x)).ToArray()));
                var tmpstring = Convert.ToChar(tmpNumber).ToString() + string.Join("", item.Where(x => char.IsLetter(x)).ToArray());

                var pop = tmpstring.ToCharArray();
                var pap = new char[] { tmpstring[tmpstring.Length - 1], tmpstring[1] };

                pop[1] = 'F';
                pop[pop.Length-1] = 'L';



                wordsArray = wordsArray.Select(s => s.Replace(item, tmpstring)).ToArray();
            }

            
            return "pap"; // Implement me! :)
        }
    }
}
