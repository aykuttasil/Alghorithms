using System;

/*
Given a non-empty, singly linked list with head node head, return a middle node of linked list.

If there are two middle nodes, return the second middle node.

 

Example 1:

Input: [1,2,3,4,5]
Output: Node 3 from this list (Serialization: [3,4,5])
The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
Note that we returned a ListNode object ans, such that:
ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
Example 2:

Input: [1,2,3,4,5,6]
Output: Node 4 from this list (Serialization: [4,5,6])
Since the list has two middle nodes with values 3 and 4, we return the second one.
 

Note:

The number of nodes in the given list will be between 1 and 100.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
namespace middle_of_linked_list
{
    class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x) { val = x; }
        }

        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);

            for (int i = 2; i < 6; i++)
            {
                ListNode last = head;
                while (last.next != null)
                {
                    last = last.next;
                }

                var newNode = new ListNode(i);
                last.next = newNode;                
            }

            ListNode middleListNode = MiddleNode(head);

            Console.WriteLine("Middle Note Value:" + middleListNode.val);
        }

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode middle = head;
            int count = 0;
            while (head != null)
            {
                if (count % 2 != 0)
                {
                    middle = middle.next;
                    Console.WriteLine("middle:" + middle.val);
                }
                count++;
                head = head.next;
            }


            return middle;
        }
    }
}
