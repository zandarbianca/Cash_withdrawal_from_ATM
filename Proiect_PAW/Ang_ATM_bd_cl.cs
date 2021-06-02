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
    public partial class Ang_ATM_bd_cl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=clienti;Integrated Security=True");
        DataTable dt;
        SqlDataAdapter adpt1;
        public Ang_ATM_bd_cl()
        {
            InitializeComponent();
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt1 = new SqlDataAdapter("select * from Clienti", con);
                adpt1.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Ang_ATM_bd_cl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseAngajatiDataSet9.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.databaseAngajatiDataSet9.Table);
            // TODO: This line of code loads data into the 'databaseAngajatiDataSet8.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.databaseAngajatiDataSet8.Table);
            // TODO: This line of code loads data into the 'databaseAngajatiDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.databaseAngajatiDataSet.Angajati);
            display();
        }

    }
}
