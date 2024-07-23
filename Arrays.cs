using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningDSA
{
    public static class Arrays
    {
        // Arrays are not good at inserting and deleting
        public static void Arr()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Access - O(1) or Constant Time
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);

            // Insert
            // True Index - O(n) or Linear Runtime, insert using index and moves the position
            // Appending - adds the item to the end 

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            // insert 6 at index 2
            nums.Insert(2, 6);

            //for (int index = 0; index < nums.Count; index++)
            //{
            //    Console.WriteLine(nums[index]);
            //}

            // Concatenation
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 6, 7, 8, 9, 10 };

            int[] arr3 = arr1.Concat(arr2).ToArray();

            foreach (int arrs in arr3)
            {
                Console.WriteLine(arrs);
            }
        }
        public static bool SearchArr()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Search - O(n) or Linear Runtime
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Contains(19))
                {
                    Console.WriteLine("True");
                    return true;
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            return false;
        }
        public static int DeleteArr()
        {
            // Delete - O(n) or Linear Runtime
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers = numbers.Except(new int[] { 4 }).ToArray();

            foreach (int nums in numbers)
            {
                Console.Write(nums + ", ");
            }

            return -1;
        }
    }
}
