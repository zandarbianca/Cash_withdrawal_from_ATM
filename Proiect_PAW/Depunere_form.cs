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
    public partial class Depunere_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=clienti;Integrated Security=True");
        public Depunere_form()
        {
            InitializeComponent();
        }
        string Acc = Login_Clienti.NumeAcc;
        private void Depunere_form_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from clienti where User_cl='" + Login_Clienti.NumeAcc + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            tbBalanta.Text = dt1.Rows[0][4].ToString();
            con.Close();
        }
        private void golire()
        {
            rbtn1.Checked = false;
            rbtn2.Checked = false;
            rbtn3.Checked = false;
            dateTimePicker.ResetText();
            numericUpDown.ResetText();
        }
        private void inserare_tr()
        {
            SqlConnection conec = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tranzactii;Integrated Security=True");
            try
            {
                conec.Open();
                string atm;
                if (rbtn1.Checked)
                {
                    atm = "1";
                }
                else if (rbtn2.Checked)
                {
                    atm = "2";
                }
                else atm = "3";

                SqlCommand command = new SqlCommand("insert into Tranzactii_ist (Tip_tranzactie,Atm,Suma,Data_tranzactie,nume_cl) values ('Depunere','" +
                     atm + "','" + numericUpDown.Value + "','" + dateTimePicker.Text + "','" + Login_Clienti.NumeAcc + "')", conec);
                command.ExecuteNonQuery();
                conec.Close();
                MessageBox.Show("tranzactia a fost inregsitrata in bd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEfectuare_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from clienti where User_cl='" + Login_Clienti.NumeAcc + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            tbBalanta.Text = dt1.Rows[0][4].ToString();
            con.Close();
            int.TryParse(tbBalanta.Text, out int balanta);
            int suma_noua = 0;
            if ((rbtn1.Checked == false) && (rbtn2.Checked == false) && (rbtn3.Checked == false)) MessageBox.Show("Alegeti ATM-ul la care va aflati in acest moment!");
            else
            {
                if (numericUpDown.Value < 0) MessageBox.Show("Suma intrdusa nu poate fi negativa!");
                else
                {
                    con.Open();
                    suma_noua = balanta + (int)numericUpDown.Value;
                    SqlCommand cmd = new SqlCommand("update clienti set Suma_cl=" + suma_noua + " where User_cl='" + Login_Clienti.NumeAcc + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tranzactia s-a efectuat cu succes!");
                    con.Close();
                }
                inserare_tr();
                golire();
            }
        }

        private void btnAnulare_Click_1(object sender, EventArgs e)
        {
            golire();
        }

        private void numericUpDown_Validated(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void numericUpDown_Validating(object sender, CancelEventArgs e)
        {
            int suma = (int)numericUpDown.Value;
            if (suma < 10 )
            {
                errorProvider1.SetError((Control)sender, "Suma trebuie să fie mai mare de 10!");
                e.Cancel = true;
            }
        }
    }
}
