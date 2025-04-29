using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfTheFirstOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haystack = "sadbutsad";
            string needle = "sad";

            Console.WriteLine($"Index of the first occuracne is: {StrStr(haystack, needle)}");
        }

        public static int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
