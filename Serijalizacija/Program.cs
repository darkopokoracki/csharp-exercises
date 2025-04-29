using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (FileStream fs = new FileStream("osobaBinarna.dat", FileMode.Create))
            {
                Osoba os1 = new Osoba("Memphis", "Depay", new DateTime(2000, 10, 15), 24);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, os1);
            }

            using (FileStream fs = new FileStream("osobaBinarna.dat", FileMode.Open))
            {
                Osoba o1;
                BinaryFormatter bf = new BinaryFormatter();
                o1 = (Osoba) bf.Deserialize(fs);
                Console.WriteLine($"Deserijalizovan objekat: {o1.ime}");
            }

                Console.ReadLine();
        }
    }
}
