using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Aparate_ATM : Form
    {
        List<Aparat> listaAparate;
        public Aparate_ATM()
        {
            InitializeComponent();
            listaAparate = new List<Aparat>();
            listaAparate.Add(new Aparat(1, "Alexandria, Str. Liberatii", "Functionala"));
            listaAparate.Add(new Aparat(2, "Alexandria, Str. Renasterii", "Functionala"));
            listaAparate.Add(new Aparat(3, "Alexandria, Str. 1 Mai", "Functionala"));
            actualizeazaLista();
        }
        public void actualizeazaLista()
        {
            lv.Items.Clear();
            foreach (Aparat past in listaAparate)
            {
                ListViewItem item = new ListViewItem(past.Id.ToString());
                item.SubItems.Add(past.Locatie);
                item.SubItems.Add(past.Stare);
                lv.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("FisierAparate.txt", FileMode.Create, FileAccess.Write);
            StreamWriter x = new StreamWriter(f);
            foreach (Aparat p in listaAparate)
            {
                x.WriteLine(p.ToString());
            }
            x.Close();
            f.Close();
        }
    }
}
