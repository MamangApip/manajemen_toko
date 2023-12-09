﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Mysql
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            FileStream fs = new FileStream("nama.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string nama = (string)bf.Deserialize(fs);
            fs.Close();

            // Set value pada textbox
            label2.Text = nama;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin melanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                this.Close();
                Info login = new Info();
                login.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kategoriBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            KategoriBarang katbuku = new KategoriBarang();
            katbuku.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pegawai pegawai = new Pegawai();
            pegawai.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            InvBuku invbuku = new InvBuku();
            invbuku.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
