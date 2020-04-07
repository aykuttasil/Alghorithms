using System;
using System.Collections;
using System.Collections.Generic;


/*
Given an array of strings, group anagrams together.

Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]

Note:

All inputs will be in lowercase.
The order of your output does not matter.
*/
namespace group_anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat", "ill", "duh" };
            //Console.WriteLine("eat:" + HashFunction("duh"));
            //Console.WriteLine("tea:" + HashFunction("ill"));

            var ll = GroupAnagrams1(strs);
            var a = "a";
        }


        public static IList<IList<string>> GroupAnagrams1(string[] arr)
        {
            var result = new List<IList<string>>();
            Dictionary<String, List<String>> map = new Dictionary<String, List<String>>();

            // loop over all words 
            for (int i = 0; i < arr.Length; i++)
            {

                // convert to char array, sort and 
                // then re-convert to string 
                String word = arr[i];
                char[] letters = word.ToCharArray();
                Array.Sort(letters);
                String newWord = new String(letters);

                // calculate hashcode of string 
                // after sorting 
                if (map.ContainsKey(newWord))
                {
                    map[newWord].Add(word);
                }
                else
                {

                    // This is the first time we are 
                    // adding a word for a specific 
                    // hashcode 
                    List<String> words = new List<String>();
                    words.Add(word);
                    map.Add(newWord, words);
                }
            }

            foreach (var item in map.Keys)
            {
                result.Add(map[item]);
            }

            return (IList<IList<string>>)result;

        }

        // Hash fonksiyonu sıkıntıl. duh ve ill aynı hash değerini veriyor
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new List<IList<string>>();
            Dictionary<int, List<string>> hashMap = new Dictionary<int, List<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var word = strs[i];
                var hashWord = HashFunction(word);
                // Console.WriteLine(strs[i] + ":" + HashFunction(strs[i]));

                if (hashMap.ContainsKey(hashWord))
                {
                    var currentList = hashMap[hashWord];
                    currentList.Add(strs[i]);

                    hashMap[hashWord] = currentList;
                }
                else
                {
                    hashMap[hashWord] = new List<string>() { strs[i] };
                }

            }

            foreach (var item in hashMap.Keys)
            {
                result.Add(hashMap[item]);
            }

            return (IList<IList<string>>)result;
        }

        static int HashFunction(string s)
        {
            long total = 0;
            char[] c;
            c = s.ToCharArray();
            for (int k = 0; k < c.Length; k++)
            {
                var ascii = (int)c[k];
                Console.WriteLine(c.ToString() + ":" + ascii);
                total += ascii;
            }

            return (int)total;
        }
    }
}
