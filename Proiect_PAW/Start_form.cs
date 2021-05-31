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
            la.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Clienti lc = new Login_Clienti();
            lc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client_nou cn = new Client_nou();
            cn.Show();
            this.Hide();
        }

        private void Start_form_Load(object sender, EventArgs e)
        {

        }
    }
}
