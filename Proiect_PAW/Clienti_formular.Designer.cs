namespace Proiect_PAW
{
    partial class Clienti_formular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNume2 = new System.Windows.Forms.TextBox();
            this.tbPrenume2 = new System.Windows.Forms.TextBox();
            this.tbIban2 = new System.Windows.Forms.TextBox();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.lvIstoricTranzactiiClient = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IBAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_tranzactie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observatii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTranzactie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModificaDate = new System.Windows.Forms.Button();
            this.btnInchide = new System.Windows.Forms.Button();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSerializare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "IBAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suma Cont";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(702, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Istoric tranzactii";
            // 
            // tbNume2
            // 
            this.tbNume2.Enabled = false;
            this.tbNume2.Location = new System.Drawing.Point(159, 53);
            this.tbNume2.Name = "tbNume2";
            this.tbNume2.Size = new System.Drawing.Size(215, 22);
            this.tbNume2.TabIndex = 5;
            // 
            // tbPrenume2
            // 
            this.tbPrenume2.Enabled = false;
            this.tbPrenume2.Location = new System.Drawing.Point(159, 99);
            this.tbPrenume2.Name = "tbPrenume2";
            this.tbPrenume2.Size = new System.Drawing.Size(215, 22);
            this.tbPrenume2.TabIndex = 6;
            // 
            // tbIban2
            // 
            this.tbIban2.Enabled = false;
            this.tbIban2.Location = new System.Drawing.Point(159, 216);
            this.tbIban2.Name = "tbIban2";
            this.tbIban2.Size = new System.Drawing.Size(215, 22);
            this.tbIban2.TabIndex = 7;
            // 
            // tbSuma
            // 
            this.tbSuma.Enabled = false;
            this.tbSuma.Location = new System.Drawing.Point(159, 263);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(215, 22);
            this.tbSuma.TabIndex = 8;
            // 
            // lvIstoricTranzactiiClient
            // 
            this.lvIstoricTranzactiiClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.IBAN,
            this.Suma,
            this.Tip_tranzactie,
            this.Observatii,
            this.DataTranzactie});
            this.lvIstoricTranzactiiClient.HideSelection = false;
            this.lvIstoricTranzactiiClient.Location = new System.Drawing.Point(451, 58);
            this.lvIstoricTranzactiiClient.Name = "lvIstoricTranzactiiClient";
            this.lvIstoricTranzactiiClient.Size = new System.Drawing.Size(652, 262);
            this.lvIstoricTranzactiiClient.TabIndex = 17;
            this.lvIstoricTranzactiiClient.UseCompatibleStateImageBehavior = false;
            this.lvIstoricTranzactiiClient.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 68;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 77;
            // 
            // IBAN
            // 
            this.IBAN.Text = "IBAN";
            this.IBAN.Width = 99;
            // 
            // Suma
            // 
            this.Suma.Text = "Suma";
            this.Suma.Width = 78;
            // 
            // Tip_tranzactie
            // 
            this.Tip_tranzactie.Text = "Tip Tranzactie";
            this.Tip_tranzactie.Width = 110;
            // 
            // Observatii
            // 
            this.Observatii.Text = "Observatii";
            this.Observatii.Width = 106;
            // 
            // DataTranzactie
            // 
            this.DataTranzactie.Text = "Data Tranzactie";
            this.DataTranzactie.Width = 109;
            // 
            // btnModificaDate
            // 
            this.btnModificaDate.Location = new System.Drawing.Point(94, 342);
            this.btnModificaDate.Name = "btnModificaDate";
            this.btnModificaDate.Size = new System.Drawing.Size(186, 47);
            this.btnModificaDate.TabIndex = 18;
            this.btnModificaDate.Text = "MODIFICA DATE";
            this.btnModificaDate.UseVisualStyleBackColor = true;
            this.btnModificaDate.Click += new System.EventHandler(this.btnModificaDate_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.Location = new System.Drawing.Point(94, 425);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(186, 48);
            this.btnInchide.TabIndex = 19;
            this.btnInchide.Text = "INCHIDE";
            this.btnInchide.UseVisualStyleBackColor = true;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // tbAdresa
            // 
            this.tbAdresa.Enabled = false;
            this.tbAdresa.Location = new System.Drawing.Point(159, 144);
            this.tbAdresa.Multiline = true;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(215, 53);
            this.tbAdresa.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Adresa";
            // 
            // btnSerializare
            // 
            this.btnSerializare.Location = new System.Drawing.Point(659, 357);
            this.btnSerializare.Name = "btnSerializare";
            this.btnSerializare.Size = new System.Drawing.Size(236, 73);
            this.btnSerializare.TabIndex = 22;
            this.btnSerializare.Text = "SERIALIZARE TRANZACTII";
            this.btnSerializare.UseVisualStyleBackColor = true;
            // 
            // Clienti_formular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 506);
            this.Controls.Add(this.btnSerializare);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.btnModificaDate);
            this.Controls.Add(this.lvIstoricTranzactiiClient);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbIban2);
            this.Controls.Add(this.tbPrenume2);
            this.Controls.Add(this.tbNume2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clienti_formular";
            this.Text = "2. Informatii CONT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNume2;
        private System.Windows.Forms.TextBox tbPrenume2;
        private System.Windows.Forms.TextBox tbIban2;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.ListView lvIstoricTranzactiiClient;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader IBAN;
        private System.Windows.Forms.ColumnHeader Suma;
        private System.Windows.Forms.ColumnHeader Tip_tranzactie;
        private System.Windows.Forms.ColumnHeader Observatii;
        private System.Windows.Forms.ColumnHeader DataTranzactie;
        private System.Windows.Forms.Button btnModificaDate;
        private System.Windows.Forms.Button btnInchide;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSerializare;
    }
}