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
    public partial class Extragere_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=clienti;Integrated Security=True");
        public Extragere_Form()
        {
            InitializeComponent();
        }
        string Acc = Login_Clienti.NumeAcc;
        private void Extragere_Form_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from clienti where User_cl='" + Login_Clienti.NumeAcc + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            tbBalanta.Text = dt1.Rows[0][4].ToString();
            con.Close();
        }
        //golire texboxuri
        private void golire()
        {
            tbBalanta.Clear();
            rbtn1.Checked = false;
            rbtn2.Checked = false;
            rbtn3.Checked = false;
            dateTimePicker.ResetText();
            numericUpDown.ResetText();
        }
        //inserare tranzactii
        private void inserare_tr()
        {
            
        }
        //Efectuare tranzactie
        private void btnEfectuare_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from clienti where User_cl='" + Login_Clienti.NumeAcc + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            tbBalanta.Text = dt1.Rows[0][4].ToString();
            con.Close();
            int.TryParse(tbBalanta.Text, out int balanta);
            int suma_noua = 0;
            if (numericUpDown.Value > balanta || numericUpDown.Value < 0) MessageBox.Show("Balanta nu poate fi negativa!");
            else
            {
                con.Open();
                suma_noua = balanta - (int)numericUpDown.Value;
                SqlCommand cmd = new SqlCommand("update clienti set Suma_cl=" + suma_noua + " where User_cl='" + Login_Clienti.NumeAcc + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tranzactia s-a efectuat cu succes!");
                con.Close();
            }
            golire();
        }
        //Anulare tranzactie
        private void btnAnulare_Click(object sender, EventArgs e)
        {
            golire();
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
