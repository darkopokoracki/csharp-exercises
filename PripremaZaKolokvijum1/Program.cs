using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Napravicemo ATM machine simulaciju koja simulira podizanje para sa racuna i uplacivanje
// Potrebne su nam 2 klase za tekuci i devizni racun
// Imacemo aprstrktnu klasu koja sadrzi sve sto je zajednicko za obe
// Imacemo Interfejs koji ce nma sluziti da se odredjene stvari u klasama koje ga implmentiraju zapravo ostvare
// Omoguci da budu razlicite provizije u zavisnosti od deviznog ili tekuceg

namespace PripremaZaKolokvijum1
{

    public interface IRacun
    {
        // ovde nemamo access modifier zato sto su svi public po defaultu
        void IsplatiSaRacuna(double iznos);
        void UplatiNaRacun(double iznos);
        string VratiPodatkeORacunu();
        double VratiStanje();
    }

    public abstract class ApstraktniRacun: IRacun
    {
        private double stanje;
        private string brojRacuna;

        public ApstraktniRacun(string brojRacuna, double pocetnoStanje)
        {
            this.stanje = pocetnoStanje;
            this.brojRacuna = brojRacuna;
        }

        public ApstraktniRacun(string brojRacuna): this(brojRacuna, 0)
        {

        }

        public double VratiStanje()
        {
            return stanje;
        }

        public void IsplatiSaRacuna(double iznos)
        {
            stanje -= iznos + ProvizijaNaIsplatu(iznos);
        }

        public void UplatiNaRacun(double iznos)
        {
            stanje += iznos + ProvizijaNaUplatu(iznos);
        }

        public virtual string VratiPodatkeORacunu()
        {
            string podaci = $"Racun broj {brojRacuna} ima iznos {stanje}";
            return podaci;

        }

        protected abstract double ProvizijaNaUplatu(double iznos);
        protected abstract double ProvizijaNaIsplatu(double iznos);
    }

    public class TekuciRacun: ApstraktniRacun
    {
        public TekuciRacun(string brojRacuna): base(brojRacuna)
        { }

        public TekuciRacun(string brojRacuna, double pocetnoStanje): base(brojRacuna, pocetnoStanje)
        { }

        protected override double ProvizijaNaUplatu(double iznos)
        {
            return 0;
        }

        protected override double ProvizijaNaIsplatu(double iznos)
        {
            double obracunataProvizija = 100 + (iznos * 3 / 100);
            return obracunataProvizija;
        }

        public override string VratiPodatkeORacunu()
        {
            return base.VratiPodatkeORacunu() + "\nTip racuna: TEKUCI";
        }
    }

    public class DevizniRacun: ApstraktniRacun
    {
        public DevizniRacun(string brojRacuna): base(brojRacuna)
        { }

        public DevizniRacun(string brojRacuna, double pocetnoStanje): base(brojRacuna, pocetnoStanje)
        { }

        protected override double ProvizijaNaUplatu(double iznos)
        {
            double obracunataProvizija = 100 + (iznos * 5 / 100);
            return obracunataProvizija;
        }

        protected override double ProvizijaNaIsplatu(double iznos)
        {
            double obracunataProvizija = 100 + (iznos * 5 / 100);
            return obracunataProvizija;
        }

        public override string VratiPodatkeORacunu()
        {
            return base.VratiPodatkeORacunu() + "\nTip racuna: DEVIZNI";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ApstraktniRacun[] racuni = new ApstraktniRacun[4];
            // Probaj da koristis i neki drugi dataType.
            // Probaj ulancavnaje konstruktora
            // Dodaj jos neke validacije u funkcijama
            // Sve ovo upisi u neki tekst fajl (.txt file)

            racuni[0] = new TekuciRacun("123-456", 0);
            racuni[1] = new DevizniRacun("287-142", 0);
            racuni[2] = new DevizniRacun("842-654", 1000);
            racuni[3] = new TekuciRacun("842-654", 25000);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Uplata na " + i + ". racun u iznosu od 1000");
                racuni[i].UplatiNaRacun(1000);
                Console.WriteLine("Isplata sa " + i + ". racuna u iznosu od 500");
                racuni[i].IsplatiSaRacuna(500);
                Console.WriteLine("Uplata na " + i + ". racun u iznosu od 3000");
                racuni[i].UplatiNaRacun(3000);
                Console.WriteLine("Isplata sa " + i + ". racun u iznosu od 1500");
                racuni[i].IsplatiSaRacuna(1500);
                Console.WriteLine("Podaci o racunu posle uplate: \n" + racuni[i].VratiPodatkeORacunu());
                Console.WriteLine();
            }
        }
    }
}
