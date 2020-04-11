using System;
using System.Collections.Generic;

/*
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

push(x) -- Push element x onto stack.
pop() -- Removes the element on top of the stack.
top() -- Get the top element.
getMin() -- Retrieve the minimum element in the stack.
 

Example:

MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> Returns -3.
minStack.pop();
minStack.top();      --> Returns 0.
minStack.getMin();   --> Returns -2.
 

   Hide Hint #1  
Consider each node in the stack having a minimum value. (Credits to @aakarshmadhavan)
*/
namespace min_stack
{

    class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.push(-2);
            minStack.push(0);
            minStack.push(-3);
            Console.WriteLine("min: " + minStack.getMin()); // --> Returns - 3.
            minStack.pop();
            Console.WriteLine("top: " + minStack.top()); // --> Returns 0.
            Console.WriteLine("min: " + minStack.getMin()); ; // --> Returns - 2.
        }


        public class MinStack
        {
            LinkedList<int> ll = new LinkedList<int>();
            int min = 0;

            public MinStack()
            { }

            public void push(int x)
            {
                ll.AddLast(x);
                if (x <= min)
                {
                    min = x;
                }
            }

            public void pop()
            {
                ll.RemoveLast();
            }

            public int top()
            {
                return ll.Last.Value;
            }

            public int getMin()
            {

                var node = ll.First;
                var m = node.Value;
                while (node != null)
                {
                    if (node.Value <= m)
                    {
                        m = node.Value;
                    }
                    node = node.Next;
                }
                return m;
            }
        }

        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(x);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */

    }
}
