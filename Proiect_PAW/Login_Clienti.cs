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
    public partial class Login_Clienti : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=clienti;Integrated Security=True");

        public Login_Clienti()
        {
            InitializeComponent();
        }

        private void btnLogareCl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Clienti where User_cl=@name and Pass_cl=@pass ", con);
                cmd.Parameters.Add("@name", tbNume.Text);
                cmd.Parameters.Add("@pass", tbParola.Text);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("V-ati logat cu succes!");
                    Client_ATM ca = new Client_ATM();
                    ca.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Verificati daca numele de utilizator si parola sunt introduse corect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
