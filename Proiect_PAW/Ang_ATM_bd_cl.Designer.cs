namespace Proiect_PAW
{
    partial class Ang_ATM_bd_cl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iban_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suma_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_cl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAngajatiDataSet9 = new Proiect_PAW.DatabaseAngajatiDataSet9();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAngajatiDataSet = new Proiect_PAW.DatabaseAngajatiDataSet();
            this.angajatiTableAdapter = new Proiect_PAW.DatabaseAngajatiDataSetTableAdapters.AngajatiTableAdapter();
            this.databaseAngajatiDataSet8 = new Proiect_PAW.DatabaseAngajatiDataSet8();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Proiect_PAW.DatabaseAngajatiDataSet8TableAdapters.TableTableAdapter();
            this.tableTableAdapter1 = new Proiect_PAW.DatabaseAngajatiDataSet9TableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(291, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENȚI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Nume_cl,
            this.Prenume_cl,
            this.Iban_cl,
            this.Suma_cl,
            this.Adresa_cl,
            this.User_cl});
            this.dataGridView1.DataSource = this.tableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 318);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Nume_cl
            // 
            this.Nume_cl.DataPropertyName = "Nume_cl";
            this.Nume_cl.HeaderText = "Nume_cl";
            this.Nume_cl.MinimumWidth = 6;
            this.Nume_cl.Name = "Nume_cl";
            this.Nume_cl.Width = 125;
            // 
            // Prenume_cl
            // 
            this.Prenume_cl.DataPropertyName = "Prenume_cl";
            this.Prenume_cl.HeaderText = "Prenume_cl";
            this.Prenume_cl.MinimumWidth = 6;
            this.Prenume_cl.Name = "Prenume_cl";
            this.Prenume_cl.Width = 125;
            // 
            // Iban_cl
            // 
            this.Iban_cl.DataPropertyName = "Iban_cl";
            this.Iban_cl.HeaderText = "Iban_cl";
            this.Iban_cl.MinimumWidth = 6;
            this.Iban_cl.Name = "Iban_cl";
            this.Iban_cl.Width = 125;
            // 
            // Suma_cl
            // 
            this.Suma_cl.DataPropertyName = "Suma_cl";
            this.Suma_cl.HeaderText = "Suma_cl";
            this.Suma_cl.MinimumWidth = 6;
            this.Suma_cl.Name = "Suma_cl";
            this.Suma_cl.Width = 125;
            // 
            // Adresa_cl
            // 
            this.Adresa_cl.DataPropertyName = "Adresa_cl";
            this.Adresa_cl.HeaderText = "Adresa_cl";
            this.Adresa_cl.MinimumWidth = 6;
            this.Adresa_cl.Name = "Adresa_cl";
            this.Adresa_cl.Width = 125;
            // 
            // User_cl
            // 
            this.User_cl.DataPropertyName = "User_cl";
            this.User_cl.HeaderText = "User_cl";
            this.User_cl.MinimumWidth = 6;
            this.User_cl.Name = "User_cl";
            this.User_cl.Width = 125;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.databaseAngajatiDataSet9;
            // 
            // databaseAngajatiDataSet9
            // 
            this.databaseAngajatiDataSet9.DataSetName = "DatabaseAngajatiDataSet9";
            this.databaseAngajatiDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.databaseAngajatiDataSet;
            // 
            // databaseAngajatiDataSet
            // 
            this.databaseAngajatiDataSet.DataSetName = "DatabaseAngajatiDataSet";
            this.databaseAngajatiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // databaseAngajatiDataSet8
            // 
            this.databaseAngajatiDataSet8.DataSetName = "DatabaseAngajatiDataSet8";
            this.databaseAngajatiDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.databaseAngajatiDataSet8;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // Ang_ATM_bd_cl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ang_ATM_bd_cl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ang_ATM_bd_cl";
            this.Load += new System.EventHandler(this.Ang_ATM_bd_cl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseAngajatiDataSet databaseAngajatiDataSet;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private DatabaseAngajatiDataSetTableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private DatabaseAngajatiDataSet8 databaseAngajatiDataSet8;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DatabaseAngajatiDataSet8TableAdapters.TableTableAdapter tableTableAdapter;
        private DatabaseAngajatiDataSet9 databaseAngajatiDataSet9;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private DatabaseAngajatiDataSet9TableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume_cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iban_cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suma_cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa_cl;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_cl;
    }
}