using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningDSA
{
    public static class LinearSearch
    {
        public static int Linear(int[] input, int target)
        {
            for (int index = 0; index <= (input).Length; index++)
            {
                if ((input[index]) == target)
                {
                    Console.WriteLine("Target found at index: " + index);
                    return index;
                }
            }
            return -1;
        }
    }
}
