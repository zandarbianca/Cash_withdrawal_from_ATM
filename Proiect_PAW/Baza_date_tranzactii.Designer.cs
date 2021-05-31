namespace Proiect_PAW
{
    partial class Baza_date_tranzactii
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
            this.datatranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiptranzactieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeclDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabletranzactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseAngajatiDataSet4 = new Proiect_PAW.DatabaseAngajatiDataSet4();
            this.table_tranzactiiTableAdapter = new Proiect_PAW.DatabaseAngajatiDataSet4TableAdapters.Table_tranzactiiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANZACȚII";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datatranzactieDataGridViewTextBoxColumn,
            this.atmDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn,
            this.tiptranzactieDataGridViewTextBoxColumn,
            this.numeclDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabletranzactiiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 318);
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
            // numeclDataGridViewTextBoxColumn
            // 
            this.numeclDataGridViewTextBoxColumn.DataPropertyName = "Nume_cl";
            this.numeclDataGridViewTextBoxColumn.HeaderText = "Nume_cl";
            this.numeclDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeclDataGridViewTextBoxColumn.Name = "numeclDataGridViewTextBoxColumn";
            this.numeclDataGridViewTextBoxColumn.Width = 125;
            // 
            // tabletranzactiiBindingSource
            // 
            this.tabletranzactiiBindingSource.DataMember = "Table_tranzactii";
            this.tabletranzactiiBindingSource.DataSource = this.databaseAngajatiDataSet4;
            // 
            // databaseAngajatiDataSet4
            // 
            this.databaseAngajatiDataSet4.DataSetName = "DatabaseAngajatiDataSet4";
            this.databaseAngajatiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_tranzactiiTableAdapter
            // 
            this.table_tranzactiiTableAdapter.ClearBeforeFill = true;
            // 
            // Baza_date_tranzactii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Baza_date_tranzactii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baza_date_tranzactii";
            this.Load += new System.EventHandler(this.Baza_date_tranzactii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletranzactiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAngajatiDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseAngajatiDataSet4 databaseAngajatiDataSet4;
        private System.Windows.Forms.BindingSource tabletranzactiiBindingSource;
        private DatabaseAngajatiDataSet4TableAdapters.Table_tranzactiiTableAdapter table_tranzactiiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datatranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn atmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiptranzactieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeclDataGridViewTextBoxColumn;
    }
}