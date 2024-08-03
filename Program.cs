using System;

namespace C_LearningDSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorting and Searching
            // 4:21:00

            // Selection Sort
            // Code from https://www.geeksforgeeks.org/selection-sort-algorithm-2/
            int[] arr = { 64, 25, 12, 22, 11 };
            sort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }
        static void sort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;
                        // eto yung value ng minimum 
                        Console.WriteLine(arr[min_idx]);

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
        // Prints the array
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
