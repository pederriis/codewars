using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    public static class PancakeFlip
    {

        public static List<int> FlipPancakes(List<int> stack)
        {
            //lav ny tom liste
            
            //loop igennem stacken
            //hvis der er et tal der er højere end foregående, gør følgende
            //find det højeste tal i stack
            //del stacken op i 2
            //noter indexet i den nye stack
            //tag den første halvdel og reverse alt
            //sæt de to stacks sammen igen
            //forfra


            List<int> flips = new List<int>();

            for (int i = 0; i < stack.Count(); i++)
            {
                var highest = stack.Max();

                var indexOfHighset = stack.IndexOf(highest);
                flips.Add(indexOfHighset);

                stack[indexOfHighset] = 1;

            }

           


            return flips;
        }
    }
}
