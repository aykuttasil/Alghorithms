using System;
using System.Collections.Generic;

namespace unique_email_addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new String[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };
            var sonuc = NumUniqueEmails(arr);
            Console.WriteLine("Sonuc: " + sonuc);

        }

        public static int NumUniqueEmails(string[] emails)
        {
            var map = new HashSet<String>();
            for (int i = 0; i < emails.Length; i++)
            {
                var email = emails[i];
                var parts = email.Split("@");
                var name = parts[0].Replace(".", "");
                if (name.Contains("+"))
                {
                    name = name.Split("+")[0];
                }
                var domain = parts[1];
                map.Add(name + "@" + domain);
            }
            return map.Count;
        }

    }
}
