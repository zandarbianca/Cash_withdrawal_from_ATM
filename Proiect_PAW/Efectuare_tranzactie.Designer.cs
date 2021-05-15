namespace Proiect_PAW
{
    partial class Efectuare_tranzactie
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IBAN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_tranzactie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observatii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTranzactie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.IdAparat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Prenume,
            this.IBAN,
            this.Suma,
            this.Tip_tranzactie,
            this.Observatii,
            this.DataTranzactie,
            this.IdAparat});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(546, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 271);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.IBAN.Width = 66;
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
            this.Observatii.Width = 101;
            // 
            // DataTranzactie
            // 
            this.DataTranzactie.Text = "Data Tranzactie";
            this.DataTranzactie.Width = 114;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb5);
            this.groupBox3.Controls.Add(this.cb4);
            this.groupBox3.Controls.Add(this.cb3);
            this.groupBox3.Controls.Add(this.cb2);
            this.groupBox3.Controls.Add(this.cb1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(11, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 531);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tranzactie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EXTRAGERE"});
            this.comboBox1.Location = new System.Drawing.Point(200, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 24);
            this.comboBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tip tranzactie :";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(327, 467);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 45);
            this.button6.TabIndex = 14;
            this.button6.Text = "Efectuare tranzactie";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data tranzactiei :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(200, 189);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(290, 132);
            this.textBox5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Suma :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(290, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Obervatii :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(699, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 45);
            this.button5.TabIndex = 15;
            this.button5.Text = "Serializare Tranzactie";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1013, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Inchide";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.Location = new System.Drawing.Point(236, 401);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(98, 21);
            this.cb5.TabIndex = 15;
            this.cb5.Text = "Aparat 5";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.Location = new System.Drawing.Point(236, 357);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(98, 21);
            this.cb4.TabIndex = 16;
            this.cb4.Text = "Aparat 4";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.Location = new System.Drawing.Point(31, 444);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(98, 21);
            this.cb3.TabIndex = 17;
            this.cb3.Text = "Aparat 3";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.Location = new System.Drawing.Point(31, 401);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(98, 21);
            this.cb2.TabIndex = 18;
            this.cb2.Text = "Aparat 2";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.Location = new System.Drawing.Point(31, 357);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(98, 21);
            this.cb1.TabIndex = 19;
            this.cb1.Text = "Aparat 1";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // IdAparat
            // 
            this.IdAparat.Text = "IdAparat";
            this.IdAparat.Width = 88;
            // 
            // Efectuare_tranzactie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Name = "Efectuare_tranzactie";
            this.Text = "3. Efectuare Tranzactie";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Prenume;
        private System.Windows.Forms.ColumnHeader IBAN;
        private System.Windows.Forms.ColumnHeader Suma;
        private System.Windows.Forms.ColumnHeader Tip_tranzactie;
        private System.Windows.Forms.ColumnHeader Observatii;
        private System.Windows.Forms.ColumnHeader DataTranzactie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.ColumnHeader IdAparat;
    }
}