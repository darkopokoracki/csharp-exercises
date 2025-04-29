using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 3, 2, 2, 3 };
            nums[0] = 2;
            nums[1] = 2;

            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
