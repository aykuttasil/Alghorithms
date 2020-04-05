using System;
using System.Collections;

/*
Given an integer array nums, find the contiguous subarray (containing at least one number) 
which has the largest sum and return its sum.

Example:
Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.

Follow up:
If you have figured out the O(n) solution, 
try coding another solution using the divide and conquer approach, which is more subtle.
*/


/*
    [-1,2,-3,1] -> [2]
    [ 2,3,-5,3] -> [2,3]
    [-2,1,-3,4,-1,2,1,-5,4,15] -> [4,-1,2,1,-5,4,15] = 20
*/
namespace maximum_subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[4] { -1, 2, -3, 1 };


        }

        public static int MaxSubArray(int[] a)
        {
            int max_so_far = a[0];
            int curr_max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                curr_max = Math.Max(a[i], curr_max + a[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }

            return max_so_far;
        }
    }
}
