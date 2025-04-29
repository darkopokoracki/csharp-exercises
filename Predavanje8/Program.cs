using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje8
{

    public delegate void DelegateIspis(string poruka);
    public delegate int Operacija(int a, int b);
    public delegate void Notifikacija(string poruka);
    public delegate void DelegatePrag(string portuka);


    class MojaKlasa
    {
        public event EventHandler mojDogadjaj;

        public void PokreniDogadjaj()
        {
            mojDogadjaj?.Invoke(this, EventArgs.Empty);
        }
    }
    class Brojac
    {
        int stanje;
        int prag;
        public event DelegatePrag dogadjaj;

        public Brojac(int prag)
        {
            this.prag = prag;
        }

        public void Inkrementiraj()
        {
            this.stanje++;
            Console.WriteLine($"Trenutno stanje je: {this.stanje}");
            if (this.stanje >= this.prag )
            {
                dogadjaj?.Invoke("Dosegnut je prag!");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            MojaKlasa mk = new MojaKlasa();
            mk.mojDogadjaj += AkcijaNaMojDogadjaj;
            mk.PokreniDogadjaj();

            Brojac br = new Brojac(3);
            br.dogadjaj += Br_dogadjaj;
            br.Inkrementiraj();
            br.Inkrementiraj();
            br.Inkrementiraj();


            DelegateIspis del = new DelegateIspis(Ispis);
            del("Hello World");

            del = Ispis2;
            del("Ovo je druga poruka");


            Operacija op = new Operacija(Saberi);
            int rez = op(5, 6);
            Console.WriteLine($"Sabrani brojevi: {rez}");

            op = Pomnozi;

            rez = op(5, 6);
            Console.WriteLine($"Rezultat mnozenja: {rez}");

            Notifikacija notify = new Notifikacija(NotifikujPrekoMaila);
            notify += NotifikujPrekoSms;

            notify("Vazno obavestenje!!");

        }

        private static void AkcijaNaMojDogadjaj(object sender, EventArgs e)
        {
            Console.WriteLine("Desio se dogadjaj");
        }

        private static void Br_dogadjaj(string portuka)
        {
            Console.WriteLine(portuka);
        }

        static void NotifikujPrekoMaila(string poruka)
        {
            Console.WriteLine($"Notifikacija preko maila: {poruka}");
        }

        static void NotifikujPrekoSms(string poruka)
        {
            Console.WriteLine($"Notifikacija preko sms: {poruka}");
        }

        static int Saberi(int a, int b)
        {
            return a + b;
        }

        static int Pomnozi(int a, int b)
        {
            return a * b;
        }

        static void Ispis(string poruka)
        {
            Console.WriteLine($"Ispis: {poruka}");
        }

        static void Ispis2(string msg)
        {
            Console.WriteLine($"Ispis2: {msg}");
        }
    }
}
