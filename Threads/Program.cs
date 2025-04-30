using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Thread thread = new Thread(MojaMetoda);
            thread.Start();
            Thread thread1 = new Thread(MojaMetoda);
            thread1.Start();
            Thread thread2 = new Thread(MojaMetoda);
            thread2.Start();
            Thread thread3 = new Thread(() =>
            {
                Console.WriteLine("With Lambda");
                Thread.Sleep(3000);
            });
            thread3.Start();

            thread.Join();
            thread1.Join();
            thread2.Join();
            thread3.Join();

            stopwatch.Stop();
            Console.WriteLine($"Finish!, {stopwatch.ElapsedMilliseconds} ms");


        }

        static void MojaMetoda()
        {
            Console.WriteLine("Pokrenuta je metoda");
            Thread.Sleep(3000);
        }
    }
}
