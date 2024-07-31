using System;

namespace C_LearningDSA
{
    class Program
    {
        public class linkedList
        {
            node head = null;

            // node a, b;
            public class node
            {
                public int val;
                public node next;

                public node(int val)
                {
                    this.val = val;
                }
            }

            node sortedMerge(node a, node b)
            {
                node result = null;
                /* Base cases */
                if (a == null)
                    return b;
                if (b == null)
                    return a;

                /* Pick either a or b, and recur */
                if (a.val <= b.val)
                {
                    result = a;
                    result.next = sortedMerge(a.next, b);
                }
                else
                {
                    result = b;
                    result.next = sortedMerge(a, b.next);
                }
                return result;
            }

            node mergeSort(node h)
            {
                // Base case : if head is null
                if (h == null || h.next == null)
                {
                    return h;
                }

                // get the middle of the list
                node middle = getMiddle(h);
                node nextofmiddle = middle.next;

                // set the next of middle node to null
                middle.next = null;

                // Apply mergeSort on left list
                node left = mergeSort(h);

                // Apply mergeSort on right list
                node right = mergeSort(nextofmiddle);

                // Merge the left and right lists
                node sortedlist = sortedMerge(left, right);
                return sortedlist;
            }

            // Utility function to get the
            // middle of the linked list
            node getMiddle(node h)
            {
                // Base case
                if (h == null)
                    return h;
                node fastptr = h.next;
                node slowptr = h;

                // Move fastptr by two and slow ptr by one
                // Finally slowptr will point to middle node
                while (fastptr != null)
                {
                    fastptr = fastptr.next;
                    if (fastptr != null)
                    {
                        slowptr = slowptr.next;
                        fastptr = fastptr.next;
                    }
                }
                return slowptr;
            }

            // Add to linked list
            void push(int new_data)
            {
                /* allocate node */
                node new_node = new node(new_data);

                /* link the old list of the new node */
                new_node.next = head;

                /* move the head to point to the new node */
                head = new_node;
            }

            // Utility function to print the linked list
            void printList(node headref)
            {
                while (headref != null)
                {
                    Console.Write(headref.val + " ");
                    headref = headref.next;
                }
            }
            static void Main(string[] args)
            {
                // Linked List Merge Sort - Code from GeeksForGeeks https://www.geeksforgeeks.org/merge-sort-for-linked-list/
                // recursive divide and conquer similar to binary search
                // 3:37:50
                
                linkedList li = new linkedList();
                /* 
                * Let us create a unsorted linked list to test the functions 
                * created. The list shall be a: 2->3->20->5->10->15 
                */
                li.push(15);
                li.push(10);
                li.push(5);
                li.push(20);
                li.push(3);
                li.push(2);

                // Apply merge Sort
                li.head = li.mergeSort(li.head);
                Console.Write("Sorted Linked List is: \n");
                li.printList(li.head);

            }

        }
    }
}
