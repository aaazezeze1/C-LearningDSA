using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LearningDSA
{
    public static class MergeSortAlgo
    {
        // Merge Sort code from https://youtu.be/FW9ODUUBDpI?si=uoGaHihBmjlvm-la

        // Merge Sort - O(n log n)
        // merge runs at - O(n) and sort runs at - O(log n)
        public static void Merge(int[] myArray, int left, int midpoint, int right)
        {
            // three pointers
            int i, j, k;

            int leftArrLength = midpoint - left;
            int rightArrLength = right - midpoint + 1;

            // length of the sub arrays
            int[] leftArr = new int[leftArrLength];
            int[] rightArr = new int[rightArrLength];

            // copy elements inside the sub arrays
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

        // Merge Sort Function - recursive, similar approach to binary search
        public static void MergeSort(int[] myArray, int left, int right)
        {
            if (left < right)
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
