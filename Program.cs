using System;

namespace C_LearningDSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorting and Searching

            // Quick Sort - divide and conquer approach, uses pivots instead of sorting by subarrays or merge sort
            // explanation from BroCode https://youtu.be/Vtckgz38QHs?si=LwuCXVP8HCXSiovN
            // Stackoverflow https://stackoverflow.com/questions/70402/why-is-quicksort-better-than-mergesort
            // Code from https://teamtreehouse.com/library/algorithms-sorting-and-searching/code-for-quicksort
            var list = new List<int>() { 32, 100, 1, 2, 29, 28, 88, 3, 50, 67, 37, 1, 57, 20 };
            var sortedList = Quicksort(list);
            Console.WriteLine(String.Join(", ", sortedList));
        }
        public static List<int> Quicksort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            var lessThanPivot = new List<int>();
            var greaterThanPivot = new List<int>();
            // pivot starts at the first element
            int pivot = list[0];
            int length = list.Count;
            for (int i = 1; i < length; i++)
            {
                int currentValue = list[i];
                if (currentValue <= pivot)
                {
                    lessThanPivot.Add(currentValue);
                }
                else
                {
                    greaterThanPivot.Add(currentValue);
                }
            }
            var sortedList = new List<int>();
            sortedList.AddRange(Quicksort(lessThanPivot));
            sortedList.Add(pivot);
            sortedList.AddRange(Quicksort(greaterThanPivot));

            return sortedList;
        }

    }
}
