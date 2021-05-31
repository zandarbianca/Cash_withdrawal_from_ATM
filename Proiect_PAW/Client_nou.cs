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
    public partial class Client_nou : Form
    {
        public Client_nou()
        {
            InitializeComponent();
        }
        //butoane curatare
        private void button2_Click(object sender, EventArgs e)
        {
            tbNume.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tbPrenume.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tbAdresa.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tbIban.Clear();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            tbUser.Clear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tbPass.Clear();
        }
        //butoane salvare
        private void btnSalvare1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }
        private void btnSalvare2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btnVerificare.Enabled = true;
        }
        //butoane pannel jos
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true; groupBox2.Enabled = true;
            btnVerificare.Enabled = false;
            btnCreare.Enabled = true;
            btnSalvare1.Enabled = false;
            btnSalvare2.Enabled = false;
        }

       // /////////////////////////////////////////////////// //
        private void Client_nou_Load(object sender, EventArgs e)
        {
            btnCreare.Enabled = btnVerificare.Enabled = false;
        }

        private void inserare_tr()
        {
            // Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =| DataDirectory |\DatabaseAngajati.mdf; Integrated Security = True
            SqlConnection conec = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=clienti;Integrated Security=True");


            try
            {
                conec.Open();
                

                SqlCommand command = new SqlCommand("insert into Clienti (Nume_cl,Prenume_cl,Iban_cl,Suma_cl,Adresa_cl,User_cl,Pass_cl)" +
                    " values ('"+ tbNume.Text +"','" + tbPrenume.Text + "','" + tbIban.Text + "','" + 0 + "','" + tbAdresa.Text + "','"+tbUser.Text + "','"+ tbPass.Text+ "')", conec);
                command.ExecuteNonQuery();
                conec.Close();
                MessageBox.Show("Ati fost inregsitrat in baza de date");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreare_Click(object sender, EventArgs e)
        {
            inserare_tr();
        }
    }
}
