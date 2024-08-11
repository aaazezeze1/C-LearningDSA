using System;

namespace C_LearningDSA
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Searching 

            // Code from https://teamtreehouse.com/library/algorithms-sorting-and-searching/code-for-linear-search
            // https://teamtreehouse.com/library/algorithms-sorting-and-searching/code-for-binary-search

            var numbers = new [] { 1, 2, 3, 4, 5, 6 };
            //var numbers = Enumerable.Range(1, 10000).ToArray();

            // Linear Search Version
            //foreach (var number in numbers)
            //{
            //    //int? result = LinearSearch(numbers, number);
            //    int? result = GenericLinearSearch(numbers, number);

            //    if (result != null && result == (number - 1))
            //    {
            //        Console.WriteLine($"Index for '{number}' is '{result}'");
            //    }
            //    else
            //    {
            //        throw new Exception("Oh no!");
            //    }
            //}

            // Recursive Binary Search Version
            foreach (var number in numbers)
            {
                //int? result = IterativeBinarySearch(numbers, number);
                int? result = RecursiveBinarySearch(numbers, number);

                if (result != null && result == (number - 1))
                {
                    Console.WriteLine($"Index for '{number}' is '{result}'");
                }
                else
                {
                    throw new Exception("Oh no!");
                }
            }
        }
        public static int LinearSearch(int[] data, int key)
        {
            for (int index = 0; index < data.Length; index++)
            {
                 if (data[index] == key)
                 {
                     return index;
                 }
            }

            return -1;
        }
        public static int GenericLinearSearch<T>(T[] data, T key)
        {
            for (int index = 0; index < data.Length; index++)
            {
                if (EqualityComparer<T>.Default.Equals(data[index], key))
                {
                    return index;
                }
            }

            return -1;
        }

        // Recursive Binary Search Version
        public static int? IterativeBinarySearch(int[] data, int key)
        {
            var first = 0;
            var last = data.Length - 1;

            while (first <= last)
            {
                var mid = (first + last) / 2;

                if (data[mid] < key)
                {
                    first = mid + 1;
                }
                else if (data[mid] > key)
                {
                    last = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return null;
        }
        public static int? RecursiveBinarySearch<T>(T[] data, T key)
            where T : IComparable<T>
        {
            return RecursiveBinarySearch(data, key, 0, data.Length - 1);
        }

        public static int? RecursiveBinarySearch<T>(
            T[] data, T key, int first, int last)
            where T : IComparable<T>
        {
            if (first > last)
            {
                return null;
            }
            else
            {
                var mid = (first + last) / 2;
                var comparison = data[mid].CompareTo(key);

                if (comparison < 0)
                {
                    return RecursiveBinarySearch(data, key, mid + 1, last);
                }
                else if (comparison > 0)
                {
                    return RecursiveBinarySearch(data, key, first, mid - 1);
                }
                else
                {
                    return mid;
                }
            }
        }

    }
}
