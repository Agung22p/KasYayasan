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
    public partial class Rekapitulasi : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Documents\Kas.mdf"";Integrated Security=True;Connect Timeout=30");
        public Rekapitulasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            // Query SQL dengan parameter
            string query = "SELECT * FROM [dbo].[penerimaan] WHERE CAST(Tanggal AS DATE) BETWEEN @TanggalMulai AND @TanggalSelesai";

            // Menggunakan SqlCommand dengan parameter
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TanggalMulai", dtFrom.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TanggalSelesai", dtTo.Value.ToString("yyyy-MM-dd"));

            // Mengambil data menggunakan SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Menampilkan data di DataGridView (misalnya dgPenerimaan)
            dgRecap.DataSource = table;

            // Tutup koneksi
            conn.Close();
        }
    }
}
