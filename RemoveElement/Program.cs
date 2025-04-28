using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;

            int notEqualToVal = RemoveElement(nums, val);
            Console.WriteLine($"Not Equal to val: {notEqualToVal}");
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
