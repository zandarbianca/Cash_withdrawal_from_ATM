namespace Proiect_PAW
{
    partial class Verificare_date
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
            this.components = new System.ComponentModel.Container();
            this.btnInfoCont = new System.Windows.Forms.Button();
            this.btnInchide = new System.Windows.Forms.Button();
            this.btnEfectTranz = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.bntVerificareClient = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificareAngajat = new System.Windows.Forms.Button();
            this.groupBoxAngajat = new System.Windows.Forms.GroupBox();
            this.tbIdAngaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAngajat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.epNume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenume = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIban = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxClient.SuspendLayout();
            this.groupBoxAngajat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIban)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfoCont
            // 
            this.btnInfoCont.Location = new System.Drawing.Point(645, 44);
            this.btnInfoCont.Name = "btnInfoCont";
            this.btnInfoCont.Size = new System.Drawing.Size(258, 58);
            this.btnInfoCont.TabIndex = 11;
            this.btnInfoCont.Text = "INFOMATII CONT";
            this.btnInfoCont.UseVisualStyleBackColor = true;
            this.btnInfoCont.Click += new System.EventHandler(this.btnInfoCont_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.Location = new System.Drawing.Point(402, 598);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(258, 61);
            this.btnInchide.TabIndex = 13;
            this.btnInchide.Text = "INCHIDE";
            this.btnInchide.UseVisualStyleBackColor = true;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // btnEfectTranz
            // 
            this.btnEfectTranz.Location = new System.Drawing.Point(645, 164);
            this.btnEfectTranz.Name = "btnEfectTranz";
            this.btnEfectTranz.Size = new System.Drawing.Size(258, 61);
            this.btnEfectTranz.TabIndex = 12;
            this.btnEfectTranz.Text = "EFECTUARE TRANZACTII";
            this.btnEfectTranz.UseVisualStyleBackColor = true;
            this.btnEfectTranz.Click += new System.EventHandler(this.btnEfectTranz_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.btnInfoCont);
            this.groupBoxClient.Controls.Add(this.bntVerificareClient);
            this.groupBoxClient.Controls.Add(this.tbNume);
            this.groupBoxClient.Controls.Add(this.btnEfectTranz);
            this.groupBoxClient.Controls.Add(this.tbIBAN);
            this.groupBoxClient.Controls.Add(this.label1);
            this.groupBoxClient.Controls.Add(this.tbPrenume);
            this.groupBoxClient.Controls.Add(this.label2);
            this.groupBoxClient.Controls.Add(this.label3);
            this.groupBoxClient.Location = new System.Drawing.Point(40, 158);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(961, 290);
            this.groupBoxClient.TabIndex = 15;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // bntVerificareClient
            // 
            this.bntVerificareClient.Location = new System.Drawing.Point(202, 216);
            this.bntVerificareClient.Name = "bntVerificareClient";
            this.bntVerificareClient.Size = new System.Drawing.Size(167, 43);
            this.bntVerificareClient.TabIndex = 9;
            this.bntVerificareClient.Text = "Verifica datele";
            this.bntVerificareClient.UseVisualStyleBackColor = true;
            this.bntVerificareClient.Click += new System.EventHandler(this.bntVerificareClient_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(236, 35);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(290, 22);
            this.tbNume.TabIndex = 6;
            this.tbNume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // tbIBAN
            // 
            this.tbIBAN.Location = new System.Drawing.Point(236, 127);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.Size = new System.Drawing.Size(290, 22);
            this.tbIBAN.TabIndex = 8;
            this.tbIBAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbIBAN.Validating += new System.ComponentModel.CancelEventHandler(this.tbIBAN_Validating);
            this.tbIBAN.Validated += new System.EventHandler(this.tbIBAN_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume client : ";
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(236, 79);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(290, 22);
            this.tbPrenume.TabIndex = 7;
            this.tbPrenume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPrenume.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenume_Validating);
            this.tbPrenume.Validated += new System.EventHandler(this.tbPrenume_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "IBAN :";
            // 
            // btnVerificareAngajat
            // 
            this.btnVerificareAngajat.Location = new System.Drawing.Point(694, 21);
            this.btnVerificareAngajat.Name = "btnVerificareAngajat";
            this.btnVerificareAngajat.Size = new System.Drawing.Size(162, 66);
            this.btnVerificareAngajat.TabIndex = 17;
            this.btnVerificareAngajat.Text = "VERIFICA";
            this.btnVerificareAngajat.UseVisualStyleBackColor = true;
            this.btnVerificareAngajat.Click += new System.EventHandler(this.btnVerificareAngajat_Click);
            // 
            // groupBoxAngajat
            // 
            this.groupBoxAngajat.Controls.Add(this.tbIdAngaj);
            this.groupBoxAngajat.Controls.Add(this.label4);
            this.groupBoxAngajat.Controls.Add(this.btnVerificareAngajat);
            this.groupBoxAngajat.Location = new System.Drawing.Point(40, 473);
            this.groupBoxAngajat.Name = "groupBoxAngajat";
            this.groupBoxAngajat.Size = new System.Drawing.Size(961, 100);
            this.groupBoxAngajat.TabIndex = 18;
            this.groupBoxAngajat.TabStop = false;
            this.groupBoxAngajat.Text = "Angajat";
            // 
            // tbIdAngaj
            // 
            this.tbIdAngaj.Location = new System.Drawing.Point(236, 43);
            this.tbIdAngaj.Name = "tbIdAngaj";
            this.tbIdAngaj.Size = new System.Drawing.Size(290, 22);
            this.tbIdAngaj.TabIndex = 19;
            this.tbIdAngaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID ANGAJAT : ";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(188, 30);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(141, 47);
            this.btnClient.TabIndex = 19;
            this.btnClient.Text = "CLIENT";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnAngajat
            // 
            this.btnAngajat.Location = new System.Drawing.Point(657, 30);
            this.btnAngajat.Name = "btnAngajat";
            this.btnAngajat.Size = new System.Drawing.Size(142, 47);
            this.btnAngajat.TabIndex = 20;
            this.btnAngajat.Text = "ANGAJAT";
            this.btnAngajat.UseVisualStyleBackColor = true;
            this.btnAngajat.Click += new System.EventHandler(this.btnAngajat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnClient);
            this.groupBox2.Controls.Add(this.btnAngajat);
            this.groupBox2.Location = new System.Drawing.Point(40, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Alegeti una din cele 2 optiuni prezentate ";
            // 
            // epNume
            // 
            this.epNume.ContainerControl = this;
            // 
            // epPrenume
            // 
            this.epPrenume.ContainerControl = this;
            // 
            // epIban
            // 
            this.epIban.ContainerControl = this;
            // 
            // Verificare_date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxAngajat);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.groupBoxClient);
            this.Name = "Verificare_date";
            this.Text = "1. Verifica Date";
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxAngajat.ResumeLayout(false);
            this.groupBoxAngajat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInfoCont;
        private System.Windows.Forms.Button btnInchide;
        private System.Windows.Forms.Button btnEfectTranz;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button bntVerificareClient;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificareAngajat;
        private System.Windows.Forms.GroupBox groupBoxAngajat;
        private System.Windows.Forms.TextBox tbIdAngaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnAngajat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider epNume;
        private System.Windows.Forms.ErrorProvider epPrenume;
        private System.Windows.Forms.ErrorProvider epIban;
    }
}

