namespace Proiect_PAW
{
    partial class Istoric_tranzactii_Clienti
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
            this.databaseAngajatiDataSet = new Proiect_PAW.DatabaseAngajatiDataSet();
            this.databaseAngajatiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAngajatiDataSet1 = new Proiect_PAW.DatabaseAngajatiDataSet1();
            this.angajatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.angajatiTableAdapter = new Proiect_PAW.DatabaseAngajatiDataSet1TableAdapters.AngajatiTableAdapter();
            this.databaseAngajatiDataSet2 = new Proiect_PAW.DatabaseAngajatiDataSet2();
            this.tabletranzactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_tranzactiiTableAdapter = new Proiect_PAW.DatabaseAngajatiDataSet2TableAdapters.Table_tranzactiiTableAdapter();
            this.databaseAngajatiDataSet3 = new Proiect_PAW.DatabaseAngajatiDataSet3();
            this.tabletranzactiiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_tranzactiiTableAdapter1 = new Proiect_PAW.DatabaseAngajatiDataSet3TableAdapters.Table_tranzactiiTableAdapter();
            this.tabletranzactiiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAngajatiDataSet5 = new Proiect_PAW.DatabaseAngajatiDataSet5();
            this.tabletranzactiiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.table_tranzactiiTableAdapter3 = new Proiect_PAW.DatabaseAngajatiDataSet5TableAdapters.Table_tranzactiiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datatranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiptranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabletranzactiiBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAngajatiDataSet6 = new Proiect_PAW.DatabaseAngajatiDataSet6();
            this.table_tranzactiiTableAdapter4 = new Proiect_PAW.DatabaseAngajatiDataSet6TableAdapters.Table_tranzactiiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISTORIC TRANZACTII";
            // 
            // databaseAngajatiDataSet
            // 
            this.databaseAngajatiDataSet.DataSetName = "DatabaseAngajatiDataSet";
            this.databaseAngajatiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseAngajatiDataSetBindingSource
            // 
            this.databaseAngajatiDataSetBindingSource.DataSource = this.databaseAngajatiDataSet;
            this.databaseAngajatiDataSetBindingSource.Position = 0;
            // 
            // databaseAngajatiDataSet1
            // 
            this.databaseAngajatiDataSet1.DataSetName = "DatabaseAngajatiDataSet1";
            this.databaseAngajatiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // angajatiBindingSource
            // 
            this.angajatiBindingSource.DataMember = "Angajati";
            this.angajatiBindingSource.DataSource = this.databaseAngajatiDataSet1;
            // 
            // angajatiTableAdapter
            // 
            this.angajatiTableAdapter.ClearBeforeFill = true;
            // 
            // databaseAngajatiDataSet2
            // 
            this.databaseAngajatiDataSet2.DataSetName = "DatabaseAngajatiDataSet2";
            this.databaseAngajatiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabletranzactiiBindingSource
            // 
            this.tabletranzactiiBindingSource.DataMember = "Table_tranzactii";
            this.tabletranzactiiBindingSource.DataSource = this.databaseAngajatiDataSet2;
            // 
            // table_tranzactiiTableAdapter
            // 
            this.table_tranzactiiTableAdapter.ClearBeforeFill = true;
            // 
            // databaseAngajatiDataSet3
            // 
            this.databaseAngajatiDataSet3.DataSetName = "DatabaseAngajatiDataSet3";
            this.databaseAngajatiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabletranzactiiBindingSource1
            // 
            this.tabletranzactiiBindingSource1.DataMember = "Table_tranzactii";
            this.tabletranzactiiBindingSource1.DataSource = this.databaseAngajatiDataSet3;
            // 
            // table_tranzactiiTableAdapter1
            // 
            this.table_tranzactiiTableAdapter1.ClearBeforeFill = true;
            // 
            // databaseAngajatiDataSet5
            // 
            this.databaseAngajatiDataSet5.DataSetName = "DatabaseAngajatiDataSet5";
            this.databaseAngajatiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabletranzactiiBindingSource3
            // 
            this.tabletranzactiiBindingSource3.DataMember = "Table_tranzactii";
            this.tabletranzactiiBindingSource3.DataSource = this.databaseAngajatiDataSet5;
            // 
            // table_tranzactiiTableAdapter3
            // 
            this.table_tranzactiiTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datatranzactieDataGridViewTextBoxColumn,
            this.atmDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.tiptranzactieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabletranzactiiBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(46, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // datatranzactieDataGridViewTextBoxColumn
            // 
            this.datatranzactieDataGridViewTextBoxColumn.DataPropertyName = "Data_tranzactie";
            this.datatranzactieDataGridViewTextBoxColumn.HeaderText = "Data_tranzactie";
            this.datatranzactieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datatranzactieDataGridViewTextBoxColumn.Name = "datatranzactieDataGridViewTextBoxColumn";
            this.datatranzactieDataGridViewTextBoxColumn.Width = 125;
            // 
            // atmDataGridViewTextBoxColumn
            // 
            this.atmDataGridViewTextBoxColumn.DataPropertyName = "Atm";
            this.atmDataGridViewTextBoxColumn.HeaderText = "Atm";
            this.atmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.atmDataGridViewTextBoxColumn.Name = "atmDataGridViewTextBoxColumn";
            this.atmDataGridViewTextBoxColumn.Width = 125;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Suma";
            this.sumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tiptranzactieDataGridViewTextBoxColumn
            // 
            this.tiptranzactieDataGridViewTextBoxColumn.DataPropertyName = "Tip_tranzactie";
            this.tiptranzactieDataGridViewTextBoxColumn.HeaderText = "Tip_tranzactie";
            this.tiptranzactieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tiptranzactieDataGridViewTextBoxColumn.Name = "tiptranzactieDataGridViewTextBoxColumn";
            this.tiptranzactieDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabletranzactiiBindingSource4
            // 
            this.tabletranzactiiBindingSource4.DataMember = "Table_tranzactii";
            this.tabletranzactiiBindingSource4.DataSource = this.databaseAngajatiDataSet6;
            // 
            // databaseAngajatiDataSet6
            // 
            this.databaseAngajatiDataSet6.DataSetName = "DatabaseAngajatiDataSet6";
            this.databaseAngajatiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_tranzactiiTableAdapter4
            // 
            this.table_tranzactiiTableAdapter4.ClearBeforeFill = true;
            // 
            // Istoric_tranzactii_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Istoric_tranzactii_Clienti";
            this.Text = "Istoric_tranzactii_Clienti";
            this.Load += new System.EventHandler(this.Istoric_tranzactii_Clienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource databaseAngajatiDataSetBindingSource;
        private DatabaseAngajatiDataSet databaseAngajatiDataSet;
        private DatabaseAngajatiDataSet1 databaseAngajatiDataSet1;
        private System.Windows.Forms.BindingSource angajatiBindingSource;
        private DatabaseAngajatiDataSet1TableAdapters.AngajatiTableAdapter angajatiTableAdapter;
        private DatabaseAngajatiDataSet2 databaseAngajatiDataSet2;
        private System.Windows.Forms.BindingSource tabletranzactiiBindingSource;
        private DatabaseAngajatiDataSet2TableAdapters.Table_tranzactiiTableAdapter table_tranzactiiTableAdapter;
        private DatabaseAngajatiDataSet3 databaseAngajatiDataSet3;
        private System.Windows.Forms.BindingSource tabletranzactiiBindingSource1;
        private DatabaseAngajatiDataSet3TableAdapters.Table_tranzactiiTableAdapter table_tranzactiiTableAdapter1;
       
        private System.Windows.Forms.BindingSource tabletranzactiiBindingSource2;
        
        private DatabaseAngajatiDataSet5 databaseAngajatiDataSet5;
        private System.Windows.Forms.BindingSource tabletranzactiiBindingSource3;
        private DatabaseAngajatiDataSet5TableAdapters.Table_tranzactiiTableAdapter table_tranzactiiTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseAngajatiDataSet6 databaseAngajatiDataSet6;
        private System.Windows.Forms.BindingSource tabletranzactiiBindingSource4;
        private DatabaseAngajatiDataSet6TableAdapters.Table_tranzactiiTableAdapter table_tranzactiiTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn datatranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiptranzactieDataGridViewTextBoxColumn;
    }
}