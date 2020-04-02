using System;

namespace happy_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(""+sumOfSquareOfDigits(12));
        }

        public static int sumOfSquareOfDigits(int a)
        {
            var strInt = a.ToString();    
            var sum = 0;
            for (int i = 0; i < strInt.Length; i++)
            {
                var digit = int.Parse(strInt[i].ToString());
                sum += digit * digit;            
            }
            return sum;
        }
    }
}
