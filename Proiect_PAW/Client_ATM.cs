using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect_PAW
{
    public partial class Client_ATM : Form
    {
       
        public Client_ATM(int x)
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
        //Infromatii client
        private void button1_Click(object sender, EventArgs e)
        {    
            openChildForm(new Informatii_cont_form());
        }
        //Depunere numerar
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        //Extragere numerar
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Extragere_Form());
        }
        //Inchide
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //istoric tranzactii
        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
