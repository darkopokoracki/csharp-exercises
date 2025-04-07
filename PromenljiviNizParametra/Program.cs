using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PromenljiviNizParametra
{
    internal class Program
    {

        public static void MetodaParams(params int[] promenljiviBrojParametara) 
        {
            for (int i = 0; i < promenljiviBrojParametara.Length; i++)
            {
                Console.Write(promenljiviBrojParametara[i]);
            }
            Console.WriteLine();
        }
            
        static void Main(string[] args)
        {
            MetodaParams(1, 2, 3, 4, 5);
            MetodaParams(1, 2, 3, 4, 5, 6, 7, 8, 9);
            MetodaParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            MetodaParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

            int[] myArray = new int[3];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;

            MetodaParams(myArray);
        }
    }
}
