using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningDSA
{
    // java code from Treehouse website
    public static class BinarySearch
    {
        public static int Binary(int[] input, int target)
        {
            int first = 0;
            int last = input.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;

                if (input[mid] == target)
                {
                    Console.WriteLine(mid);
                    return mid;
                }
                else if (input[mid] < target)
                {
                    first = mid + 1;
                }
                else
                {
                    last = mid - 1;
                }
            }

            return -1;
        }
    }
}
