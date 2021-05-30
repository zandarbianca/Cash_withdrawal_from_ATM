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
    public partial class Informatii_cont_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=clienti;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        public Informatii_cont_form()
        {
            InitializeComponent();
        }

        private void Informatii_cont_form_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * From clienti", con);
            ds = new DataSet();
            da.Fill(ds, "clienti");
            GetData();
        }
        public static String NumeAcc;
        private void GetData()
        {
            con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from clienti where User_cl='" + Login_Clienti.NumeAcc + "'",con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            tbNumeInfo.Text = dt.Rows[0][1].ToString();
            tbPrenumeInfo.Text = dt.Rows[0][2].ToString();
            tbAdresaInfo.Text = dt.Rows[0][5].ToString();
            tbIbanInfo.Text = dt.Rows[0][3].ToString();
            tbSumaInfo.Text = dt.Rows[0][4].ToString();
            con.Close();
        }

        private void tbNumeInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrenumeInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAdresaInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIbanInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSumaInfo_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
