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
    public partial class Pengeluaran : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Documents\Kas.mdf"";Integrated Security=True;Connect Timeout=30");
        public Pengeluaran()
        {
            InitializeComponent();
        }

        private void tampilJumlah()
        {

            conn.Open();
            SqlCommand CountItem = new SqlCommand("SELECT COUNT(id) FROM [dbo].[Pengeluaran]", conn);
            string ItemCount = CountItem.ExecuteScalar().ToString();

            SqlCommand SumJumlah = new SqlCommand("SELECT SUM(Jumlah) FROM [dbo].[Pengeluaran]", conn);
            string jumlah = SumJumlah.ExecuteScalar().ToString();

            conn.Close();

            lblpengeluaran.Text = ItemCount;
            lblTotal.Text = "Rp. " + jumlah;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtKeterangan.Text))
            {
                MessageBox.Show("Keterangan pengeluaran tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKeterangan.Focus();
                this.ActiveControl = txtKeterangan;
            }
            else
            {
                if (string.IsNullOrEmpty(txtJumlah.Text))
                {
                    MessageBox.Show("Nama Pendonasi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtJumlah.Focus();
                    this.ActiveControl = txtJumlah;
                }
                else
                {
                    conn.Open();

                    SqlCommand jumlahTotalDana = new SqlCommand("SELECT SUM(Jumlah) FROM [dbo].[Penerimaan]", conn);
                    string TotalDanastr = jumlahTotalDana.ExecuteScalar().ToString();
                    double TotalDana = double.Parse(TotalDanastr);
                    conn.Close();

                    if (double.Parse(txtJumlah.Text) > TotalDana)
                    {
                        MessageBox.Show("Jumlah dana tidak mencukupi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        conn.Open();
                        SqlCommand PenerimaanUpdate = new SqlCommand("INSERT INTO [dbo].[Pengeluaran] ([Keterangan], [Jumlah], [Tanggal]) VALUES (@keterangan, @jumlah ,@tanggal)", conn);
                        PenerimaanUpdate.Parameters.AddWithValue("@keterangan", txtKeterangan.Text);
                        PenerimaanUpdate.Parameters.AddWithValue("@jumlah", int.Parse(txtJumlah.Text));
                        PenerimaanUpdate.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        PenerimaanUpdate.ExecuteNonQuery();
                        conn.Close();
                    }



                    tampilDataPengeluaran();

                    tampilJumlah();
                }
            }
        }

        private void tampilDataPengeluaran()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand pengeluaran = new SqlCommand("SELECT * FROM [dbo].[Pengeluaran]", conn);
            pengeluaran.ExecuteNonQuery();
            SqlDataAdapter PengeluaranAdapter = new SqlDataAdapter(pengeluaran);

            DataTable PengeluaranTable = new DataTable();

            PengeluaranAdapter.Fill(PengeluaranTable);
            dgPengeluaran.DataSource = PengeluaranTable;
            conn.Close();
            // Menambahkan kolom tombol delete ke DataGridView
            if (dgPengeluaran.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Aksi";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true; // Menampilkan teks tombol
                dgPengeluaran.Columns.Add(deleteButtonColumn);
            }
        }

        private void Pengeluaran_Load(object sender, EventArgs e)
        {
            tampilJumlah();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tampilDataPengeluaran();
        }

        private void dgPengeluaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPengeluaran.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Konfirmasi sebelum menghapus
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Ambil ID dari baris yang diklik (asumsikan ada kolom ID di database)
                    int rowIndex = e.RowIndex;
                    string id = dgPengeluaran.Rows[rowIndex].Cells["Id"].Value.ToString();

                    // Hapus data dari database
                    DeleteDataFromDatabase(id);

                    // Hapus baris dari DataGridView
                    dgPengeluaran.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void DeleteDataFromDatabase(string id)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "DELETE FROM [dbo].[Pengeluaran] WHERE Id = @ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                
                MessageBox.Show("Data berhasil dihapus!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
