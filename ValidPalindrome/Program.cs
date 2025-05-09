using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "A man, a plan, a canal: Panama";
            Console.WriteLine($"Is valid palindrome: {IsPalindrome(sentence)}");
        }

        public static bool IsPalindrome(string s)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            Regex empt = new Regex(@"\s+");
            string str = rgx.Replace(s, "");
            string withoutSpace = empt.Replace(str, "");
            string finalString = withoutSpace.ToLower();

            for (int i = 0; i < finalString.Length; i++)
            {
                if (finalString[i] != finalString[finalString.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
