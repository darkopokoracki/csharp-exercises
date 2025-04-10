using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1:
            // Write a C# program to compute the sum of the two numerical values entered by user.
            // If the two values are the same, return a triple their sum.

            /*
            int sum;

            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                sum = (number1 + number2) * 3;
            }
            else
            {
                sum = number1 + number2;
            }

            Console.WriteLine($"Result is: {sum}");
            */


            // Exercise 2
            // Do the same using ternary operator

            /*
            int sum;

            Console.WriteLine("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            sum = number1 == number2 ? (number1 + number2) * 3 : number1 + number2;

            Console.WriteLine($"Result is: {sum}");
            */


            // Exercise 3
            // Print number staring from 1 to 100. When number is multiple of 3, print "fizz instead of a number
            // If number is multiple of 5 print "Buzz". With 3 and 5 with fizzBuzz

            /*
            for (int i = 1; i < 101; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
            */


            // Ecercise 4
            // Count the number of time character 'a' appears in a given string

            /*
            Console.WriteLine("Enter some sentence to find how many a character is in the text: ");
            string sentence = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < sentence.Length; i++) {
                if (sentence[i] == 'a')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Number of letter a = {counter}");
            */


            // Exercise 5
            // Write a program to make a square-like pattern of asteriks

            /*
            Console.WriteLine("Enter the size of square: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            */


            // Exercise 6
            // Write a program to display piramid-like pattern of asteriks and each row contain an odd number of asteriks

            /*    *
                 ***
                ***** 
            */

            /*
            Console.WriteLine("Enter a number of rows for your piramid-like pattern: ");
            int sizeOfPiramid = int.Parse(Console.ReadLine());

            for (int i = 0; i < sizeOfPiramid; i++)
            {
                
                for (int j = i; j < sizeOfPiramid; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */


            // Exercise 7
            //  Same as previous but this time diamond shape.
            /*
               * 
              ***
             *****
              ***
               *
            */

            /*
            Console.WriteLine("Enter the size of diamond shape, in rows: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++) 
            {  
                for (int j = i; j < size; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = size - 1; i >= 1; i--)
            {
                for (int j = size; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */


            // Ex 8
            // 5! = 5 * 4 * 3 * 2 * 1 = 120

            /*
            public int FaktorijelNerekurzivno(int y)
            {
                if (y == 0)
                {
                    return 1;
                }
                else
                {
                    int faktorijel = 1;

                    for (int i = y; i >= 1; i--)
                    {
                        faktorijel = faktorijel * i;
                    }

                    return faktorijel;
                }
            }
            static int FaktorijelRekurzivno(int x)
            {
                if (x == 0)
                    return 1;
                else
                    return x * FaktorijelRekurzivno(x - 1);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Faktorijel Nerekurzivno od broja 5 je: {0}", FaktorijelNerekurzivno(5).ToString());
                Console.WriteLine("Faktorijel Rekurzivno od broja 5 je: {0}", FaktorijelRekurzivno(5).ToString());
            }

            */

            // Exercise 9: Write code that will show time difference execution between string type and stringBuilder.


            /*
            var watch = new System.Diagnostics.Stopwatch();

            string exampleString1 = "John";

            watch.Start();

            for (int i = 0; i < 100000; i++)
            {
                exampleString1 += "Doe";
            }

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            */

            /*
            var watch = new System.Diagnostics.Stopwatch();

            StringBuilder exampleString2 = new StringBuilder("John");

            watch.Start();


            for (int i = 0; i < 100000000; i++)
            {
                exampleString2.Append("Doe");
            }

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            */

            // Just to check:
            /*
            string x = "John";

            for (int i = 0; i < 10; i++)
            {
                x += "Doe";
            }

            Console.WriteLine(x);
            */

            /*
            StringBuilder x = new StringBuilder("John");

            for (int i = 0; i < 10; i++)
            {
                x.Append("Doe");
            }

            Console.WriteLine(x);
            */


            // Exercise 10:
            // Find minimum and maximum number of given array of numbers.

            /*
            int[] numbers = { 5, 100, 4, 6, 8, 19, -4, 130, -7, 222, 8 };

            int min = 0; int max = 0;

            for (int i = 0; i < numbers.Length; i++) 
            { 
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"Maximum is: {max}");
            Console.WriteLine($"Minimum is: {min}");
            */

            // Exercise 11: Lists
            // *Make a list for storing football players. At the beginning add 2 players
            // *Add 1 player with Add method
            // *Make an array with 3 players and add to the list.
            // *With remove, remove one name from the list
            // remove range and make list what elements you will remove.
            // also remove at position 2
            // console all names with forearch loop.
            // With contains check if "Wayne Rooney" is in the list
            // console number of elements and console second element




            List<string> players = new List<string>()
            {
                "Wayne Rooney",
                "Cristiano Ronaldo"
            };
            players.Add("Lionel Messi");

            string[] playersArray = { "Pablo Dybala", "David De Gea", "Nemanja Vidic" };

            players.AddRange(playersArray);
            players.Remove("Cristiano Ronaldo");
            players.RemoveRange(2, 2);
            players.RemoveAt(2);

            foreach (string player in players)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine($"Second player is: {players[1]}");
            Console.WriteLine($"Is Wayne Rooney in the list? --> {players.Contains("Wayne Rooney")}");
            


        }
    }
}
