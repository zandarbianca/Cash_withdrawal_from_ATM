using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//<div>Icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a></div>
namespace Proiect_PAW
{
    public class Clienti
    {
        private string nume;
        private string prenume;
        private long iban;
        private int suma;
        private string adresa;
        public Clienti()
        {
            nume = "necunoscut"; prenume = "necunoscut"; iban = 0; adresa = "-"; suma = 0;
        }
        public Clienti(string nume_, string prenume_, long iban_)
        {
            nume = nume_;
            prenume = prenume_;
            iban = iban_;
        }
        public Clienti(string nume_,string prenume_,long iban_,int suma_,string adresa_)
        {
            nume = nume_;
            prenume = prenume_;
            iban = iban_;
            suma = suma_;
            adresa = adresa_;
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }
        public long Iban
        {
            get { return iban; }
            set { iban = value; }
        }
        public int Suma
        {
            get { return suma; }
            set { suma = value; }
        }
        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
    }
}
