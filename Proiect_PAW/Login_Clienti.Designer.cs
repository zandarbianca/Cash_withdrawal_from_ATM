﻿namespace Proiect_PAW
{
    partial class Login_Clienti
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
            this.tbParola = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.btnLogareCl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume de utilizator : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola :";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(218, 344);
            this.tbParola.Multiline = true;
            this.tbParola.Name = "tbParola";
            this.tbParola.PasswordChar = '*';
            this.tbParola.Size = new System.Drawing.Size(224, 30);
            this.tbParola.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(218, 288);
            this.tbNume.Multiline = true;
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(224, 29);
            this.tbNume.TabIndex = 4;
            // 
            // btnLogareCl
            // 
            this.btnLogareCl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnLogareCl.CausesValidation = false;
            this.btnLogareCl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogareCl.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogareCl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnLogareCl.Location = new System.Drawing.Point(159, 415);
            this.btnLogareCl.Name = "btnLogareCl";
            this.btnLogareCl.Size = new System.Drawing.Size(162, 61);
            this.btnLogareCl.TabIndex = 6;
            this.btnLogareCl.Text = "Logare";
            this.btnLogareCl.UseVisualStyleBackColor = false;
            this.btnLogareCl.Click += new System.EventHandler(this.btnLogareCl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proiect_PAW.Properties.Resources.man_512_cl1;
            this.pictureBox1.Location = new System.Drawing.Point(109, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(140)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(490, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogareCl);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login_Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Clienti";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button btnLogareCl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}