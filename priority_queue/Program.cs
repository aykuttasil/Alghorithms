using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace priority_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // PriorityQueue<Integer> pQueue = new PriorityQueue<Integer>();
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>(new Comparer());
            sd.Add(1, "ABC1");
            sd.Add(2, "ABC2");
            sd.Add(9, "ABC9");
            sd.Add(3, "ABC3");
            sd.Add(4, "ABC4");
            sd.Add(0, "ABC0");


            Console.WriteLine("---------");
            // Console.WriteLine("value: " + sd.GetValueOrDefault(2));

            
            foreach (KeyValuePair<int,string> item in sd)
            {                
                Console.WriteLine("k:" + item.Key + " - value:" + item.Value);
            }        
            
        }


        class Comparer : IComparer<int>
        {
            public int Compare([AllowNull] int x, [AllowNull] int y)
            {
                Console.WriteLine("x:" + x);
                Console.WriteLine("y:" + y);
                return x - y;
            }
        }
    }
}
