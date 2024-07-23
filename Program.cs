namespace C_LearningDSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // This returns the index it was found in which is 8
            //LinearSearch.Linear([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 9);

            // The input has to be sorted first
            // Binary Search is faster because Linear Search is iterative
            //BinarySearch.Binary([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 9);

            //RecursiveBinary.Result();

            //Arrays.Arr();
            //Arrays.SearchArr();
            //Arrays.DeleteArr();

            // Linked List - check this video for easier explanation https://youtu.be/8TGFk_zUS9A?si=yS-TKLUH_A4hOfTz
            //Console.WriteLine("Add First:");
            //LinkedList myList1 = new LinkedList();

            //myList1.AddFirst("Hello");
            //myList1.AddFirst("Magical");
            //myList1.AddFirst("World");
            //myList1.printAllNodes();

            //Console.WriteLine();

            //Console.WriteLine("Add Last:");
            //LinkedList myList2 = new LinkedList();

            //myList2.AddLast("Hello");
            //myList2.AddLast("Magical");
            //myList2.AddLast("World");
            //myList2.printAllNodes();

            // Merge Sort / Divide and Conquer
            // sort items from random order to ascending order in array
            // 3:04:21

            // Divide: find the midpoint of the array or list and divide into sublists like binary search
            // Conquer: recursively sort the sublists
            // Combine: merge the sorted sublists into one list


            // Merge Function Test
            //int[] myArray = new int[] { 2, 3, 8, 15, 1, 4, 7, 11};
            //// index 4 is the midpoint
            //Merge(myArray, 0, 4, myArray.Length - 1);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write($"{myArray[i]} ");
            //}
            //Console.Read();

            // Merge Sort Function Test
            int[] myArray = new int[] { 2, 3, 1, 8, 1, 5, 7, 11 };
            MergeSort(myArray, 0, myArray.Length - 1);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.Read();

        }
        // Merge Sort code from https://youtu.be/FW9ODUUBDpI?si=uoGaHihBmjlvm-la

        // Merge only function
        private static void Merge(int[] myArray, int left, int midpoint, int right)
        {
            // three pointers
            int i, j, k;

            int leftArrLength = midpoint - left;
            int rightArrLength = right - midpoint + 1;

            // left of the sublist or sub arrays
            int[] leftArr = new int[leftArrLength];
            int[] rightArr = new int[rightArrLength];

            for (i = 0; i < leftArrLength; i++)
            {
                leftArr[i] = myArray[left + i];
            }

            for (i = 0; i < rightArrLength; i++)
            {
                rightArr[i] = myArray[midpoint + i];
            }
            i = 0; j = 0; k = left;

            // compare both arrays
            while (i < leftArrLength && j < rightArrLength)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    myArray[k++] = leftArr[i++];
                }
                else
                {
                    myArray[k++] = rightArr[j++];
                }
            }

            if (i == leftArrLength)
            {
                // left array is done, copy from right array
                for (int ii = j; ii < rightArrLength; ii++)
                {
                    myArray[k++] = rightArr[ii];
                }
            }

            if (j == rightArrLength)
            {
                // right array is done, copy from left array
                for (int ii = i; ii < leftArrLength; ii++)
                {
                    myArray[k++] = leftArr[ii];
                }
            }

        }
        // Merge Sort Function - recursive 
        public static void MergeSort(int[] myArray, int left, int right)
        {
            if(left < right)
            {
                int midpoint = (left + (right - 1)) / 2 + 1;
                
                MergeSort(myArray, left, midpoint - 1);
                MergeSort(myArray, midpoint, right);

                // Merge the subarrays
                Merge(myArray, left, midpoint, right);
            }
        }
    }
}
