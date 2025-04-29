using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serijalizacija
{
    [Serializable]
    public class Osoba: IDeserializationCallback
    {
        public string ime;
        public string prezime;
        public DateTime datumjRodjenja;
        [NonSerialized] public int starost;

        public Osoba(string ime, string prezime, DateTime datumjRodjenja, int starost)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumjRodjenja = datumjRodjenja;
            this.starost = starost;
        }

        public void OnDeserialization(object sender)
        {
            racunajStarost();
        }

        private void racunajStarost()
        {
            
        }
    }
}
