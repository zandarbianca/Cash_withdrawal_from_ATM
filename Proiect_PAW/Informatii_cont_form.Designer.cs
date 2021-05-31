namespace Proiect_PAW
{
    partial class Informatii_cont_form
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
            this.tbNumeInfo = new System.Windows.Forms.TextBox();
            this.tbPrenumeInfo = new System.Windows.Forms.TextBox();
            this.tbIbanInfo = new System.Windows.Forms.TextBox();
            this.tbAdresaInfo = new System.Windows.Forms.TextBox();
            this.tbSumaInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSerializareInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumeInfo
            // 
            this.tbNumeInfo.Enabled = false;
            this.tbNumeInfo.Location = new System.Drawing.Point(251, 39);
            this.tbNumeInfo.Name = "tbNumeInfo";
            this.tbNumeInfo.Size = new System.Drawing.Size(195, 22);
            this.tbNumeInfo.TabIndex = 0;
            // 
            // tbPrenumeInfo
            // 
            this.tbPrenumeInfo.Enabled = false;
            this.tbPrenumeInfo.Location = new System.Drawing.Point(251, 88);
            this.tbPrenumeInfo.Name = "tbPrenumeInfo";
            this.tbPrenumeInfo.Size = new System.Drawing.Size(195, 22);
            this.tbPrenumeInfo.TabIndex = 1;
            // 
            // tbIbanInfo
            // 
            this.tbIbanInfo.Enabled = false;
            this.tbIbanInfo.Location = new System.Drawing.Point(251, 184);
            this.tbIbanInfo.Name = "tbIbanInfo";
            this.tbIbanInfo.Size = new System.Drawing.Size(195, 22);
            this.tbIbanInfo.TabIndex = 2;
            // 
            // tbAdresaInfo
            // 
            this.tbAdresaInfo.Enabled = false;
            this.tbAdresaInfo.Location = new System.Drawing.Point(251, 135);
            this.tbAdresaInfo.Name = "tbAdresaInfo";
            this.tbAdresaInfo.Size = new System.Drawing.Size(195, 22);
            this.tbAdresaInfo.TabIndex = 4;
            // 
            // tbSumaInfo
            // 
            this.tbSumaInfo.Enabled = false;
            this.tbSumaInfo.Location = new System.Drawing.Point(251, 241);
            this.tbSumaInfo.Name = "tbSumaInfo";
            this.tbSumaInfo.Size = new System.Drawing.Size(195, 22);
            this.tbSumaInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prenume : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "IBAN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Suma : ";
            // 
            // btnSerializareInfo
            // 
            this.btnSerializareInfo.BackColor = System.Drawing.Color.LightCoral;
            this.btnSerializareInfo.Location = new System.Drawing.Point(221, 333);
            this.btnSerializareInfo.Name = "btnSerializareInfo";
            this.btnSerializareInfo.Size = new System.Drawing.Size(175, 67);
            this.btnSerializareInfo.TabIndex = 11;
            this.btnSerializareInfo.Text = "Serializare informatii";
            this.btnSerializareInfo.UseVisualStyleBackColor = false;
            this.btnSerializareInfo.Click += new System.EventHandler(this.btnSerializareInfo_Click);
            // 
            // Informatii_cont_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 467);
            this.Controls.Add(this.btnSerializareInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSumaInfo);
            this.Controls.Add(this.tbAdresaInfo);
            this.Controls.Add(this.tbIbanInfo);
            this.Controls.Add(this.tbPrenumeInfo);
            this.Controls.Add(this.tbNumeInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informatii_cont_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informatii_cont_form";
            this.Load += new System.EventHandler(this.Informatii_cont_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeInfo;
        private System.Windows.Forms.TextBox tbPrenumeInfo;
        private System.Windows.Forms.TextBox tbIbanInfo;
        private System.Windows.Forms.TextBox tbAdresaInfo;
        private System.Windows.Forms.TextBox tbSumaInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSerializareInfo;
    }
}