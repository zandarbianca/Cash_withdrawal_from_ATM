namespace Proiect_PAW
{
    partial class Depunere_form
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
            this.btnAnulare = new System.Windows.Forms.Button();
            this.btnEfectuare = new System.Windows.Forms.Button();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbBalanta = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnulare
            // 
            this.btnAnulare.BackColor = System.Drawing.Color.Orange;
            this.btnAnulare.Location = new System.Drawing.Point(369, 372);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(173, 61);
            this.btnAnulare.TabIndex = 26;
            this.btnAnulare.Text = "Anulati";
            this.btnAnulare.UseVisualStyleBackColor = false;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click_1);
            // 
            // btnEfectuare
            // 
            this.btnEfectuare.BackColor = System.Drawing.Color.Orange;
            this.btnEfectuare.Location = new System.Drawing.Point(94, 372);
            this.btnEfectuare.Name = "btnEfectuare";
            this.btnEfectuare.Size = new System.Drawing.Size(173, 61);
            this.btnEfectuare.TabIndex = 25;
            this.btnEfectuare.Text = "Efectuati depunerea";
            this.btnEfectuare.UseVisualStyleBackColor = false;
            this.btnEfectuare.Click += new System.EventHandler(this.btnEfectuare_Click_1);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(400, 204);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(70, 21);
            this.rbtn3.TabIndex = 24;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "ATM 3";
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(400, 177);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(70, 21);
            this.rbtn2.TabIndex = 23;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "ATM 2";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(400, 149);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(70, 21);
            this.rbtn1.TabIndex = 22;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "ATM 1";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(260, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(297, 22);
            this.dateTimePicker.TabIndex = 21;
            // 
            // tbBalanta
            // 
            this.tbBalanta.Enabled = false;
            this.tbBalanta.Location = new System.Drawing.Point(260, 32);
            this.tbBalanta.Name = "tbBalanta";
            this.tbBalanta.Size = new System.Drawing.Size(297, 22);
            this.tbBalanta.TabIndex = 20;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(346, 287);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown.TabIndex = 19;
            this.numericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDown_Validating);
            this.numericUpDown.Validated += new System.EventHandler(this.numericUpDown_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Alegeti ATM-ul la care efectuati depunerea :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Data depunere :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Suma pe care doriti sa o depuneti este : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Balanta contului : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Depunere_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 467);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnEfectuare);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.tbBalanta);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Depunere_form";
            this.Text = "Depunere_form";
            this.Load += new System.EventHandler(this.Depunere_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Button btnEfectuare;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbBalanta;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}