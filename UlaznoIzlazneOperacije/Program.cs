using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UlaznoIzlazneOperacije
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter sw = new StreamWriter("Greeting.txt"))
            {
                sw.WriteLine("Hello World!");
                sw.WriteLine("Zdravo svete!");
            }

            using (StreamReader sr = new StreamReader("Greeting.txt"))
            {
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}
