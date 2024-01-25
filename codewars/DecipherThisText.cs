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
            if (s=="")
            {
                return s;
            }
            var wordsArray= s.Split(' ');
            List<string> output = new List<string>();    

            foreach (var item in wordsArray)
            {
                int tmpNumber = Convert.ToInt32(string.Join("", item.Where(x => char.IsDigit(x)).ToArray()));
                string tmpstring = Convert.ToChar(tmpNumber).ToString() + string.Join("", item.Where(x => char.IsLetter(x)).ToArray());

                char[] currentWord = tmpstring.ToCharArray();

               if (currentWord.Length > 1)
                
                {
                    char[] tempCharArray = new char[] {  tmpstring[1], tmpstring[tmpstring.Length - 1] };
                    currentWord[1] = tempCharArray[1];
                    currentWord[currentWord.Length-1] = tempCharArray[0];

                }

                   output.Add(new string(currentWord));

            }
            
            return string.Join(" ", output);
        }
    }
}
