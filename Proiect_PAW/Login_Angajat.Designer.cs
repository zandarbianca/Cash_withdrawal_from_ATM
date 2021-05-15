namespace Proiect_PAW
{
    partial class Login_Angajat
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogareAng = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(238, 187);
            this.tbNume.Multiline = true;
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(224, 29);
            this.tbNume.TabIndex = 0;
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(238, 243);
            this.tbParola.Multiline = true;
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(224, 30);
            this.tbParola.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numele utilizatorului :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola : ";
            // 
            // btnLogareAng
            // 
            this.btnLogareAng.Location = new System.Drawing.Point(188, 309);
            this.btnLogareAng.Name = "btnLogareAng";
            this.btnLogareAng.Size = new System.Drawing.Size(140, 48);
            this.btnLogareAng.TabIndex = 4;
            this.btnLogareAng.Text = "Logare";
            this.btnLogareAng.UseVisualStyleBackColor = true;
            this.btnLogareAng.Click += new System.EventHandler(this.btnLogareAng_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_PAW.Properties.Resources.login_img;
            this.pictureBox1.Location = new System.Drawing.Point(55, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogareAng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbNume);
            this.Name = "Login_Angajat";
            this.Text = "Login_Angajat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogareAng;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}