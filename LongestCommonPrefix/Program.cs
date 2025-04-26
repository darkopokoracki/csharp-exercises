using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };

            string longestPrefix = LongestCommonPrefix(strs);
            Console.WriteLine($"Longest prefix: {longestPrefix}");
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (!strs[i].StartsWith(prefix))
                {
                    if (prefix.Length == 0)
                        return "";
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            return prefix;
        }
    }
}
