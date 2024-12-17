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
    public partial class Penerimaan : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\M S I\Documents\Kas.mdf"";Integrated Security=True;Connect Timeout=30");
        public Penerimaan()
        {
            InitializeComponent();
        }

        private void PenerimaanOpen()
        {
            conn.Open();
            SqlCommand CountItem = new SqlCommand("SELECT COUNT(id) FROM [dbo].[Penerimaan]", conn);
            string ItemCount = CountItem.ExecuteScalar().ToString();

            SqlCommand SumJumlah = new SqlCommand("SELECT SUM(Jumlah) FROM [dbo].[Penerimaan]", conn);
            string jumlah = SumJumlah.ExecuteScalar().ToString();

            conn.Close();

            lblDonatur.Text = ItemCount;
            lblJumlah.Text = "Rp. " + jumlah;
        }

        private void btnPurchasingSummary_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamaDonatur.Text))
            {
                MessageBox.Show("Nama Pendonasi tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNamaDonatur.Focus();
                this.ActiveControl = txtNamaDonatur;
            }
            else
            {
                if (string.IsNullOrEmpty(txtAlamat.Text))
                {
                    MessageBox.Show("Alamat tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAlamat.Focus();
                    this.ActiveControl = txtAlamat;
                }
                else
                {
                    if (string.IsNullOrEmpty(txtJumlah.Text))
                    {
                        MessageBox.Show("Jumlah Tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtJumlah.Focus();
                        this.ActiveControl = txtJumlah;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtNoHp.Text))
                        {
                            MessageBox.Show("No hp tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNoHp.Focus();
                            this.ActiveControl = txtNoHp;
                        }
                        else
                        {
                            conn.Open();
                            SqlCommand PenerimaanUpdate = new SqlCommand("INSERT INTO [dbo].[Penerimaan] ([Nama_pendonasi], [Alamat], [Jumlah], [No_Hp], [Tanggal]) VALUES (@nama, @alamat,@jumlah , @no_hp, @tanggal)", conn);
                            PenerimaanUpdate.Parameters.AddWithValue("@nama", txtNamaDonatur.Text);
                            PenerimaanUpdate.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                            PenerimaanUpdate.Parameters.AddWithValue("@jumlah", int.Parse(txtJumlah.Text));
                            PenerimaanUpdate.Parameters.AddWithValue("@no_Hp", txtNoHp.Text);
                            PenerimaanUpdate.Parameters.AddWithValue("@tanggal", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                            PenerimaanUpdate.ExecuteNonQuery();


                            conn.Close();

                            showPenerimaan();

                            PenerimaanOpen();

                            txtNamaDonatur.Text = "";
                            txtAlamat.Text = "";
                            txtJumlah.Text = "";
                            txtNoHp.Text = "";
                        }
                    }
                }
            }
        }

        private void Penerimaan_Load(object sender, EventArgs e)
        {
            PenerimaanOpen();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            showPenerimaan();
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNoHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showPenerimaan()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand penerimaan = new SqlCommand("SELECT * FROM [dbo].[Penerimaan]", conn);
            penerimaan.ExecuteNonQuery();
            SqlDataAdapter PenerimaanAdapter = new SqlDataAdapter(penerimaan);

            DataTable PenerimaanTable = new DataTable();

            PenerimaanAdapter.Fill(PenerimaanTable);
            dgPenerimaan.DataSource = PenerimaanTable;
            // Menambahkan kolom tombol delete ke DataGridView
            if (dgPenerimaan.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.HeaderText = "Aksi";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true; // Menampilkan teks tombol
                dgPenerimaan.Columns.Add(deleteButtonColumn);
            }
            conn.Close();
        }

        private void dgPenerimaan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPenerimaan.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Konfirmasi sebelum menghapus
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Ambil ID dari baris yang diklik (asumsikan ada kolom ID di database)
                    int rowIndex = e.RowIndex;
                    string id = dgPenerimaan.Rows[rowIndex].Cells["Id"].Value.ToString();
                    
                    // Hapus data dari database
                    DeleteDataFromDatabase(id);

                    // Hapus baris dari DataGridView
                    dgPenerimaan.Rows.RemoveAt(rowIndex);
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
                string query = "DELETE FROM [dbo].[Penerimaan] WHERE ID = @ID";
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
