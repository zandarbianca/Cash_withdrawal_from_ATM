namespace Proiect_PAW
{
    partial class Extragere_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tbBalanta = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.btnEfectuare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balanta contului : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suma pe care doriti sa o extrageti este : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data extragere :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alegeti ATM-ul la care efectuati extragerea :";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(343, 287);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(211, 22);
            this.numericUpDown.TabIndex = 5;
            // 
            // tbBalanta
            // 
            this.tbBalanta.Enabled = false;
            this.tbBalanta.Location = new System.Drawing.Point(257, 32);
            this.tbBalanta.Name = "tbBalanta";
            this.tbBalanta.Size = new System.Drawing.Size(297, 22);
            this.tbBalanta.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(257, 101);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(297, 22);
            this.dateTimePicker.TabIndex = 9;
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(397, 149);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(70, 21);
            this.rbtn1.TabIndex = 10;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "ATM 1";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(397, 177);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(70, 21);
            this.rbtn2.TabIndex = 11;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "ATM 2";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(397, 204);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(70, 21);
            this.rbtn3.TabIndex = 12;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "ATM 3";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // btnEfectuare
            // 
            this.btnEfectuare.BackColor = System.Drawing.Color.Orange;
            this.btnEfectuare.Location = new System.Drawing.Point(91, 372);
            this.btnEfectuare.Name = "btnEfectuare";
            this.btnEfectuare.Size = new System.Drawing.Size(173, 61);
            this.btnEfectuare.TabIndex = 13;
            this.btnEfectuare.Text = "Efectuati extragerea";
            this.btnEfectuare.UseVisualStyleBackColor = false;
            this.btnEfectuare.Click += new System.EventHandler(this.btnEfectuare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.BackColor = System.Drawing.Color.Orange;
            this.btnAnulare.Location = new System.Drawing.Point(366, 372);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(173, 61);
            this.btnAnulare.TabIndex = 14;
            this.btnAnulare.Text = "Anulati";
            this.btnAnulare.UseVisualStyleBackColor = false;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // Extragere_Form
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
            this.Name = "Extragere_Form";
            this.Text = "Extragere_Form";
            this.Load += new System.EventHandler(this.Extragere_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.TextBox tbBalanta;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.Button btnEfectuare;
        private System.Windows.Forms.Button btnAnulare;
    }
}