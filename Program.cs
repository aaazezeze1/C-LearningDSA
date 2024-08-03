using System;

namespace C_LearningDSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorting and Searching
            // 4:15:18

            // Bogo Sort
            // Code from https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-2.php
            
            // Initializing an unsorted list of integers
            List<int> list = new List<int>() { 45, 23, 89, 67 };
            Console.WriteLine("Sorting...");
            // Calling the Bogo_sort function with optional parameters (announce and delay)
            Bogo_sort(list, true, 5);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        // Function to perform Bogo sort
        static void Bogo_sort(List<int> list, bool announce, int delay)
        {
            int iteration = 0;
            // Loop until the list is sorted
            while (!IsSorted(list))
            {
                if (announce)
                {
                    // Print the current iteration if announce is set to true
                    Print_Iteration(list, iteration);
                }
                if (delay != 0)
                {
                    // Introduce a delay if delay parameter is non-zero
                    System.Threading.Thread.Sleep(Math.Abs(delay));
                }
                // Rearrange the list elements randomly
                list = Remap(list);
                iteration++; // Increment iteration count
            }

            Print_Iteration(list, iteration); // Print the final sorted list
            Console.WriteLine();
            Console.WriteLine("Bogo_sort completed after {0} iterations.", iteration); // Display the total iterations
        }

        // Function to print the current iteration of the list
        static void Print_Iteration(List<int> list, int iteration)
        {
            Console.Write("Bogo_sort iteration {0}: ", iteration);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        // Function to check if the list is sorted
        static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false; // Returns false if the list is not sorted
                }
            }

            return true; // Returns true if the list is sorted
        }

        // Function to rearrange the list elements randomly
        static List<int> Remap(List<int> list)
        {
            int temp;
            List<int> newList = new List<int>();
            Random r = new Random();

            // Randomly rearrange elements from the input list to a new list
            while (list.Count > 0)
            {
                temp = (int)r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }
            return newList; // Return the new list with rearranged elements
        }
    }
}
