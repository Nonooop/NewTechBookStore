using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewTechBookStore
{
    public partial class Data_Buku : Form
    {
        private SqlCommand cmd;

        public Data_Buku()
        {
            InitializeComponent();
        }
        void Display()
        {
            try
            {
                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter sqlDisplay = new SqlDataAdapter("EXEC spDataBuku", SqlConnect);
                    sqlDisplay.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    sqlDisplay.Fill(data);

                    dgvBuku.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Search()
        {
            try
            {
                using (SqlConnection SqlConnect = new SqlConnection(Koneksi.Connect))
                {
                    SqlConnect.Open();
                    SqlDataAdapter GetUser = new SqlDataAdapter("EXEC spCariDataBuku @CARI", SqlConnect);
                    GetUser.SelectCommand.Parameters.AddWithValue("@CARI", txtCari.Text.Trim());
                    GetUser.SelectCommand.ExecuteNonQuery();

                    DataTable data = new DataTable();
                    GetUser.Fill(data);

                    dgvBuku.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void IdOtomatis()
        {
            long itung;
            string urut;
            SqlDataReader dr;
            using (SqlConnection IdSqlConnect = new SqlConnection(Koneksi.Connect))
            {
                IdSqlConnect.Open();
                cmd = new SqlCommand("EXECUTE spIdBuku", IdSqlConnect);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    itung = Convert.ToInt64(dr[0].ToString().Substring(dr["id_buku"].ToString().Length - 4, 4)) + 1;
                    string idurut = "0000" + itung;
                    urut = "BK" + idurut.Substring(idurut.Length - 4, 4);
                }
                else
                {
                    urut = "BK0001";
                }
                dr.Close();
                txtID.Text = urut;
            }

        }

        void ClearData()
        {
            txtID.Clear();
            txtNama.Clear();
            txtPenerbit.Clear();
            txtPenulis.Clear();
            txtISBN.Clear();
            txtHarga.Clear();
            txtStok.Clear();
            txtTahun.Clear();
            cbLevel.Text="Pilih Kategori";
        }

        private void Data_Buku_Load(object sender, EventArgs e)
        {
            ClearData();
            IdOtomatis();
            Display();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "" || txtNama.Text.Trim() == "" || txtPenerbit.Text.Trim() == "" ||
                txtPenulis.Text.Trim() == "" || txtISBN.Text.Trim() == "" || txtHarga.Text.Trim() == "" || txtStok.Text.Trim() == "" || 
                txtHarga.Text.Trim() == "" || txtStok.Text.Trim() == "" || txtTahun.Text.Trim() == "" || cbLevel.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh dikosongkan");
                }
                else
                {
                    using (SqlConnection SqlConnectSimpan = new SqlConnection(Koneksi.Connect))
                    {
                        SqlConnectSimpan.Open();
                        SqlDataAdapter Insert = new SqlDataAdapter("EXEC spInputBuku @ID, @JUDUL ,@PENULIS, @PENERBIT, @TAHUN, @HARGA, @STOK, @KATEGORI, @ISBN", SqlConnectSimpan);
                        Insert.SelectCommand.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@JUDUL", txtNama.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@PENULIS", txtPenulis.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@PENERBIT", txtPenerbit.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@TAHUN", txtTahun.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@HARGA", txtHarga.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@STOK", txtStok.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@KATEGORI", cbLevel.Text.Trim());
                        Insert.SelectCommand.Parameters.AddWithValue("@ISBN", txtISBN.Text.Trim());
                        Insert.SelectCommand.ExecuteNonQuery();

                        MessageBox.Show("Data Tersimpan");
                        Display();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvBuku.SelectedRows)
                {
                    txtID.Text = row.Cells[0].Value.ToString();
                    txtNama.Text = row.Cells[1].Value.ToString();
                    txtPenulis.Text = row.Cells[2].Value.ToString();
                    txtPenerbit.Text = row.Cells[3].Value.ToString();
                    txtTahun.Text = row.Cells[4].Value.ToString();
                    txtHarga.Text = row.Cells[5].Value.ToString();
                    txtStok.Text = row.Cells[6].Value.ToString();
                    cbLevel.Text = row.Cells[7].Value.ToString();
                    txtISBN.Text = row.Cells[8].Value.ToString();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection IdSqlConnectEdit = new SqlConnection(Koneksi.Connect))
                {
                    IdSqlConnectEdit.Open();
                    DialogResult dr = MessageBox.Show("Anda yakin ingin mengubah data " + txtID.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand update = new SqlCommand("EXEC spUpdateBuku @ID, @JUDUL ,@PENULIS, @PENERBIT, @TAHUN, @HARGA, @STOK, @KATEGORI, @ISBN", IdSqlConnectEdit);
                        update.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                        update.Parameters.AddWithValue("@JUDUL", txtNama.Text.Trim());
                        update.Parameters.AddWithValue("@PENULIS", txtPenulis.Text.Trim());
                        update.Parameters.AddWithValue("@PENERBIT", txtPenerbit.Text.Trim());
                        update.Parameters.AddWithValue("@TAHUN", txtTahun.Text.Trim());
                        update.Parameters.AddWithValue("@HARGA", txtHarga.Text.Trim());
                        update.Parameters.AddWithValue("@STOK", txtStok.Text.Trim());
                        update.Parameters.AddWithValue("@KATEGORI", cbLevel.Text.Trim());
                        update.Parameters.AddWithValue("@ISBN", txtISBN.Text.Trim());
                        update.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtID.Text + "  Terupdate");
                        ClearData();
                        Display();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection IdSqlConnectHps = new SqlConnection(Koneksi.Connect))
                {
                    IdSqlConnectHps.Open();
                    DialogResult dr = MessageBox.Show("Anda yakin ingin menghapus data " + txtNama.Text + " ?",
                        "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand hapus = new SqlCommand("EXEC spHapusBuku @ID ", IdSqlConnectHps);
                        hapus.Parameters.AddWithValue("@ID", txtID.Text);
                        hapus.ExecuteNonQuery();

                        MessageBox.Show("Data " + txtNama.Text + "  Terhapus");
                        ClearData();
                        Display();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
            Display();
            IdOtomatis();
        }
    }
}
