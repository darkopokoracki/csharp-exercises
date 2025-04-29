using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "       Fly me   to   the moon     ";

            Console.WriteLine($"Length od Last Word is: {LengthOfLastWord(s)}");
        }

        public static int LengthOfLastWord(string s)
        {
            string[] splitedString = s.Trim().Split(' ');
            // string lastWord = splitedString[splitedString.Length - 1];
            string lastWord = splitedString.Last();
            return lastWord.Length;
        }
    }
}
