﻿namespace CRUD_Mysql
{
    partial class FormInvBuku
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
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.cmbKategoriBuku = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateKat = new System.Windows.Forms.Button();
            this.txtJudulBuku = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 12;
            // 
            // judulForm
            // 
            this.judulForm.AutoSize = true;
            this.judulForm.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulForm.Location = new System.Drawing.Point(179, 46);
            this.judulForm.Name = "judulForm";
            this.judulForm.Size = new System.Drawing.Size(187, 25);
            this.judulForm.TabIndex = 4;
            this.judulForm.Text = "Tambah Data Barang";
            this.judulForm.Click += new System.EventHandler(this.judulForm_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtPenulis);
            this.panel2.Controls.Add(this.cmbKategoriBuku);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCreateKat);
            this.panel2.Controls.Add(this.txtJudulBuku);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(37, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 560);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtPenulis
            // 
            this.txtPenulis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPenulis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenulis.Location = new System.Drawing.Point(45, 243);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(366, 21);
            this.txtPenulis.TabIndex = 19;
            // 
            // cmbKategoriBuku
            // 
            this.cmbKategoriBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategoriBuku.FormattingEnabled = true;
            this.cmbKategoriBuku.Location = new System.Drawing.Point(45, 144);
            this.cmbKategoriBuku.Name = "cmbKategoriBuku";
            this.cmbKategoriBuku.Size = new System.Drawing.Size(366, 23);
            this.cmbKategoriBuku.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Harga :";
            // 
            // btnCreateKat
            // 
            this.btnCreateKat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateKat.FlatAppearance.BorderSize = 0;
            this.btnCreateKat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateKat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateKat.ForeColor = System.Drawing.Color.Black;
            this.btnCreateKat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateKat.Location = new System.Drawing.Point(325, 488);
            this.btnCreateKat.Name = "btnCreateKat";
            this.btnCreateKat.Size = new System.Drawing.Size(124, 47);
            this.btnCreateKat.TabIndex = 12;
            this.btnCreateKat.Text = "Simpan";
            this.btnCreateKat.UseVisualStyleBackColor = false;
            this.btnCreateKat.Click += new System.EventHandler(this.btnCreateKat_Click);
            // 
            // txtJudulBuku
            // 
            this.txtJudulBuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJudulBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJudulBuku.Location = new System.Drawing.Point(45, 50);
            this.txtJudulBuku.Name = "txtJudulBuku";
            this.txtJudulBuku.Size = new System.Drawing.Size(366, 21);
            this.txtJudulBuku.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Barang :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang :";
            // 
            // FormInvBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 733);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormInvBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvBuku";
            this.Load += new System.EventHandler(this.FormInvBuku_Load);
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
        private System.Windows.Forms.Button btnCreateKat;
        private System.Windows.Forms.TextBox txtJudulBuku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategoriBuku;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.Label label3;
    }
}