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
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
        }

        private void btnAngajat_Click(object sender, EventArgs e)
        {
            Login_Angajat la = new Login_Angajat();
            la.ShowDialog();
            this.Hide();
        }
    }
}
