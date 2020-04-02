using System;

namespace happy_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 6;

            while (result != 1 && result != 4)
            {
                result = sumOfSquareOfDigits(result);
                Console.WriteLine("Result:" + result);
            }

            if (result == 1)
                Console.WriteLine("Happy number");
            else if (result == 4)
                Console.WriteLine("Not Happy number");
        }

        public static int sumOfSquareOfDigits(int num)
        {
            int rem = 0, sum = 0;

            //Calculates the sum of squares of digits  
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem);
                num = num / 10;
            }
            return sum;
        }
    }
}
