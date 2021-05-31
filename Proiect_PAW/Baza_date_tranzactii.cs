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
    public partial class Baza_date_tranzactii : Form
    {
        DataTable dt;
        SqlDataAdapter adpt1;
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=tranzactii;Integrated Security=True");
        public Baza_date_tranzactii()
        {
            InitializeComponent();
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt1 = new SqlDataAdapter("select * from tranzactii_ist", con);
                adpt1.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Baza_date_tranzactii_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAngajatiDataSet4.Table_tranzactii' table. You can move, or remove it, as needed.
            this.table_tranzactiiTableAdapter.Fill(this.databaseAngajatiDataSet4.Table_tranzactii);
            display();
        }
    }
}
