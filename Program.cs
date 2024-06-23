namespace C_LearningDSA
{
    internal class Program
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

            // Linked List
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.printAllNodes();

            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.printAllNodes();
        }
    }
}
