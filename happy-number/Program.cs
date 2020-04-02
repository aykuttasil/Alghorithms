using System;
using System.Collections.Generic;

/*
Write an algorithm to determine if a number is "happy".

A happy number is a number defined by the following process: Starting with any positive integer, 
replace the number by the sum of the squares of its digits, 
and repeat the process until the number equals 1 (where it will stay), 
or it loops endlessly in a cycle which does not include 1. 
Those numbers for which this process ends in 1 are happy numbers.

Input: 19
Output: true
Explanation: 
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
*/

namespace happy_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1111111;
            //Console.WriteLine(num + " % 10 =" + num % 10);
            //Console.WriteLine("result:" + sumOfSquareOfDigits(num));

            HashSet<int> hash = new HashSet<int>();
            bool isOK = true;
            while (num != 1)
            {
                num = sumOfSquareOfDigits(num);
                if (hash.Contains(num))
                {
                    isOK = false;
                    break;
                }
                else
                {
                    hash.Add(num);
                }

                if (num == 1)
                {
                    isOK = true;
                    break;
                }
            }

            if (isOK)
            {
                Console.WriteLine(num + " is Happy Number");
            }
            else
            {
                Console.WriteLine(num + " is not Happy Number");
            }


        }

        /*
            12 = 1^2 + 2^2 = 5
            5 = 5^2 = 25
            25 = 2'2 + 5^2 = 29
            29 = 2^2 + 9 ^ 2 = 85
            ..            
        */
        public static int sumOfSquareOfDigits(int num)
        {
            int sum = 0;
            int x = 0;
            while (num != 0)
            {
                x = (num % 10) * (num % 10);
                sum += x;
                num = num / 10;
            }
            Console.WriteLine("sum:" + sum);
            return sum;
        }
    }
}
