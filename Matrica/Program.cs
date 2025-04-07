using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrica
{

    class Matrix
    {
        static Matrix()
        {
            Console.WriteLine("This will Execute first");
        }

        public Matrix(int rows, int columns)
        {
            Console.WriteLine("This will Execute after because static constructor is always first!");
            
            int[,] matrix = new int[rows, columns];
            matrix[0, 0] = 1;
            matrix[1, 0] = 2;
            matrix[2, 0] = 3;
            matrix[0, 1] = 4;
            matrix[1, 1] = 5;
            matrix[2, 1] = 6;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"{i} and {j}");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 2);
        }
    }
}
