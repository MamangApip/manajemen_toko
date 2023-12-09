﻿namespace CRUD_Mysql
{
    partial class FormPegawai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.judulForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnCreateKat = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.judulForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 121);
            this.panel1.TabIndex = 11;
            // 
            // judulForm
            // 
            this.judulForm.AutoSize = true;
            this.judulForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulForm.Location = new System.Drawing.Point(173, 47);
            this.judulForm.Name = "judulForm";
            this.judulForm.Size = new System.Drawing.Size(197, 25);
            this.judulForm.TabIndex = 4;
            this.judulForm.Text = "Tambah Data Pegawai";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtNoTelp);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tanggalLahir);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAlamat);
            this.panel2.Controls.Add(this.btnCreateKat);
            this.panel2.Controls.Add(this.txtNama);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(36, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 473);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTelp.Location = new System.Drawing.Point(45, 350);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(366, 21);
            this.txtNoTelp.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "No. Telepon :";
            // 
            // tanggalLahir
            // 
            this.tanggalLahir.AllowDrop = true;
            this.tanggalLahir.CustomFormat = "dd/mm/yyyy hh:mm:ss";
            this.tanggalLahir.Location = new System.Drawing.Point(45, 249);
            this.tanggalLahir.Name = "tanggalLahir";
            this.tanggalLahir.Size = new System.Drawing.Size(366, 20);
            this.tanggalLahir.TabIndex = 15;
            this.tanggalLahir.Value = new System.DateTime(2023, 11, 9, 0, 0, 0, 0);
            this.tanggalLahir.ValueChanged += new System.EventHandler(this.tanggalLahir_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tanggal Lahir :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(45, 147);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(366, 21);
            this.txtAlamat.TabIndex = 13;
            // 
            // btnCreateKat
            // 
            this.btnCreateKat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateKat.FlatAppearance.BorderSize = 0;
            this.btnCreateKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKat.ForeColor = System.Drawing.Color.Black;
            this.btnCreateKat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateKat.Location = new System.Drawing.Point(323, 408);
            this.btnCreateKat.Name = "btnCreateKat";
            this.btnCreateKat.Size = new System.Drawing.Size(124, 47);
            this.btnCreateKat.TabIndex = 12;
            this.btnCreateKat.Text = "Simpan";
            this.btnCreateKat.UseVisualStyleBackColor = false;
            this.btnCreateKat.Click += new System.EventHandler(this.btnCreateKat_Click);
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(45, 50);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(366, 21);
            this.txtNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pegawai :";
            // 
            // FormPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 646);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPegawai";
            this.Load += new System.EventHandler(this.FormPegawai_Load);
            this.Shown += new System.EventHandler(this.FormPegawai_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label judulForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tanggalLahir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnCreateKat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}