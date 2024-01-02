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
 
            List<int> flips = new List<int>();

            
            while(!IsOrderCorrect(stack))
            {
                Console.WriteLine("new loop");
                int maxValue = stack.Max();
                int firstIndexOfMax = stack.IndexOf(maxValue);
                int lastIndexOfMax = stack.LastIndexOf(maxValue);


                if (lastIndexOfMax + 1 == stack.Count)
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                 
                else if (firstIndexOfMax == 0)
                
                {
                    flips.Add(stack.Count-1);
                    stack.Reverse();
                }
                
                else
                {
                    flips.Add(lastIndexOfMax);
                    int count = lastIndexOfMax + 1;
                    
                    stack.Reverse(0, count);

                }
            }
            


            


            //hvis pap er falsk skal vi en tur mere rundt i mangegen
            //hvordan ungår jeg at den altid vil flippe to gange per tur?

            foreach (var item in flips)
            {
                Console.WriteLine(item);
            }


            return flips;
        }

      

        public static bool IsOrderCorrect(List<int> stack)
        {
            for (int i = 0; i < stack.Count()-1; i++)
            {
                if (stack[i] > stack[i + 1])
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
         
    


