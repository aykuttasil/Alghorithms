using System;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" + isPrime(67));
        }

        private static bool isPrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
