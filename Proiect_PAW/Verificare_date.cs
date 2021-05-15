using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Verificare_date : Form
    {
        List<Clienti> listaClienti;
        Clienti c;
        public Verificare_date()
        {
           // (string nume_, string prenume_, int iban_, int suma_, string adresa_)
            InitializeComponent();
            groupBoxClient.Enabled = false; groupBoxAngajat.Enabled = false;
            listaClienti = new List<Clienti>();
            listaClienti.Add(new Clienti("Zandar","Bianca",123456123456,2000,"Str.Dunarii, Bl.K1, Sc.B, Et.1, Ap.3"));
            listaClienti.Add(new Clienti("Duta","Catalin",654321654321,4000,"Str.Luna, Nr. 44"));
        }

        // START POINT
        private void btnClient_Click(object sender, EventArgs e)
        {
            groupBoxClient.Enabled = true;
            groupBoxAngajat.Enabled = false;
            btnInfoCont.Enabled = btnEfectTranz.Enabled = false;
            tbIdAngaj.Clear();
        }

        private void btnAngajat_Click(object sender, EventArgs e)
        {
            groupBoxAngajat.Enabled = true;
            groupBoxClient.Enabled = false;
            tbNume.Clear(); tbPrenume.Clear(); tbIBAN.Clear();
        }

        //CLIENT
        private void bntVerificareClient_Click(object sender, EventArgs e)
        {
            bool valid = true;
            String nume = tbNume.Text;
            if (String.IsNullOrEmpty(nume) ||
                String.IsNullOrWhiteSpace(nume) ||
                nume.Length < 2) { valid = false; }

            String prenume = tbPrenume.Text;
            if (String.IsNullOrEmpty(prenume) ||
                String.IsNullOrWhiteSpace(prenume) ||
                prenume.Length < 2) { valid = false; }

            int.TryParse(tbIBAN.Text, out int iban);
            if (iban == 0) valid = false;

            Clienti cl = new Clienti(nume, prenume, iban);
            foreach (Clienti c in listaClienti)
            {
                if (nume == c.Nume) valid = true;
                if (prenume == c.Prenume) valid = true; 
                if (iban == c.Iban) valid = true; 
            }
            if (valid)
            {
                btnInfoCont.Enabled = btnEfectTranz.Enabled = true;
            }//else MessageBox.Show("Date introduse gresit!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        private void btnInfoCont_Click(object sender, EventArgs e)
        {
            Clienti_formular c1 = new Clienti_formular();
            c1.ShowDialog();
        }
        private void btnEfectTranz_Click(object sender, EventArgs e)
        {
            Efectuare_tranzactie e1 = new Efectuare_tranzactie();
            e1.ShowDialog();
        }
        private void btnInchide_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //ANGAJAT
        private void btnVerificareAngajat_Click(object sender, EventArgs e)
        {
            bool valid = true;
            int.TryParse(tbIdAngaj.Text, out int id);
            if (id != 000) valid = false;
            if (valid)
            {
                Banca_formular b1 = new Banca_formular();
                b1.ShowDialog();
            }
            else MessageBox.Show("Id incorect!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Validari nume,prenume,iban inainte de a apasa verificare
        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            String nume = tbNume.Text;

            if (String.IsNullOrEmpty(nume) ||
                String.IsNullOrWhiteSpace(nume) ||
                nume.Length < 2)
            {
                epNume.SetError((Control)sender, "Nume invalid");
                e.Cancel = true;
            }
        }
        private void tbNume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }
        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            String prenume = tbPrenume.Text;

            if (String.IsNullOrEmpty(prenume) ||
                String.IsNullOrWhiteSpace(prenume) ||
                prenume.Length < 2)
            {
                epPrenume.SetError((Control)sender, "Prenume invalid");
                e.Cancel = true;
            }
        }
        private void tbPrenume_Validated(object sender, EventArgs e)
        {
            epNume.Clear();
        }
        private void tbIBAN_Validating(object sender, CancelEventArgs e)
        {
            String iban = tbIBAN.Text;

            if (String.IsNullOrEmpty(iban) ||
                String.IsNullOrWhiteSpace(iban) ||
                iban.Length != 12)
            {
                epPrenume.SetError((Control)sender, "IBAN invalid");
                e.Cancel = true;
            }
        }
        private void tbIBAN_Validated(object sender, EventArgs e)
        {
            epIban.Clear();
        }


    }
}
