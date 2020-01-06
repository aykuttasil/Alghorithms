using System;

namespace maximize_sum_of_array_after_k_negotions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = new int[3]{1,2,3};

            int abc = 10;
            Console.WriteLine(abc++);
            Console.WriteLine(abc);

            Console.WriteLine("----------");

            abc = 10;
            Console.WriteLine(++abc);
            Console.WriteLine(abc);

            Console.WriteLine("----------");



            for(int a = 0 ; a < arr.Length ; ++a)
            {
                Console.WriteLine(a.ToString());
            }

            Console.WriteLine("----------");

            for(int a = 0 ; a < arr.Length ; a++)
            {
                Console.WriteLine(a.ToString());
            }

            
            Console.WriteLine("----------");

            abc = 3;
            int q = 0;
            while(q < abc--){
                Console.WriteLine(abc);
            }

            Console.WriteLine("----------");
            
            abc = 3;
            q = 0;
            while(q < --abc){
                Console.WriteLine(abc);
            }

        }
    }
}
