using System;

namespace two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 3, 4, 7 };
            var x = TwoSum(arr, 5);

            Console.WriteLine(x);

            Console.ReadLine();
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                var x = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var y = nums[j];
                    if (x + y == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }
            return result;
        }
    }


}
