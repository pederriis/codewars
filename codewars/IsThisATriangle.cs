using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public static class IsThisATriangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
             List<int> intList = new List<int>{a,b,c};

            var maxValue = intList.Max();
            intList.Remove(maxValue);

            return intList.Sum() > maxValue;
            
        }
    }
}
