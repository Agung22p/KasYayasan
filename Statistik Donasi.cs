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
    public partial class Statistik_Donasi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Documents\Kas.mdf"";Integrated Security=True;Connect Timeout=30");
        public Statistik_Donasi()
        {
            InitializeComponent();
        }

        private void Statistik_Donasi_Load(object sender, EventArgs e)
        {
            conn.Open();

            // Mengambil data jumlah donatur hari ini 
            SqlCommand jumlahHariIni = new SqlCommand("SELECT COUNT(ID) FROM [dbo].[penerimaan] WHERE CAST(Tanggal AS DATE) = CAST(GETDATE() AS DATE)", conn);
            string HariIni = jumlahHariIni.ExecuteScalar().ToString();

            SqlCommand jumlahKemarin = new SqlCommand("SELECT COUNT(ID) FROM [dbo].[penerimaan] WHERE CAST(Tanggal AS DATE) = CAST(DATEADD(DAY, -1, GETDATE()) AS DATE)", conn);
            string Kemarin = jumlahKemarin.ExecuteScalar().ToString();

            SqlCommand jumlahMingguIni = new SqlCommand("SELECT COUNT(ID) FROM [dbo].[penerimaan] WHERE DATEPART(WEEK, Tanggal) = DATEPART(WEEK, GETDATE())  AND DATEPART(YEAR, Tanggal) = DATEPART(YEAR, GETDATE())", conn);
            string MingguIni = jumlahMingguIni.ExecuteScalar().ToString();

            SqlCommand jumlahBulanIni = new SqlCommand("SELECT COUNT(ID) FROM [dbo].[Penerimaan] WHERE MONTH(Tanggal) = MONTH(GETDATE()) AND YEAR(Tanggal) = YEAR(GETDATE())", conn);
            string BulanIni = jumlahBulanIni.ExecuteScalar().ToString();

            SqlCommand jumlahSemua = new SqlCommand("SELECT COUNT(ID) FROM [dbo].[Penerimaan] WHERE MONTH(Tanggal) = MONTH(GETDATE()) AND YEAR(Tanggal) = YEAR(GETDATE())", conn);
            string Semua = jumlahSemua.ExecuteScalar().ToString();

            conn.Close();

            lblToday.Text = HariIni;
            lblYesterday.Text = Kemarin;
            lblThisWeek.Text = MingguIni;
            lblThisMonth.Text = BulanIni;
            lblTotal.Text = Semua;
        }
    }
}
