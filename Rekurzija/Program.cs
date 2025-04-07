using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekurzija
{
    internal class Program
    {
        // !5 = 5 * 4 * 3 * 2 * 1
        public static int FactorialNonRecursive(int n)
        {
            int factorijel = 1;

            for (int i = n; i > 0; i--)
            {
                factorijel *= i;
            }

            return factorijel;
        }

        public static int FactorialRecursive(int n)
        {
            if (n == 0)
                return 1;

            return n * FactorialRecursive(n - 1);


        }
        static void Main(string[] args)
        {

            // 1. Write down a method that gives factorial of a given number non-recursively
            // 2. Write down a method that gives factorial of a given number recursively
            Console.WriteLine(FactorialNonRecursive(7));
            Console.WriteLine(FactorialRecursive(5));

        }
    }
}
