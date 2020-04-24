using System;

namespace climbing_stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ClimbStairs(4);
            Console.WriteLine("Result: " + result);

            var result1 = climb_Stairs(0, 4);
            Console.WriteLine("Result1: " + result1);
        }

        static int sayac = 0;
        public static int climb_Stairs(int i, int n)
        {
            sayac++;
            Console.WriteLine("i:" + i + " - n:" + n + " sayac:" + sayac);
            if (i > n)
            {
                return 0;
            }
            if (i == n)
            {
                return 1;
            }
            var x = climb_Stairs(i + 1, n);
            Console.WriteLine("x:" + x);
            
            var y = climb_Stairs(i + 2, n);
            Console.WriteLine("y:" + y);
            return x + y;
        }


        public static int ClimbStairs(int n)
        {
            if (n == 1 || n == 2)
            {
                return n;
            }
            int first = 1;
            int second = 2;
            for (int i = 2; i < n; i++)
            {
                int temp = second;
                second += first;
                first = temp;
            }
            return second;
        }
    }
}
