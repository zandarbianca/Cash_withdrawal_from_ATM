﻿using System;
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
    public partial class Login_Angajat : Form
    {
        //string path = @"Data Source=DESKTOP_ANG;Initial Catalog=angajati;Integrated Security=True";
        SqlConnection con = new SqlConnection("Data Source=DESKTOP_ANG;Initial Catalog=angajati;Integrated Security=True");

        public Login_Angajat()
        {
            InitializeComponent();
            //con = new SqlConnection(path);
        }

        private void btnLogareAng_Click(object sender, EventArgs e)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand("select * from Angajati where Nume_ang=@nume and Pass_ang=@pass ", con);
                cmd.Parameters.Add("@name", tbNume.Text);
                cmd.Parameters.Add("@pass", tbParola.Text);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("V-ati logat cu succes!");
                }
                else
                {
                    MessageBox.Show("Verificati daca numele de utilizator si parola sunt introduse corect");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
    }
}
