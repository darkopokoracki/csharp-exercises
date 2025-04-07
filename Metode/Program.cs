using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode
{

    class Radnik
    {
        private string ime;
        private string prezime;
        private double plata;
        public Radnik(string ime, string prezime, double plata)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.plata = plata;
        }

        //public string predstaviSe(string imeRadnika, string prezimeRadnika, double plataRadnika)
        //{
        //    return $"{imeRadnika} {prezimeRadnika} ima platu {plataRadnika}";
        //}

        public static string predstaviSe(string imeRadnika, string prezimeRadnika, double plataRadnika)
        {
            return $"{imeRadnika} {prezimeRadnika} ima platu {plataRadnika}";
        }
        public int zbir(int a, int b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Radnik r1 = new Radnik("Marko", "Markovic", 100000);
            // r1.predstaviSe("Marko", "Markovic", 100000);

            Console.WriteLine(Radnik.predstaviSe("Marko", "Markovic", 100000));
        }
    }
}
