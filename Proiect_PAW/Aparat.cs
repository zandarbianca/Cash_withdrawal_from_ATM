using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Aparat
    {
        private int id;
        private string locatie;
        private string stare;
        public Aparat() { id = 0; locatie = "Necunoscuta"; stare = "Necunoscuta"; }
        public Aparat(int id_,string locatie_,string stare_)
        {
            id = id_;
            locatie = locatie_;
            stare = stare_;
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
        public string Stare
        {
            get { return stare; }
            set { stare = value; }
        }
        public override string ToString()
        {
            return "Id: " + id + "  Locatie: " + locatie + "  Stare: " + stare;
        }
    }
}
