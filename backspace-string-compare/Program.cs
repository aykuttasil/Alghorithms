using System;
using System.Collections;
using System.Collections.Generic;
/*
Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.

Example 1:

Input: S = "ab#c", T = "ad#c"
Output: true
Explanation: Both S and T become "ac".
Example 2:

Input: S = "ab##", T = "c#d#"
Output: true
Explanation: Both S and T become "".
Example 3:

Input: S = "a##c", T = "#a#c"
Output: true
Explanation: Both S and T become "c".
Example 4:

Input: S = "a#c", T = "b"
Output: false
Explanation: S becomes "c" while T becomes "b".
Note:

1 <= S.length <= 200
1 <= T.length <= 200
S and T only contain lowercase letters and '#' characters.
Follow up:

Can you solve it in O(N) time and O(1) space?
*/
namespace backspace_string_compare
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "a##c";
            var t = "#a#c";
            Console.WriteLine("s == t: " + BackspaceCompare(s, t));
        }

        // Solution 2
        public static bool BackspaceCompare1(string S, string T)
        {
            return true;
        }

        // Solution 1
        public static bool BackspaceCompare(string S, string T)
        {
            Stack<Char> stackS = new Stack<Char>();
            Stack<Char> stackT = new Stack<Char>();

            for (int i = 0; i < S.ToCharArray().Length; i++)
            {
                var c = S[i];
                if (c == '#')
                {
                    if (stackS.Count > 0)
                    {
                        stackS.Pop();
                    }
                }
                else
                {
                    stackS.Push(S[i]);
                }
            }


            for (int i = 0; i < T.ToCharArray().Length; i++)
            {
                var c = T[i];
                if (c == '#')
                {
                    if (stackT.Count > 0)
                    {
                        stackT.Pop();
                    }
                }
                else
                {
                    stackT.Push(T[i]);
                }
            }

            var stringS = "";
            foreach (var item in stackS)
            {
                stringS += item;
            }


            var stringT = "";
            foreach (var item in stackT)
            {
                stringT += item;
            }


            return stringS == stringT;
        }
    }
}
