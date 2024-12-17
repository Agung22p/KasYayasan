using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasYayasan
{
    public partial class Form2 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Documents\Kas.mdf"";Integrated Security=True;Connect Timeout=30");
        public Form2()
        {
            InitializeComponent();
        }

        private void tampilJumlah()
        {
            conn.Open();
            SqlCommand JumlahDonatur = new SqlCommand("SELECT COUNT(id) FROM [dbo].[Penerimaan]", conn);
            string Donatur = JumlahDonatur.ExecuteScalar().ToString();

            SqlCommand JumlahPenerimaan = new SqlCommand("SELECT SUM(Jumlah) FROM [dbo].[Penerimaan]", conn);
            string Penerimaan = JumlahPenerimaan.ExecuteScalar().ToString();

            SqlCommand JumlahPengeluaran = new SqlCommand("SELECT SUM(Jumlah) FROM [dbo].[Pengeluaran]", conn);
            string Pengeluaran = JumlahPengeluaran.ExecuteScalar().ToString();

            conn.Close();

            lblJumlahDonatur.Text = Donatur;
            lblJumlahPenerimaan.Text = "Rp. " + Penerimaan;
            lblJumlahPengeluaran.Text = "Rp. " + Pengeluaran;
        }
        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Penerimaan penerimaan = new Penerimaan();
            penerimaan.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Pengeluaran pengeluaran = new Pengeluaran();
            pengeluaran.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tampilJumlah();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampilJumlah();
            MessageBox.Show("Data telah diperbarui!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Statistik_Donasi statistik_Donasi = new Statistik_Donasi();
            statistik_Donasi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rekapitulasi rekapitulasi = new Rekapitulasi();
            rekapitulasi.Show();
        }
    }
}
