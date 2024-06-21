using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningDSA
{
    public static class RecursiveBinary
    {
        // code from geeksforgeeks
        public static int RecursiveBin(int[] input, int low, int high, int target)
        {
            // continue running as long as this condition is satisfied
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                // if mid index value is the same as target
                if (input[mid] == target)
                    return mid;

                // check left subarray
                if (input[mid] > target)
                    return RecursiveBin(input, low, mid - 1, target);

                // right subarray
                return RecursiveBin(input, mid + 1, high, target);
            }
            return -1;
        }
        public static void Result()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int n = input.Length;
            int target = 9;
            int result = RecursiveBin(input, 0, n - 1, target);
            
            if (result == -1)
            {
                Console.WriteLine("Target not found");
            }
            else
            {
                Console.WriteLine("Target found at index: " + result);
            }
        }
    }
}
