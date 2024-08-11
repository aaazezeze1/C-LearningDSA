using System;

namespace C_LearningDSA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sorting and Searching
            // 4:31:25

            // Recursion - not the most efficient way to add a list or array of numbers
            int[] myArr = {1, 2, 3, 4, 5};
            //myFunc(myArr);
            Console.WriteLine(myRecurFunc(myArr, 0));

        }
        static void myFunc(int[] myArr)
        {
            int total = 0;
            foreach (int number in myArr)
            {
                total += number;
            }
            Console.WriteLine(total);
        }
        static int myRecurFunc(int[] myArr, int index)
        {
            if (myArr[index] == myArr[myArr.Length - 1])
            {
                //Console.WriteLine(index);
                return myArr[myArr.Length - 1];
            }
            else
            {
                return myArr[index] + myRecurFunc(myArr, index + 1);
            }
        }
        
    }
}
