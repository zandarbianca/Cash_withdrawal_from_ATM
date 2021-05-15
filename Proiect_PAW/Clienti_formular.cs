using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Clienti_formular : Form
    {
        public Clienti_formular()
        {
            InitializeComponent();
        }

        private void btnModificaDate_Click(object sender, EventArgs e)
        {
            Modifica_date m1 = new Modifica_date();
            m1.ShowDialog();
        }

        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
