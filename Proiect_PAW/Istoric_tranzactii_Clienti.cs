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
    public partial class Istoric_tranzactii_Clienti : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tranzactii;Integrated Security=True");
        //SqlCommand cmd = new SqlCommand("select * from Clienti where User_cl=@name and Pass_cl=@pass ", con);
        DataTable dt;
        SqlDataAdapter adpt1;
            //= new SqlDataAdapter("select * from clienti where User_cl='" + Login_Clienti.NumeAcc + "'", con);
        public Istoric_tranzactii_Clienti()
        {
            InitializeComponent();

        }

        private void Istoric_tranzactii_Clienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAngajatiDataSet7.Table_tranzactii' table. You can move, or remove it, as needed.
            // this.table_tranzactiiTableAdapter5.Fill(this.databaseAngajatiDataSet7.Table_tranzactii);
            display();
        }

        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt1 = new SqlDataAdapter("select * from tranzactii_ist where Nume_cl='" + Login_Clienti.NumeAcc + "'", con);
                adpt1.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
