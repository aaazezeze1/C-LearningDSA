using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningDSA
{
    public static class LinearSearch
    {
        public static int Linear(int[] input, int target)
        {
            for (int i = 0; i <= (input).Length; i++)
            {
                if ((input[i]) == target)
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            return -1;
        }
    }
}
