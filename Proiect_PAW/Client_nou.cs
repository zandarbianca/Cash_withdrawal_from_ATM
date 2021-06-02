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
            groupBox2.Enabled = true;
        }
        private void btnSalvare2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
           
            if (select() == false)
            {
                MessageBox.Show("User-ul deja exista!");
                groupBox2.Enabled = true;
                btnVerificare.Enabled = false;
                tbUser.Clear();
            }
            else
            {
                btnVerificare.Enabled = true;
            }

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
            groupBox2.Enabled = false;
        }
        private void inserare_tr()
        {
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
            tbNume.Clear(); tbPrenume.Clear(); tbAdresa.Clear(); tbIban.Clear(); tbUser.Clear(); tbPass.Clear();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Start_form sf = new Start_form();
            sf.Show();
            this.Hide();
        }
        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }
        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            String nume = tbNume.Text;

            if (String.IsNullOrEmpty(nume) ||
                String.IsNullOrWhiteSpace(nume) ||
                nume.Length < 2)
            {
                epNume.SetError((Control)sender, "Numele trebuie să conțină cel puțin 2 caractere.");
                e.Cancel = true;
            }
        }
        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            epPrenume.Clear();
        }
        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            String prenume = tbPrenume.Text;

            if (String.IsNullOrEmpty(prenume) ||
                String.IsNullOrWhiteSpace(prenume) ||
                prenume.Length < 2)
            {
                epNume.SetError((Control)sender, "Prenumele trebuie să conțină cel puțin 2 caractere.");
                e.Cancel = true;
            }
        }
        private void tbAdresa_Validated(object sender, EventArgs e)
        {
            epAdresa.Clear();
        }
        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            String adresa = tbAdresa.Text;

            if (String.IsNullOrEmpty(adresa) ||
                String.IsNullOrWhiteSpace(adresa) ||
                adresa.Length < 5)
            {
                epNume.SetError((Control)sender, "Adresa trebuie să conțină cel puțin 5 caractere.");
                e.Cancel = true;
            }
        }
        private void tbIban_Validated(object sender, EventArgs e)
        {
            epIban.Clear();
        }
        private void tbIban_Validating(object sender, CancelEventArgs e)
        {
            String iban = tbIban.Text;

            if (String.IsNullOrEmpty(iban) ||
                String.IsNullOrWhiteSpace(iban) ||
                iban.Length < 13 || iban.Length>15 )
            {
                epNume.SetError((Control)sender, "Ibanul trebuie să conțină 14 caractere, iar primele 2 sa fie RO.");
                e.Cancel = true;
            }
        }
        private void tbUser_Validated(object sender, EventArgs e)
        {
            epUser.Clear();
        }
        private void tbUser_Validating(object sender, CancelEventArgs e)
        {
            String user = tbUser.Text;

            if (String.IsNullOrEmpty(user) ||
                String.IsNullOrWhiteSpace(user) ||
                user.Length < 3)
            {
                epNume.SetError((Control)sender, "Userul exista deja sau are mai putin de 3 caractere!");
                e.Cancel = true;
            }
        }
        private void tbPass_Validated(object sender, EventArgs e)
        {
            epPass.Clear();
        }
        private void tbPass_Validating(object sender, CancelEventArgs e)
        {
            String pass = tbPass.Text;

            if (String.IsNullOrEmpty(pass) ||
                String.IsNullOrWhiteSpace(pass) ||
                pass.Length < 3)
            {
                epNume.SetError((Control)sender, "Parola trebuie să conțină cel puțin 3 caractere.");
                e.Cancel = true;
            }
        }

        public bool select()
        {
            SqlConnection c = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=clienti;Integrated Security=True");
            c.Open();
            string select = "select * from Clienti";
            SqlCommand cmd = new SqlCommand(select, c);
            SqlDataReader r = cmd.ExecuteReader();
          
            bool ok = true;
            while (r.Read())
            {
                if (String.Compare(tbUser.Text, r[6].ToString().Trim()) == 0)
                {
                    ok = false;
                    break;
                }
                else ok = true;
            }
            return ok;
            c.Close();
        }
    }
}
