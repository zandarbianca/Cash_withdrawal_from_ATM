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
    public partial class Angajat_ATM : Form
    {
        public Angajat_ATM()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Ang_ATM_bd_cl());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Baza_date_tranzactii());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Aparate_ATM());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
