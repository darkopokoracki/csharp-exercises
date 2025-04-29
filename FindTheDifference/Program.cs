using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            string t = "adcbe";
            Console.WriteLine($"Difference is: {FindTheDifference(s, t)}");
        }

        public static char FindTheDifference (string s, string t)
        {
            char diff;

            foreach(char c in t)
            {
                foreach(char c2 in s)
                {
                    if (c == c2)
                        continue;

                    diff = c; break;
                }
            }
            
            return diff;
        }

    }
}
