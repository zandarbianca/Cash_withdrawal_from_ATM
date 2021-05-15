namespace Proiect_PAW
{
    partial class Banca_formular
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IBAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_tranzactie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observatii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTranzactie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Locatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumaAparat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SumaAdaugata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 350);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clienti";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 60);
            this.button2.TabIndex = 20;
            this.button2.Text = "Deserializare date clienti";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 60);
            this.button1.TabIndex = 19;
            this.button1.Text = "Serializare date clienti";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.Adresa,
            this.IBAN,
            this.Suma});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(747, 194);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 156;
            // 
            // Prenume
            // 
            this.Prenume.Text = "Prenume";
            this.Prenume.Width = 151;
            // 
            // Adresa
            // 
            this.Adresa.DisplayIndex = 4;
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 189;
            // 
            // IBAN
            // 
            this.IBAN.DisplayIndex = 2;
            this.IBAN.Text = "IBAN";
            this.IBAN.Width = 151;
            // 
            // Suma
            // 
            this.Suma.DisplayIndex = 3;
            this.Suma.Text = "Suma cont";
            this.Suma.Width = 157;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.Tip_tranzactie,
            this.Observatii,
            this.DataTranzactie});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 33);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(747, 175);
            this.listView2.TabIndex = 33;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IBAN";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Suma";
            this.columnHeader4.Width = 78;
            // 
            // Tip_tranzactie
            // 
            this.Tip_tranzactie.Text = "Tip Tranzactie";
            this.Tip_tranzactie.Width = 110;
            // 
            // Observatii
            // 
            this.Observatii.Text = "Observatii";
            this.Observatii.Width = 149;
            // 
            // DataTranzactie
            // 
            this.DataTranzactie.Text = "Data Tranzactie";
            this.DataTranzactie.Width = 109;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 302);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tranzactii";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 60);
            this.button3.TabIndex = 35;
            this.button3.Text = "Deserializare tranzactii";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 60);
            this.button4.TabIndex = 34;
            this.button4.Text = "Serializare tranzactii";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(574, 712);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 44);
            this.button5.TabIndex = 34;
            this.button5.Text = "INCHIDE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cb5);
            this.groupBox3.Controls.Add(this.cb4);
            this.groupBox3.Controls.Add(this.cb3);
            this.groupBox3.Controls.Add(this.cb2);
            this.groupBox3.Controls.Add(this.cb1);
            this.groupBox3.Controls.Add(this.listView3);
            this.groupBox3.Location = new System.Drawing.Point(798, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 645);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aparate";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(148, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 72);
            this.button7.TabIndex = 8;
            this.button7.Text = "Serializare status aparate";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(202, 563);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 58);
            this.button6.TabIndex = 7;
            this.button6.Text = "ADAUGA ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectati aparatele la care doriti sa se adaugati";
            // 
            // cb5
            // 
            this.cb5.Location = new System.Drawing.Point(312, 477);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(98, 21);
            this.cb5.TabIndex = 0;
            this.cb5.Text = "Aparat 5";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.Location = new System.Drawing.Point(312, 433);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(98, 21);
            this.cb4.TabIndex = 0;
            this.cb4.Text = "Aparat 4";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.Location = new System.Drawing.Point(107, 520);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(98, 21);
            this.cb3.TabIndex = 0;
            this.cb3.Text = "Aparat 3";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.Location = new System.Drawing.Point(107, 477);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(98, 21);
            this.cb2.TabIndex = 0;
            this.cb2.Text = "Aparat 2";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.Location = new System.Drawing.Point(107, 433);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(98, 21);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Aparat 1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Locatie,
            this.SumaAparat,
            this.SumaAdaugata});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(19, 36);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(454, 238);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 47;
            // 
            // Locatie
            // 
            this.Locatie.Text = "Locatie";
            this.Locatie.Width = 130;
            // 
            // SumaAparat
            // 
            this.SumaAparat.Text = "Suma in aparat";
            this.SumaAparat.Width = 134;
            // 
            // SumaAdaugata
            // 
            this.SumaAdaugata.Text = "Suma de adaugat";
            this.SumaAdaugata.Width = 137;
            // 
            // Banca_formular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 768);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Banca_formular";
            this.Text = "Banca_formular";
            this.Load += new System.EventHandler(this.Banca_formular_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader IBAN;
        private System.Windows.Forms.ColumnHeader Suma;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader Tip_tranzactie;
        private System.Windows.Forms.ColumnHeader Observatii;
        private System.Windows.Forms.ColumnHeader DataTranzactie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Locatie;
        private System.Windows.Forms.ColumnHeader SumaAparat;
        private System.Windows.Forms.ColumnHeader SumaAdaugata;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
    }
}