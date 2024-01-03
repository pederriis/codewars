using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public static class Howmuchisthefish
    {
        public static int FisHex(string name)
        {

            List<char> hexes= FindHex(name);
            var ints=GetIntsFromHex(hexes);
            var strings=GetBinaryFromInts(ints);


            return 0;
        }

        public static List<char> FindHex(string name)
        {
            string hexValues = "abcdef";

            List<char> output = name.Where(x=>hexValues.Contains(x)).ToList();


            return output;


        }

        public static List<int> GetIntsFromHex(List<char> hexes)
        {
            List<int> output = new List<int>();

            foreach (char c in hexes) 
            {
                int value = Convert.ToInt32("0x"+c, 16);
                output.Add(value);
            }
            return output;
        }

        public static List<string> GetBinaryFromInts(List<int> ints)
        {
            List<string> output = new List<string>();   

            foreach (int i in ints)
            {
                string binary = Convert.ToString(i, 2);
                output.Add(binary);
            }
            return output;
        }
    }
}
