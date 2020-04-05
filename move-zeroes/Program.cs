using System;
using System.Collections.Generic;
using System.Diagnostics;

/*
- Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:

Input: [0,1,0,3,12]
Output: [1,3,12,0,0]

Note:

You must do this in-place without making a copy of the array.
Minimize the total number of operations.
*/
namespace move_zeroes
{
    class Program
    {
        static Stopwatch watch = new Stopwatch();

        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12, 0, 2, 3, 5, 12 };
            watch.Reset();
            MoveZeroes1(nums);
            watch.Reset();
            MoveZeroes2(nums);
            watch.Reset();
            MoveZeroes3(nums);
        }


        // Method 1
        public static void MoveZeroes1(int[] nums)
        {

            watch.Start();
            int countNonZero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[countNonZero++] = nums[i];
                }
            }

            while (countNonZero < nums.Length)
            {
                nums[countNonZero++] = 0;
            }
            watch.Stop();
            printScreen(nums);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        // Method 2
        public static void MoveZeroes2(int[] nums)
        {
            watch.Start();
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index++] = nums[i];
                }
            }


            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            watch.Stop();
            printScreen(nums);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }


        // Method 3
        public static void MoveZeroes3(int[] nums)
        {
            watch.Start();
            List<int> list = new List<int>();
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    list.Add(nums[i]);
                }
                else
                {
                    zeroCount++;
                }
            }

            for (int i = 0; i < zeroCount; i++)
            {
                list.Add(0);
            }
            watch.Stop();
            printScreen(nums);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        public static void printScreen(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("i:" + nums[i]);
            }
        }

    }
}
