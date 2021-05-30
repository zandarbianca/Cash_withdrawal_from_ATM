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
    public partial class Ang_ATM_bd_cl : Form
    {
        public Ang_ATM_bd_cl()
        {
            InitializeComponent();
        }

        private void Ang_ATM_bd_cl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAngajatiDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.databaseAngajatiDataSet.Angajati);

        }
    }
}
