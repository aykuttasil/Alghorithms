using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace string_calc
{
    class Program
    {
        /*
            3+1-(5-4) = 3
         */
        static void Main(string[] args)
        {
            var value = "3+1-(5-4)";
            calc(value);
        }

        static int calc(string value)
        {
            var valueArray = value.ToCharArray();
            // Console.WriteLine(valueArray[0]);

            var valueStack = new Stack<char>();
            foreach (var item in value)
            {
                valueStack.Push(item);
            }

            foreach (var item in valueArray)
            {
                if (int.TryParse(item.ToString(), out int number))
                {
                    Console.WriteLine(number.ToString());
                }
            }

            return 1;
        }


    }
}
