using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Aparat
    {
        private int id;
        private string locatie;
        private long suma;

        Aparat() { id = 0; locatie = "Necunoscuta";  suma = 0; }
        Aparat(int id_,string locatie_,long suma_)
        {
            id = id_;
            locatie = locatie_;
            suma = suma_;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }
        public long Suma
        {
            get { return suma; }
            set { suma = value; }
        }
    }
}
