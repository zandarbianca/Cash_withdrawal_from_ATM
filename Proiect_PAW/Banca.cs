using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Banca
    {
        List<Aparat> listaAparate;

        public Banca()
        {
            listaAparate = new List<Aparat>();
            listaAparate.Add(new Aparat(1, "Alexandria, Str. Liberatii", "Functionala"));
            listaAparate.Add(new Aparat(2, "Alexandria, Str. Renasterii", "Functionala"));
            listaAparate.Add(new Aparat(3, "Alexandria, Str. 1 Mai", "Functionala"));
        }



    }



}
