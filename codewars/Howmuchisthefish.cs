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
            if (string.IsNullOrWhiteSpace(name))
            { 
                return 0; 
            }

            string hexValues = "abcdef";

            List<char> hexes = name.ToLower().Replace(" ","").Where(x => hexValues.Contains(x)).ToList();

            if (hexes.Count <= 0) 
            {
                return 0;
            }
            
            List<string> binaries = new List<string>();
            
            foreach (char c in hexes)
            {
                var value =Convert.ToString( Convert.ToInt32("0x" + c, 16),2);
                binaries.Add(value);
            }

            string tempString = "";
            string resultString = "";

            for (int i = 1; i < binaries.Count; i++)
            {
                for (int j = 0; j < binaries[i].Length; j++)
                {
                    if (binaries[i][j] == binaries[i - 1][j])
                    {
                        tempString = tempString + "0";
                    }
                    else
                    {
                        tempString = tempString + "1";
                    }
                }
                binaries[i] = tempString;
                resultString = tempString;
                tempString = "";

            }

            return Convert.ToInt32(resultString, 2);
        }

        public static List<char> FindHex(string name)
        {
            string hexValues = "abcdef";

            List<char> output = name.ToLower().Where(x=>hexValues.Contains(x)).ToList();


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

        public static int XorBinary(List<string> binaries) 
        {
            string tempString = "";
            string resultString="";

            for (int i = 1; i < binaries.Count; i++)
            {
                for (int j = 0; j < binaries[i].Length; j++)
                {
                    if (binaries[i][j] == binaries[i - 1][j])
                    {
                        tempString = tempString + "0";
                        }
                    else
                    {
                        tempString = tempString + "1";
                    }
                }
                binaries[i] = tempString;
                resultString = tempString;
                tempString = "";
               
            }
            return Convert.ToInt32(resultString,2);
        }
    }
}
