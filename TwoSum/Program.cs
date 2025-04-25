using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 7, 11, 2, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            Console.WriteLine("Result: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Indices {i + 1}: {result[i]}");
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] indices = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        indices[0] = i;
                        indices[1] = j;
                        break;
                    }
                }
            }

            return indices;
        }
    }
}

